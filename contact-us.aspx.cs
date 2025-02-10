using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class contact_us : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SendMail_Click(object sender, EventArgs e)
    {

        if (Page.IsValid)
        {
            try
            {
                ContactUs CD = new ContactUs();

                CD.Name = txtname.Text.Trim();
                CD.Email = txtemail.Text.Trim();
                CD.Subject = txtsubject.Text.Trim();
                CD.Message = txtmsg.Text.Trim();
                CD.AddedOn = TimeStamps.UTCTime();
                CD.AddedIp = CommonModel.IPAddress();
                CD.Status = "Active";
                int result = ContactUs.InsertContactUs(conSQ, CD);
                if (result > 0)
                {
                    Response.Redirect("thankyou.aspx", false);
                    SendMail(CD);
                    txtname.Text = txtemail.Text = txtsubject.Text = txtmsg.Text = "";


                }
                else
                {
                    lblStatus.Visible = true;
                    lblStatus.Text = "There is some problem now. Please try after some time.";
                    lblStatus.Attributes.Add("class", "alert alert-danger");
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "There is some problem now. Please try after some time";
                lblStatus.CssClass = "alert alert-danger d-block";
                ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "SendMail_Click", ex.Message);
            }
        }
    }
    public int SendMail(ContactUs con)
    {
        try
        {

            MailMessage mail = new MailMessage();
            mail.To.Add(ConfigurationManager.AppSettings["ToMail"]);
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["CCMail"]))
            {
                mail.CC.Add(ConfigurationManager.AppSettings["CCMail"]);
            }
            mail.From = new MailAddress(ConfigurationManager.AppSettings["from"], ConfigurationManager.AppSettings["fromName"]);
            mail.Subject = "Contact Request - Park Controls & Communication";
            mail.Body = "Hi Admin, <br><br>You have received a contact request from " + con.Name + ".<br><br><u><b><i>Details : </i></b></u><br>Name : " + con.Name + "<br>Email : " + con.Email + "<br>Subject : " + con.Subject + "<br>Message :" + con.Message + @"</a><br><br>Regards,<br>Park Controls & Communication";
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = ConfigurationManager.AppSettings["host"];
            smtp.Port = Convert.ToInt32(ConfigurationManager.AppSettings["port"]);
            smtp.Credentials = new System.Net.NetworkCredential
            (ConfigurationManager.AppSettings["userName"], ConfigurationManager.AppSettings["password"]);
            smtp.EnableSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["enableSsl"]);
            smtp.Timeout = 10000;
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
