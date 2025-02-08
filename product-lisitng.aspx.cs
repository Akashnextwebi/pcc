using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class product_lisitng : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string strBanner = "", strBannertitle = "", strDesctitle = "", strDesc = "", strProduct = "", StrWhitepaper = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (RouteData.Values["surl"] != null)
        {
            BindSubCapabilityDetails();
        }

    }
    public void BindSubCapabilityDetails()
    {
        try
        {
            var url = Convert.ToString(RouteData.Values["surl"]);
            var SC = SubCapability.GetAllSubCapabilityWithUrl(conSQ, url);
            if (SC != null)
            {
                strBanner = SC.BannerImage;
                strBannertitle = SC.BannerTitle;
                strDesctitle = SC.DescHeading;
                strDesc = SC.FullDesc;
                BindProducts(Convert.ToString(SC.Id));
                BindWhitepaper(Convert.ToString(SC.Id));
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindSubCapabilityDetails", ex.Message);
        }
    }
    public void BindProducts(string name)
    {
        try
        {
            var pro = ProductDetails.GetAllProducts(conSQ, name);
            if (pro.Count > 0)
            {
                for (int i = 0; i < pro.Count; i++)
                {
                    var url = "product/" + pro[i].ProductUrl;
                    strProduct += @"<div class='col-lg-4'>
                            <div class='card1'>
                                <a href='/" + url + @"' contenteditable='false' style='cursor: pointer;'>
                                    <img src='/" + pro[i].ThumbImage + @"' class='img1'>
                                    <div class='intro1'>
                                        <h4 class='text-h1'>" + pro[i].ProductName + @"

</h4>

                                        <p class='text-p'>
                                           " + pro[i].FullDesc + @"          
                                        </p>
                                    </div>
                                </a>

                            </div>
                        </div>";
                }
            }
            else
            {
                divpro.Visible = false;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindProducts", ex.Message);
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
                    StrWhitepaper += @"<div class='col-lg-3 col-md-6'>
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