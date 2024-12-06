using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductDetails
/// </summary>
public class ProductDetails
{
    public ProductDetails()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int Id { get; set; }
    public string ProductName { get; set; }
    public string ProductUrl { get; set; }
    public string ThumbImage { get; set; }
    public string SKUCode { get; set; }
    public string Broucher { get; set; }
    public string DatasheetName { get; set; }
    public string DatasheetLink { get; set; }
    public string FullDesc { get; set; }
    public string PageTitle { get; set; }
    public string MetaKeys { get; set; }
    public string MetaDesc { get; set; }
    public DateTime AddedOn { get; set; }
    public string AddedIp { get; set; }
    public string AddedBy { get; set; }
    public string Status { get; set; }
    public static ProductDetails getProductsById(SqlConnection _con, int id)
    {
        ProductDetails pro = new ProductDetails();
        try
        {
            string query = "Select * from ProductDetails where Status=@Status and Id=@Id";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    pro.Id = Convert.ToInt32(Convert.ToString(dt.Rows[0]["Id"]));
                    pro.ProductName = Convert.ToString(dt.Rows[0]["ProductName"]);
                    pro.ProductUrl = Convert.ToString(dt.Rows[0]["ProductUrl"]);
                    pro.ThumbImage = Convert.ToString(dt.Rows[0]["ThumbImage"]);
                    pro.SKUCode = Convert.ToString(dt.Rows[0]["SKUCode"]);
                    pro.Broucher = Convert.ToString(dt.Rows[0]["Broucher"]);
                    pro.DatasheetName = Convert.ToString(dt.Rows[0]["DatasheetName"]);
                    pro.DatasheetLink = Convert.ToString(dt.Rows[0]["DatasheetLink"]);
                    pro.FullDesc = Convert.ToString(dt.Rows[0]["FullDesc"]);
                    pro.PageTitle = Convert.ToString(dt.Rows[0]["PageTitle"]);
                    pro.MetaKeys = Convert.ToString(dt.Rows[0]["MetaKeys"]);
                    pro.MetaDesc = Convert.ToString(dt.Rows[0]["MetaDesc"]);
                    pro.AddedOn = Convert.ToDateTime(Convert.ToString(dt.Rows[0]["AddedOn"]));
                    pro.AddedBy = Convert.ToString(dt.Rows[0]["AddedBy"]);
                    pro.AddedIp = Convert.ToString(dt.Rows[0]["AddedIp"]);
                    pro.Status = Convert.ToString(dt.Rows[0]["Status"]);
                   

                }
                else
                {
                    pro = null;
                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "getProductsById", ex.Message);
        }
        return pro;
    }
    public static int UpdateProducts(SqlConnection _con, ProductDetails cat)
    {
        int result = 0;
        try
        {
            string query = "Update ProductDetails Set ProductName=@ProductName,ProductUrl=@ProductUrl,ThumbImage=@ThumbImage,SKUCode=@SKUCode,Broucher=@Broucher,DatasheetName=@DatasheetName,DatasheetLink=@DatasheetLink,FullDesc=@FullDesc,PageTitle=@PageTitle,MetaKeys=@MetaKeys,MetaDesc=@MetaDesc,AddedOn=@AddedOn,AddedBy=@AddedBy,AddedIp=@AddedIp,Status=@Status Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = cat.Id;
                cmd.Parameters.AddWithValue("@ProductName", SqlDbType.NVarChar).Value = cat.ProductName;
                cmd.Parameters.AddWithValue("@ProductUrl", SqlDbType.NVarChar).Value = cat.ProductUrl;
                cmd.Parameters.AddWithValue("@ThumbImage", SqlDbType.NVarChar).Value = cat.ThumbImage;
                cmd.Parameters.AddWithValue("@SKUCode", SqlDbType.NVarChar).Value = cat.SKUCode;
                cmd.Parameters.AddWithValue("@Broucher", SqlDbType.NVarChar).Value = cat.Broucher;
                cmd.Parameters.AddWithValue("@DatasheetName", SqlDbType.NVarChar).Value = cat.DatasheetName;
                cmd.Parameters.AddWithValue("@DatasheetLink", SqlDbType.NVarChar).Value = cat.DatasheetLink;
                cmd.Parameters.AddWithValue("@FullDesc", SqlDbType.NVarChar).Value = cat.FullDesc;
                cmd.Parameters.AddWithValue("@PageTitle", SqlDbType.NVarChar).Value = cat.PageTitle;
                cmd.Parameters.AddWithValue("@MetaKeys", SqlDbType.NVarChar).Value = cat.MetaKeys;
                cmd.Parameters.AddWithValue("@MetaDesc", SqlDbType.NVarChar).Value = cat.MetaDesc;               
                cmd.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = cat.AddedBy;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.DateTime).Value = cat.AddedOn;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = cat.AddedIp;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                _con.Open();
                result = cmd.ExecuteNonQuery();
                _con.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UpdateProducts", ex.Message);
        }
        return result;
    }
    public static int InsertProducts(SqlConnection _con, ProductDetails cat)
    {
        int result = 0;


        try
        {
            string query = "Insert Into ProductDetails (ProductName,ProductUrl,ThumbImage,SKUCode,Broucher,DatasheetName,DatasheetLink,FullDesc,PageTitle,MetaKeys,MetaDesc,AddedBy,AddedOn,AddedIp,Status) values" +
                           "(@ProductName,@ProductUrl,@ThumbImage,@SKUCode,@Broucher,@DatasheetName,@DatasheetLink,@FullDesc,@PageTitle,@MetaKeys,@MetaDesc,@AddedBy,@AddedOn,@AddedIp,@Status)";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@ProductName", SqlDbType.NVarChar).Value = cat.ProductName;
                cmd.Parameters.AddWithValue("@ProductUrl", SqlDbType.NVarChar).Value = cat.ProductUrl;
                cmd.Parameters.AddWithValue("@ThumbImage", SqlDbType.NVarChar).Value = cat.ThumbImage;
                cmd.Parameters.AddWithValue("@SKUCode", SqlDbType.NVarChar).Value = cat.SKUCode;
                cmd.Parameters.AddWithValue("@Broucher", SqlDbType.NVarChar).Value = cat.Broucher;
                cmd.Parameters.AddWithValue("@DatasheetName", SqlDbType.NVarChar).Value = cat.DatasheetName;
                cmd.Parameters.AddWithValue("@DatasheetLink", SqlDbType.NVarChar).Value = cat.DatasheetLink;
                cmd.Parameters.AddWithValue("@FullDesc", SqlDbType.NVarChar).Value = cat.FullDesc;
                cmd.Parameters.AddWithValue("@PageTitle", SqlDbType.NVarChar).Value = cat.PageTitle;
                cmd.Parameters.AddWithValue("@MetaKeys", SqlDbType.NVarChar).Value = cat.MetaKeys;
                cmd.Parameters.AddWithValue("@MetaDesc", SqlDbType.NVarChar).Value = cat.MetaDesc;
                cmd.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = cat.AddedBy;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.DateTime).Value = cat.AddedOn;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = cat.AddedIp;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                _con.Open();
                result = cmd.ExecuteNonQuery();
                _con.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "InsertProducts", ex.Message);
        }
        return result;
    }
}
