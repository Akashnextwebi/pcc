using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductGallery
/// </summary>
public class ProductGallery
{
    public ProductGallery()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int Id { get; set; }
    public string ProductGuid { get; set; }
    public string ImageUrl { get; set; }
    public DateTime AddedOn { get; set; }
    public string AddedBy { get; set; }
    public string AddedIp { get; set; }
    public string Status { get; set; }

    public static int AddImage(SqlConnection conSQ, ProductGallery Image)
    {
        int result = 0;
        try
        {
            string query = "Insert Into ProductGallery (ImageUrl,ProductGuid,AddedOn,AddedIp,Status,AddedBy) values (@ImageUrl,@ProductGuid,@AddedOn,@AddedIp,@Status,@AddedBy) select SCOPE_IDENTITY()";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@ImageUrl", SqlDbType.NVarChar).Value = Image.ImageUrl;
                cmd.Parameters.AddWithValue("@ProductGuid", SqlDbType.NVarChar).Value = Image.ProductGuid;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = CommonModel.IPAddress();
                cmd.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = Image.AddedBy;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = Image.Status;
                conSQ.Open();
                result = Convert.ToInt32(cmd.ExecuteScalar());
                conSQ.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "AddImage", ex.Message);
        }
        return result;
    }
    public static int UpdateImage(SqlConnection conSQ, ProductGallery Image)
    {
        int result = 0;
        try
        {
            string query = "Update ProductGallery Set ImageUrl=@ImageUrl,ProductGuid=@ProductGuid,AddedOn=@AddedOn,AddedIp=@AddedIp, AddedBy=@AddedBy Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = Image.Id;
                cmd.Parameters.AddWithValue("@ImageUrl", SqlDbType.NVarChar).Value = Image.ImageUrl;
                cmd.Parameters.AddWithValue("@ProductGuid", SqlDbType.NVarChar).Value = Image.ProductGuid;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = CommonModel.IPAddress();
                cmd.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = Image.AddedBy;

                conSQ.Open();
                result = cmd.ExecuteNonQuery();
                conSQ.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UpdateImage", ex.Message);
        }
        return result;
    }
    public static List<ProductGallery> GetAllProductGalleryWithGuid(SqlConnection conSQ, string ProductGuid)
    {
        var ListOfBolgs = new List<ProductGallery>();
        try
        {
            string query = "Select * from ProductGallery where Status=@Status and ProductGuid=@ProductGuid Order by Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                cmd.Parameters.AddWithValue("@ProductGuid", SqlDbType.NVarChar).Value = ProductGuid;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListOfBolgs = (from DataRow dr in dt.Rows
                               select new ProductGallery()
                               {
                                   Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                   ProductGuid = Convert.ToString(dr["ProductGuid"]),
                                   ImageUrl = Convert.ToString(dr["ImageUrl"]),
                                   AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                   AddedIp = Convert.ToString(dr["AddedIP"]),
                                   AddedBy = Convert.ToString(dr["AddedBy"]),
                                   Status = Convert.ToString(dr["Status"])
                               }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllProductGallery", ex.Message);
        }
        return ListOfBolgs;
    }
    public static ProductGallery GetAllProductGalleryDetailsWithId(SqlConnection conSQ, int id)
    {
        var ProductGallery = new ProductGallery();
        try
        {
            string query = "Select * from ProductGallery where Status='Active' and Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ProductGallery = (from DataRow dr in dt.Rows
                                  select new ProductGallery()
                                  {
                                      Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                      ProductGuid = Convert.ToString(dr["ProductGuid"]),
                                      ImageUrl = Convert.ToString(dr["ImageUrl"]),
                                      AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                      AddedIp = Convert.ToString(dr["AddedIP"]),
                                      AddedBy = Convert.ToString(dr["AddedBy"]),
                                      Status = Convert.ToString(dr["Status"])
                                  }).FirstOrDefault();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAlImageDetailsWithId", ex.Message);
        }
        return ProductGallery;
    }
    public static int DeleteImage(SqlConnection conSQ, ProductGallery Image)
    {
        int result = 0;
        try
        {
            string query = "Update ProductGallery Set Status=@Status, AddedOn=@AddedOn, AddedIp=@AddedIp Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = Image.Id;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = Image.AddedOn;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = Image.AddedIp;
                conSQ.Open();
                result = cmd.ExecuteNonQuery();
                conSQ.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteImage", ex.Message);
        }
        return result;
    }
    public static List<ProductGallery> GetAllProductGallerytWithGuid(SqlConnection conSQ, string ProductGuid)
    {
        var ListOfGalleries = new List<ProductGallery>();
        try
        {
            string query = "Select * from ProductGallery where Status=@Status and ProductGuid=@ProductGuid Order by Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                cmd.Parameters.AddWithValue("@ProductGuid", SqlDbType.NVarChar).Value = ProductGuid;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListOfGalleries = (from DataRow dr in dt.Rows
                                   select new ProductGallery()
                                   {

                                       Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                       ProductGuid = Convert.ToString(dr["ProductGuid"]),
                                       ImageUrl = Convert.ToString(dr["ImageUrl"]),
                                       AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                       AddedIp = Convert.ToString(dr["AddedIP"]),
                                       AddedBy = Convert.ToString(dr["AddedBy"]),
                                       Status = Convert.ToString(dr["Status"])
                                   }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllProductGallerytWithGuid", ex.Message);
        }
        return ListOfGalleries;
    }
    public static List<ProductGallery> GetProductImage(SqlConnection conSQ)
    {
        List<ProductGallery> categories = new List<ProductGallery>();
        try
        {
            string query = "Select *,(Select UserName from CreateUser Where UserGuid=ProductGallery.AddedBy) as UpdatedBy from ProductGallery where status !='Deleted'";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                categories = (from DataRow dr in dt.Rows
                              select new ProductGallery()
                              {
                                  Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                  ProductGuid = Convert.ToString(dr["ProductGuid"]),
                                  ImageUrl = Convert.ToString(dr["ImageUrl"]),
                                  AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                  AddedIp = Convert.ToString(dr["AddedIP"]),
                                  AddedBy = Convert.ToString(dr["AddedBy"]),
                                  Status = Convert.ToString(dr["Status"])
                              }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetProductImage", ex.Message);
        }
        return categories;
    }
    public static List<ProductGallery> GetAllProductGalleryProductGuid(SqlConnection conSQ, string ProductGuid)
    {
        var ListOfPg = new List<ProductGallery>();
        try
        {
            string query = "Select * from ProductGallery where Status=@Status and ProductGuid=@ProductGuid Order by Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                cmd.Parameters.AddWithValue("@ProductGuid", SqlDbType.NVarChar).Value = ProductGuid;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListOfPg = (from DataRow dr in dt.Rows
                                    select new ProductGallery()
                                    {
                                        Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                        ProductGuid = Convert.ToString(dr["ProductGuid"]),
                                        ImageUrl = Convert.ToString(dr["ImageUrl"]),
                                        AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                        AddedIp = Convert.ToString(dr["AddedIP"]),
                                        AddedBy = Convert.ToString(dr["AddedBy"]),
                                        Status = Convert.ToString(dr["Status"])
                                    }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllProductGalleryProductGuid", ex.Message);
        }
        return ListOfPg;
    }
}
