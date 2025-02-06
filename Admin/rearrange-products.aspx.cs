using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_rearrange_products : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [WebMethod(EnableSession = true)]
    public static int ProductOrderUpdate(string product)
    {
        int status = 1;
        string[] str = product.Split(',');
        SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
        try
        {

            for (int i = 0; i < str.Length; i++)
            {
                ProductDetails catG = new ProductDetails();
                catG.Id = str[i] == "" ? 0 : Convert.ToInt32(str[i]);
                catG.ProductOrder = Convert.ToString(i);
                ProductDetails.UpdateProductOrder(conSQ, catG);
            }
            status = 0;
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "productOrderUpdate", ex.Message);
            status = 1;
        }
        return status;
    }

    [WebMethod(EnableSession = true)]
    public static List<ProductDetails> ProductOrder()
    {
        List<ProductDetails> fpl = new List<ProductDetails>();
        try
        {
            SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
            List<ProductDetails> lpds = ProductDetails.GetAllProductDetails(conSQ).OrderBy(x => x.ProductOrder).ToList();
            foreach (var cat in lpds)
            {
                fpl.Add(new ProductDetails() { ProductName = cat.ProductName, Id = cat.Id, ThumbImage = cat.ThumbImage });
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "productOrder", ex.Message);
        }
        return fpl;
    }
}