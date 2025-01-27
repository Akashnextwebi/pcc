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

public partial class Admin_manage_capabilities : System.Web.UI.Page
{

    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);

    public string strcap = "", strThumbImage="", StrProductname="";
    protected void Page_Load(object sender, EventArgs e)
    {
        GetProductName();
        GetCapabilitiesList();
        if (!IsPostBack)
        {

            if (Request.QueryString["id"] != null)
            {
                GetCapabilitiesDetails();
            }
        }
    }
    public void GetCapabilitiesDetails()
    {
        try
        {
            var cap = manageCapabilities.GetAllCapabilitiesDetailsWithId(conSQ, Convert.ToInt32(Request.QueryString["id"]));
            if (cap != null)
            {
                btnNew.Visible = true;
                btnSave.Text = "Update";
                txttitle.Text = cap.Title;
                txtDesc.Text = cap.FullDesc;
                if (cap.ThumbImage != "")
                {
                    strThumbImage = "<img src='/" + cap.ThumbImage + "' style='max-height:60px;' />";
                    lblThumb.Text = cap.ThumbImage;
                }

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetCapabilitiesDetails", ex.Message);
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            try
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

                string aid = Request.Cookies["bmw_aid"].Value;
                manageCapabilities st = new manageCapabilities()
                {
                    Title = txttitle.Text,
                    FullDesc = txtDesc.Text,
                    ThumbImage = UploadThumbImage(),
                    ProductGuid = Convert.ToString(Request.QueryString["Pid"]),
                    AddedIp = CommonModel.IPAddress(),
                    AddedOn = TimeStamps.UTCTime(),
                    AddedBy = aid,
                    Status = "Active",
                    Id = Request.QueryString["id"] == null ? 0 : Convert.ToInt32(Request.QueryString["id"]),
                };
                if (btnSave.Text == "Update")
                {
                    int result = manageCapabilities.UpdateCapabilities(conSQ, st);
                    if (result > 0)
                    {
                        GetCapabilitiesDetails();
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Capabilities details Updated successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops! Something went wrong. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    }

                }
                else
                {
                    int result = manageCapabilities.AddCapabilities(conSQ, st);
                    if (result > 0)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Capabilities details added successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                        txttitle.Text = txtDesc.Text = "";
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops! Something went wrong. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    }
                }
                GetCapabilitiesList();
            }
            catch (Exception ex)
            {
                ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "btnSave_Click", ex.Message);
            }
        }
    }
    public void GetCapabilitiesList()
    {
        try
        {
            var pid = Convert.ToString(Request.QueryString["Pid"]);
            if (pid != null && pid != "")
            {
                var cap = manageCapabilities.GetAllCapabilitiesWithGuid(conSQ, pid);
                if (cap != null)
                {
                    strcap="";
                    for (int i = 0; i < cap.Count; i++)
                    {
                        var image = "<a href='/" + cap[i].ThumbImage + @"' target='_blank'><img src='/" + cap[i].ThumbImage + @"' alt='' class='rounded-circle avatar-xs shadow'></a>";
                        strcap += @"<tr>
                                        <td>" + (i + 1) + @"</td>
                                         <td>" + image + @"</td>  
                                        <td>" + cap[i].Title + @"</td>  
                                        <td>" + Convert.ToDateTime(cap[i].AddedOn).ToString("dd MMM yyyy") + @"</td>
                                        <td class='text-center'>
                                        <a href='manage-capabilities.aspx?Pid=" + cap[i].ProductGuid + @"&id=" + cap[i].Id + @"' class='bs-tooltip text-info fs-18' data-id='" + cap[i].Id + @"' data-toggle='tooltip' data-placement='top' title='Edit' data-original-title='Edit'>
                                               <i class='mdi mdi-pencil'></i></a>
                                                <a href='javascript:void(0);' class='bs-tooltip deleteItem warning confirm text-danger fs-18' data-id='" + cap[i].Id + @"' data-toggle='tooltip' data-placement='top' title='Delete' data-original-title='Delete'>
                                               <i class='mdi mdi-delete-forever'></i></a>
                                        </td>
                                    </tr>";
                    }
                }
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetCapabilitiesList", ex.Message);

        }
    }
    [WebMethod(EnableSession = true)]
    public static string Delete(string id)
    {
        string x = "";
        try
        {
            SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
            manageCapabilities BD = new manageCapabilities();
            BD.Id = Convert.ToInt32(id);
            BD.AddedOn = DateTime.UtcNow;
            BD.AddedIp = CommonModel.IPAddress();
            int exec = manageCapabilities.DeleteCapabilities(conSQ, BD);
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
                    string iconPath = Server.MapPath(".") + "\\../UploadImages\\" + ImageGuid1 + "-thumb" + fileExtension;
                    System.Drawing.Bitmap bitimg = new System.Drawing.Bitmap(ThumbImage.PostedFile.InputStream);
                    if ((bitimg.PhysicalDimension.Height != 60) || (bitimg.PhysicalDimension.Width != 60))
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
                ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "CheckCSthumbFormat", ex.Message);

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
                string fileExtension = Path.GetExtension(ThumbImage.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString() + "-sample".Replace(" ", "-").Replace(".", "");
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
    protected void btnNew_Click(object sender, EventArgs e)
    {
        var pid = Convert.ToString(Request.QueryString["Pid"]);
        Response.Redirect("/admin/manage-capabilities.aspx?Pid=" + pid, false);
    }
     public void GetProductName()
    {
        try
        {
            var pid = Convert.ToString(Request.QueryString["Pid"]);
            if (pid != null && pid != "")
            {
                var sub = ProductDetails.GetProductnameWithGuid(conSQ, pid);
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