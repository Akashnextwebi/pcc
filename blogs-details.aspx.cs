using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class blogs_details : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string StrDetailImage = "", StrBlogDesc = "", StrBlogTitle = "", strBlogURL = "",strId="", StrPrev="", StrNext="";
    protected void Page_Load(object sender, EventArgs e)
    {
        strBlogURL = Convert.ToString(RouteData.Values["BUrl"]);
        if (strBlogURL != "")
        {
            BindBlogDetails();

        }
    }
    public void BindBlogDetails()
    {
        try
        {
            BlogDetails BD = BlogDetails.GetAllBlogDetailsWithUrl(conSQ, strBlogURL).FirstOrDefault();
            if (BD != null)
            {
                #region SEO
                if (!string.IsNullOrEmpty(BD.PageTitle))
                {
                    Page.Title = BD.PageTitle;
                }
                else
                {
                    Page.Title = BD.BlogTitle + " | Park Control and Communication";
                }
                if (!string.IsNullOrEmpty(BD.MetaDescription))
                {
                    Page.MetaDescription = BD.MetaDescription;
                }
                if (!string.IsNullOrEmpty(BD.MetaKeys))
                {
                    Page.MetaKeywords = BD.MetaKeys;
                }
                #endregion
                StrBlogDesc = BD.FullDescription;
                StrBlogTitle = BD.BlogTitle;
                StrDetailImage = BD.ThumbImage;
                strId = BD.Id.ToString();
                OtherBlogs(BD.Id);

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindBlogDetails", ex.Message);
        }
    }
    public void OtherBlogs(int id)
    {
        try
        {
            var prev = BlogDetails.GetPrevBlogDetails(conSQ, id);
            var next = BlogDetails.GetNextBlogDetails(conSQ, id);
            if (prev != null)
            {
                StrPrev += @"<div class='single-navigation'>
    <a class='arrow' href='/blog/" + prev.BlogURL + @"'>
        <svg width='9' height='15' viewBox='0 0 8 13' xmlns='http://www.w3.org/2000/svg'>
            <path d='M0 6.50008L8 0L2.90909 6.50008L8 13L0 6.50008Z'></path>
        </svg>
    </a>
    <div class='content'>
        <a href='/blog/" + prev.BlogURL + @"'>Prev Post</a>
        <h6><a href='/blog/" + prev.BlogURL + @"'>"+prev.BlogTitle + @"</a></h6>
    </div>
</div>";
            }
            if (next != null)
            {
                StrNext += @"<div class='single-navigation two text-end'>
     <div class='content'>
         <a href='/blog/" + next.BlogURL + @"'>Next Post</a>
         <h6><a href='/blog/" + next.BlogURL + @"'>"+next.BlogTitle + @"</a></h6>
     </div>
     <a class='arrow' href='/blog/" + next.BlogURL + @"'>
         <svg width='9' height='15' viewBox='0 0 8 13' xmlns='http://www.w3.org/2000/svg'>
             <path d='M8 6.50008L0 0L5.09091 6.50008L0 13L8 6.50008Z'></path>
         </svg>
     </a>
 </div>";
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "OtherBlogs", ex.Message);
        }
    }
    
}
