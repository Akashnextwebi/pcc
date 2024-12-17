using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_view_case_studies : System.Web.UI.Page
{
    public string strCaseStudy = "";
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        bindCaseStudy();
    }
    public void bindCaseStudy()
    {
        try
        {
            strCaseStudy = "";
            List<CaseStudy> CS = CaseStudy.GetAllCaseStudies(conSQ).ToList();
            for (int i = 0; i < CS.Count; i++)
            {
                var image1 = "<a href='/" + CS[i].CSThumbImage + @"' target='_blank'><img src='/" + CS[i].CSThumbImage + @"' alt='' class='rounded-circle avatar-xs shadow'></a>";
                var image2 = "<a href='/" + CS[i].CSDetailImage + @"' target='_blank'><img src='/" + CS[i].CSDetailImage + @"' alt='' class='rounded-circle avatar-xs shadow'></a>";

                strCaseStudy += @"<tr>
                                        <td>" + (i + 1) + @"</td>
                                        
                                        <td>" + CS[i].CaseStudyName + @"</td>
                                        <td>" + image1 + @"</td>
                                        <td>" + image2 + @"</td>
                                        <td>" + CS[i].Category + @"</td>
                                        <td>" + CS[i].AddedOn.ToString("dd/MMM/yyyy") + @"</td>
                                        <td class='text-center'> 
                                            <a href='add-case-studies.aspx?id=" + CS[i].Id + @"' class='bs-tooltip  fs-18 link-success' data-id='" + CS[i].Id + @"' data-bs-toggle='tooltip' data-placement='top' title='Edit Case Study'><i class='mdi mdi-pencil'></i></a> 
                                            <a href = 'javascript:void(0);' class='bs-tooltip  fs-18 link-danger deleteItem' data-id='" + CS[i].Id + @"' data-bs-toggle='tooltip' data-placement='top' title='Delete Case Study'><i class='mdi mdi-trash-can-outline'></i></a> 
                                        </td>
                                        </tr>";

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "bindCaseStudy", ex.Message);
        }
    }



    [WebMethod(EnableSession = true)]
    public static string Delete(string id)
    {
        string x = "";
        try
        {
            SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
            CaseStudy CS = new CaseStudy();
            CS.Id = Convert.ToInt32(id);
            CS.AddedOn = TimeStamps.UTCTime();
            CS.AddedIP = CommonModel.IPAddress();
            int exec = CaseStudy.DeleteCaseStudy(conSQ, CS);
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