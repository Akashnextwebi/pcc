using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_add_testimonial : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                GetTestimonials();
            }
        }
    }
    public void GetTestimonials()
    {
        try
        {
            TestimonialDetails BD = TestimonialDetails.GetAllTestimonialDetailsWithId(conSQ, Convert.ToInt32(Request.QueryString["id"]));
            if (BD != null)
            {
                btnSave.Text = "Update";
                btnNew.Visible = true;
                txtPName.Text = BD.Name;
                ddlrating.SelectedValue = BD.Ratings;
                TxtTdesc.Text = BD.TestimonialDesc;
                
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

                var aid = Request.Cookies["bmw_aid"].Value;
                TestimonialDetails BD = new TestimonialDetails();
                BD.Name = txtPName.Text;
                BD.Ratings = ddlrating.SelectedValue;
                BD.TestimonialDesc = TxtTdesc.Text;             
                BD.AddedIp = CommonModel.IPAddress();
                BD.AddedOn = TimeStamps.UTCTime();
                BD.AddedBy = aid;
                BD.Status = "Active";

                if (btnSave.Text == "Update")
                {
                    BD.Id = Convert.ToInt32(Request.QueryString["id"]);
                    int result = TestimonialDetails.UpdateTestimonialDetails(conSQ, BD);
                    if (result > 0)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Testimonial Updated successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'There is some problem now.please try again after some time. ',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    }
                }
                else
                {
                    int result = TestimonialDetails.InsertTestimonial(conSQ, BD);
                    if (result > 0)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Testimonial Added successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                        txtPName.Text = ddlrating.Text = TxtTdesc.Text="";
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
        Response.Redirect("add-testimonial.aspx");
    }
}