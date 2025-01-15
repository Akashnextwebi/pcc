using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class whitepaper_details : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string strImage = "", strBanner = "", strFullDesc = "",strPostedby="",strpostedon="",strheading="", strwhitepaperheading="";
    protected void Page_Load(object sender, EventArgs e)
    {
        var wurl = Convert.ToString(RouteData.Values["wurl"]);
        if (!string.IsNullOrEmpty(wurl))
        {
            BindWhitepaperDetails(wurl);
        }
    }
    private void BindWhitepaperDetails(string wurl)
    {
        try
        {
            var wp = WhitePaperDetails.getWhitepaperDetailsByUrl(conSQ, wurl);
            if (wp != null)
            {
                #region SEO
                if (!string.IsNullOrEmpty(wp.PageTitle))
                {
                    Page.Title = wp.PageTitle;
                }
                else
                {
                    Page.Title = wp.WhitePaperTitle + " | Park Control and Communication";
                }
                if (!string.IsNullOrEmpty(wp.MetaDesc))
                {
                    Page.MetaDescription = wp.MetaDesc;
                }
                if (!string.IsNullOrEmpty(wp.MetaKeys))
                {
                    Page.MetaKeywords = wp.MetaKeys;
                }
                #endregion

                strImage = wp.DetailImage;
                strBanner = wp.BannerImage;
                strwhitepaperheading = wp.WhitePaperHeading;
                strFullDesc = wp.FullDesc;
                strPostedby = wp.PostedBy;
                strpostedon=wp.PostedOn;
               //strheading = wp.WhitePaperHeading;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindWhitepaperDetails", ex.Message);
        }
    }
}