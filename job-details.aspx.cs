using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class job_details : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string strJobTitle = "", strEducation = "", strJobLocation = "", strJobDescription = "", strKeyResponsibilities = "", strSkills = "", strEmploymentType = "", strtime = "", strImage = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        var jurl = Convert.ToString(RouteData.Values["jurl"]);
        if (!string.IsNullOrEmpty(jurl))
        {
            BindJobDetails(jurl);
        }

    }
    private void BindJobDetails(string jurl)
    {
        try
        {

            var Job = JobDetails.getJobDetailsByUrl(conSQ, jurl);
            if (Job != null)
            {
                #region SEO
                if (!string.IsNullOrEmpty(Job.PageTitle))
                {
                    Page.Title = Job.PageTitle;
                }
                else
                {
                    Page.Title = Job.JobTitle + " | Park Control and Comunication";
                }
                if (!string.IsNullOrEmpty(Job.MetaDesc))
                {
                    Page.MetaDescription = Job.MetaDesc;
                }
                if (!string.IsNullOrEmpty(Job.MetaKeys))
                {
                    Page.MetaKeywords = Job.MetaKeys;
                }
                #endregion

                var currDate = TimeStamps.UTCTime() - Job.AddedOn;
                var ago = "";
                if (currDate.TotalMinutes < 60)
                {
                    ago = Convert.ToInt32(currDate.TotalMinutes) + " Minute ago";
                }
                else if (currDate.TotalHours < 24)
                {
                    ago = currDate.TotalHours.ToString("N0") + " Hours ago";
                }
                else if (currDate.TotalDays < 30)
                {
                    ago = currDate.TotalDays.ToString("N0") + " Days ago";
                }
                else if (currDate.TotalDays < 365 / 30)
                {
                    ago = currDate.TotalDays.ToString("N0") + " Month ago";
                }
                else if (currDate.TotalDays > 365)
                {
                    ago = currDate.TotalDays.ToString("N0") + " Year ago";
                }

                strJobTitle = Job.JobTitle;
                strEducation = Job.Education;
                strJobLocation = Job.JobLocation;
                strJobDescription = Job.JobDescription;
                strKeyResponsibilities = Job.KeyResponsibilities;
                strSkills = Job.KeyResponsibilities;
                strEmploymentType = Job.EmploymentType;
                strtime = ago;
                strImage = Job.ThumbImage;

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindJobDetails", ex.Message);
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        lblStatus.Visible = true;
        try
        {
            var rPath = CheckResumeFormat();
            if (rPath == "Format")
            {
                lblStatus.Text = "Invalid resume format.";
                lblStatus.CssClass = "alert alert-danger d-block";
                return;
            }

            var ApplyJobs = new ApplyJobs()
            {

                Fullname = txtname.Text.Trim(),
                Emailid = txtemail.Text.Trim(),
                Contactnumber = txtcontact.Text.Trim(),
                Experience = txtexperience.Text.Trim(),
                Location = txtlocation.Text.Trim(),
                CurrentCompany = txtcompany.Text.Trim(),
                Resume = UploadResumes(),
                Message = txtWriteYourMessage.Text.Trim(),
                Noticeperiod = ddlNoticePeriod.Text.Trim(),
                JobId = txtJobId.Value == "" ? 0 : Convert.ToInt32(txtJobId.Value),
                JobTitle = txtJobTitle.Value.Trim(),
                AddedIp = CommonModel.IPAddress(),
                AddedOn = TimeStamps.UTCTime(),
                Status = "Active",

            };

            var result = ApplyJobs.InsertApplyjobs(conSQ, ApplyJobs);


            if (result > 0)
            {
                lblStatus.Text = "Job applied Succefully, our team will reach out to you soon!";
                lblStatus.CssClass = "alert alert-success d-block";
                string Pageurl = HttpContext.Current.Request.Url.AbsoluteUri.ToString();
                MailMessage mail = new MailMessage();
                mail.To.Add("hr@parkcontrols.com");
                if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["CCMail"]))
                {
                    mail.CC.Add(ConfigurationManager.AppSettings["CCMail"]);
                }
                string path = HttpContext.Current.Server.MapPath(@"\" + ApplyJobs.Resume + "");
                Attachment attachment = new Attachment(path);
                mail.Attachments.Add(attachment);
                mail.From = new MailAddress(ConfigurationManager.AppSettings["from"], ConfigurationManager.AppSettings["fromName"]);
                mail.Subject = "Job Application - Park Control and Communication";
                mail.Body = @"Hi Admin, <br><br>You have received a Job Application from " + txtname.Text + ".<br><br>" +
                    "<u><b><i>Application Details : </i></b></u>" +
                    "<br>Full Name : " + txtname.Text + "" +
                    "<br>Email Id : " + txtemail.Text + "" +
                    "<br>Contact Number : " + txtcontact.Text + "" +
                    "<br>Experience: " + txtexperience.Text + "" +
                    "<br>Location: " + txtlocation.Text + "" +
                    "<br>Current Company: " + txtcompany.Text + "" +
                    "<br>Message: " + txtWriteYourMessage.Text + "" +
                    "<br>Job Title: " + txtJobTitle.Value + "" +
                    "<br>Noticeperiod : " + ddlNoticePeriod.SelectedItem.Value + "" +
                    "<br>PageURL : <a href='" + Pageurl + "'>" + Pageurl + "</a>" +
                    "<br><br>Regards,<br> Park Control and Communication";
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = ConfigurationManager.AppSettings["host"];
                smtp.Port = Convert.ToInt32(ConfigurationManager.AppSettings["port"]);
                smtp.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["userName"], ConfigurationManager.AppSettings["password"]);
                smtp.EnableSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["enableSsl"]);
                smtp.Timeout = 10000;
                smtp.Send(mail);
                lblStatus.Text = "true";
                txtname.Text = txtemail.Text = txtcontact.Text = txtexperience.Text = txtlocation.Text = txtcompany.Text = txtWriteYourMessage.Text = "";
                ddlNoticePeriod.ClearSelection();
                lblStatus.Text = "Job applied successfully";
                //Response.Redirect("thankyou.aspx");

            }
            else
            {
                lblStatus.Text = "There is some problem now. Please try after some time";
                lblStatus.CssClass = "alert alert-danger d-block";
            }
        }
        catch (Exception ex)
        {

            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UploadResumePath", ex.Message);

        }
    }
    private string CheckResumeFormat()
    {
        #region resumeFormat
        string resume = "";
        if (UploadResume.HasFile)
        {
            try
            {
                string fileExtension = Path.GetExtension(UploadResume.PostedFile.FileName.ToLower());
                if ((fileExtension == ".pdf" || fileExtension == ".doc" || fileExtension == ".docx"))
                {
                    string iconPath = Server.MapPath(".") + "\\../Uploadpdf\\" + fileExtension;
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
        return resume;
    }
    public string UploadResumes()
    {
        #region upload file
        string thumbfile = "";
        try
        {
            if (UploadResume.HasFile)
            {
                string fileExtension = Path.GetExtension(UploadResume.PostedFile.FileName.ToLower()),
                ImageGuid1 = Guid.NewGuid().ToString() + "_resume".Replace(" ", "-").Replace(".", "");
                string iconPath = Server.MapPath(".") + "\\../UploadImages\\" + ImageGuid1 + "" + fileExtension;
                UploadResume.SaveAs(iconPath);
                thumbfile = "UploadImages/" + ImageGuid1 + "" + fileExtension;
            }
            else
            {
                thumbfile = lblResume.Text;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UploadResume", ex.Message);

        }

        #endregion
        return thumbfile;
    }
}