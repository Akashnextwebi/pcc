using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string strsolution = "",strIndustries="";
    protected void Page_Load(object sender, EventArgs e)
    {
        BindCompetencies();
        BindIndustries();
    }
    public void BindCompetencies()
    {
        try
        {
            strsolution = "";          
            List<Capability> loc = Capability.GetCompetenciesDetails(conSQ);

            if (loc.Count > 0)
            {
                List<Capability> ca = loc;

                for (int i = 0; i < ca.Count; i++)
                {

                    strsolution += @"<li><a class='dropdown-item' href='/capability/" + ca[i].CapabilityUrl + @"'><i class='las la-angle-double-right'></i>" + ca[i].CapabilityName + @"</a></li>";
                    

                }

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindCompetencies", ex.Message);

        }
    }
    public void BindIndustries()
    {
        try
        {
            strIndustries = "";
            List<IndustryDetails> loc = IndustryDetails.GetIndustryDetails(conSQ);

            if (loc.Count > 0)
            {
                List<IndustryDetails> ind = loc;

                for (int i = 0; i < ind.Count; i++)
                {

                    strIndustries += @"<li><a href='/industries/" + ind[i].IndustryUrl + @"'>" + ind[i].IndustryName +@"</a></li>";


                }

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindIndustries", ex.Message);

        }
    }
}
