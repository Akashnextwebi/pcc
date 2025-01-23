using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DatasheetGallery
/// </summary>
public class DatasheetGallery
{
    public DatasheetGallery()
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


    public static int AddImage(SqlConnection conSQ, DatasheetGallery Image)
    {
        int result = 0;
        try
        {
            string query = "Insert Into DatasheetGallery (ImageUrl,ProductGuid,AddedOn,AddedIp,Status,AddedBy) values (@ImageUrl,@ProductGuid,@AddedOn,@AddedIp,@Status,@AddedBy) select SCOPE_IDENTITY()";
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
    public static int UpdateImage(SqlConnection conSQ, DatasheetGallery Image)
    {
        int result = 0;
        try
        {
            string query = "Update DatasheetGallery Set ImageUrl=@ImageUrl,ProductGuid=@ProductGuid,AddedOn=@AddedOn,AddedIp=@AddedIp, AddedBy=@AddedBy Where Id=@Id ";
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
    public static List<DatasheetGallery> GetAllProductGalleryWithGuid(SqlConnection conSQ, string ProductGuid)
    {
        var ListOfBolgs = new List<DatasheetGallery>();
        try
        {
            string query = "Select * from DatasheetGallery where Status=@Status and ProductGuid=@ProductGuid Order by Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                cmd.Parameters.AddWithValue("@ProductGuid", SqlDbType.NVarChar).Value = ProductGuid;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListOfBolgs = (from DataRow dr in dt.Rows
                               select new DatasheetGallery()
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
    public static DatasheetGallery GetAllProductGalleryDetailsWithId(SqlConnection conSQ, int id)
    {
        var ProductGallery = new DatasheetGallery();
        try
        {
            string query = "Select * from DatasheetGallery where Status='Active' and Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ProductGallery = (from DataRow dr in dt.Rows
                                  select new DatasheetGallery()
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
    public static int DeleteImage(SqlConnection conVS, DatasheetGallery Image)
    {
        int result = 0;
        try
        {
            string query = "Update DatasheetGallery Set Status=@Status, AddedOn=@AddedOn, AddedIp=@AddedIp Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conVS))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = Image.Id;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = Image.AddedOn;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = Image.AddedIp;
                conVS.Open();
                result = cmd.ExecuteNonQuery();
                conVS.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteImage", ex.Message);
        }
        return result;
    }
    public static List<DatasheetGallery> GetAllGallerytWithGuid(SqlConnection conSQ, string ProductGuid)
    {
        var ListOfGalleries = new List<DatasheetGallery>();
        try
        {
            string query = "Select * from DatasheetGallery where Status=@Status and ProductGuid=@ProductGuid Order by Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                cmd.Parameters.AddWithValue("@ProductGuid", SqlDbType.NVarChar).Value = ProductGuid;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListOfGalleries = (from DataRow dr in dt.Rows
                                   select new DatasheetGallery()
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllGallerytWithGuid", ex.Message);
        }
        return ListOfGalleries;
    }
   
    public static List<DatasheetGallery> GetAllDatasheetGalleryProductGuid(SqlConnection conSQ, string ProductGuid)
    {
        var ListOfDatasheets = new List<DatasheetGallery>();
        try
        {
            string query = "Select * from DatasheetGallery where Status=@Status and ProductGuid=@ProductGuid Order by Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                cmd.Parameters.AddWithValue("@ProductGuid", SqlDbType.NVarChar).Value = ProductGuid;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListOfDatasheets = (from DataRow dr in dt.Rows
                               select new DatasheetGallery()
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllDatasheetGalleryProductGuid", ex.Message);
        }
        return ListOfDatasheets;
    }
}
