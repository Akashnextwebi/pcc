using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class Admin_manage_investor : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);

    public string strInvestors = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        GetInvestorList();
        if (!IsPostBack)
        {

            if (Request.QueryString["id"] != null)
            {
                GetInvestorDetails();
            }
        }
    }
    public void GetInvestorDetails()
    {
        try
        {
            var lnk = ManageInvestor.GetAllInvestorDetailsWithId(conSQ, Convert.ToInt32(Request.QueryString["id"]));
            if (lnk != null)
            {
                btnNew.Visible = true;
                btnSave.Text = "Update";
                txttitle.Text = lnk.InvestorTitle;
                txtUrl.Text=lnk.InvestorUrl;


            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllInvestorDetailsWithId", ex.Message);
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
           
            try
            {
                var id = Request.QueryString["id"] == "" ? 0 : Convert.ToInt32(Request.QueryString["id"]);
                var exist = ManageInvestor.CheckExist(conSQ, txttitle.Text, txtUrl.Text, id);
                if (exist > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Investor with title,url already exist.',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }

                string aid = Request.Cookies["bmw_aid"].Value;
                ManageInvestor st = new ManageInvestor()
                {
                    InvestorTitle = txttitle.Text,
                    InvestorUrl = txtUrl.Text,
                    AddedOn = DateTime.Now,
                    AddedBy = aid,
                    AddedIp = CommonModel.IPAddress(),
                    Status = "Active",
                    Id = Request.QueryString["id"] == null ? 0 : Convert.ToInt32(Request.QueryString["id"]),
                };
                if (btnSave.Text == "Update")
                {
                    int result = ManageInvestor.UpdateInvestor(conSQ, st);
                    if (result > 0)
                    {
                        GetInvestorDetails();
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: ' Investor Updated successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops! Something went wrong. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    }

                }
                else
                {
                    int result = ManageInvestor.AddInvestor(conSQ, st);
                    if (result > 0)
                    {
                        txttitle.Text = txtUrl.Text= "";

                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Investor added successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops! Something went wrong. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    }
                }
                GetInvestorList();

            }
            catch (Exception ex)
            {
                ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "btnSave_Click", ex.Message);
            }
        }
    }
    public void GetInvestorList()
    {
        try
        {
            var lnk = ManageInvestor.GetAllInvestor(conSQ);
            if (lnk != null)
            {
                strInvestors = "";
                for (int i = 0; i < lnk.Count; i++)
                {

                    strInvestors += @"<tr>
                                        <td>" + (i + 1) + @"</td>
                                        <td>" + lnk[i].InvestorTitle + @"</td>
                                        <td>" + lnk[i].InvestorUrl + @"</td>
                                        <td>" + Convert.ToDateTime(lnk[i].AddedOn).ToString("dd MMM yyyy") + @"</td>
                                        <td class='text-center'>
                                            <a href='manage-investor.aspx?id=" + lnk[i].Id + @"' class='bs-tooltip text-info fs-18' data-id='" + lnk[i].Id + @"' data-toggle='tooltip' data-placement='top' title='Edit' data-original-title='Edit'>
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetInvestorList", ex.Message);

        }
    }
    [WebMethod(EnableSession = true)]
    public static string Delete(string id)
    {
        string x = "";
        try
        {
            SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
            ManageInvestor BD = new ManageInvestor();
            BD.Id = Convert.ToInt32(id);
            BD.AddedOn = DateTime.UtcNow;
            BD.AddedIp = CommonModel.IPAddress();
            BD.Status = "Active";
            int exec = ManageInvestor.DeleteInvestor(conSQ, BD);
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
    protected void btnNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("manage-investor.aspx");
    }
}