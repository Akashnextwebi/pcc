﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_add_blogs : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string strThumbImage = "", strBlogImage = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                GetBlogs();
            }
        }
    }
    public void GetBlogs()
    {
        try
        {
            BlogDetails BD = BlogDetails.GetAllBlogDetailsWithId(conSQ, Convert.ToInt32(Request.QueryString["id"])).FirstOrDefault();
            if (BD != null)
            {
                divimg.Visible = true;

                btnSave.Text = "Update";
                btnNew.Visible = true;
                txtName.Text = BD.BlogTitle;
                txtUrl.Text = BD.BlogURL;
                txtMetaDesc.Text = BD.MetaDescription;
                txtMetaKey.Text = BD.MetaKeys;
                txtDesc.Text = BD.FullDescription;
                txtPageTitle.Text = BD.PageTitle;
                txtPostedBy.Text = BD.PostedBy;
                txtPostedOn.Text = BD.PostedOn;
                txttag.Text=BD.Tag;
                if (BD.ThumbImage != "")
                {
                    strThumbImage = "<img src='/" + BD.ThumbImage + "' style='max-height:60px;' />";
                    lblThumb.Text = BD.ThumbImage;
                }
                if (BD.BlogImage != "")
                {
                    strBlogImage = "<img src='/" + BD.BlogImage + "' style='max-height:60px;' />";
                    lblBlog.Text = BD.BlogImage;
                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetBlogs", ex.Message);
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsValid)
            {
                var id = Request.QueryString["id"] == "" ? 0 : Convert.ToInt32(Request.QueryString["id"]);
                var exist = BlogDetails.CheckExist(conSQ, txtName.Text, txtUrl.Text, id);
                if (exist > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Blog Name with title,url already exist.',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                var thumbimg = CheckThumbFormat();

                if (thumbimg == "Format")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image format. Please upload .png, .jpeg, .jpg, .webp, .gif for thumb image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                if (thumbimg == "Size")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image size.Please upload correct resolution image for thumb image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                var Blogimg = CheckBlogImageFormat();

                if (Blogimg == "Format")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image format. Please upload .png, .jpeg, .jpg, .webp, .gif for blog image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                if (Blogimg == "Size")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image size.Please upload correct resolution image for blog image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }

                var aid = Request.Cookies["pcc_aid"].Value;
                BlogDetails BD = new BlogDetails();
                BD.BlogTitle = txtName.Text;
                BD.BlogURL = txtUrl.Text;
                BD.PostedBy = txtPostedBy.Text;
                BD.ThumbImage = UploadThumbImage();
                BD.BlogImage = UploadBlogImage();
                BD.FullDescription = txtDesc.Text.Trim();
                BD.MetaDescription = txtMetaDesc.Text;
                BD.MetaKeys = txtMetaKey.Text;
                BD.PageTitle = txtPageTitle.Text;
                BD.Tag = txttag.Text;
                BD.AddedIp = CommonModel.IPAddress();
                BD.AddedOn = TimeStamps.UTCTime();
                BD.PostedOn = txtPostedOn.Text;
                BD.AddedBy = aid;

                if (BD.ThumbImage != "" && BD.BlogImage != "")
                {
                    if (btnSave.Text == "Update")
                    {
                        BD.Id = Convert.ToInt32(Request.QueryString["id"]);
                        int result = BlogDetails.UpdateBlogDetails(conSQ, BD);
                        if (result > 0)
                        {
                            GetBlogs();
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Blog Updated successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops...! There is some problem right now.please try again after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);

                        }
                    }
                    else
                    {
                        int result = BlogDetails.InsertBlogDetails(conSQ, BD);
                        if (result > 0)
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Blog Added successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                            txtDesc.Text = txtMetaDesc.Text = txtName.Text = txtUrl.Text = txtPageTitle.Text = txtMetaKey.Text = txttag.Text = txtPostedBy.Text= txtPostedOn.Text="";
                            strThumbImage = strBlogImage = "";
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops...! There is some problem right now.please try again after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                        }
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Please upload all the required images.',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                }

            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "btnSave_Click", ex.Message);

        }
    }
    private string CheckThumbFormat()
    {
        #region ThumbImage
        string thumbImg = "";
        if (Thumbimage.HasFile)
        {
            try
            {
                string fileExtension = Path.GetExtension(Thumbimage.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString();
                if ((fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" || fileExtension == ".gif" || fileExtension == ".webp"))
                {
                    System.Drawing.Bitmap bitimg = new System.Drawing.Bitmap(Thumbimage.PostedFile.InputStream);
                    if ((bitimg.PhysicalDimension.Height != 720) || (bitimg.PhysicalDimension.Width != 1080))
                    {
                        return "Size";
                    }
                }
                else
                {

                    return "Format";
                }
            }
            catch (Exception ex)
            {
                ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "CheckThumbFormat", ex.Message);

            }
        }
        #endregion
        return thumbImg;
    }
    public string UploadThumbImage()
    {
        #region upload file
        string thumbfile = "";
        try
        {
            if (Thumbimage.HasFile)
            {
                string fileExtension = Path.GetExtension(Thumbimage.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString() + "-blogthumb".Replace(" ", "-").Replace(".", "");
                string iconPath = Server.MapPath(".") + "\\../UploadImages\\" + ImageGuid1 + "" + fileExtension;
                try
                {
                    if (File.Exists(Server.MapPath("~/" + Convert.ToString(lblThumb.Text))))
                    {
                        File.Delete(Server.MapPath("~/" + Convert.ToString(lblThumb.Text)));
                    }
                }
                catch (Exception eeex)
                {
                    ExceptionCapture.CaptureException(Request.Url.PathAndQuery, "UploadThumbImage", eeex.Message);
                    return lblThumb.Text;
                }
                Thumbimage.SaveAs(iconPath);
                thumbfile = "UploadImages/" + ImageGuid1 + "" + fileExtension;
            }
            else
            {
                thumbfile = lblThumb.Text;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UploadThumbImage", ex.Message);

        }

        #endregion
        return thumbfile;
    }
    private string CheckBlogImageFormat()
    {
        #region ThumbImage
        string thumbImg = "";
        if (BlogImage.HasFile)
        {
            try
            {
                string fileExtension = Path.GetExtension(BlogImage.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString();
                if ((fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" || fileExtension == ".gif" || fileExtension == ".webp"))
                {
                    System.Drawing.Bitmap bitimg = new System.Drawing.Bitmap(BlogImage.PostedFile.InputStream);
                    if ((bitimg.PhysicalDimension.Height != 750) || (bitimg.PhysicalDimension.Width != 1200))
                    {
                        return "Size";
                    }
                }
                else
                {

                    return "Format";
                }
            }
            catch (Exception ex)
            {
                ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "CheckBlogImageFormat", ex.Message);

            }
        }
        #endregion
        return thumbImg;
    }
    public string UploadBlogImage()
    {
        #region upload file
        string thumbfile = "";
        try
        {
            if (BlogImage.HasFile)
            {
                string fileExtension = Path.GetExtension(BlogImage.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString() + "-BlogImg".Replace(" ", "-").Replace(".", "");
                string iconPath = Server.MapPath(".") + "\\../UploadImages\\" + ImageGuid1 + "" + fileExtension;
                try
                {
                    if (File.Exists(Server.MapPath("~/" + Convert.ToString(lblBlog.Text))))
                    {
                        File.Delete(Server.MapPath("~/" + Convert.ToString(lblBlog.Text)));
                    }
                }
                catch (Exception eeex)
                {
                    ExceptionCapture.CaptureException(Request.Url.PathAndQuery, "UploadBlogImage", eeex.Message);
                    return lblBlog.Text;
                }
                BlogImage.SaveAs(iconPath);
                thumbfile = "UploadImages/" + ImageGuid1 + "" + fileExtension;
            }
            else
            {
                thumbfile = lblBlog.Text;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UploadBlogImage", ex.Message);

        }

        #endregion
        return thumbfile;
    }


    protected void btnNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("add-blogs.aspx");
    }

}