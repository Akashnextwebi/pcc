using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class job_listing : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string strJobs = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        BindJobOpenings();
    }
    private void BindJobOpenings()
    {

        try
        {
            strJobs = "";
            var Jobs = JobDetails.GetAllJobs(conSQ).ToList();
            if (Jobs.Count > 0)
            {
                for (int i = 0; i < Jobs.Count; i++)
                {
                    var url = "Jobs/" + Jobs[i].JobUrl;


                    strJobs += @"<div class='col-lg-6'>
                        <div class='job-list-three d-flex h-100 w-100'>
                            <div class='main-wrapper h-100 w-100'>
                                <a href='job-details-v2' class='save-btn text-center rounded-circle tran3s' title='Save Job'><i class='bi bi-bookmark-dash'></i></a>
                                <div class='list-header d-flex align-items-center'>
                                    <a href='/job/" + Jobs[i].JobUrl + @"' class='logo'>
                                        <img src='/" + Jobs[i].ThumbImage + @"' data-src='/" + Jobs[i].ThumbImage + @"' alt='' class='lazy-img m-auto'></a>
                                    <div class='info-wrapper'>
                                        <a href='/job/" + Jobs[i].JobUrl + @"' class='title fw-500 tran3s'>" + Jobs[i].JobTitle + @"</a>
                                        <ul class='style-none d-flex flex-wrap info-data'>
                                            <li>₹" + Jobs[i].Salary + @"</li>
                                            <li>" + Jobs[i].Education +@"</li>
                                            <li>" + Jobs[i].JobLocation +@"</li>
                                        </ul>
                                    </div>
                                </div>
                                <p>
                                    " + Jobs[i].JobDescription + @"
                                </p>
                                <div class='d-sm-flex align-items-center justify-content-between mt-auto'>
                                    <div class='d-flex align-items-center'>
                                        <a href='/job/" + Jobs[i].JobUrl + @"' class='job-duration fw-500'>" + Jobs[i].EmploymentType + @"</a>
                                    </div>
                                    <a href='/job/" + Jobs[i].JobUrl + @"' class='btn2 ' data-animation='fadeInLeft' data-delay='.4s'>Apply Now <i class='fal fa-long-arrow-right'></i></a>
                                </div>
                            </div>
                        </div>
                    </div>
";
                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindAllJobs", ex.Message);
        }
    }
}