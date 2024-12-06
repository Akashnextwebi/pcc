using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_view_jobs : System.Web.UI.Page
{
    public string strJobs = "";
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        BindAllJobs();
    }
    public void BindAllJobs()
    {

        try
        {
            strJobs = "";
            List<JobDetails> BD = JobDetails.GetAllJobDetails(conSQ);

            for (int i = 0; i < BD.Count; i++)
            {
                 var image = "<a href='/" + BD[i].ThumbImage + @"' target='_blank'><img src='/" + BD[i].ThumbImage + @"' alt='' class='rounded-circle avatar-xs shadow'></a>";
                strJobs += @"<tr>
                                        <td>" + (i + 1) + @"</td>
                                        <td>"+ image + @"</td>
                                        <td>" + BD[i].JobTitle + @"</td>
                                        <td>" + BD[i].JobLocation + @"</td>
                                        <td>" + BD[i].EmploymentType + @"</td>
                                        <td>" + BD[i].AddedOn.ToString("dd/MMM/yyyy") + @"</td>
                                        <td class='text-center'> 
                                            <a href='add-new-job.aspx?id=" + BD[i].Id + @"' class='bs-tooltip  fs-18 link-success' data-id='" + BD[i].Id + @"' data-bs-toggle='tooltip' data-placement='top' title='Edit Jobs'><i class='mdi mdi-pencil'></i></a> 
                                            <a href = 'javascript:void(0);' class='bs-tooltip  fs-18 link-danger deleteItem' data-id='" + BD[i].Id + @"' data-bs-toggle='tooltip' data-placement='top' title='Delete Jobs'><i class='mdi mdi-trash-can-outline'></i></a> 
                                        </td>
                                        </tr>";

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindAllJobs", ex.Message);
        }
    }



    [WebMethod(EnableSession = true)]
    public static string Delete(string id)
    {
        string x = "";
        try
        {
            SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
            JobDetails BD = new JobDetails();
            BD.Id = Convert.ToInt32(id);
            BD.AddedOn = TimeStamps.UTCTime();
            BD.AddedIp = CommonModel.IPAddress();
            int exec = JobDetails.DeleteJobDetails(conSQ, BD);
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