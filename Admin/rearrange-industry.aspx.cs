using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_rearrange_industry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [WebMethod(EnableSession = true)]
    public static int IndustryOrderUpdate(string industry)
    {
        int status = 1;
        string[] str = industry.Split(',');
        SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
        try
        {

            for (int i = 0; i < str.Length; i++)
            {
                IndustryDetails catG = new IndustryDetails();
                catG.Id = str[i] == "" ? 0 : Convert.ToInt32(str[i]);
                catG.IndustryOrder = Convert.ToString(i);
                IndustryDetails.UpdateIndustryOrder(conSQ, catG);
            }
            status = 0;
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "IndustryOrderUpdate", ex.Message);
            status = 1;
        }
        return status;
    }

    [WebMethod(EnableSession = true)]
    public static List<IndustryDetails> IndustryOrder()
    {
        List<IndustryDetails> fpl = new List<IndustryDetails>();
        try
        {
            SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
            List<IndustryDetails> lpds = IndustryDetails.GetAllIndustryDetails(conSQ).OrderBy(x => x.IndustryOrder).ToList();
            foreach (var cat in lpds)
            {
                fpl.Add(new IndustryDetails() { IndustryName = cat.IndustryName, Id = cat.Id, BannerImage = cat.BannerImage });
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "IndustryOrder", ex.Message);
        }
        return fpl;
    }
}