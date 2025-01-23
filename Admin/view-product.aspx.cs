using Newtonsoft.Json;
using System;
using System.Activities.Expressions;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_view_product : System.Web.UI.Page
{
    public string strProducts = "";
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //BindIndustry();
            //BindCapability();
        }
    }
    //public void BindCapability()
    //{
    //    try
    //    {
    //        List<Capability> loc = Capability.GetAllCapability(conSQ);
    //        if (loc != null && loc.Count() > 0)
    //        {
    //            ddlCapabilityType.DataSource = loc;
    //            ddlCapabilityType.DataTextField = "CapabilityName";
    //            ddlCapabilityType.DataValueField = "Id";
    //            ddlCapabilityType.DataBind();
    //            ddlCapabilityType.Items.Insert(0, new ListItem { Value = "0", Text = "Select Capability" });
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindCapability", ex.Message);
    //    }
    //}
    //public void BindIndustry()
    //{
    //    try
    //    {
    //        List<IndustryDetails> loc = IndustryDetails.GetAllIndustries(conSQ);
    //        if (loc != null && loc.Count() > 0)
    //        {
    //            ddlindustry.DataSource = loc;
    //            ddlindustry.DataTextField = "IndustryName";
    //            ddlindustry.DataValueField = "Id";
    //            ddlindustry.DataBind();
    //            ddlindustry.Items.Insert(0, new ListItem { Value = "0", Text = "Select Industry Name" });
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindIndustry", ex.Message);
    //    }
    //}
    
    [WebMethod(EnableSession = true)]
    public static string Getproducts(string PageNo, string PageLenght, string Key,string Capability,string Industry)
    {
        SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
        try
        {

            var result = "";
            var pro = ProductDetails.GetProductListing(conSQ, PageNo, PageLenght, Key, Capability,Industry);
            if (pro != null && pro.Count() > 0)
            {
                for (int i = 0; i < pro.Count(); i++)
                {
                    var specount = 0;
                    specount = SpecificationDetails.GetAllSpecificationcntWithGuid(conSQ, pro[i].ProductGuid).Count;
                    var capcount = 0;
                    capcount = manageCapabilities.GetAllcapabilitiesWithGuid(conSQ, pro[i].ProductGuid).Count;
                    var Gallerycount = 0;
                    Gallerycount = DatasheetGallery.GetAllGallerytWithGuid(conSQ, pro[i].ProductGuid).Count;
                    var ProductGallerycount = 0;
                    ProductGallerycount = ProductGallery.GetAllProductGallerytWithGuid(conSQ, pro[i].ProductGuid).Count;
                    var image = "<a href='/" + pro[i].ThumbImage + @"' target='_blank'><img src='/" + pro[i].ThumbImage + @"' alt='' class='rounded-circle avatar-xs shadow'></a>";
                    var pdfIcon = "<img src='assets/images/pdf.png' alt='PDF' class='pdf-icon' style='width:30px; height:30px; vertical-align:middle;'>";
                    var PDF = "<a href='/" + pro[i].Broucher + "' target='_blank'>" + pdfIcon + "PDF</a>";


                    result += @"<tr>
                                       <td>" + (i + 1) + @"</td>
                                        <td>" + image + @"</td>
                                       <td>" + PDF + @"</td> 
                                       <td>" + pro[i].ProductName + @"</td>
                                      <td><a href='manage-capabilities.aspx?Pid=" + pro[i].ProductGuid + @"' class='text-success fw-bold' target='_blank'>Capabilities(" + capcount + @")</a></td>
                                        <td><a href='manage-specification.aspx?Pid=" + pro[i].ProductGuid + @"' class='text-success fw-bold' target='_blank'>Specification(" + specount + @")</a></td>
                                       <td><a href='manage-datasheet-galleries.aspx?Pid=" + pro[i].ProductGuid + @"' class='text-success fw-bold' target='_blank'>Datasheet Gallery(" + Gallerycount + @")</a></td>
                                         <td><a href='manage-product-galleries.aspx?Gid=" + pro[i].ProductGuid + @"' class='text-success fw-bold' target='_blank'>Product Gallery(" + ProductGallerycount + @")</a></td>
                                        <td>" + pro[i].CapabilityTitle + @"</td>
                                       <td>" + pro[i].SubcapabilityTitle + @"</td>    
                                       <td>" + pro[i].IndustryTitle + @"</td>  
                                         <td>" + pro[i].AddedOn.ToString("dd/MMM/yyyy") + @"</td>
                                        <td class='text-center'> 
                                            <a href='add-product.aspx?id=" + pro[i].Id + @"' class='bs-tooltip text-info fs-18' data-id='" + pro[i].Id + @"' data-toggle='tooltip' data-placement='top' title='Edit' data-original-title='Edit'>
                                             <i class='mdi mdi-pencil'></i></a>
                                            <a href='javascript:void(0);' class='bs-tooltip deleteItem warning confirm text-danger fs-18' data-id='" + pro[i].Id + @"' data-toggle='tooltip' data-placement='top' title='Delete' data-original-title='Delete'>
                                               <i class='mdi mdi-delete-forever'></i></a></a>    </td>
                                          </tr>";
                }
            }
            else
            {
                result = "<tr><td class='text-center' colspan='6'>No data to show.</td></tr>";
            }
            return JsonConvert.SerializeObject(new { table = result, count = pro[0].TotalCount });
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "ViewCustomers", ex.Message);
            return "Error";
        }
    }

    [WebMethod(EnableSession = true)]
    public static string Delete(string id)
    {
        string x = "";
        try
        {
            SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
            ProductDetails BD = new ProductDetails();
            BD.Id = Convert.ToInt32(id);
            BD.AddedOn = TimeStamps.UTCTime();
            BD.AddedIp = CommonModel.IPAddress();
            int exec = ProductDetails.DeleteProducts(conSQ, BD);
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
    [WebMethod(EnableSession = true)]
    public static List<Capability> alllist()
    {
        SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
        List<Capability> item = null;
        try
        {
            item = Capability.GetAllCapability(conSQ);
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "alllist", ex.Message);
        }
        return item;
    }

    [WebMethod(EnableSession = true)]
    public static List<IndustryDetails> industrylist()
    {
        SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
        List<IndustryDetails> item = null;
        try
        {
            item = IndustryDetails.GetAllIndustry(conSQ);
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "industrylist", ex.Message);
        }
        return item;
    }
}