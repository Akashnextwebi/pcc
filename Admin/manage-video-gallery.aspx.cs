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

public partial class Admin_manage_video_gallery : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);

    public string strVideos = "", strThumbImage="";
    
    protected void Page_Load(object sender, EventArgs e)
    {
        GetVideoList();
        if (!IsPostBack)
        {

            if (Request.QueryString["id"] != null)
            {
                GetVideoDetails();
            }
        }
    }
    public void GetVideoDetails()
    {
        try
        {
            var lnk = VideoDetails.GetAllVideoDetailsWithId(conSQ, Convert.ToInt32(Request.QueryString["id"]));
            if (lnk != null)
            {
                btnNew.Visible = true;
                btnSave.Text = "Update";
                txtlink.Text = lnk.VideoLink;
                if (lnk.ThumbImage != "")
                {
                    lblThumb.Text = lnk.ThumbImage;
                    strThumbImage = @"<a href='/" + lnk.ThumbImage + @"' target='_blank'><img src='/" + lnk.ThumbImage + @"' width='60px'></a>";

                }

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetVideoDetails", ex.Message);
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            try
            {
                var ThumbImg = CheckThumbFormat();
                if (ThumbImg == "Format")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image format. Please upload .png, .jpeg, .jpg, .webp, .gif for blog image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                if (ThumbImg == "Size")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image size.Please upload correct resolution image for Video Gallery Image image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }

                string aid = Request.Cookies["pcc_aid"].Value;
                VideoDetails st = new VideoDetails()
                {
                    VideoLink = txtlink.Text,
                    ThumbImage = UploadThumbImage(),
                    AddedOn = DateTime.Now,
                    AddedBy = aid,
                    AddedIp = CommonModel.IPAddress(),
                    Status = "Active",
                    Id = Request.QueryString["id"] == null ? 0 : Convert.ToInt32(Request.QueryString["id"]),
                };
                if (btnSave.Text == "Update")
                {
                    int result = VideoDetails.UpdateVideoLink(conSQ, st);
                    if (result > 0)
                    {
                        GetVideoDetails();
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: ' Video Gallery Updated successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops! Something went wrong. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    }

                }
                else
                {
                    int result = VideoDetails.AddVideoLink(conSQ, st);
                    if (result > 0)
                    {
                        txtlink.Text = "";

                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Video Gallery added successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops! Something went wrong. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    }
                }
                GetVideoList();

            }
            catch (Exception ex)
            {
                ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "btnSave_Click", ex.Message);
            }
        }
    }
    public void GetVideoList()
    {
        try
        {
            var lnk = VideoDetails.GetAllVideoLink(conSQ);
            if (lnk != null)
            {
                strVideos = "";
                for (int i = 0; i < lnk.Count; i++)
                {
                    var image = "<a href='/" + lnk[i].ThumbImage + @"' target='_blank'><img src='/" + lnk[i].ThumbImage + @"' alt=''  width='50'></a>";
                    strVideos += @"<tr>
                                        <td>" + (i + 1) + @"</td>
                                        <td>"+ image + @"</td>
                                        <td><a href='" + lnk[i].VideoLink + @"' class='text secondary fw-bold' target='_blank'>Link</a></td>
                                        <td>" + Convert.ToDateTime(lnk[i].AddedOn).ToString("dd MMM yyyy") + @"</td>
                                        <td class='text-center'>
                                            <a href='manage-video-gallery.aspx?id=" + lnk[i].Id + @"' class='bs-tooltip text-info fs-18' data-id='" + lnk[i].Id + @"' data-toggle='tooltip' data-placement='top' title='Edit' data-original-title='Edit'>
                                               <i class='mdi mdi-pencil'></i></a>
                                            <a href='javascript:void(0);' class='bs-tooltip warning confirm text-danger fs-18 deleteItem' data-id='" + lnk[i].Id + @"' data-toggle='tooltip' data-placement='top' title='Delete' data-original-title='Delete'>
                                               <i class='mdi mdi-delete-forever'></i></a>
                                        </td>
                                    </tr>";
                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetCategoryList", ex.Message);

        }
    }
    [WebMethod(EnableSession = true)]
    public static string Delete(string id)
    {
        string x = "";
        try
        {
            SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
            VideoDetails BD = new VideoDetails();
            BD.Id = Convert.ToInt32(id);
            BD.AddedOn = DateTime.UtcNow;
            BD.AddedIp = CommonModel.IPAddress();
            BD.Status = "Active";
            int exec = VideoDetails.DeleteVideoLink(conSQ, BD);
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
                    System.Drawing.Bitmap bitimg = new System.Drawing.Bitmap(ThumbImage.PostedFile.InputStream);
                    if ((bitimg.PhysicalDimension.Height != 548) || (bitimg.PhysicalDimension.Width != 800))
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

    protected void btnNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("manage-video-gallery.aspx");
    }

}