using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;

public partial class Admin_dashboard : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string Strusername = "";
    protected void Page_Load(object sender, EventArgs e)
    {//check if admin login is valid
        if (Request.Cookies["bmw_aid"] == null)
        {
            Response.Redirect("Default.aspx", false);
        }
        else
        {

            BindUserName();
        }
    }

    public void BindUserName()
    {
        try
        {
            Strusername = CreateUser.GetLoggedUserName(conSQ, Request.Cookies["bmw_aid"].Value);
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindUserName", ex.Message);
        }
    }
}