using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_view_contact : System.Web.UI.Page
{
    public string strContact = "";
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        BindAllContacts();
    }
    public void BindAllContacts()
    {

        try
        {
            strContact = "";
            List<ContactUs> BD = ContactUs.GetAllContact(conSQ);

            for (int i = 0; i < BD.Count; i++)
            {

                strContact += @"<tr>
                                        <td>" + (i + 1) + @"</td>
                                        <td>" + BD[i].Name + @"</td>
                                        <td>" + BD[i].Email + @"</td>
                                        <td>" + BD[i].Subject + @"</td>
                                      <td><a href='javascript:void(0);' data-bs-toggle='modal' data-bs-target='#fadeInRightModal' class='btn btn-sm btn-secondary badge-gradient-secondary btnmsg' data-message='" + BD[i].Message + "' data-id=" + BD[i].Id + @" data-name=" + BD[i].Name + @">View Message</a></td>
                                        <td>" + BD[i].AddedOn.ToString("dd-MMM-yyyy") + @"</td>    
                                        <td class='text-center'> 
                                          <a href = 'javascript:void(0);' class='bs-tooltip  fs-18 link-danger deleteItem' data-id='" + BD[i].Id + @"' data-bs-toggle='tooltip' data-placement='top' title='Delete Contacts'><i class='mdi mdi-trash-can-outline'></i></a> 
                                        </td>
                                        </tr>";

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindAllContacts", ex.Message);
        }
    }



    [WebMethod(EnableSession = true)]
    public static string Delete(string id)
    {
        string x = "";
        try
        {
            SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
            ContactUs BD = new ContactUs();
            BD.Id = Convert.ToInt32(id);
            int exec = ContactUs.DeleteContact(conSQ, BD);
            if (exec > 0)
            {
                x = "Success";
            }
            else
            {
                x = "W";
            }
        }
        catch (Exception ex)
        {
            x = "W";
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "Delete", ex.Message);
        }
        return x;
    }
    [WebMethod(EnableSession = true)]
    public static string GetContactMessage(string id)
    {
        var message = "";
        try
        {
            SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
            message = "";
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetContactMessage", ex.Message);
        }
        return message;
    }
}