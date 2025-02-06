using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_manage_industries : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);

    public string strIndustry = "", strThumbImage = "", strbanner = "";
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {

            if (Request.QueryString["id"] != null)
            {
                GetIndustryDetails();
            }
        }
    }
    public void GetIndustryDetails()
    {
        try
        {
            var lnk = IndustryDetails.GetAllIndustryDetailsWithId(conSQ, Convert.ToInt32(Request.QueryString["id"]));
            if (lnk != null)
            {
                btnNew.Visible = true;
                btnSave.Text = "Update";
                txtname.Text = lnk.IndustryName;
                txtUrl.Text = lnk.IndustryUrl;
                txtheading.Text = lnk.DescHeading;
                txtfulldesc.Text = lnk.FullDesc;
                txtheading2.Text = lnk.DescHeading2;
                txtfdesc2.Text = lnk.FullDesc2;
                txtPageTitle.Text = lnk.PageTitle;
                txtMetaKey.Text = lnk.MetaKeys;
                txtMetaDesc.Text = lnk.MetaDesc;
                if (lnk.BannerImage != "")
                {
                    lblThumb.Text = lnk.BannerImage;
                    strThumbImage = @"<a href='/" + lnk.BannerImage + @"' target='_blank'><img src='/" + lnk.BannerImage + @"' width='60px'></a>";

                }
                if (lnk.BannerImage2 != "")
                {
                    lblbanner.Text = lnk.BannerImage2;
                    strbanner = @"<a href='/" + lnk.BannerImage2 + @"' target='_blank'><img src='/" + lnk.BannerImage2 + @"' width='60px'></a>";

                }

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllInvestorDetailsWithId", ex.Message);
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {

            try
            {

                var id = Request.QueryString["id"] == "" ? 0 : Convert.ToInt32(Request.QueryString["id"]);
                var exist = IndustryDetails.CheckExist(conSQ, txtname.Text, txtUrl.Text, id);
                if (exist > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Industry with title,url already exist.',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                var thumbimg = CheckThumbFormat();

                if (thumbimg == "Format")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image format. Please upload .png, .jpeg, .jpg, .webp, .gif for BannerImage1',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                if (thumbimg == "Size")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image size.Please upload correct resolution image for BannerImage1',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                var thumbImg = CheckBannerFormat();

                if (thumbimg == "Format")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image format. Please upload .png, .jpeg, .jpg, .webp, .gif for BannerImage2',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                if (thumbimg == "Size")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image size.Please upload correct resolution image for BannerImage2',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }

                string aid = Request.Cookies["pcc_aid"].Value;
                IndustryDetails st = new IndustryDetails()
                {
                    IndustryGuid = Guid.NewGuid().ToString(),
                    IndustryName = txtname.Text,
                    IndustryUrl = txtUrl.Text,
                    BannerImage = UploadBannerImage(),
                    BannerImage2 = UploadBannerImage2(),
                    DescHeading = txtheading.Text,
                    FullDesc = txtfulldesc.Text,
                    IndustryOrder="0",
                    FullDesc2 = txtfdesc2.Text,
                    DescHeading2 = txtheading2.Text,
                    PageTitle = txtPageTitle.Text,
                    MetaKeys = txtMetaKey.Text,
                    MetaDesc = txtMetaDesc.Text,
                    AddedOn = DateTime.Now,
                    AddedBy = aid,
                    AddedIp = CommonModel.IPAddress(),
                    Status = "Active",
                    Id = Request.QueryString["id"] == null ? 0 : Convert.ToInt32(Request.QueryString["id"]),
                };
                if (btnSave.Text == "Update")
                {
                    int result = IndustryDetails.UpdateIndustry(conSQ, st);
                    if (result > 0)
                    {
                        GetIndustryDetails();
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: ' Industry Updated successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops! Something went wrong. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    }

                }
                else
                {
                    int result = IndustryDetails.AddIndustry(conSQ, st);
                    if (result > 0)
                    {
                        txtname.Text = txtUrl.Text = txtheading.Text = txtfulldesc.Text = txtPageTitle.Text = txtMetaKey.Text = txtMetaDesc.Text = txtheading2.Text = txtfdesc2.Text = "";

                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Industry added successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops! Something went wrong. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    }
                }
               

            }
            catch (Exception ex)
            {
                ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "btnSave_Click", ex.Message);
            }
        }
    }
   
    private string CheckThumbFormat()
    {
        #region ThumbImage
        string thumbImg = "";
        if (ThumbImage.HasFile)
        {
            try
            {
                string fileExtension = Path.GetExtension(ThumbImage.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString();
                if ((fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" || fileExtension == ".gif" || fileExtension == ".webp"))
                {
                    System.Drawing.Bitmap bitimg = new System.Drawing.Bitmap(ThumbImage.PostedFile.InputStream);
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
    public string UploadBannerImage()
    {
        #region upload file
        string thumbfile = "";
        try
        {
            if (ThumbImage.HasFile)
            {
                string fileExtension = Path.GetExtension(ThumbImage.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString() + "-banner".Replace(" ", "-").Replace(".", "");
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
                    ExceptionCapture.CaptureException(Request.Url.PathAndQuery, "UploadBannerImage", eeex.Message);
                    return lblThumb.Text;
                }
                ThumbImage.SaveAs(iconPath);
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
    
    protected void btnNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("add-industries.aspx");
    }
    private string CheckBannerFormat()
    {
        #region BannerImage
        string thumbImg = "";
        if (BannerImage.HasFile)
        {
            try
            {
                string fileExtension = Path.GetExtension(BannerImage.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString();
                if ((fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" || fileExtension == ".gif" || fileExtension == ".webp"))
                {
                    System.Drawing.Bitmap bitimg = new System.Drawing.Bitmap(BannerImage.PostedFile.InputStream);
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
                ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "CheckBannerFormat", ex.Message);

            }
        }
        #endregion
        return thumbImg;
    }
    public string UploadBannerImage2()
    {
        #region upload file
        string thumbfile = "";
        try
        {
            if (BannerImage.HasFile)
            {
                string fileExtension = Path.GetExtension(BannerImage.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString() + "-banner".Replace(" ", "-").Replace(".", "");
                string iconPath = Server.MapPath(".") + "\\../UploadImages\\" + ImageGuid1 + "" + fileExtension;
                try
                {
                    if (File.Exists(Server.MapPath("~/" + Convert.ToString(lblbanner.Text))))
                    {
                        File.Delete(Server.MapPath("~/" + Convert.ToString(lblbanner.Text)));
                    }
                }
                catch (Exception eeex)
                {
                    ExceptionCapture.CaptureException(Request.Url.PathAndQuery, "UploadBannerImage2", eeex.Message);
                    return lblbanner.Text;
                }
                BannerImage.SaveAs(iconPath);
                thumbfile = "UploadImages/" + ImageGuid1 + "" + fileExtension;
            }
            else
            {
                thumbfile = lblbanner.Text;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UploadBannerImage2", ex.Message);

        }

        #endregion
        return thumbfile;
    }
}