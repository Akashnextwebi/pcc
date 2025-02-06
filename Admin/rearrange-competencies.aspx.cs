using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_rearrange_competencies : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [WebMethod(EnableSession = true)]
    public static int CompetenciesOrderUpdate(string com)
    {
        int status = 1;
        string[] str = com.Split(',');
        SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
        try
        {

            for (int i = 0; i < str.Length; i++)
            {
                Capability catG = new Capability();
                catG.Id = str[i] == "" ? 0 : Convert.ToInt32(str[i]);
                catG.CompetenciesOrder = Convert.ToString(i);
                Capability.UpdateCompetenciesOrder(conSQ, catG);
            }
            status = 0;
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "productOrderUpdate", ex.Message);
            status = 1;
        }
        return status;
    }

    [WebMethod(EnableSession = true)]
    public static List<Capability> CompetenciesOrder()
    {
        List<Capability> fpl = new List<Capability>();
        try
        {
            SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
            List<Capability> lpds = Capability.GetAllCompetenciesDetails(conSQ).OrderBy(x => x.CompetenciesOrder).ToList();
            foreach (var cat in lpds)
            {
                fpl.Add(new Capability() { CapabilityName = cat.CapabilityName, Id = cat.Id, BannerImage = cat.BannerImage });
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "CompetenciesOrder", ex.Message);
        }
        return fpl;
    }
}