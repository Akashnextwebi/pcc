using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_view_whitepaper : System.Web.UI.Page
{
    public string strWhitepapers = "";
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetAllDetails();

        }
    }
    public void GetAllDetails()
    {
        try
        {
            strWhitepapers = "";
            List<WhitePaperDetails> BD = WhitePaperDetails.GetAllWhitepaperDetails(conSQ).ToList();
            for (int i = 0; i < BD.Count; i++)
            {
                strWhitepapers += @"<tr>
                                        <td>" + (i + 1) + @"</td>
                                        <td><a href='/" + BD[i].ThumbImage + @"'/><img src='/" + BD[i].ThumbImage + @"' style='height:60px;' /></td>
                                        <td><a href='/" + BD[i].DetailImage + @"'/><img src='/" + BD[i].DetailImage + @"' style='height:60px;' /></td>
                                        <td><a href='/" + BD[i].BannerImage + @"'/><img src='/" + BD[i].BannerImage + @"' style='height:60px;' /></td>
                                        <td>" + BD[i].WhitePaperTitle + @"</td>
                                        <td>" + BD[i].PostedBy + @"</td>
                                         <td>" + BD[i].AddedOn.ToString("dd/MMM/yyyy") + @"</td>
                                        <td class='text-center'> 
                                            <a href='add-whitepaper.aspx?id=" + BD[i].Id + @"' class='bs-tooltip text-info fs-18' data-id='" + BD[i].Id + @"' data-toggle='tooltip' data-placement='top' title='Edit' data-original-title='Edit'>
                                               <i class='mdi mdi-pencil'></i></a>
                                            <a href='javascript:void(0);' class='bs-tooltip deleteItem warning confirm text-danger fs-18' data-id='" + BD[i].Id + @"' data-toggle='tooltip' data-placement='top' title='Delete' data-original-title='Delete'>
                                               <i class='mdi mdi-delete-forever'></i></a></a>    </td>
                                            </tr>";

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllDetails", ex.Message);
        }
    }
    [WebMethod(EnableSession = true)]
    public static string Delete(string id)
    {
        string x = "";
        try
        {
            SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
            WhitePaperDetails BD = new WhitePaperDetails();
            BD.Id = Convert.ToInt32(id);
            BD.AddedOn = TimeStamps.UTCTime();
            BD.AddedIp = CommonModel.IPAddress();
            int exec = WhitePaperDetails.DeleteWhitepaperDetails(conSQ, BD);
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
}