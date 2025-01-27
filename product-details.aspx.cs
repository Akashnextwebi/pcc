using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class product_details : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string strName = "", strSKU, strMainImg = "",strId="", strdesc = "", strpdf = "", StrGallery = "", strCapabilities = "", strSpecification = "",strDatasheet="";
    protected void Page_Load(object sender, EventArgs e)
    {
        var purl = Convert.ToString(RouteData.Values["purl"]);
        if (!string.IsNullOrEmpty(purl))
        {
            BindProductDetails(purl);
        }

    }
    private void BindProductDetails(string purl)
    {
        try
        {
            var Pro = ProductDetails.getProductdetailsByUrl(conSQ, purl);
            if (Pro != null)
            {
                #region SEO
                if (!string.IsNullOrEmpty(Pro.PageTitle))
                {
                    Page.Title = Pro.PageTitle;
                }
                else
                {
                    Page.Title = Pro.ProductName + " | Park Control and Communication";
                }
                if (!string.IsNullOrEmpty(Pro.MetaDesc))
                {
                    Page.MetaDescription = Pro.MetaDesc;
                }
                if (!string.IsNullOrEmpty(Pro.MetaKeys))
                {
                    Page.MetaKeywords = Pro.MetaKeys;
                }
                #endregion

                strName = Pro.ProductName;
                strSKU = Pro.SKUCode;
                strdesc = Pro.FullDesc;
                strpdf = Pro.Broucher;
                strId = Pro.Id.ToString();
                var DS = DatasheetGallery.GetAllDatasheetGalleryProductGuid(conSQ, Pro.ProductGuid);
                if (DS.Count > 0)
                {
                    for (int i = 0; i < DS.Count; i++)
                    {


                        strDatasheet += @"<div class='swiper-slide'>
    <div class='data-sheet'>
        <img src='/" + DS[i].ImageUrl + @"' />
    </div>
</div>";
                    }

                }
                else
                {
                    divsheet.Visible = false;
                }
                var cap = manageCapabilities.GetAllCapabilitiesProductGuid(conSQ, Pro.ProductGuid);
                if (cap.Count > 0)
                {
                    for (int i = 0; i < cap.Count; i++)
                    {


                        if (i <= 3)
                        {
                            strCapabilities += @"<div class='col-sm-4 '>
                                            <div class='wptb-icon-box2 style3'>
                                                <div class='wptb-item--inner'>
                                                    <div class='wptb-item--holder'>
                                                        <div class='wptb-item--icon'>
                                                            <img src='/" + cap[i].ThumbImage + @"'  alt=''/>
                                                        </div>
                                                        <h3 class='wptb-item--title'>" + cap[i].Title + @"</h3>
                                                        <p class='wptb-item--description mb-0'>
                                                             " + cap[i].FullDesc + @"
                                                        </p>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
";


                        }
                        else
                        {
                            strCapabilities += @"<div class='col-sm-6 '>
     <div class='wptb-icon-box2 style3'>
         <div class='wptb-item--inner'>
             <div class='wptb-item--holder'>
                 <div class='wptb-item--icon'>
      <img src='/" + cap[i].ThumbImage + @"'  alt=''/>
                 </div>
                 <h3 class='wptb-item--title'>" + cap[i].Title + @"</h3>
                 <p class='wptb-item--description mb-0'>
                     " + cap[i].FullDesc + @"
                 </p>
             </div>
         </div>
     </div>
 </div>";
                        }
                    }
                }
               
                var spe = SpecificationDetails.GetAllSpecificationProductGuid(conSQ, Pro.ProductGuid);
                if (spe.Count > 0)
                {
                    for (int i = 0; i < spe.Count; i++)
                    {


                        strSpecification += @"<div class='wptb--item active'>
                                                    <h6 class='wptb-item-title'><span><span class='wptb-item--number'></span>" + spe[i].Title + @"</span> <i class='fa-solid fa-angle-down'></i></h6>
                                                    <div class='wptb-item--content' style='display: block;'>
                                                        " + spe[i].FullDesc + @"
                                                    </div>
                                                </div>";
                    }

                }
                var PG = ProductGallery.GetAllProductGalleryProductGuid(conSQ, Pro.ProductGuid);
                if (PG.Count > 0)
                {
                    for (int i = 0; i < PG.Count; i++)
                    {
                           StrGallery += @"<li class='product_zoom_button'>
    <a class='selected' href='#' style='background-image: url(/" + PG[i].ImageUrl + @");'></a>
</li>";
                        strMainImg += @"<div class='product_zoom_info selected'>
                                        <div class='product_image_zoom'>
                                            <img src='/"+ PG[i].ImageUrl + @"' alt='img'>
                                        </div>
                                    </div>";
                    }

                }
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindProductDetails", ex.Message);
        }
    }
    [WebMethod(EnableSession = true)]
    public static string SaveDownloadBroucherEnquiry(string name, string email, string contact, int Id)
    {
        SqlConnection conSQ= new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);

        try
        {
            BrochureEnguiry BE = new BrochureEnguiry();


            var ResPDF ="";

            BE.FullName = name;
            BE.Email = email;
            BE.Contact = contact;
            BE.AddedIP = CommonModel.IPAddress();
            BE.AddedOn = TimeStamps.UTCTime();
            BE.Status = "Active";
            BE.AddedBy = "";
            int result = BrochureEnguiry.InsertBroucherEnguiry(conSQ, BE);

            if (result > 0)
            {
                ResPDF = BrochureEnguiry.GetBroucherPDF(conSQ, Id);
                return "Success | " + ResPDF;
            }
            else
            {
                return "Error";
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "SaveDownloadBroucherEnquiry", ex.Message);
            return "Error";
        }
    }
}