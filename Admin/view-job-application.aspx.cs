using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_view_job_application : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string strJobs = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        BindAllJobapplications();
    }
    public void BindAllJobapplications()
    {

        try
        {
            strJobs = "";
            List<ApplyJobs> JA = ApplyJobs.GetAllApplyjobs(conSQ);

            for (int i = 0; i < JA.Count; i++)
            {          
                var pdfIcon = "<img src='assets/images/pdf.png' alt='PDF' class='pdf-icon' style='width:30px; height:30px; vertical-align:middle;'>";
                var ResumePath = "<a href='/" + JA[i].Resume + "' target='_blank'>" + pdfIcon + "PDF</a>";

                strJobs += @"<tr>
                                        <td>" + (i + 1) + @"</td>
                                        <td>" + JA[i].Fullname + @"</td>
                                        <td>" + JA[i].Emailid + @"</td>
                                        <td>" + JA[i].Contactnumber + @"</td>
                                        <td>" + JA[i].Experience + @"</td>
                                        <td>" + JA[i].Location + @"</td>
                                        <td>" + JA[i].CurrentCompany + @"</td>
                                        <td>" + JA[i].Noticeperiod + @"</td>
                                        <td>" + ResumePath + @"</td>
                                        <td>" + JA[i].Message + @"</td>
                                        <td>" + JA[i].AddedOn.ToString("dd/mm/yyyy") + @"</td>
                                        
                                        <td class='text-center'> 
                                            <a href = 'javascript:void(0);' class='bs-tooltip  fs-18 link-danger deleteItem' data-id='" + JA[i].Id + @"' data-bs-toggle='tooltip' data-placement='top' title='Delete Jobs'><i class='mdi mdi-trash-can-outline'></i></a> 
                                        </td>
                                        </tr>";

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindAllJobapplications", ex.Message);
        }
    }
    [WebMethod(EnableSession = true)]
    public static string Delete(string id)
    {
        string x = "";
        try
        {
            SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
            ApplyJobs JA = new ApplyJobs();
            JA.Id = Convert.ToInt32(id);
            JA.AddedIp = CommonModel.IPAddress();
            JA.AddedOn = TimeStamps.UTCTime();
            int exec = ApplyJobs.DeleteApplyjobs(conSQ, JA);
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
}