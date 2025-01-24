using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_add_product : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string strThumbImage = "", strUploadPDF = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindCapability();
            BindSubCapability();
            BindIndustry();
            if (!string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                bindProducts();
            }
        }
    }
    public void bindProducts()
    {
        try
        {
            var pro = ProductDetails.getProductsById(conSQ, Convert.ToInt32(Request.QueryString["id"]));
            if (pro != null)
            {
                btnSave.Text = "Update";
                btnNew.Visible = true;
                txtproductName.Text = pro.ProductName;
                txtUrl.Text = pro.ProductUrl;
                txtcode.Text = pro.SKUCode;
                //txtdatasheet.Text = pro.DatasheetName;             
                ddlCapabilityType.SelectedValue = pro.Capability;
                BindSubCapability();
                ddlSubcapability.SelectedValue = pro.SubCapability;
                ddlindustry.SelectedValue= pro.Industry;
               // txtlink.Text = pro.DatasheetLink;
                txtDesc.Text = pro.FullDesc;
                txtMetaDesc.Text = pro.MetaDesc;
                txtMetaKey.Text = pro.MetaKeys;
                txtPageTitle.Text = pro.PageTitle;
                chkenquiry.Checked = pro.Enquiry == "Yes" ? true : false;

                if (pro.ThumbImage != "")
                {
                    strThumbImage = "<img src='/" + pro.ThumbImage + "' style='max-height:60px;' />";
                    lblThumb.Text = pro.ThumbImage;
                }
                
                if (pro.Broucher != "")
                {
                    strUploadPDF = "<a href='/" + pro.Broucher + @"'><img src='assets/images/PDF.png' style='max-height:60px;' class='img-fluid'/></a>";
                    lblPDF.Text = pro.Broucher;

                }
                divimg.Visible = true;

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "bindProducts", ex.Message);
        }
    }
    public void BindCapability()
    {
        try
        {
            List<Capability> loc = Capability.GetAllCapability(conSQ);
            if (loc != null && loc.Count() > 0)
            {
                ddlCapabilityType.DataSource = loc;
                ddlCapabilityType.DataTextField = "CapabilityName";
                ddlCapabilityType.DataValueField = "Id";
                ddlCapabilityType.DataBind();
                ddlCapabilityType.Items.Insert(0, new ListItem { Value = "0", Text = "Select Capability" });
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindCapability", ex.Message);
        }
    }
    public void GetCapability(string loc)
    {
        try
        {
            foreach (string str in loc.Split('|'))
            {
                foreach (ListItem li in ddlCapabilityType.Items)
                {
                    if (str.Trim() == li.Value.Trim())
                    {
                        li.Selected = true;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetCapability", ex.Message);
        }
    }
    public string SaveCapability()
    {
        string x = "";
        try
        {

            foreach (ListItem li in ddlCapabilityType.Items)
            {
                if (li.Selected)
                {
                    x += li.Value + "|";
                }
            }
            x = x.TrimEnd('|');

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "SaveCapability", ex.Message);

        }
        return x;
    }
    public void BindIndustry()
    {
        try
        {
            List<IndustryDetails> loc = IndustryDetails.GetAllIndustries(conSQ);
            if (loc != null && loc.Count() > 0)
            {
                ddlindustry.DataSource = loc;
                ddlindustry.DataTextField = "IndustryName";
                ddlindustry.DataValueField = "Id";
                ddlindustry.DataBind();
                ddlindustry.Items.Insert(0, new ListItem { Value = "0", Text = "Select Industry Name" });
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindIndustry", ex.Message);
        }
    }
    public void GetIndustry(string loc)
    {
        try
        {
            foreach (string str in loc.Split('|'))
            {
                foreach (ListItem li in ddlindustry.Items)
                {
                    if (str.Trim() == li.Value.Trim())
                    {
                        li.Selected = true;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetIndustry", ex.Message);
        }
    }
    public string SaveIndustry()
    {
        string x = "";
        try
        {

            foreach (ListItem li in ddlindustry.Items)
            {
                if (li.Selected)
                {
                    x += li.Value + "|";
                }
            }
            x = x.TrimEnd('|');

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "SaveIndustry", ex.Message);

        }
        return x;
    }
    public void BindSubCapability()
    {
        try
        {
            List<SubCapability> loc = SubCapability.GetAllSubCapability(conSQ).Where(x => x.Capabilities == ddlCapabilityType.SelectedItem.Value).ToList();
            if (loc != null && loc.Count() > 0)
            {
                ddlSubcapability.DataSource = loc;
                ddlSubcapability.DataTextField = "SubCapabilityName";
                ddlSubcapability.DataValueField = "Id";
                ddlSubcapability.DataBind();
                ddlSubcapability.Items.Insert(0, new ListItem { Value = "0", Text = "Select Subcapability" });
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindSubCapability", ex.Message);
        }
    }
    protected void ddlCapabilityType_SelectedIndexChanged(object sender, EventArgs e)
    {

        try
        {
            if (ddlCapabilityType.SelectedValue != "0")
            {

                BindSubCapability();
            }
            else
            {
                ddlSubcapability.Items.Clear();
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "ddlCapabilityType_SelectedIndexChanged", ex.Message);

        }

    }
    public void GetSubCapability(string loc)
    {
        try
        {
            foreach (string str in loc.Split('|'))
            {
                foreach (ListItem li in ddlSubcapability.Items)
                {
                    if (str.Trim() == li.Value.Trim())
                    {
                        li.Selected = true;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetSubCapability", ex.Message);
        }
    }
    public string SaveSubCapability()
    {
        string x = "";
        try
        {

            foreach (ListItem li in ddlSubcapability.Items)
            {
                if (li.Selected)
                {
                    x += li.Value + "|";
                }
            }
            x = x.TrimEnd('|');

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "SaveSubCapability", ex.Message);

        }
        return x;
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {

            if (Page.IsValid)
            {
                var id = Request.QueryString["id"] == "" ? 0 : Convert.ToInt32(Request.QueryString["id"]);
                var exist = ProductDetails.CheckExist(conSQ, txtproductName.Text, txtUrl.Text, id);
                if (exist > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Product with title,url already exist.',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }


                #region Upload Image
                var CSthumbimg = CheckThumbFormat();
                if (CSthumbimg == "Format")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image format. Please upload .png, .jpeg, .jpg, .webp, .gif for thumb image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                if (CSthumbimg == "Size")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image size.Please upload correct resolution image for thumb image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }

                var Uploadpdf = CheckPDFFormat();
                if (Uploadpdf == "Format")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid PDF format. Please upload .pdf, .doc, for PDF',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                if (Uploadpdf == "Size")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image size.Please upload correct PDF Size',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }

                #endregion

                var aid = Request.Cookies["bmw_aid"].Value;

                ProductDetails pro = new ProductDetails();
                pro.ProductGuid = Guid.NewGuid().ToString();
                pro.ProductName = txtproductName.Text.Trim();
                pro.ProductUrl = txtUrl.Text.Trim();
                pro.SKUCode = txtcode.Text.Trim();
                pro.DatasheetName = "";
                pro.DatasheetLink = "";
                pro.Enquiry = chkenquiry.Checked ? "Yes" : "No";
                pro.Capability = SaveCapability();
                pro.SubCapability = SaveSubCapability();
                pro.Industry = SaveIndustry();
                pro.FullDesc = txtDesc.Text.Trim();
                pro.MetaDesc = txtMetaDesc.Text.Trim();
                pro.MetaKeys = txtMetaKey.Text.Trim();
                pro.PageTitle = txtPageTitle.Text.Trim();
                pro.ThumbImage = UploadThumbImage();
                pro.Broucher = UploadPDFSheet();
                pro.AddedIp = CommonModel.IPAddress();
                pro.AddedOn = TimeStamps.UTCTime();
                pro.AddedBy = aid;
                pro.Status = "Active";
                

                if (pro.ThumbImage != "" && pro.Broucher != "")
                {
                    if (btnSave.Text == "Update")
                    {
                        pro.Id = Convert.ToInt32(Request.QueryString["id"]);
                        int result = ProductDetails.UpdateProducts(conSQ, pro);
                        if (result > 0)
                        {
                            bindProducts();
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Products Details Updated successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops! Something went wrong. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                        }
                    }

                    else
                    {
                        if (string.IsNullOrEmpty(pro.Broucher))
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Please upload PDF.',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                            return;
                        }
                        int result = ProductDetails.InsertProducts(conSQ, pro);
                        if (result > 0)
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Product Added successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                            txtproductName.Text = txtUrl.Text = txtcode.Text =  txtDesc.Text = txtMetaDesc.Text = txtMetaKey.Text = txtPageTitle.Text = ddlCapabilityType.SelectedValue = ddlSubcapability.SelectedValue = "";
                            chkenquiry.Checked = false;
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops! Something went wrong. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                        }
                    }
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops! Something went wrong. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "btnSave_Click", ex.Message);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops! Something went wrong. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
        }
    }
    private string CheckThumbFormat()
    {
        #region CSThumbImage
        string thumbImg = "";
        if (CSthumbimg.HasFile)
        {
            try
            {
                string fileExtension = Path.GetExtension(CSthumbimg.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString();
                if ((fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" || fileExtension == ".gif" || fileExtension == ".webp"))
                {
                    string iconPath = Server.MapPath(".") + "\\../UploadImages\\" + ImageGuid1 + "-CSthumb" + fileExtension;
                    System.Drawing.Bitmap bitimg = new System.Drawing.Bitmap(CSthumbimg.PostedFile.InputStream);
                    if ((bitimg.PhysicalDimension.Height != 334) || (bitimg.PhysicalDimension.Width != 500))
                    {
                        return "Size";
                    }
                }
                else
                {

                    return "Format";
                }
            }
            catch (Exception ex)
            {
                ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "CheckCSthumbFormat", ex.Message);

            }
        }
        #endregion
        return thumbImg;
    }
    public string UploadThumbImage()
    {
        #region upload file
        string thumbfile = "";
        try
        {
            if (CSthumbimg.HasFile)
            {
                string fileExtension = Path.GetExtension(CSthumbimg.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString() + "-sample".Replace(" ", "-").Replace(".", "");
                string iconPath = Server.MapPath(".") + "\\../UploadImages\\" + ImageGuid1 + "" + fileExtension;
                try
                {
                    if (File.Exists(Server.MapPath("~/" + Convert.ToString(lblThumb.Text))))
                    {
                        File.Delete(Server.MapPath("~/" + Convert.ToString(lblThumb.Text)));
                    }
                }
                catch (Exception eeex)
                {
                    ExceptionCapture.CaptureException(Request.Url.PathAndQuery, "UploadThumbImage", eeex.Message);
                    return lblThumb.Text;
                }
                CSthumbimg.SaveAs(iconPath);
                thumbfile = "UploadImages/" + ImageGuid1 + "" + fileExtension;
            }
            else
            {
                thumbfile = lblThumb.Text;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UploadThumbImage", ex.Message);

        }

        #endregion
        return thumbfile;
    }
    private string CheckPDFFormat()
    {
        #region PDF
        string UploadPdf = "";
        if (UploadPDF.HasFile)
        {
            try
            {
                string fileExtension = Path.GetExtension(UploadPDF.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString();
                if ((fileExtension == ".pdf" || fileExtension == ".doc"))
                {
                    string iconPath = Server.MapPath(".") + "\\../Uploadpdf\\" + ImageGuid1 + "-AprImg" + fileExtension;
                    System.Drawing.Bitmap bitimg = new System.Drawing.Bitmap(UploadPDF.PostedFile.InputStream);
                }
                else
                {

                    return "Format";
                }
            }
            catch (Exception ex)
            {
                ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "CheckPDFFormat", ex.Message);

            }
        }
        #endregion
        return UploadPdf;
    }
    public string UploadPDFSheet()
    {
        #region PDF file
        string Uploadpdf = "";
        try
        {
            if (UploadPDF.HasFile)
            {
                string fileExtension = Path.GetExtension(UploadPDF.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString() + "-pdf".Replace(" ", "-").Replace(".", "");
                string iconPath = Server.MapPath(".") + "\\../Uploadpdf\\" + ImageGuid1 + "" + fileExtension;
                try
                {
                    if (File.Exists(Server.MapPath("~/" + Convert.ToString(lblPDF.Text))))
                    {
                        File.Delete(Server.MapPath("~/" + Convert.ToString(lblPDF.Text)));
                    }
                }
                catch (Exception eeex)
                {
                    ExceptionCapture.CaptureException(Request.Url.PathAndQuery, "UploadPDFSheet", eeex.Message);
                    return lblPDF.Text;
                }
                UploadPDF.SaveAs(iconPath);
                Uploadpdf = "Uploadpdf/" + ImageGuid1 + "" + fileExtension;
            }
            else
            {
                Uploadpdf = lblPDF.Text;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UploadPDFSheet", ex.Message);

        }

        #endregion
        return Uploadpdf;
    }
    protected void btnNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("add-product.aspx");
    }

}