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
        }
    }


    [WebMethod(EnableSession = true)]
    public static string Getproducts(string PageNo, string PageLenght, string Key, string Capability, string Industry)
    {
        SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
        try
        {

            var result = "";
            var pro = ProductDetails.GetProductListing(conSQ, PageNo, PageLenght, Key, Capability, Industry);
            if (pro != null && pro.Rows.Count > 0)
            {
                for (int i = 0; i < pro.Rows.Count; i++)
                {
                    //var specount = 0;
                    //specount = SpecificationDetails.GetAllSpecificationcntWithGuid(conSQ, pro.Rows[i]["ProductGuid"]).Count;
                    //var capcount = 0;
                    //capcount = manageCapabilities.GetAllcapabilitiesWithGuid(conSQ, pro.Rows[i]["ProductGuid"]).Count;
                    //var Gallerycount = 0;
                    //Gallerycount = DatasheetGallery.GetAllGallerytWithGuid(conSQ, pro.Rows[i]["ProductGuid"]).Count;
                    //var ProductGallerycount = 0;
                    //ProductGallerycount = ProductGallery.GetAllProductGallerytWithGuid(conSQ, pro.Rows[i]["ProductGuid"]).Count;
                    var image = "<a href='/" + pro.Rows[i]["ThumbImage"] + @"' target='_blank'><img src='/" + pro.Rows[i]["ThumbImage"] + @"' alt='' class='avatar-md shadow'></a>";


                    result += @"<tr>
                                    <td>" + (i + 1) + @"</td>
                                    <td>" + image + @"</td>
                                    <td class='text-primary fw-bold'>" + pro.Rows[i]["ProductName"] + @",</br>" + pro.Rows[i]["CapabilityTitle"] + @",</br>" + (Convert.ToString(pro.Rows[i]["SubcapabilityTitle"]) == "" ? "<span class='text-muted'>Not Applicable</span>" : Convert.ToString(pro.Rows[i]["SubcapabilityTitle"])) + @"</td>
                                    <td>" + pro.Rows[i]["Industries"] + @"</td>
                                    <td><a href='manage-capabilities.aspx?Pid=" + pro.Rows[i]["ProductGuid"] + @"' class='text-secondary fw-bold' target='_blank'>Capabilities(" + pro.Rows[i]["CapCnt"] + @")</a></td>
                                    <td><a href='manage-specification.aspx?Pid=" + pro.Rows[i]["ProductGuid"] + @"' class='text-secondary fw-bold' target='_blank'>Specification(" + pro.Rows[i]["SpecCnt"] + @")</a></td>
                                    <td><a href='manage-datasheet-galleries.aspx?Pid=" + pro.Rows[i]["ProductGuid"] + @"' class='text-secondary fw-bold' target='_blank'>Datasheet Gallery(" + pro.Rows[i]["GalleryCnt"] + @")</a></td>
                                    <td><a href='manage-product-galleries.aspx?Gid=" + pro.Rows[i]["ProductGuid"] + @"' class='text-secondary fw-bold' target='_blank'>Product Gallery(" + pro.Rows[i]["ProductCnt"] + @")</a></td>
                                    <td>" + Convert.ToDateTime(pro.Rows[i]["AddedOn"]).ToString("dd/MMM/yyyy") + @"</td>
                                    <td class='text-center'> 
                                        <a href='add-product.aspx?id=" + pro.Rows[i]["Id"] + @"' class='bs-tooltip text-info fs-18' data-id='" + pro.Rows[i]["Id"] + @"' data-toggle='tooltip' data-placement='top' title='Edit' data-original-title='Edit'>
                                            <i class='mdi mdi-pencil'></i></a>
                                        <a href='javascript:void(0);' class='bs-tooltip deleteItem warning confirm text-danger fs-18' data-id='" + pro.Rows[i]["Id"] + @"' data-toggle='tooltip' data-placement='top' title='Delete' data-original-title='Delete'>
                                            <i class='mdi mdi-delete-forever'></i></a>
                                    </td>
                                </tr>";
                }
            }
            else
            {
                result = "<tr><td class='text-center' colspan='6'>No data to show.</td></tr>";
            }
            return JsonConvert.SerializeObject(new { table = result, count = pro.Rows[0]["TotalCnt"] });
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