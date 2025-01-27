using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_manage_product_galleries : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);

    public string strImage = "", StrThumbImage = "", StrProductname = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetProductName();
            GetImageList();
            if (Request.QueryString["id"] != null)
            {
                GetImageDetails();
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            try
            {
                var upload = CheckImageFormat();
                if (upload == "Format")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image format. Please upload .png, .jpeg, .jpg, .webp',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                if (upload == "Size")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image size,please add required size image.',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                string aid = Request.Cookies["bmw_aid"].Value;
                ProductGallery st = new ProductGallery()
                {
                    ImageUrl = UploadImage(),
                    ProductGuid = Convert.ToString(Request.QueryString["Gid"]),
                    AddedBy = aid,
                    Status = "Active",
                    Id = Request.QueryString["id"] == null ? 0 : Convert.ToInt32(Request.QueryString["id"]),
                };
                if (st.ImageUrl != "")
                {

                    if (btnSave.Text == "Update")
                    {
                        int result = ProductGallery.UpdateImage(conSQ, st);
                        if (result > 0)
                        {
                            GetImageDetails();
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Image details Updated successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops! Something went wrong. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                        }

                    }
                    else
                    {
                        int result = ProductGallery.AddImage(conSQ, st);
                        if (result > 0)
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Image details added successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops! Something went wrong. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                        }
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Please select image to upload',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);

                }
                GetImageList();
            }
            catch (Exception ex)
            {
                ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "btnSave_Click", ex.Message);
            }
        }
    }

    private string CheckImageFormat()
    {
        #region upload image
        string thumbImage = "";
        try
        {
            if (updImg.HasFile)
            {
                string fileExtension = Path.GetExtension(updImg.PostedFile.FileName.ToLower());

                if ((fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" || fileExtension == ".gif" || fileExtension == ".webp"))
                {

                    return thumbImage;
                }
                else
                {
                    return "Format";
                }
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "CheckImageFormat", ex.Message);
        }
        #endregion
        return thumbImage;
    }
    public string UploadImage()
    {
        #region upload image
        string thumbImage = "";

        try
        {
            if (updImg.HasFile)
            {
                string fileExtension = Path.GetExtension(updImg.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString() + "-product".Replace(" ", "-").Replace(".", "");
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
                    ExceptionCapture.CaptureException(Request.Url.PathAndQuery, "UploadImage", eeex.Message);
                    return lblThumb.Text;
                }

                if (fileExtension == ".webp")
                {
                    updImg.SaveAs(iconPath);

                }
                else if (fileExtension == ".gif")
                {
                    updImg.SaveAs(iconPath);
                }
                else
                {
                    System.Drawing.Bitmap bmpPostedImageBig = new System.Drawing.Bitmap(updImg.PostedFile.InputStream);
                    System.Drawing.Image objImagesmallBig = CommonModel.ScaleImageBig(bmpPostedImageBig, bmpPostedImageBig.Height, bmpPostedImageBig.Width);
                    if (fileExtension == ".png")
                    {
                        CommonModel.SavePNG(iconPath, objImagesmallBig, 99);
                    }
                    else { CommonModel.SaveJpeg(iconPath, objImagesmallBig, 99); }
                }
                thumbImage = "UploadImages/" + ImageGuid1 + "" + fileExtension;
            }
            else
            {
                thumbImage = lblThumb.Text;
            }
        }
        catch (Exception ex)
        {

        }


        #endregion
        return thumbImage;
    }
    public void GetImageDetails()
    {
        try
        {
            var Image = ProductGallery.GetAllProductGalleryDetailsWithId(conSQ, Convert.ToInt32(Request.QueryString["id"]));
            if (Image != null)
            {
                btnNew.Visible = true;
                btnSave.Text = "Update";
                if (Image.ImageUrl != "")
                {
                    lblThumb.Text = Image.ImageUrl;
                    StrThumbImage = @"<a href='/" + Image.ImageUrl + @"' target='_blank'><img src='/" + Image.ImageUrl + @"' width='60px'></a>";

                }

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetImageDetails", ex.Message);
        }
    }
    public void GetImageList()
    {
        try
        {
            var Gid = Convert.ToString(Request.QueryString["Gid"]);
            if (Gid != null && Gid.Count() > 0)
            {
                var sub = ProductGallery.GetAllProductGalleryWithGuid(conSQ, Gid);
                if (sub != null)
                {
                    strImage = "";
                    for (int i = 0; i < sub.Count; i++)
                    {
                        strImage += @"<tr>
                                        <td>" + (i + 1) + @"</td>
                                        <td><a href='/" + sub[i].ImageUrl + @"' target='_blank'><img src='/" + sub[i].ImageUrl + @"' width='60'></a></td>
                                        <td>" + Convert.ToDateTime(sub[i].AddedOn).ToString("dd MMM yyyy") + @"</td>
                                        <td class='text-center'>
                                        <a href='manage-product-galleries.aspx?Gid=" + sub[i].ProductGuid + @"&id=" + sub[i].Id + @"' class='bs-tooltip text-info fs-18' data-id='" + sub[i].Id + @"' data-toggle='tooltip' data-placement='top' title='Edit' data-original-title='Edit'>
                                               <i class='mdi mdi-pencil'></i></a>
                                                <a href='javascript:void(0);' class='bs-tooltip deleteItem warning confirm text-danger fs-18' data-id='" + sub[i].Id + @"' data-pid='" + sub[i].ProductGuid + @"' data-toggle='tooltip' data-placement='top' title='Delete' data-original-title='Delete'>
                                               <i class='mdi mdi-delete-forever'></i></a>
                                        </td>
                                    </tr>";
                    }
                }
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetImageList", ex.Message);

        }
    }
    [WebMethod(EnableSession = true)]
    public static string Delete(string id)
    {
        string x = "";
        try
        {
            SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
            ProductGallery BD = new ProductGallery();
            BD.Id = Convert.ToInt32(id);
            BD.AddedOn = DateTime.UtcNow;
            BD.AddedIp = CommonModel.IPAddress();
            int exec = ProductGallery.DeleteImage(conSQ, BD);
            if (exec > 0)
            {
                x = "Success";
            }
            else
            {
                x = "W";
            }
        }
        catch (Exception ex)
        {
            x = "W";
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "Delete", ex.Message);
        }
        return x;
    }
    protected void btnNew_Click(object sender, EventArgs e)
    {
        var Gid = Convert.ToString(Request.QueryString["Gid"]);
        Response.Redirect("/adminmanage-product-galleries.aspx?Pid=" + Gid, false);
    }
    public void GetProductName()
    {
        try
        {
            var Gid = Convert.ToString(Request.QueryString["Gid"]);
            if (Gid != null && Gid != "")
            {
                var sub = ProductDetails.GetProductnameWithGuid(conSQ, Gid);
                if (sub != null)
                {
                    for (int i = 0; i < sub.Count; i++)
                    {
                        StrProductname = sub[i].ProductName;
                    }
                }
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetProductName", ex.Message);

        }
    }
}