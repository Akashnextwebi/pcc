using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_add_whitepaper : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string strThumbImage = "", strDetailImage = "", strBannerImage="";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindCapability();
            if (Request.QueryString["id"] != null)
            {
                GetWhitepapers();
            }
        }
    }
    public void GetWhitepapers()
    {
        try
        {
            WhitePaperDetails WD = WhitePaperDetails.GetAllWhitepaperDetailsWithId(conSQ, Convert.ToInt32(Request.QueryString["id"])).FirstOrDefault();
            if (WD != null)
            {
                divimg.Visible = true;

                btnSave.Text = "Update";
                btnNew.Visible = true;
                txtName.Text = WD.WhitePaperTitle;
                txtPostedBy.Text = WD.PostedBy;
                txtUrl.Text = WD.WhitePaperUrl;
                txtPostedOn.Text = WD.PostedOn;
                txtPostedOn.Text= WD.PostedOn;
                txttag.Text= WD.Tag;
                ddlCapability.SelectedValue = WD.Capability;
                txtheading.Text = WD.WhitePaperHeading;
                txtDesc.Text = WD.FullDesc;
                txtPageTitle.Text = WD.PageTitle;
                txtMetaKey.Text = WD.MetaKeys;
                txtMetaDesc.Text= WD.MetaDesc;
                if (WD.ThumbImage != "")
                {
                    strThumbImage = "<img src='/" + WD.ThumbImage + "' style='max-height:60px;' />";
                    lblThumb.Text = WD.ThumbImage;
                }
                if (WD.DetailImage != "")
                {
                    strDetailImage = "<img src='/" + WD.DetailImage + "' style='max-height:60px;' />";
                    lblDetail.Text = WD.DetailImage;
                }
                if (WD.BannerImage != "")
                {
                    strBannerImage = "<img src='/" + WD.BannerImage + "' style='max-height:60px;' />";
                    lblBanner.Text = WD.BannerImage;
                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetWhitepapers", ex.Message);
        }
    }
    public void BindCapability()
    {
        try
        {
            List<Capability> loc = Capability.GetAllCapability(conSQ);
            if (loc != null && loc.Count() > 0)
            {
                ddlCapability.DataSource = loc;
                ddlCapability.DataTextField = "CapabilityName";
                ddlCapability.DataValueField = "Id";
                ddlCapability.DataBind();
               
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindCapability", ex.Message);
        }
    }
    public void GetCapability(string loc)
    {
        try
        {
            foreach (string str in loc.Split('|'))
            {
                foreach (ListItem li in ddlCapability.Items)
                {
                    if (str.Trim() == li.Value.Trim())
                    {
                        li.Selected = true;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetCapability", ex.Message);
        }
    }
    public string SaveCapability()
    {
        string x = "";
        try
        {

            foreach (ListItem li in ddlCapability.Items)
            {
                if (li.Selected)
                {
                    x += li.Value + "|";
                }
            }
            x = x.TrimEnd('|');

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "SaveCapability", ex.Message);

        }
        return x;
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsValid)
            {
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
                var Detailimg = CheckDetailImageFormat();

                if (Detailimg == "Format")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image format. Please upload .png, .jpeg, .jpg, .webp, .gif for Detail image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                if (Detailimg == "Size")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image size.Please upload correct resolution image for Detail image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                var Bannerimg = CheckBannerImageFormat();

                if (Bannerimg == "Format")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image format. Please upload .png, .jpeg, .jpg, .webp, .gif for Banner image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                if (Bannerimg == "Size")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image size.Please upload correct resolution image for Banner image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }

                var aid = Request.Cookies["pcc_aid"].Value;
                WhitePaperDetails WD = new WhitePaperDetails();
                WD.WhitePaperTitle = txtName.Text;
                WD.WhitePaperUrl = txtUrl.Text;
                WD.PostedBy = txtPostedBy.Text;
                WD.PostedOn = txtPostedOn.Text;
                WD.WhitePaperHeading = txtheading.Text;
                WD.Tag = txttag.Text;
                WD.Capability = SaveCapability();
                WD.ThumbImage = UploadThumbImage();
                WD.DetailImage = UploadDetailImage();
                WD.BannerImage = UploadBannerImage();
                WD.FullDesc = txtDesc.Text.Trim();
                WD.MetaDesc = txtMetaDesc.Text;
                WD.MetaKeys = txtMetaKey.Text;
                WD.PageTitle = txtPageTitle.Text;
                WD.AddedIp = CommonModel.IPAddress();
                WD.AddedOn = TimeStamps.UTCTime();
                WD.AddedBy = aid;
                WD.Status = "Active";
                if (WD.ThumbImage != "" && WD.DetailImage != "" && WD.BannerImage != "")
                {
                    if (btnSave.Text == "Update")
                    {
                        WD.Id = Convert.ToInt32(Request.QueryString["id"]);
                        int result = WhitePaperDetails.UpdateWhitepaperDetails(conSQ, WD);
                        if (result > 0)
                        {
                            GetWhitepapers();
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Whitepaper Updated successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops...! There is some problem right now.please try again after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);

                        }
                    }
                    else
                    {
                        int result = WhitePaperDetails.InsertWhitepaperDetails(conSQ, WD);
                        if (result > 0)
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Whitepaper Added successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                            txtDesc.Text = txtMetaDesc.Text = txtName.Text = txtUrl.Text = txtPageTitle.Text = txtMetaKey.Text = "";
                            strThumbImage = strDetailImage = strBannerImage= "";
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
                    if ((bitimg.PhysicalDimension.Height != 618) || (bitimg.PhysicalDimension.Width != 648))
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
    private string CheckDetailImageFormat()
    {
        #region ThumbImage
        string thumbImg = "";
        if (DetailImage.HasFile)
        {
            try
            {
                string fileExtension = Path.GetExtension(DetailImage.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString();
                if ((fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" || fileExtension == ".gif" || fileExtension == ".webp"))
                {
                    System.Drawing.Bitmap bitimg = new System.Drawing.Bitmap(DetailImage.PostedFile.InputStream);
                    if ((bitimg.PhysicalDimension.Height != 456) || (bitimg.PhysicalDimension.Width != 1016))
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
                ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "CheckDetailImageFormat", ex.Message);

            }
        }
        #endregion
        return thumbImg;
    }
    public string UploadDetailImage()
    {
        #region upload file
        string thumbfile = "";
        try
        {
            if (DetailImage.HasFile)
            {
                string fileExtension = Path.GetExtension(DetailImage.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString() + "-BlogImg".Replace(" ", "-").Replace(".", "");
                string iconPath = Server.MapPath(".") + "\\../UploadImages\\" + ImageGuid1 + "" + fileExtension;
                try
                {
                    if (File.Exists(Server.MapPath("~/" + Convert.ToString(lblDetail.Text))))
                    {
                        File.Delete(Server.MapPath("~/" + Convert.ToString(lblDetail.Text)));
                    }
                }
                catch (Exception eeex)
                {
                    ExceptionCapture.CaptureException(Request.Url.PathAndQuery, "UploadDetailImage", eeex.Message);
                    return lblDetail.Text;
                }
                DetailImage.SaveAs(iconPath);
                thumbfile = "UploadImages/" + ImageGuid1 + "" + fileExtension;
            }
            else
            {
                thumbfile = lblDetail.Text;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UploadDetailImage", ex.Message);

        }

        #endregion
        return thumbfile;
    }
    private string CheckBannerImageFormat()
    {
        #region ThumbImage
        string thumbImg = "";
        if (Bannerimage.HasFile)
        {
            try
            {
                string fileExtension = Path.GetExtension(Bannerimage.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString();
                if ((fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" || fileExtension == ".gif" || fileExtension == ".webp"))
                {
                    System.Drawing.Bitmap bitimg = new System.Drawing.Bitmap(Bannerimage.PostedFile.InputStream);
                    if ((bitimg.PhysicalDimension.Height != 1080) || (bitimg.PhysicalDimension.Width != 1920))
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
                ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "CheckBannerImageFormat", ex.Message);

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
            if (Bannerimage.HasFile)
            {
                string fileExtension = Path.GetExtension(Bannerimage.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString() + "-BlogImg".Replace(" ", "-").Replace(".", "");
                string iconPath = Server.MapPath(".") + "\\../UploadImages\\" + ImageGuid1 + "" + fileExtension;
                try
                {
                    if (File.Exists(Server.MapPath("~/" + Convert.ToString(lblBanner.Text))))
                    {
                        File.Delete(Server.MapPath("~/" + Convert.ToString(lblBanner.Text)));
                    }
                }
                catch (Exception eeex)
                {
                    ExceptionCapture.CaptureException(Request.Url.PathAndQuery, "UploadBannerImage", eeex.Message);
                    return lblBanner.Text;
                }
                Bannerimage.SaveAs(iconPath);
                thumbfile = "UploadImages/" + ImageGuid1 + "" + fileExtension;
            }
            else
            {
                thumbfile = lblBanner.Text;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UploadBannerImage", ex.Message);

        }

        #endregion
        return thumbfile;
    }

    protected void btnNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("add-whitepaper.aspx");
    }
}