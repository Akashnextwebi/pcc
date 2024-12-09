using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
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
            GetAllDetails();

        }
    }
    public void GetAllDetails()
    {
        try
        {
            strProducts = "";
            List<ProductDetails> BD = ProductDetails.GetProductsDetails(conSQ).ToList();
            for (int i = 0; i < BD.Count; i++)
            {
                var specount = 0;
                specount = SpecificationDetails.GetAllSpecificationcntWithGuid(conSQ, BD[i].ProductGuid).Count;
                var capcount = 0;
                capcount = manageCapabilities.GetAllcapabilitiesWithGuid(conSQ, BD[i].ProductGuid).Count;
                var image = "<a href='/" + BD[i].ThumbImage + @"' target='_blank'><img src='/" + BD[i].ThumbImage + @"' alt='' class='rounded-circle avatar-xs shadow'></a>";
                var pdfIcon = "<img src='assets/images/pdf.png' alt='PDF' class='pdf-icon' style='width:30px; height:30px; vertical-align:middle;'>";
                var PDF = "<a href='/" + BD[i].Broucher + "' target='_blank'>" + pdfIcon + "PDF</a>";
                strProducts += @"<tr>
                                        <td>" + (i + 1) + @"</td>
                                        <td>" + image + @"</td>
                                        <td>" + PDF + @"</td> 
                                        <td>" + BD[i].ProductName + @"</td>
                                         <td><a href='manage-capabilities.aspx?Pid=" + BD[i].ProductGuid + @"' class='text-secondary fw-bold' target='_blank'>Capabilities(" + capcount + @")</a></td>
                                          <td><a href='manage-specification.aspx?Pid=" + BD[i].ProductGuid + @"' class='text-secondary fw-bold' target='_blank'>Specification(" + specount + @")</a></td>
                                        <td>" + BD[i].CapabilityTitle + @"</td>
                                        <td>" + BD[i].SubcapabilityTitle + @"</td>                                      
                                         <td>" + BD[i].AddedOn.ToString("dd/MMM/yyyy") + @"</td>
                                        <td class='text-center'> 
                                            <a href='add-product.aspx?id=" + BD[i].Id + @"' class='bs-tooltip text-info fs-18' data-id='" + BD[i].Id + @"' data-toggle='tooltip' data-placement='top' title='Edit' data-original-title='Edit'>
                                               <i class='mdi mdi-pencil'></i></a>
                                            <a href='javascript:void(0);' class='bs-tooltip deleteItem warning confirm text-danger fs-18' data-id='" + BD[i].Id + @"' data-toggle='tooltip' data-placement='top' title='Delete' data-original-title='Delete'>
                                               <i class='mdi mdi-delete-forever'></i></a></a>    </td>
                                            </tr>";

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllDetails", ex.Message);
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
}