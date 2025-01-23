using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Blogs : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [WebMethod(EnableSession = true)]
    public static List<BlogDetails> GetAllBlogs(string PgNo, string PLenght)
    {
        SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
        //  var result = new List<TourDetails>();
        try
        {

            var blogs = BlogDetails.GetAllBlogDetailsWithFilters(conSQ, PgNo, PLenght);
            if (blogs != null && blogs.Count() > 0)
            {
                return blogs;
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllBlogs", ex.Message);
        }
        return null;
    }
}