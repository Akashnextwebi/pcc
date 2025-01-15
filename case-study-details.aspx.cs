using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class case_study_details : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string strovtitle = "", strovdesc = "", strpsdesc = "", strpsImage = "", stroadesc = "", stroaImage = "", strtechnologytitle = "", strtechnologydesc = "", strdigitaltitle = "", strdigitaldesc = "", strcybertitle = "", strcyberdesc = "",strcategory="",strclint="",strlocation="",strdate="",strpdf="", strdetail="", strcasestudyname="";
    protected void Page_Load(object sender, EventArgs e)
    {
        var curl = Convert.ToString(RouteData.Values["curl"]);
        if (!string.IsNullOrEmpty(curl))
        {
            BindCasestudiesDetails(curl);
        }
    }
    private void BindCasestudiesDetails(string curl)
    {
        try
        {
            var cs = CaseStudy.getCasestudiesDetailsByUrl(conSQ, curl);
            if (cs != null)
            {
                #region SEO
                if (!string.IsNullOrEmpty(cs.PageTitle))
                {
                    Page.Title = cs.PageTitle;
                }
                else
                {
                    Page.Title = cs.CaseStudyName + " | Park Control and Communication";
                }
                if (!string.IsNullOrEmpty(cs.MetaDesc))
                {
                    Page.MetaDescription = cs.MetaDesc;
                }
                if (!string.IsNullOrEmpty(cs.MetaKeys))
                {
                    Page.MetaKeywords = cs.MetaKeys;
                }
                #endregion

                strovtitle = cs.OverviewTitle;
                strovdesc = cs.OVDesc;
                strpsdesc = cs.PSDesc;
                strpsImage = cs.PSImages;
                stroadesc = cs.OADesc;
                stroaImage = cs.OAImages;
                strtechnologytitle = cs.TUTitle;
                strtechnologydesc = cs.TUDesc;
                strdigitaltitle = cs.DBPTitle;
                strdigitaldesc = cs.DBPDesc;
                strcybertitle = cs.CETitle;
                strcyberdesc=cs.CEDesc;
                strcategory=cs.Category;
                strclint=cs.Client;
                strlocation=cs.Location;
                strdate = cs.PostedOn.ToString("dd MMMM, yyyy");
                strpdf = cs.UploadPDF;
                strdetail = cs.CSDetailImage;
                strcasestudyname=cs.CaseStudyName;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindCasestudiesDetails", ex.Message);
        }
    }
}