using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class investors : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string strInvestors = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        BindInvestors();
    }
    private void BindInvestors()
    {

        try
        {
            strInvestors = "";
            var Investor = ManageInvestor.GetAllInvestors(conSQ).ToList();
            if (Investor.Count > 0)
            {
                for (int i = 0; i < Investor.Count; i++)
                {
                    var url = "Investor/" + Investor[i].InvestorUrl;


                    strInvestors += @"<div class='col-xl-3 col-lg-4 col-md-6'>
                        <a href='"+ url + @"' contenteditable='false' style='cursor: pointer;'>
                            <div class='bd-callout bd-callout-info'>
                               " + Investor[i].InvestorTitle + @"
                            </div>
                        </a>
                    </div>";

                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindAllJobs", ex.Message);
        }
    }
}