using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class product_lisitng :  System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string strBanner = "", strBannertitle = "", strDesctitle = "", strDesc = "",strProduct="";
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
                    strProduct += @"<div class='col-lg-3'>
                        <div class='magnetic-wrap'>
                            <div class='people-card2 magnetic-item' style=''>
                                <div class='people-img'>
<a href='/product/" + pro[i].ProductUrl + @"'>
                                    <img src='/"+ pro[i].ThumbImage + @"' alt=''></a>
                                </div>
                                <div class='people-content'>
                                    <div class='name-deg'>
                                        <h5 class=''><a href='/product/" + pro[i].ProductUrl + @"'>" + pro[i].ProductName + @"</a></h5>





                                    </div>
                                    <div class='contact-area'>
                                        <div class='contact-number'>
                                            <div class='icon'>
<a href='/product/" + pro[i].ProductUrl + @"'>
                                                View Product</a>
                                            </div>

                                        </div>
                                        <ul class='social-icon'>
                                            <li><a href='/product/" + pro[i].ProductUrl + @"'><i class='fa-solid fa-arrow-right-long'></i></a></li>
                                        </ul>
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindProducts", ex.Message);
        }
    }
}