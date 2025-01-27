using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class case_studies : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string strcasecasestudy = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        BindCasestudy();
    }
    private void BindCasestudy()
    {

        try
        {
            strcasecasestudy = "";
            var cs = CaseStudy.GetAllCasestudies(conSQ).ToList();
            if (cs.Count > 0)
            {
                for (int i = 0; i < cs.Count; i++)
                {
                    var url = "casestudy/" + cs[i].CaseStudyUrl;


                    strcasecasestudy += @"<div class='col-lg-6'>
                        <div class='magnetic-wrap'>
                            <div class='case-study-card2 magnetic-item' style=''>
                                <div class='case-img'>
                                    <img src='/" + cs[i].CSThumbImage + @"' alt=''>
                                </div>
                                <div class='case-content'>
                                    <div class='category-and-title'>
                                        <a href='/casestudy/" + cs[i].CaseStudyUrl + @"'>Marketing</a>
                                        <h4><a href='/casestudy/" + cs[i].CaseStudyUrl + @"'>" + cs[i].CaseStudyName + @"</a></h4>
                                    </div>
                                    <div class='details-btn'>
                                        <a class='btn ss-btn mr-15' href='/casestudy/" + cs[i].CaseStudyUrl + @"'>
                   <i class='fal fa-long-arrow-right'></i>Read more
                                    
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>";

                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindCasestudy", ex.Message);
        }
    }
}
