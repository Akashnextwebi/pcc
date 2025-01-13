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
    public string strJobTitle = "", strEducation = "", strJobLocation = "", strJobDescription = "", strKeyResponsibilities = "", strSkills = "", strEmploymentType = "", strtime = "";
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
                strEducation=Job.Education;
                strJobLocation = Job.JobLocation;
                strJobDescription=Job.JobDescription;
                strKeyResponsibilities=Job.KeyResponsibilities;
                strSkills = Job.KeyResponsibilities;
                strEmploymentType=Job.EmploymentType;
                strtime = ago;

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindJobDetails", ex.Message);
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        lblStatus.Text = "";
        lblStatus.CssClass = "";
        try
        {
            var rPath = CheckPdfFormat();
            if (rPath == "Format")
            {
                lblStatus.Text = "Invalid resume format.";
                lblStatus.CssClass = "alert alert-danger d-block";
                return;
            }

            ApplyJobs JD = new ApplyJobs();
            JD.Fullname = txtname.Text.Trim();
            JD.Emailid = txtemail.Text.Trim();
            JD.Contactnumber = txtcontact.Text.Trim();
            JD.Experience = txtexperience.Text.Trim();
            JD.Location = txtlocation.Text.Trim();
            JD.CurrentCompany = txtcompany.Text.Trim();
            JD.Resume = UploadResume();
            JD.Message = txtWriteYourMessage.Text.Trim();
            JD.Noticeperiod = ddlNoticePeriod.Text.Trim();
            JD.JobId = txtJobId.Value == "" ? 0 : Convert.ToInt32(txtJobId.Value);
            JD.JobTitle = txtJobTitle.Value.Trim();
            JD.AddedIp = CommonModel.IPAddress();
            JD.AddedOn = TimeStamps.UTCTime();
            JD.Status = "Active";           
            int result = ApplyJobs.InsertApplyjobs(conSQ, JD);
            if (result > 0)
            {

                SendMail(JD);
                txtname.Text = txtemail.Text = txtcontact.Text = txtexperience.Text = txtlocation.Text = txtcompany.Text = txtWriteYourMessage.Text = "";
                ddlNoticePeriod.ClearSelection();
                //lblStatus.Text = "Job applied successfully";
                //lblStatus.CssClass = "alert alert-success d-block";
                Response.Redirect("thankyou.aspx");

            }
            else
            {
                lblStatus.Text = "There is some problem now. Please try after some time";
                lblStatus.CssClass = "alert alert-danger d-block";
            }
        }
        catch (Exception ex)
        {
            lblStatus.Text = "There is some problem now. Please try after some time";
            lblStatus.CssClass = "alert alert-danger d-block";
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "btnSubmit_Click", ex.Message);

        }
    }
    private string CheckPdfFormat()
    {
        #region ThumbImage
        string Resume = "";
        if (fuResumePath.HasFile)
        {
            try
            {
                string fileExtension = Path.GetExtension(fuResumePath.PostedFile.FileName.ToLower());
                if (!(fileExtension == ".pdf" || fileExtension == ".doc" || fileExtension == ".docx" || fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" || fileExtension == ".gif" || fileExtension == ".webp"))
                {
                    return "Format";
                }
            }
            catch (Exception ex)
            {
                ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "CheckPdfFormat", ex.Message);
            }
        }
        #endregion
        return Resume;
    }
    public string UploadResume()
    {
        #region upload file
        string thumbfile = "";
        try
        {
            if (fuResumePath.HasFile)
            {
                string fileExtension = Path.GetExtension(fuResumePath.PostedFile.FileName.ToLower()),
                ImageGuid1 = Guid.NewGuid().ToString() + "_resume".Replace(" ", "-").Replace(".", "");
                string iconPath = Server.MapPath(".") + "../UploadPDF\\" + ImageGuid1 + "" + fileExtension;
                fuResumePath.SaveAs(iconPath);
                thumbfile = "UploadPDf/" + ImageGuid1 + "" + fileExtension;
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

    public int SendMail(ApplyJobs con)
    {
        try
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(ConfigurationManager.AppSettings["ToMail"]);
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["CCMail"]))
            {
                mail.CC.Add(ConfigurationManager.AppSettings["CCMail"]);
            }
            string path = HttpContext.Current.Server.MapPath(@"\" + con.Resume + "");
            Attachment attachment = new Attachment(path);
            mail.Attachments.Add(attachment);
            mail.From = new MailAddress(ConfigurationManager.AppSettings["from"], ConfigurationManager.AppSettings["fromName"]);
            mail.Subject = "Job Application - Park Control and Communication";
            mail.Body = "Hi Admin, <br><br>You have received a Job Application " + con.Fullname + ".<br><br><u><b><i>Details : </i></b></u><br>Fullname : " + con.Fullname + "<br>Email-Id : " + con.Emailid + "<br>ContactNumber : " + con.Contactnumber + "<br>Experience :" + con.Experience + "<br>Location :" + con.Location + "<br>CurrentCompany:" + con.CurrentCompany + "<br>Noticeperiod:" + con.Noticeperiod + @"</a><br><br>Regards,<br>Park Control and Communication";
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = ConfigurationManager.AppSettings["host"];
            smtp.Port = Convert.ToInt32(ConfigurationManager.AppSettings["port"]);
            smtp.Credentials = new System.Net.NetworkCredential
            (ConfigurationManager.AppSettings["userName"], ConfigurationManager.AppSettings["password"]);
            smtp.EnableSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["enableSsl"]);
            smtp.Send(mail);
            return 1;
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.AbsoluteUri, "SendMail", ex.Message);
            return 0;

        }
    }
}