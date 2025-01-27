using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_manage_investorpdf : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);

    public string strInvestorPdf = "", strPDF="";
    protected void Page_Load(object sender, EventArgs e)
    {
        GetInvestorpdfList();
        if (!IsPostBack)
        {
            BindInvestor();
            if (Request.QueryString["id"] != null)
            {
                GetInvestorpdfDetails();
            }
        }
    }
    public void BindInvestor()
    {
        try
        {
            List<ManageInvestor> loc = ManageInvestor.GetAllInvestorpdf(conSQ);
            if (loc != null && loc.Count() > 0)
            {
                ddlinvestor.DataSource = loc;
                ddlinvestor.DataTextField = "InvestorTitle";
                ddlinvestor.DataValueField = "Id";
                ddlinvestor.DataBind();
                ddlinvestor.Items.Insert(0, new ListItem { Value = "0", Text = "Select Investor" });
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindInvestor", ex.Message);
        }
    }
    public void GetInvestor(string loc)
    {
        try
        {
            foreach (string str in loc.Split('|'))
            {
                foreach (ListItem li in ddlinvestor.Items)
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetInvestor", ex.Message);
        }
    }
    public string SaveInvestor()
    {
        string x = "";
        try
        {

            foreach (ListItem li in ddlinvestor.Items)
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "SaveInvestor", ex.Message);

        }
        return x;
    }
    public void GetInvestorpdfDetails()
    {
        try
        {
            var lnk = InvestorPdf.GetAllInvestorpdfDetailsWithId(conSQ, Convert.ToInt32(Request.QueryString["id"]));
            if (lnk != null)
            {
                btnNew.Visible = true;
                btnSave.Text = "Update";
                ddlinvestor.SelectedValue = lnk.Investor;
                txttitle.Text = lnk.PDFTitle;
                if (lnk.PDF != "")
                {
                    strPDF = "<a href='/" + lnk.PDF + @"'><img src='assets/images/PDF.png' style='max-height:60px;' class='img-fluid'/></a>";
                    lblPdf.Text = lnk.PDF;
                }

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetInvestorpdfDetails", ex.Message);
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {

            if (Page.IsValid)
            {
                var id = Request.QueryString["id"] == "" ? 0 : Convert.ToInt32(Request.QueryString["id"]);
                var exist = InvestorPdf.CheckExist(conSQ, txttitle.Text,  id);
                if (exist > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Investor PDF with title already exist.',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }

                #region Upload PDF
                var Uploadpdf = CheckPDFFormat();
                if (Uploadpdf == "Format")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid PDF format. Please upload .pdf, .doc, for PDF',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                if (Uploadpdf == "Size")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid PDF size.Please upload correct PDF Size',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                
                #endregion

                var aid = Request.Cookies["pcc_aid"].Value;

                InvestorPdf inv = new InvestorPdf();

                inv.Investor = SaveInvestor();
                inv.PDFTitle = txttitle.Text.Trim();
                inv.PDF = UploadPDFSheet();
                inv.AddedIp = CommonModel.IPAddress();
                inv.AddedOn = TimeStamps.UTCTime();
                inv.AddedBy = aid;
                inv.Status = "Active";
               
                if (btnSave.Text == "Update")
                {
                    inv.Id = Convert.ToInt32(Request.QueryString["id"]);
                    int result = InvestorPdf.UpdateInvestorpdf(conSQ, inv);
                    if (result > 0)
                    {
                        GetInvestorpdfDetails();
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'investor PDF Details Updated successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops! Something went wrong. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    }
                }

                else
                {
                    if (string.IsNullOrEmpty(inv.PDF))
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Please upload PDF.',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                        return;
                    }
                    int result = InvestorPdf.AddInvestorpdf(conSQ, inv);
                    if (result > 0)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'investor PDF Details Added successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                        txttitle.Text = ddlinvestor.Text = "";
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops! Something went wrong. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
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
    public void GetInvestorpdfList()
    {
        try
        {
            var lnk = InvestorPdf.GetAllInvestorPdf(conSQ);
            if (lnk != null)
            {
                strInvestorPdf = "";
                for (int i = 0; i < lnk.Count; i++)
                {
                    var pdfIcon = "<img src='assets/images/pdf.png' alt='PDF' class='pdf-icon' style='width:30px; height:30px; vertical-align:middle;'>";
                    var PDF = "<a href='/" + lnk[i].PDF + "' target='_blank'>" + pdfIcon + "PDF</a>";
                    strInvestorPdf += @"<tr>
                                        <td>" + (i + 1) + @"</td>
                                        <td>" + PDF + @"</td>
                                        <td>" + lnk[i].InvestorTitle + @"</td>
                                        <td>" + lnk[i].PDFTitle + @"</td>
                                        <td>" + Convert.ToDateTime(lnk[i].AddedOn).ToString("dd MMM yyyy") + @"</td>
                                        <td class='text-center'>
                                            <a href='manage-investorpdf.aspx?id=" + lnk[i].Id + @"' class='bs-tooltip text-info fs-18' data-id='" + lnk[i].Id + @"' data-toggle='tooltip' data-placement='top' title='Edit' data-original-title='Edit'>
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetInvestorpdfList", ex.Message);

        }
    }
    [WebMethod(EnableSession = true)]
    public static string Delete(string id)
    {
        string x = "";
        try
        {
            SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
            InvestorPdf BD = new InvestorPdf();
            BD.Id = Convert.ToInt32(id);
            BD.AddedOn = DateTime.UtcNow;
            BD.AddedIp = CommonModel.IPAddress();
            BD.Status = "Active";
            int exec = InvestorPdf.DeleteInvestorPdf(conSQ, BD);
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
        Response.Redirect("manage-investorpdf.aspx");
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
                    if (File.Exists(Server.MapPath("~/" + Convert.ToString(lblPdf.Text))))
                    {
                        File.Delete(Server.MapPath("~/" + Convert.ToString(lblPdf.Text)));
                    }
                }
                catch (Exception eeex)
                {
                    ExceptionCapture.CaptureException(Request.Url.PathAndQuery, "UploadPDFSheet", eeex.Message);
                    return lblPdf.Text;
                }
                UploadPDF.SaveAs(iconPath);
                Uploadpdf = "Uploadpdf/" + ImageGuid1 + "" + fileExtension;
            }
            else
            {
                Uploadpdf = lblPdf.Text;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UploadPDFSheet", ex.Message);

        }

        #endregion
        return Uploadpdf;
    }
}