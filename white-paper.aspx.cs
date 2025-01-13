using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class white_paper : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string strwhitepaper = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        BindWhitepapers();
    }
    private void BindWhitepapers()
    {

        try
        {
            strwhitepaper = "";
            var papers = WhitePaperDetails.GetAllWhitepapers(conSQ).ToList();
            if (papers.Count > 0)
            {
                for (int i = 0; i < papers.Count; i++)
                {
                    var url = "whitepaper/" + papers[i].WhitePaperUrl;


                    strwhitepaper += @"<div class='col-lg-4 col-md-6'>
                        <div class='eg-card3 four'>
                            <div class='card-img'>
                                <img src='"+ papers[i].ThumbImage + @"' alt=''>
                            </div>
                            <div class='card-content'>
                                <div class='catgory-and-title'>
                                    <a href='/whitepaper/" + papers[i].WhitePaperUrl + @"'>" + papers[i].Tag + @"</a>
                                    <h5><a href='/whitepaper/" + papers[i].WhitePaperUrl + @"'>" + papers[i].WhitePaperTitle + @"</a></h5>
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindWhitepapers", ex.Message);
        }
    }
}