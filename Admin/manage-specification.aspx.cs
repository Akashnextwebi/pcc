using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_manage_specification : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);

    public string strSpecification = "", StrProductname="";
    protected void Page_Load(object sender, EventArgs e)
    {
        GetProductName();
        GetSpecificationList();
        if (!IsPostBack)
        {

            if (Request.QueryString["id"] != null)
            {
                GetSpecificationDetails();
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            try
            {
                
                string aid = Request.Cookies["bmw_aid"].Value;
                SpecificationDetails st = new SpecificationDetails()
                {
                    Title = txttitle.Text,
                    FullDesc = txtDesc.Text,
                    ProductGuid = Convert.ToString(Request.QueryString["Pid"]),
                    AddedBy = aid,
                    Status = "Active",
                    Id = Request.QueryString["id"] == null ? 0 : Convert.ToInt32(Request.QueryString["id"]),
                };
                if (btnSave.Text == "Update")
                {
                    int result = SpecificationDetails.UpdateSpecification(conSQ, st);
                    if (result > 0)
                    {
                        GetSpecificationDetails();
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Specification details Updated successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops! Something went wrong. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    }

                }
                else
                {
                    int result = SpecificationDetails.AddSpecification(conSQ, st);
                    if (result > 0)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Specification details added successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                        txttitle.Text = txtDesc.Text= "";
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops! Something went wrong. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    }
                }
                GetSpecificationList();
            }
            catch (Exception ex)
            {
                ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "btnSave_Click", ex.Message);
            }
        }
    }

    

    protected void btnNew_Click(object sender, EventArgs e)
    {
        var pid = Convert.ToString(Request.QueryString["Pid"]);
        Response.Redirect("/admin/manage-specification.aspx?Pid=" + pid, false);
    }

    public void GetSpecificationDetails()
    {
        try
        {
            var spe = SpecificationDetails.GetAllSpecificationDetailsWithId(conSQ, Convert.ToInt32(Request.QueryString["id"]));
            if (spe != null)
            {
                btnNew.Visible = true;
                btnSave.Text = "Update";
                txttitle.Text = spe.Title;
                txtDesc.Text = spe.FullDesc;



            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetSpecificationDetails", ex.Message);
        }
    }
    public void GetSpecificationList()
    {
        try
        {
            var pid = Convert.ToString(Request.QueryString["Pid"]);
            if (pid != null && pid != "")
            {
                var sub = SpecificationDetails.GetAllSpecificationWithGuid(conSQ, pid);
                if (sub != null)
                {
                    strSpecification = "";
                    for (int i = 0; i < sub.Count; i++)
                    {
                        strSpecification += @"<tr>
                                        <td>" + (i + 1) + @"</td>
                                        <td>" + sub[i].Title +@"</td>
                                        <td>" + sub[i].FullDesc + @"</td>  
                                        <td>" + Convert.ToDateTime(sub[i].AddedOn).ToString("dd MMM yyyy") + @"</td>
                                        <td class='text-center'>
                                       <a href='manage-specification.aspx?Pid=" + sub[i].ProductGuid + @"&id=" + sub[i].Id + @"' class='bs-tooltip text-info fs-18' data-id='" + sub[i].Id + @"' data-toggle='tooltip' data-placement='top' title='Edit' data-original-title='Edit'>
                                               <i class='mdi mdi-pencil'></i></a>
                                                <a href='javascript:void(0);' class='bs-tooltip deleteItem warning confirm text-danger fs-18' data-id='" + sub[i].Id + @"' data-toggle='tooltip' data-placement='top' title='Delete' data-original-title='Delete'>
                                               <i class='mdi mdi-delete-forever'></i></a>
                                        </td>
                                    </tr>";
                    }
                }
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetSpecificationList", ex.Message);

        }
    }
    [WebMethod(EnableSession = true)]
    public static string Delete(string id)
    {
        string x = "";
        try
        {
            SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
            SpecificationDetails BD = new SpecificationDetails();
            BD.Id = Convert.ToInt32(id);
            BD.AddedOn = DateTime.UtcNow;
            BD.AddedIp = CommonModel.IPAddress();
            int exec = SpecificationDetails.DeleteSpecification(conSQ, BD);
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
    public void GetProductName()
    {
        try
        {
            var pid = Convert.ToString(Request.QueryString["Pid"]);
            if (pid != null && pid != "")
            {
                var sub = ProductDetails.GetProductnameWithGuid(conSQ, pid);
                if (sub != null)
                {
                    for (int i = 0; i < sub.Count; i++)
                    {
                        StrProductname = sub[i].ProductName;
                    }
                }
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetProductName", ex.Message);

        }
    }
}