using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_add_capability : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string StrProductname="";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                GetCapabilities();
            }
        }
    }
    public void GetCapabilities()
    {
        try
        {
            Capability BD = Capability.GetAllCapabilityDetailsWithId(conSQ, Convert.ToInt32(Request.QueryString["id"]));
            if (BD != null)
            {
                btnSave.Text = "Update";
                btnNew.Visible = true;
                txtcapability.Text = BD.CapabilityName;
                txtUrl.Text = BD.CapabilityUrl;
                


            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetTestimonials", ex.Message);
        }

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsValid)
            {
                var id = Request.QueryString["id"] == "" ? 0 : Convert.ToInt32(Request.QueryString["id"]);
                var exist = Capability.CheckExist(conSQ, txtcapability.Text, txtUrl.Text, id);
                if (exist > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Cpability with title,url already exist.',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }

                var aid = Request.Cookies["bmw_aid"].Value;
                Capability BD = new Capability();
                BD.CapabilityName = txtcapability.Text.Trim();
                BD.CapabilityUrl = txtUrl.Text.Trim();
                BD.AddedIp = CommonModel.IPAddress();
                BD.AddedOn = TimeStamps.UTCTime();
                BD.AddedBy = aid;
                BD.Status = "Active";

                if (btnSave.Text == "Update")
                {
                    BD.Id = Convert.ToInt32(Request.QueryString["id"]);
                    int result = Capability.UpdateCapabilityDetails(conSQ, BD);
                    if (result > 0)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Capability Updated successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'There is some problem now.please try again after some time. ',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    }
                }
                else
                {
                    int result = Capability.InsertCapability(conSQ, BD);
                    if (result > 0)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Capability Added successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                        txtcapability.Text = txtUrl.Text = "";
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'There is some problem now.please try again after some time. ',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);

                    }
                }


            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "btnSave_Click", ex.Message);
        }
    }
    protected void btnNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("add-capability.aspx");
    }
    //public void GetProductName()
    //{
    //    try
    //    {
    //        var pid = Convert.ToString(Request.QueryString["Pid"]);
    //        if (pid != null && pid != "")
    //        {
    //            var sub = ProductDetails.GetProductnameWithGuid(conSQ, pid);
    //            if (sub != null)
    //            {
    //                for (int i = 0; i < sub.Count; i++)
    //                {
    //                    StrProductname = sub[i].ProductName;
    //                }
    //            }
    //        }

    //    }
    //    catch (Exception ex)
    //    {
    //        ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetProductName", ex.Message);

    //    }
    //}
}