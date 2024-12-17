using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_manage_industries : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);

    public string strIndustry = "";
    protected void Page_Load(object sender, EventArgs e)
    {

        GetIndustryList();
        if (!IsPostBack)
        {

            if (Request.QueryString["id"] != null)
            {
                GetIndustryDetails();
            }
        }
    }
    public void GetIndustryDetails()
    {
        try
        {
            var lnk = IndustryDetails.GetAllIndustryDetailsWithId(conSQ, Convert.ToInt32(Request.QueryString["id"]));
            if (lnk != null)
            {
                btnNew.Visible = true;
                btnSave.Text = "Update";
                txtname.Text = lnk.IndustryName;
                txtUrl.Text = lnk.IndustryUrl;


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
                var exist = IndustryDetails.CheckExist(conSQ, txtname.Text, txtUrl.Text, id);
                if (exist > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Industry with title,url already exist.',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }

                string aid = Request.Cookies["bmw_aid"].Value;
                IndustryDetails st = new IndustryDetails()
                {
                    IndustryName = txtname.Text,
                    IndustryUrl = txtUrl.Text,
                    AddedOn = DateTime.Now,
                    AddedBy = aid,
                    AddedIp = CommonModel.IPAddress(),
                    Status = "Active",
                    Id = Request.QueryString["id"] == null ? 0 : Convert.ToInt32(Request.QueryString["id"]),
                };
                if (btnSave.Text == "Update")
                {
                    int result = IndustryDetails.UpdateIndustry(conSQ, st);
                    if (result > 0)
                    {
                        GetIndustryDetails();
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: ' Industry Updated successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops! Something went wrong. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    }

                }
                else
                {
                    int result = IndustryDetails.AddIndustry(conSQ, st);
                    if (result > 0)
                    {
                        txtname.Text = txtUrl.Text = "";

                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Industry added successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops! Something went wrong. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    }
                }
                GetIndustryList();

            }
            catch (Exception ex)
            {
                ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "btnSave_Click", ex.Message);
            }
        }
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

                    strIndustry += @"<tr>
                                        <td>" + (i + 1) + @"</td>
                                        <td>" + lnk[i].IndustryName + @"</td>
                                        <td>" + lnk[i].IndustryUrl + @"</td>
                                        <td>" + Convert.ToDateTime(lnk[i].AddedOn).ToString("dd MMM yyyy") + @"</td>
                                        <td class='text-center'>
                                            <a href='manage-industries.aspx?id=" + lnk[i].Id + @"' class='bs-tooltip text-info fs-18' data-id='" + lnk[i].Id + @"' data-toggle='tooltip' data-placement='top' title='Edit' data-original-title='Edit'>
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
    protected void btnNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("manage-industries.aspx");
    }
}