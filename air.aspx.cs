using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class air : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string strBannerImage = "", strDescHeading = "", strIndustryName="", strfullDesc = "", strProduct="", strFeature="";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (RouteData.Values["indurl"] != null)
        {
            BindIndustryDetails();
        }
    }
    public void BindIndustryDetails()
    {
        try
        {
            var url = Convert.ToString(RouteData.Values["indurl"]);
            var ind = IndustryDetails.GetAllIndustryWithUrl(conSQ, url);
            if (ind != null)
            {
                #region SEO
                if (!string.IsNullOrEmpty(ind.PageTitle))
                {
                    Page.Title = ind.PageTitle;
                }
                else
                {
                    Page.Title = ind.IndustryName + " | Park Control and Communication";
                }
                if (!string.IsNullOrEmpty(ind.MetaDesc))
                {
                    Page.MetaDescription = ind.MetaDesc;
                }
                if (!string.IsNullOrEmpty(ind.MetaKeys))
                {
                    Page.MetaKeywords = ind.MetaKeys;
                }
                #endregion
                strBannerImage = ind.BannerImage;
                strDescHeading = ind.DescHeading;
                strfullDesc = ind.FullDesc;
                strIndustryName = ind.IndustryName;
                BindProduct(Convert.ToString(ind.Id));
                var Fea = ManageFeature.GetAllFeatureGuid(conSQ, ind.IndustryGuid);
                if (Fea.Count > 0)
                {
                    for (int i = 0; i < Fea.Count; i++)
                    {


                        strFeature += @"<div class='col-lg-4'>
                    <div class='content-card'>
                        <img src='/" + Fea[i].ThumbImage + @"' width='48' class='content-img'>

                        <h4>" + Fea[i].Title + @"
                        </h4>
                        <p>" + Fea[i].FullDesc +@"</p>
                    </div>
                </div>";
                    }

                }
            }


        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindIndustryDetails", ex.Message);
        }
    }
    public void BindProduct(string name)
    {
        try
        {
            var ca = ProductDetails.GetAllProduct(conSQ, name);
            if (ca.Count > 0)
            {
                for (int i = 0; i < ca.Count; i++)
                {
                    var url = "product/" + ca[i].ProductUrl;
                    strProduct += @"<div class='col-lg-4'>
                            <div class='card1'>
                                <a href='/"+url+@"' contenteditable='false' style='cursor: pointer;'>
                                    <img src='/" + ca[i].ThumbImage + @"' class='img1'>
                                    <div class='intro1'>
                                        <h4 class='text-h1'>" + ca[i].ProductName +@"

</h4>

                                        <p class='text-p'>
                                           " + ca[i].FullDesc +@"          
                                        </p>
                                    </div>
                                </a>

                            </div>
                        </div>";
                }
            }
           
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindProduct", ex.Message);
        }
    }
}