using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_add_sub_capability : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string strThumbImage = "", strBannerImage="";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindCapability();
            if (Request.QueryString["id"] != null)
            {
                GetSubCapabilities();
            }
        }
    }
    public void GetSubCapabilities()
    {
        try
        {
            SubCapability BD = SubCapability.GetAllSubCapabilityDetailsWithId(conSQ, Convert.ToInt32(Request.QueryString["id"]));
            if (BD != null)
            {
                btnSave.Text = "Update";
                btnNew.Visible = true;
                ddlCapability.SelectedValue = BD.Capabilities;
                txtsubcapability.Text = BD.SubCapabilityName;
                txtUrl.Text = BD.SubCapabilityUrl;
                txttag.Text=BD.Tag;
                txtbtitle.Text = BD.BannerTitle;
                txtheading.Text = BD.DescHeading;
                txtfulldesc.Text = BD.FullDesc;

                if (BD.BannerImage != "")
                {
                    lblBanner.Text = BD.BannerImage;
                    strBannerImage = @"<a href='/" + BD.BannerImage + @"' target='_blank'><img src='/" + BD.BannerImage + @"' width='60px'></a>";

                }
                if (BD.ThumbImage != "")
                {
                    lblThumb.Text = BD.ThumbImage;
                    strThumbImage = @"<a href='/" + BD.ThumbImage + @"' target='_blank'><img src='/" + BD.ThumbImage + @"' width='60px'></a>";

                }


            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetSubCapabilities", ex.Message);
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
                ddlCapability.Items.Insert(0, new ListItem { Value = "0", Text = "Select Capability" });
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
                var id = Request.QueryString["id"] == "" ? 0 : Convert.ToInt32(Request.QueryString["id"]);
                var exist = SubCapability.CheckExist(conSQ, txtsubcapability.Text, txtUrl.Text, id);
                if (exist > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'SubCpability with title,url already exist.',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                var ThumbImg = CheckThumbFormat();
                if (ThumbImg == "Format")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image format. Please upload .png, .jpeg, .jpg, .webp, .gif for Thumb image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                if (ThumbImg == "Size")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image size.Please upload correct resolution image for Thumb image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                var BannerImg = CheckBannerFormat();
                if (BannerImg == "Format")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid Banner image format. Please upload .png, .jpeg, .jpg, .webp, .gif for blog image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                if (BannerImg == "Size")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid Banner image size.Please upload correct resolution image for blog image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }

                var aid = Request.Cookies["bmw_aid"].Value;
                SubCapability BD = new SubCapability();
                BD.Capabilities = SaveCapability();
                BD.SubCapabilityName= txtsubcapability.Text;
                BD.SubCapabilityUrl=txtUrl.Text;
                BD.Tag = txttag.Text;
                BD.BannerTitle = txtbtitle.Text.Trim();
                BD.DescHeading = txtheading.Text.Trim();
                BD.FullDesc = txtfulldesc.Text.Trim();
                BD.BannerImage = UploadBannerImage();
                BD.ThumbImage = UploadThumbImage();
                BD.AddedIp = CommonModel.IPAddress();
                BD.AddedOn = TimeStamps.UTCTime();
                BD.AddedBy = aid;
                BD.Status = "Active";

                if (btnSave.Text == "Update")
                {
                    BD.Id = Convert.ToInt32(Request.QueryString["id"]);
                    int result = SubCapability.UpdateSubCapabilityDetails(conSQ, BD);
                    if (result > 0)
                    {
                        GetSubCapabilities();
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'SubCapability Updated successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'There is some problem now.please try again after some time. ',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    }
                }
                else
                {
                    int result = SubCapability.InsertSubCapability(conSQ, BD);
                    if (result > 0)
                    {
                        
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'SubCapability Added successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                        txtsubcapability.Text = txttag.Text = txtUrl.Text  = ddlCapability.SelectedValue = "";
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'There is some problem now.please try again after some time. ',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);

                    }
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
        if (ThumbImage.HasFile)
        {
            try
            {
                string fileExtension = Path.GetExtension(ThumbImage.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString();
                if ((fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" || fileExtension == ".gif" || fileExtension == ".webp"))
                {
                    System.Drawing.Bitmap bitimg = new System.Drawing.Bitmap(ThumbImage.PostedFile.InputStream);
                    if ((bitimg.PhysicalDimension.Height != 350) || (bitimg.PhysicalDimension.Width != 415))
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
                    ExceptionCapture.CaptureException(Request.Url.PathAndQuery, "UploadThumbImage", eeex.Message);
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
    public string UploadBannerImage()
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
                BannerImage.SaveAs(iconPath);
                thumbfile = "UploadImages/" + ImageGuid1 + "" + fileExtension;
            }
            else
            {
                thumbfile = lblBanner.Text;
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
        Response.Redirect("add-sub-capability.aspx");
    }
}