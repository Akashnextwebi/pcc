using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductCatalogue
/// </summary>
public class ProductCatalogue
{
    public ProductCatalogue()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int Id { get; set; }
    public string CatalogueName { get; set; }
    public string ThumbImage { get; set; }
    public string PDFLink { get; set; }
    public DateTime AddedOn { get; set; }
    public string AddedIp { get; set; }
    public string AddedBy { get; set; }
    public string Status { get; set;}
    public static ProductCatalogue GetAllCatalogueDetailsWithId(SqlConnection conSQ, int id)
    {
        ProductCatalogue categories = new ProductCatalogue();
        try
        {
            string query = "Select * from ProductCatalogue where Status=@Status and Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                categories = (from DataRow dr in dt.Rows
                              select new ProductCatalogue()
                              {
                                  Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                  CatalogueName = Convert.ToString(dr["CatalogueName"]),
                                  ThumbImage = Convert.ToString(dr["ThumbImage"]),
                                  PDFLink = Convert.ToString(dr["PDFLink"]),
                                  AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                  AddedBy = Convert.ToString(dr["AddedBy"]),
                                  AddedIp = Convert.ToString(dr["AddedIP"]),
                                  Status = Convert.ToString(dr["Status"])
                              }).FirstOrDefault();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllCatalogueDetailsWithId", ex.Message);
        }
        return categories;
    }
    public static int UpdateCatalogueDetails(SqlConnection conSQ, ProductCatalogue cat)
    {
        int result = 0;
        try
        {
            string query = "Update ProductCatalogue Set CatalogueName=@CatalogueName,ThumbImage=@ThumbImage,PDFLink=@PDFLink,AddedOn=@AddedOn,AddedIp=@AddedIp,AddedBy=@AddedBy,Status=@Status Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = cat.Id;
                cmd.Parameters.AddWithValue("@CatalogueName", SqlDbType.NVarChar).Value = cat.CatalogueName;
                cmd.Parameters.AddWithValue("@ThumbImage", SqlDbType.NVarChar).Value = cat.ThumbImage;
                cmd.Parameters.AddWithValue("@PDFLink", SqlDbType.NVarChar).Value = cat.PDFLink;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = cat.AddedOn;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = cat.AddedIp;
                cmd.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = cat.AddedBy;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                conSQ.Open();
                result = cmd.ExecuteNonQuery();
                conSQ.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UpdateCatalogueDetails", ex.Message);
        }
        return result;
    }
    public static int InsertCatalogue(SqlConnection conSQ, ProductCatalogue cat)
    {
        int result = 0;

        try
        {
            string query = "Insert Into ProductCatalogue (CatalogueName,ThumbImage,PDFLink,AddedOn,AddedBy, AddedIp,Status) values(@CatalogueName,@ThumbImage,@PDFLink,@AddedOn,@AddedBy,@AddedIp,@Status) ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@CatalogueName", SqlDbType.NVarChar).Value = cat.CatalogueName;
                cmd.Parameters.AddWithValue("@ThumbImage", SqlDbType.NVarChar).Value = cat.ThumbImage;
                cmd.Parameters.AddWithValue("@PDFLink", SqlDbType.NVarChar).Value = cat.PDFLink;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = cat.AddedOn;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = cat.AddedIp;
                cmd.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = cat.AddedBy;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                conSQ.Open();
                result = cmd.ExecuteNonQuery();
                conSQ.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "InsertCatalogue", ex.Message);
        }
        return result;
    }
    public static List<ProductCatalogue> GetCatalogueDetails(SqlConnection conSQ)
    {
        List<ProductCatalogue> zips = new List<ProductCatalogue>();
        try
        {
            string query = "Select *,(Select UserName from CreateUser Where UserGuid=ProductCatalogue.AddedBy) as UpdatedBy from ProductCatalogue where Status !=@Status  Order by Id Desc ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                zips = (from DataRow dr in dt.Rows
                        select new ProductCatalogue()
                        {
                            Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                            CatalogueName = Convert.ToString(dr["CatalogueName"]),
                            ThumbImage = Convert.ToString(dr["ThumbImage"]),
                            PDFLink = Convert.ToString(dr["PDFLink"]),
                            AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                            AddedBy = Convert.ToString(dr["AddedBy"]),
                            AddedIp = Convert.ToString(dr["AddedIP"]),
                            Status = Convert.ToString(dr["Status"])
                        }).ToList();

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetCatalogueDetails", ex.Message);
        }
        return zips;
    }
    public static int DeleteCatalogue(SqlConnection conSQ, ProductCatalogue con)
    {
        int result = 0;

        try
        {
            string query = "Update ProductCatalogue set Status=@Status Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";
                cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = con.Id;
                conSQ.Open();
                result = cmd.ExecuteNonQuery();
                conSQ.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteCatalogue", ex.Message);
        }
        return result;
    }
}