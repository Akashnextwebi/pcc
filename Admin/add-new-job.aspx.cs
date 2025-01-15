using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class Admin_add_new_job : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string strCompanyImage = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindJobDetails();
            if (!string.IsNullOrEmpty(Request.QueryString["id"]))
            {

            }
        }
    }
    public void BindJobDetails()
    {
        try
        {
            var job = JobDetails.GetJobDetailsById(conSQ, Convert.ToInt32(Request.QueryString["id"]));
            if (job != null)
            {
                btnSave.Text = "Update";
                btnNew.Visible = true;
                txtName.Text = job.JobTitle;
                txtUrl.Text = job.JobUrl;
                txtMetaDesc.Text = job.MetaDesc;
                txtEmpType.Text = job.EmploymentType;
                txtPostedOn.Text = job.PostedOn.ToString("dd MMM yyyy");
                txtMetaKey.Text = job.MetaKeys;
                txtShortDesc.Text = job.ShortDesc;
                txtDesc.Text = job.JobDescription;
                txtkey.Text= job.KeyResponsibilities;
                txtskills.Text = job.Experience;
                txtPageTitle.Text = job.PageTitle;
                txtEducation.Text = job.Education;             
                txtLocation.Text = job.JobLocation;
                txtSalary.Text= job.Salary;

                if (job.ThumbImage != "")
                {
                    lblThumb.Text = job.ThumbImage;
                    strCompanyImage = @"<a href='/" + job.ThumbImage + @"' target='_blank'><img src='/" + job.ThumbImage + @"' width='60px'></a>";

                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindJobDetails", ex.Message);
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsValid)
            {
                var ThumbImg = CheckThumbFormat();
                if (ThumbImg == "Format")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image format. Please upload .png, .jpeg, .jpg, .webp, .gif for blog image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                if (ThumbImg == "Size")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image size.Please upload correct resolution image for blog image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                var aid = Request.Cookies["bmw_aid"].Value;

                JobDetails job = new JobDetails();

                job.JobTitle = txtName.Text.Trim();
                job.JobUrl = txtUrl.Text.Trim();
                job.PostedOn = Convert.ToDateTime(txtPostedOn.Text.Trim());
                job.EmploymentType = txtEmpType.Text.Trim();
                job.JobLocation = txtLocation.Text.Trim();
                job.Salary = txtSalary.Text.Trim();
                job.Education = txtEducation.Text.Trim();
                job.ShortDesc = txtShortDesc.Text.Trim();
                job.JobDescription = txtDesc.Text.Trim();
                job.KeyResponsibilities = txtkey.Text.Trim();
                job.Experience = txtskills.Text.Trim();
                job.ThumbImage = UploadThumbImage();
                job.MetaDesc = txtMetaDesc.Text.Trim();
                job.MetaKeys = txtMetaKey.Text.Trim();
                job.PageTitle = txtPageTitle.Text.Trim();
                job.AddedIp = CommonModel.IPAddress();
                job.AddedOn = TimeStamps.UTCTime();
                job.AddedBy = aid;
                job.Status = "Active";

                if (btnSave.Text == "Update")
                {
                    job.Id = Convert.ToInt32(Request.QueryString["id"]);
                    int result = JobDetails.UpdateJobDetails(conSQ, job);
                    if (result > 0)
                    {
                        BindJobDetails();
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Job Details Updated successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops! Something went wrong. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    }
                }
                else
                {
                    int result = JobDetails.InsertJobDetails(conSQ, job);
                    if (result > 0)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Job Details Added successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                        txtName.Text = txtUrl.Text = txtPostedOn.Text = txtEmpType.Text = txtLocation.Text = txtSalary.Text = txtEducation.Text = txtDesc.Text = txtkey.Text = txtskills.Text = txtMetaDesc.Text = txtMetaKey.Text = txtPageTitle.Text = txtShortDesc.Text="";
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops! Something went wrong. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    }
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Please fill all required fields.',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "btnSave_Click", ex.Message);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops! Something went wrong. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
        }
    }
    private string CheckThumbFormat()
    {
        #region ThumbImage
        string thumbImg = "";
        if (companyimage.HasFile)
        {
            try
            {
                string fileExtension = Path.GetExtension(companyimage.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString();
                if ((fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" || fileExtension == ".gif" || fileExtension == ".webp"))
                {
                    System.Drawing.Bitmap bitimg = new System.Drawing.Bitmap(companyimage.PostedFile.InputStream);
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
            if (companyimage.HasFile)
            {
                string fileExtension = Path.GetExtension(companyimage.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString() + "-banner".Replace(" ", "-").Replace(".", "");
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
                companyimage.SaveAs(iconPath);
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
        Response.Redirect("add-new-job.aspx", false);
    }
}