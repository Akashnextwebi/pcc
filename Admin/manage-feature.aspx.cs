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

public partial class Admin_manage_feature : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string StrThumbImage = "", strFeature="";
    protected void Page_Load(object sender, EventArgs e)
    {
        GetFeatureList();
        if (Request.QueryString["id"] != null)
        {
            GetFeatureDetails();
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
                string aid = Request.Cookies["pcc_aid"].Value;
                ManageFeature st = new ManageFeature()
                {
                    Title = txtheading.Text,
                    FullDesc= txtfulldesc.Text,
                    ThumbImage = UploadImage(),
                    IndustryGuid = Convert.ToString(Request.QueryString["Pid"]),
                    AddedBy = aid,
                    Status = "Active",
                    Id = Request.QueryString["id"] == null ? 0 : Convert.ToInt32(Request.QueryString["id"]),
                };
                if (st.ThumbImage != "")
                {

                    if (btnSave.Text == "Update")
                    {
                        int result = ManageFeature.UpdateFeature(conSQ, st);
                        if (result > 0)
                        {
                            GetFeatureDetails();
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Feature Updated successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops! Something went wrong. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                        }

                    }
                    else
                    {
                        int result = ManageFeature.AddFeature(conSQ, st);
                        if (result > 0)
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Feature added successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                            txtheading.Text = txtfulldesc.Text = "";

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
                GetFeatureList();
            }
            catch (Exception ex)
            {
                ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "btnSave_Click", ex.Message);
            }
        }
    }
    public void GetFeatureDetails()
    {
        try
        {
            var feature = ManageFeature.GetAllFeatureDetailsWithId(conSQ, Convert.ToInt32(Request.QueryString["id"]));
            if (feature != null)
            {
                btnNew.Visible = true;
                btnSave.Text = "Update";
                txtheading.Text = feature.Title;
                txtfulldesc.Text = feature.FullDesc;
                if (feature.ThumbImage != "")
                {
                    lblThumb.Text = feature.ThumbImage;
                    StrThumbImage = @"<a href='/" + feature.ThumbImage + @"' target='_blank'><img src='/" + feature.ThumbImage + @"' width='60px'></a>";

                }

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetFeatureDetails", ex.Message);
        }
    }
    public void GetFeatureList()
    {
        try
        {
            var Pid = Convert.ToString(Request.QueryString["Pid"]);
            if (Pid != null && Pid.Count() > 0)
            {
                var Feature = ManageFeature.GetAllFeatureWithGuid(conSQ, Pid);
                if (Feature != null)
                {
                    strFeature = "";
                    for (int i = 0; i < Feature.Count; i++)
                    {
                        strFeature += @"<tr>
                                        <td>" + (i + 1) + @"</td>
                                        <td><a href='/" + Feature[i].ThumbImage + @"' target='_blank'><img src='/" + Feature[i].ThumbImage + @"' width='60'></a></td>
                                         <td>" + Feature[i].Title + @"</td>
                                        <td>" + Convert.ToDateTime(Feature[i].AddedOn).ToString("dd MMM yyyy") + @"</td>
                                        <td class='text-center'>
                                        <a href='manage-feature.aspx?Pid=" + Feature[i].IndustryGuid + @"&id=" + Feature[i].Id + @"' class='bs-tooltip text-info fs-18' data-id='" + Feature[i].Id + @"' data-toggle='tooltip' data-placement='top' title='Edit' data-original-title='Edit'>
                                               <i class='mdi mdi-pencil'></i></a>
                                                <a href='javascript:void(0);' class='bs-tooltip deleteItem warning confirm text-danger fs-18' data-id='" + Feature[i].Id + @"' data-pid='" + Feature[i].IndustryGuid + @"' data-toggle='tooltip' data-placement='top' title='Delete' data-original-title='Delete'>
                                               <i class='mdi mdi-delete-forever'></i></a>
                                        </td>
                                    </tr>";
                    }
                }
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllFeatureWithGuid", ex.Message);

        }
    }
    [WebMethod(EnableSession = true)]
    public static string Delete(string id)
    {
        string x = "";
        try
        {
            SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
            ManageFeature Feature = new ManageFeature();
            Feature.Id = Convert.ToInt32(id);
            Feature.AddedOn = DateTime.UtcNow;
            Feature.AddedIp = CommonModel.IPAddress();
            int exec = ManageFeature.DeleteFeature(conSQ, Feature);
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
        var Pid = Convert.ToString(Request.QueryString["Pid"]);
        Response.Redirect("/admin/manage-feature.aspx?Pid=" + Pid, false);
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
}