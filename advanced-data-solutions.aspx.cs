using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class advanced_data_solutions :  System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string strBanner = "", strBannertitle = "", strDesctitle = "", strDesc = "", strsubcapability="", StrWhitepaper="";
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (RouteData.Values["curl"] != null)
        {
            BindCapabilityDetails();
        }
        
    }
    public void BindCapabilityDetails()
    {
        try
        {
            var url = Convert.ToString(RouteData.Values["curl"]);
            var CA = Capability.GetAllCapabilityWithUrl(conSQ, url);
            if (CA != null)
            {
                strBanner = CA.BannerImage;
                strBannertitle=CA.BannerTitle;
                strDesctitle = CA.DescHeading;
                strDesc = CA.FullDesc;
                BindSubcapability(Convert.ToString(CA.Id));
                BindWhitepaper(Convert.ToString(CA.Id));
            }


        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindDetails", ex.Message);
        }
    }
    public void BindSubcapability(string name)
    {
        try
        {
            var ca = SubCapability.GetAllSubcapability(conSQ, name);
            if (ca.Count > 0)
            {
                for (int i = 0; i < ca.Count; i++)
                {
                    var url = "/subcompetencies/" + ca[i].SubCapabilityUrl;
                    strsubcapability += @"<div class='col-lg-4 col-md-6'>
                        <div class='eg-card3 three'>
                            <div class='card-img'>
                                <img src='/" + ca[i].ThumbImage + @"' alt=''>
                            </div>
                            <div class='card-content'>
                                <a class='view-btn' href='" + url + @"'>
                                    <img src='image/sub1/right-arrow2.png' alt=''>
                                </a>
                                <div class='catgory-and-title'>
                                    <a href='" + url+ @"'>" + ca[i].Tag + @"</a>
                                    <h5><a href='" + url + @"'>" + ca[i].SubCapabilityName + @"</a></h5>
                                </div>
                            </div>
                        </div>
                    </div>";
                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindSubcapability", ex.Message);
        }
    }
    public void BindWhitepaper(string name)
    {
        try
        {
            var Wp = WhitePaperDetails.GetAllWhitepaper(conSQ, name);
            if (Wp.Count > 0)
            {
                for (int i = 0; i < Wp.Count; i++)
                {
                    StrWhitepaper += @"<div class='col-lg-3'>
    <div class='broacher-card'>
        <div class='broacher-img'>
<a href='/whitepaper/" + Wp[i].WhitePaperUrl + @"'>
            <img src='/" + Wp[i].ThumbImage + @"' alr='img' /></a>
        </div>
        <div class='broacher-content '>
            <span>White Paper</span>
          <h5 class='mt-2'><a href='/whitepaper/" + Wp[i].WhitePaperUrl + @"'> " + Wp[i].WhitePaperTitle + @"
                                </h5></a>
<p>test</p>

        </div>
    </div>

</div>";
                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindWhitepaper", ex.Message);
        }
    }
}