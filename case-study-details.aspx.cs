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
    public string strovtitle = "", strovdesc = "", strpsdesc = "", strpsImage = "", stroadesc = "", stroaImage = "", strtechnologytitle = "", strtechnologydesc = "", strdigitaltitle = "", strdigitaldesc = "", strcybertitle = "", strcyberdesc = "",strcategory="",strclint="",strlocation="",strdate="",strpdf="", strdetail="", strcasestudyname="", StrPrev="", StrNext="",strid="";
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
                strid=cs.Id.ToString();
                OtherCasestudy(cs.Id);
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindCasestudiesDetails", ex.Message);
        }
    }
    public void OtherCasestudy(int id)
    {
        try
        {
            var prev = CaseStudy.GetPrevCasestudyDetails(conSQ, id);
            var next = CaseStudy.GetNextCasestudyDetails(conSQ, id);
            if (prev != null)
            {
                StrPrev += @"<div class='single-navigation'>
    <a class='arrow' href='/Casestudy/" + prev.CaseStudyUrl + @"'>
        <svg width='9' height='15' viewBox='0 0 8 13' xmlns='http://www.w3.org/2000/svg'>
            <path d='M0 6.50008L8 0L2.90909 6.50008L8 13L0 6.50008Z'></path>
        </svg>
    </a>
    <div class='content'>
        <a href='/Casestudy/" + prev.CaseStudyUrl + @"'>Prev Post</a>
        <h6><a href='/Casestudy/" + prev.CaseStudyUrl + @"'>" + prev.CaseStudyName + @"</a></h6>
    </div>
</div>";
            }
            if (next != null)
            {
                StrNext += @"<div class='single-navigation two text-end'>
     <div class='content'>
         <a href='/Casestudy/" + next.CaseStudyUrl + @"'>Next Post</a>
         <h6><a href='/Casestudy/" + next.CaseStudyUrl + @"'>"+next.CaseStudyName+@"</a></h6>
     </div>
     <a class='arrow' href='/Casestudy/" + next.CaseStudyUrl + @"'>
         <svg width='9' height='15' viewBox='0 0 8 13' xmlns='http://www.w3.org/2000/svg'>
             <path d='M8 6.50008L0 0L5.09091 6.50008L0 13L8 6.50008Z'></path>
         </svg>
     </a>
 </div>";
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "OtherCasestudy", ex.Message);
        }
    }
}