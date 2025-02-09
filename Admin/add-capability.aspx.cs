using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Admin_add_capability : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string StrProductname="", strThumbImage="";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                GetCapabilities();
            }
        }
    }
    public void GetCapabilities()
    {
        try
        {
            Capability BD = Capability.GetAllCapabilityDetailsWithId(conSQ, Convert.ToInt32(Request.QueryString["id"]));
            if (BD != null)
            {
                btnSave.Text = "Update";
                btnNew.Visible = true;
                txtcapability.Text = BD.CapabilityName;
                txtUrl.Text = BD.CapabilityUrl;
                txtbtitle.Text = BD.BannerTitle;
                txtheading.Text = BD.DescHeading;
                txtfulldesc.Text = BD.FullDesc;

                if (BD.BannerImage != "")
                {
                    lblThumb.Text = BD.BannerImage;
                    strThumbImage = @"<a href='/" + BD.BannerImage + @"' target='_blank'><img src='/" + BD.BannerImage + @"' width='60px'></a>";

                }


            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetTestimonials", ex.Message);
        }

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsValid)
            {
                var id = Request.QueryString["id"] == "" ? 0 : Convert.ToInt32(Request.QueryString["id"]);
                var exist = Capability.CheckExist(conSQ, txtcapability.Text, txtUrl.Text, id);
                if (exist > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Cpability with title,url already exist.',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                var thumbImg = CheckThumbFormat();
                if (thumbImg == "Format")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image format. Please upload .png, .jpeg, .jpg, .webp, .gif for blog image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                if (thumbImg == "Size")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image size.Please upload correct resolution image for blog image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }

                var aid = Request.Cookies["pcc_aid"].Value;
                Capability BD = new Capability();
                BD.CapabilityName = txtcapability.Text.Trim();
                BD.CapabilityUrl = txtUrl.Text.Trim();
                BD.BannerTitle = txtbtitle.Text.Trim();
                BD.DescHeading = txtheading.Text.Trim();
                BD.FullDesc = txtfulldesc.Text.Trim();
                BD.CompetenciesOrder = "0";
                BD.BannerImage = UploadBannerImage();
                BD.AddedIp = CommonModel.IPAddress();
                BD.AddedOn = TimeStamps.UTCTime();
                BD.AddedBy = aid;
                BD.Status = "Active";

                if (btnSave.Text == "Update")
                {
                    BD.Id = Convert.ToInt32(Request.QueryString["id"]);
                    Capability cap = new Capability();
                    int result = cap.UpdateCapabilityDetails(conSQ, BD);
                    if (result > 0)
                    {
                        GetCapabilities();
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Capability Updated successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'There is some problem now.please try again after some time. ',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    }
                }
                else
                {
                    int result = Capability.InsertCapability(conSQ, BD);
                    if (result > 0)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Capability Added successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                        txtcapability.Text = txtUrl.Text = txtbtitle.Text= txtheading.Text= txtfulldesc.Text="";
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
                    if ((bitimg.PhysicalDimension.Height != 650) || (bitimg.PhysicalDimension.Width != 1920))
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
        Response.Redirect("add-capability.aspx");
    }

    //public void GetProductName()
    //{
    //    try
    //    {
    //        var pid = Convert.ToString(Request.QueryString["Pid"]);
    //        if (pid != null && pid != "")
    //        {
    //            var sub = ProductDetails.GetProductnameWithGuid(conSQ, pid);
    //            if (sub != null)
    //            {
    //                for (int i = 0; i < sub.Count; i++)
    //                {
    //                    StrProductname = sub[i].ProductName;
    //                }
    //            }
    //        }

    //    }
    //    catch (Exception ex)
    //    {
    //        ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetProductName", ex.Message);

    //    }
    //}
}