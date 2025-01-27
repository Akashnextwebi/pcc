using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_add_case_studies : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string strThumbImage = "", strDetailImage = "", strImgPS = "", strImgApproach = "", strUploadPDF = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                bindCaseStudy();
            }
        }
    }
    public void bindCaseStudy()
    {
        try
        {
            var Case = CaseStudy.getCaseStudiesById(conSQ, Convert.ToInt32(Request.QueryString["id"]));
            if (Case != null)
            {
                btnSave.Text = "Update";
                btnNew.Visible = true;
                txtCasestudyName.Text = Case.CaseStudyName;
                txtUrl.Text = Case.CaseStudyUrl;
                txtCategory.Text = Case.Category;
                txtPostedOn.Text = Case.PostedOn.ToString("dd MMM yyyy");
                txtLocation.Text = Case.Location;
                txtClient.Text = Case.Client;
                txtOverview.Text= Case.OverviewTitle;
                OverviewDesc.Text= Case.OVDesc;
                txtPStitle.Text= Case.PSTitle;
                txtPSDesc.Text= Case.PSDesc;
                txtApproach.Text= Case.OATitle;
                txtDescApproach.Text= Case.OADesc;
                txttutitle.Text= Case.TUTitle;
                txttudesc.Text= Case.TUDesc;
                txtcetitle.Text= Case.CETitle;
                txtcedesc.Text = Case.CEDesc;
                txtdbptitle.Text= Case.DBPTitle;
                txtdbpdesc.Text= Case.DBPDesc;
                txtMetaDesc.Text = Case.MetaDesc;
                txtMetaKey.Text = Case.MetaKeys;
                txtPageTitle.Text = Case.PageTitle;
               
               


                if (Case.CSThumbImage != "")
                {
                    strThumbImage = "<img src='/" + Case.CSThumbImage + "' style='max-height:60px;' />";
                    lblThumb.Text = Case.CSThumbImage;
                }
                if (Case.CSDetailImage != "")
                {
                    strDetailImage = "<img src='/" + Case.CSDetailImage + "' style='max-height:60px;' />";
                    lblDetailImg.Text = Case.CSDetailImage;
                }

                if (Case.PSImages != "")
                {
                    strImgPS = "<img src='/" + Case.PSImages + "' style='max-height:60px;' />";
                    lblPSImg.Text = Case.PSImages;
                }

                if (Case.OAImages != "")
                {
                    strImgApproach = "<img src='/" + Case.OAImages + "' style='max-height:60px;' />";
                    lblApproachImg.Text = Case.OAImages;
                }

                if (Case.UploadPDF != "")
                {
                    strUploadPDF = "<a href='/" + Case.UploadPDF + @"'><img src='assets/images/PDF.png' style='max-height:60px;' class='img-fluid'/></a>";
                    strUploadPDF = Case.UploadPDF;

                }
                divimg.Visible = true;

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "bindCaseStudy", ex.Message);
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {

            if (Page.IsValid)
            {


                #region Upload Image
                var CSthumbimg = CheckCSthumbFormat();
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

                var CSdetailimg = CheckCSdetailImageFormat();
                if (CSdetailimg == "Format")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image format. Please upload .png, .jpeg, .jpg, .webp, .gif for CaseStudy image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                if (CSdetailimg == "Size")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image size.Please upload correct resolution image for CaseStudy  image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }


                //=========================================
                var PstateImg = CheckPSImageFormat();
                if (PstateImg == "Format")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image format. Please upload .png, .jpeg, .jpg, .webp, .gif for PS image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                if (PstateImg == "Size")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image size.Please upload correct resolution image for PS image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }

                var Approachimg = CheckOAImageFormat();
                if (Approachimg == "Format")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image format. Please upload .png, .jpeg, .jpg, .webp, .gif for OA image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                if (Approachimg == "Size")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image size.Please upload correct resolution image for OA image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
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




                var aid = Request.Cookies["pcc_aid"].Value;

                CaseStudy CS = new CaseStudy();

                CS.CaseStudyName = txtCasestudyName.Text.Trim();
                CS.CaseStudyUrl = txtUrl.Text.Trim();
                CS.Category = txtCategory.Text.Trim();
                CS.Location = txtLocation.Text.Trim();
                CS.Client = txtClient.Text.Trim();
                CS.PostedOn= Convert.ToDateTime(txtPostedOn.Text.Trim());
                CS.MetaDesc = txtMetaDesc.Text.Trim();
                CS.MetaKeys = txtMetaKey.Text.Trim();
                CS.PageTitle = txtPageTitle.Text.Trim();
                CS.CSThumbImage = UploadCSThumbImage();
                CS.UploadPDF = UploadPDFSheet();
                CS.CSDetailImage = UploadCSdetailImage();
                CS.PSImages = UploadPSImage();
                CS.OAImages = UploadOAImage();
                CS.OverviewTitle= txtOverview.Text.Trim();
                CS.OVDesc= OverviewDesc.Text.Trim();
                CS.PSTitle= txtPStitle.Text.Trim();
                CS.PSDesc = txtPSDesc.Text.Trim();
                CS.OATitle= txtApproach.Text.Trim();
                CS.OADesc= txtDescApproach.Text.Trim();
                CS.TUTitle= txttutitle.Text.Trim();
                CS.TUDesc= txttudesc.Text.Trim();
                CS.CETitle= txtcetitle.Text.Trim();
                CS.CEDesc= txtcedesc.Text.Trim();
                CS.DBPTitle= txtdbptitle.Text.Trim();
                CS.DBPDesc= txtdbpdesc.Text.Trim();
                CS.AddedIP = CommonModel.IPAddress();
                CS.AddedOn = TimeStamps.UTCTime();              
                CS.AddedBy = aid;
                CS.Status = "Active";
                if (string.IsNullOrEmpty(CS.CSThumbImage))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Please upload Thumbnail Image.',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }

                if (string.IsNullOrEmpty(CS.CSDetailImage))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Please upload Detail Image.',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }

                if (string.IsNullOrEmpty(CS.PSImages))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Please upload Problem Statement Image.',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }

                if (string.IsNullOrEmpty(CS.OAImages))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Please upload Image for Approach.',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }




                if (btnSave.Text == "Update")
                {
                    CS.Id = Convert.ToInt32(Request.QueryString["id"]);
                    int result = CaseStudy.UpdateCaseStudies(conSQ, CS);
                    if (result > 0)
                    {
                        bindCaseStudy();
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Case Studies Details Updated successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Oops! Something went wrong. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    }
                }

                else
                {
                    if (string.IsNullOrEmpty(CS.UploadPDF))
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Please upload PDF.',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                        return;
                    }
                    int result = CaseStudy.InsertCaseStudies(conSQ, CS);
                    if (result > 0)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'CaseStudy Details Added successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                        txtCasestudyName.Text = txtUrl.Text = txtCategory.Text = txtLocation.Text = txtClient.Text = OverviewDesc.Text = txtMetaDesc.Text = txtMetaKey.Text = txtPageTitle.Text = txtPStitle.Text = txtPSDesc.Text = txtApproach.Text = txtDescApproach.Text =  txtOverview.Text = "";
                        strThumbImage = strDetailImage = strImgPS = strImgApproach = strUploadPDF = "";


                        /*txtName.Text = txtUrl.Text = txtPostedBy.Text = txtShortDesc.Text = txtDesc.Text = txtPageTitle.Text = txtMetaKey.Text = txtMetaDesc.Text = "";
                        strThumbImage = strBlogImage = "";*/
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
    private string CheckCSthumbFormat()
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
                    if ((bitimg.PhysicalDimension.Height != 430) || (bitimg.PhysicalDimension.Width != 650))
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
    public string UploadCSThumbImage()
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
                    ExceptionCapture.CaptureException(Request.Url.PathAndQuery, "UploadCSThumbImage", eeex.Message);
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

    private string CheckCSdetailImageFormat()
    {
        #region CSDetailImg
        string CSDetailImg = "";
        if (CSDetailImage.HasFile)
        {
            try
            {
                string fileExtension = Path.GetExtension(CSDetailImage.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString();
                if ((fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" || fileExtension == ".gif" || fileExtension == ".webp"))
                {
                    string iconPath = Server.MapPath(".") + "\\../UploadImages\\" + ImageGuid1 + "-CSimg" + fileExtension;
                    System.Drawing.Bitmap bitimg = new System.Drawing.Bitmap(CSDetailImage.PostedFile.InputStream);
                    if ((bitimg.PhysicalDimension.Height != 720) || (bitimg.PhysicalDimension.Width != 1080))
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
                ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "CheckBlogImageFormat", ex.Message);

            }
        }
        #endregion
        return CSDetailImg;
    }
    public string UploadCSdetailImage()
    {
        #region CSDetail file
        string CSDetailfile = "";
        try
        {
            if (CSDetailImage.HasFile)
            {
                string fileExtension = Path.GetExtension(CSDetailImage.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString() + "-sample".Replace(" ", "-").Replace(".", "");
                string iconPath = Server.MapPath(".") + "\\../UploadImages\\" + ImageGuid1 + "" + fileExtension;
                try
                {
                    if (File.Exists(Server.MapPath("~/" + Convert.ToString(lblDetailImg.Text))))
                    {
                        File.Delete(Server.MapPath("~/" + Convert.ToString(lblDetailImg.Text)));
                    }
                }
                catch (Exception eeex)
                {
                    ExceptionCapture.CaptureException(Request.Url.PathAndQuery, "UploadCSdetailImage", eeex.Message);
                    return lblDetailImg.Text;
                }
                CSDetailImage.SaveAs(iconPath);
                CSDetailfile = "UploadImages/" + ImageGuid1 + "" + fileExtension;
            }
            else
            {
                CSDetailfile = lblDetailImg.Text;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UploadCSdetailImage", ex.Message);

        }

        #endregion
        return CSDetailfile;
    }

    private string CheckPSImageFormat()
    {
        #region PS Image
        string PSImg = "";
        if (ImgPS.HasFile)
        {
            try
            {
                string fileExtension = Path.GetExtension(ImgPS.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString();
                if ((fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" || fileExtension == ".gif" || fileExtension == ".webp"))
                {
                    string iconPath = Server.MapPath(".") + "\\../UploadImages\\" + ImageGuid1 + "-PSimg" + fileExtension;
                    System.Drawing.Bitmap bitimg = new System.Drawing.Bitmap(ImgPS.PostedFile.InputStream);
                    if ((bitimg.PhysicalDimension.Height != 306) || (bitimg.PhysicalDimension.Width != 463))
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
                ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "CheckPSImageFormat", ex.Message);

            }
        }
        #endregion
        return PSImg;
    }
    public string UploadPSImage()
    {
        #region PS file
        string PSfile = "";
        try
        {
            if (ImgPS.HasFile)
            {
                string fileExtension = Path.GetExtension(ImgPS.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString() + "-sample".Replace(" ", "-").Replace(".", "");
                string iconPath = Server.MapPath(".") + "\\../UploadImages\\" + ImageGuid1 + "" + fileExtension;
                try
                {
                    if (File.Exists(Server.MapPath("~/" + Convert.ToString(lblPSImg.Text))))
                    {
                        File.Delete(Server.MapPath("~/" + Convert.ToString(lblPSImg.Text)));
                    }
                }
                catch (Exception eeex)
                {
                    ExceptionCapture.CaptureException(Request.Url.PathAndQuery, "UploadPSImage", eeex.Message);
                    return lblPSImg.Text;
                }
                ImgPS.SaveAs(iconPath);
                PSfile = "UploadImages/" + ImageGuid1 + "" + fileExtension;
            }
            else
            {
                PSfile = lblPSImg.Text;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UploadPSImage", ex.Message);

        }

        #endregion
        return PSfile;
    }

    private string CheckOAImageFormat()
    {
        #region Approach Image
        string ApproachImg = "";
        if (ImgApproach.HasFile)
        {
            try
            {
                string fileExtension = Path.GetExtension(ImgApproach.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString();
                if ((fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" || fileExtension == ".gif" || fileExtension == ".webp"))
                {
                    string iconPath = Server.MapPath(".") + "\\../UploadImages\\" + ImageGuid1 + "-AprImg" + fileExtension;
                    System.Drawing.Bitmap bitimg = new System.Drawing.Bitmap(ImgApproach.PostedFile.InputStream);
                    if ((bitimg.PhysicalDimension.Height != 306) || (bitimg.PhysicalDimension.Width != 463))
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
                ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "CheckOAImageFormat", ex.Message);

            }
        }
        #endregion
        return ApproachImg;
    }
    public string UploadOAImage()
    {
        #region Approach file
        string Approachfile = "";
        try
        {
            if (ImgApproach.HasFile)
            {
                string fileExtension = Path.GetExtension(ImgApproach.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString() + "-sample".Replace(" ", "-").Replace(".", "");
                string iconPath = Server.MapPath(".") + "\\../UploadImages\\" + ImageGuid1 + "" + fileExtension;
                try
                {
                    if (File.Exists(Server.MapPath("~/" + Convert.ToString(lblApproachImg.Text))))
                    {
                        File.Delete(Server.MapPath("~/" + Convert.ToString(lblApproachImg.Text)));
                    }
                }
                catch (Exception eeex)
                {
                    ExceptionCapture.CaptureException(Request.Url.PathAndQuery, "UploadOAImage", eeex.Message);
                    return lblApproachImg.Text;
                }
                ImgApproach.SaveAs(iconPath);
                Approachfile = "UploadImages/" + ImageGuid1 + "" + fileExtension;
            }
            else
            {
                Approachfile = lblApproachImg.Text;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UploadApproachImage", ex.Message);

        }

        #endregion
        return Approachfile;
    }

    //pdf

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
        Response.Redirect("add-case-studies.aspx", false);
    }

}