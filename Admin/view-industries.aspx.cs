using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_view_industries : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string strIndustry = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        GetIndustryList();
    }
    public void GetIndustryList()
    {
        try
        {
            var lnk = IndustryDetails.GetAllIndustry(conSQ);
            if (lnk != null)
            {
                strIndustry = "";
                for (int i = 0; i < lnk.Count; i++)
                {
                    var Feacount = 0;
                    Feacount = ManageFeature.GetAllFeaturecntWithGuid(conSQ, lnk[i].IndustryGuid).Count;
                    var image = "<a href='/" + lnk[i].BannerImage + @"' target='_blank'><img src='/" + lnk[i].BannerImage + @"' alt='' class='rounded-circle avatar-xs shadow'></a>";
                    strIndustry += @"<tr>
                                        <td>" + (i + 1) + @"</td>
                                        <td>" + image + @"</td>
                                        <td>" + lnk[i].IndustryName + @"</td>
                                        <td>" + lnk[i].IndustryUrl + @"</td>
                                        <td><a href='manage-feature.aspx?Pid=" + lnk[i].IndustryGuid + @"' class='text-success fw-bold' target='_blank'>Features(" + Feacount + @")</a></td>
                                        <td>" + Convert.ToDateTime(lnk[i].AddedOn).ToString("dd MMM yyyy") + @"</td>
                                        <td class='text-center'>
                                            <a href='add-industries.aspx?id=" + lnk[i].Id + @"' class='bs-tooltip text-info fs-18' data-id='" + lnk[i].Id + @"' data-toggle='tooltip' data-placement='top' title='Edit' data-original-title='Edit'>
                                               <i class='mdi mdi-pencil'></i></a>
                                            <a href='javascript:void(0);' class='bs-tooltip warning confirm text-danger fs-18 deleteItem' data-id='" + lnk[i].Id + @"' data-toggle='tooltip' data-placement='top' title='Delete' data-original-title='Delete'>
                                               <i class='mdi mdi-delete-forever'></i></a>
                                        </td>
                                    </tr>";
                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetIndustryList", ex.Message);

        }
    }
    [WebMethod(EnableSession = true)]
    public static string Delete(string id)
    {
        string x = "";
        try
        {
            SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
            IndustryDetails BD = new IndustryDetails();
            BD.Id = Convert.ToInt32(id);
            BD.AddedOn = DateTime.UtcNow;
            BD.AddedIp = CommonModel.IPAddress();
            BD.Status = "Active";
            int exec = IndustryDetails.DeleteIndustry(conSQ, BD);
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