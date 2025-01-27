using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;

public partial class Admin_dashboard : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string Strusername = "", StrBlogsCnt="",strCasestudycnt="",strProductcnt="",strInvestorcnt="", strJobcnt="",strContacts="",strWhitepapercnt="", strApplicationcnt="", strContactcnt="";
    protected void Page_Load(object sender, EventArgs e)
    {//check if admin login is valid
        if (Request.Cookies["pcc_aid"] == null)
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
            strWhitepapercnt= DashBoard.NoOfWhitePapers(conSQ).ToString();
            strApplicationcnt = DashBoard.NoOfApplications(conSQ).ToString();
            strContactcnt = DashBoard.NoOfContacts(conSQ).ToString();
        }
        BindTop10Contacts();
    }

    public void BindUserName()
    {
        try
        {
            Strusername = CreateUser.GetLoggedUserName(conSQ, Request.Cookies["pcc_aid"].Value);
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
                var Message = @"<td>
                                    <button data-bs-toggle='modal' data-bs-target='#fadeInRightModal' type='button' id='Viewcust' data-vid='" + BD[i].Id + @"' data-vname='" + BD[i].Name + @"' class='btn btn-success btn-label waves-effect right waves-light rounded-pill btn-sm'>
                                        <i class='ri-mail-send-line label-icon align-middle rounded-pill fs-16 ms-2'></i>
                                    View Message
                                    </button></td>";
                strContacts += @"<tr>
                                        <td>" + (i + 1) + @"</td>
                                        <td>" + BD[i].Name + @"</td>
                                        <td><a href='mailto:" + BD[i].Email + @"'>" + BD[i].Email + @"</a></td>
                                        <td>" + BD[i].Subject + @"</td>
                                        " + Message + @"
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