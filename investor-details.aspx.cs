using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class investor_details : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string strInvestor = "",strTitle="";
    protected void Page_Load(object sender, EventArgs e)
    {
        var iurl = Convert.ToString(RouteData.Values["iurl"]);
        if (!string.IsNullOrEmpty(iurl))
        {
            BindInvestors(iurl);
            
        }

    }
    private void BindInvestors(string iurl)
    {
        try
        {
            
            var inv = ManageInvestor.getInvestordetailsByUrl(conSQ, iurl);
            if (inv != null)
            {
                strTitle = inv.InvestorTitle;
                BindInvestorpdf();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindInvestors", ex.Message);
        }
    }
    private void BindInvestorpdf()
    {

        try
        {
            strInvestor = "";
            var Inv = InvestorPdf.GetAllInvestors(conSQ).ToList();
            if (Inv.Count > 0)
            {
                for (int i = 0; i < Inv.Count; i++)
                {
                   
                    strInvestor += @"<tr>
    <td class='align-middle px-10 text-body-emphasis'>"+ Inv[i].PDFTitle + @" </td>
    <td class=''>
        <a href='/" + Inv[i].PDF + @"' class='btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4' target='_blank' contenteditable='false' style='cursor: pointer;'>
            Download PDF
        </a>
    </td>
</tr>";

                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindCasestudy", ex.Message);
        }
    }
}