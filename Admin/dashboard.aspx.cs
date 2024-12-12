using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;

public partial class Admin_dashboard : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string Strusername = "", StrBlogsCnt="",strCasestudycnt="",strProductcnt="",strInvestorcnt="", strJobcnt="",strContacts="";
    protected void Page_Load(object sender, EventArgs e)
    {//check if admin login is valid
        if (Request.Cookies["bmw_aid"] == null)
        {
            Response.Redirect("Default.aspx", false);
        }
        else
        {

            BindUserName();
            strCasestudycnt = DashBoard.GetstudiesCount(conSQ).ToString();
            StrBlogsCnt = DashBoard.NoOfBlogs(conSQ).ToString();
            strProductcnt = DashBoard.NoOfProducts(conSQ).ToString();
            strInvestorcnt = DashBoard.NoOfInvestors(conSQ).ToString();
            strJobcnt = DashBoard.NoOfJobs(conSQ).ToString();
        }
        BindTop10Contacts();
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
    public void BindTop10Contacts()
    {

        try
        {
            strContacts = "";
            List<ContactUs> BD = DashBoard.GetTop10Contact(conSQ);

            for (int i = 0; i < BD.Count; i++)
            {
                var Message = "";
                if (BD[i].Message.Length > 100)
                {
                    Message = BD[i].Message.Substring(0, 100) + " ....";
                }
                else
                {
                    Message = BD[i].Message;
                }
                strContacts += @"<tr>
                                        <td>" + (i + 1) + @"</td>
                                        <td>" + BD[i].Name + @"</td>
                                        <td><a href='mailto:" + BD[i].Email + @"'>" + BD[i].Email + @"</a></td>
                                        <td>" + BD[i].Subject + @"</td>
                                        <td class='col-1'>" + Message + @"</td>
                                        <td>" + BD[i].AddedOn.ToString("dd-MMM-yyyy") + @"</td>
                                        </tr>";

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindTop10Contacts", ex.Message);
        }
    }
}