using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class seminars : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string strseminar = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        BindSeminar();
    }
    private void BindSeminar()
    {

        try
        {
            strseminar = "";
            var seminar = SeminarDetails.GetAllSeminars(conSQ).ToList();
            if (seminar.Count > 0)
            {
                for (int i = 0; i < seminar.Count; i++)
                {

                    strseminar += @"<div class='col-md-6'>
                        <div class='eg-card4'>
                            <div class='card-img'>
                                <img src='/" + seminar[i].ThumbImage + @"' alt=''>
                            </div>
                            <div class='card-content'>
                                <a class'video-i popup-video' href='" + seminar[i].VideoUrl +@"'>"+ seminar[i].Tag + @"</a>
                                <div class='title-and-btn'>
                                    <h4><a href='" + seminar[i].VideoUrl +@"'>"+ seminar[i].SeminarTitle + @"</a></h4>
                                    <a href='"+ seminar[i].VideoUrl + @"' class='video-i popup-video btn2 ' contenteditable='false' style='cursor: pointer;'><i class='fa-regular fa-eye'></i>Watch Now
   
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>";

                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindSeminar", ex.Message);
        }
    }
}