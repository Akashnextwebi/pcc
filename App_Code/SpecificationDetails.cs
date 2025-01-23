using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SpecificationDetails
/// </summary>
public class SpecificationDetails
{
    public SpecificationDetails()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int Id { get; set; }
    public string ProductGuid { get; set; }
    public string Title { get; set; }
    public string FullDesc { get; set; }
    public DateTime AddedOn { get; set; }
    public string AddedIp {  get; set; }
    public string AddedBy {  get; set; }
    public string Status { get; set; }
    /// <summary>
    /// Updates the details of a paper format in the database.
    /// </summary>
    /// <param name="conSQ">The SQL connection object.</param>
    /// <param name="Specification">A IternaryGallery object containing updated details of the paper format.</param>
    /// <returns>An integer representing the number of rows affected in the database.</returns>


    public static int UpdateSpecification(SqlConnection conSQ, SpecificationDetails spe)
    {
        int result = 0;
        try
        {
            string query = "Update SpecificationDetails Set ProductGuid=@ProductGuid,Title=@Title,FullDesc=@FullDesc,AddedOn=@AddedOn,AddedIp=@AddedIp,AddedBy=@AddedBy,Status=@Status Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = spe.Id;
                cmd.Parameters.AddWithValue("@ProductGuid", SqlDbType.NVarChar).Value = spe.ProductGuid;
                cmd.Parameters.AddWithValue("@Title", SqlDbType.NVarChar).Value = spe.Title;
                cmd.Parameters.AddWithValue("@FullDesc", SqlDbType.NVarChar).Value = spe.FullDesc;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = CommonModel.IPAddress();
                cmd.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = spe.AddedBy;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = spe.Status;
                conSQ.Open();
                result = cmd.ExecuteNonQuery();
                conSQ.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UpdateSpecification", ex.Message);
        }
        return result;
    }
    /// <summary>
    /// Adds a new paper format to the database.
    /// </summary>
    /// <param name="conSQ">The SQL connection object.</param>
    /// <param name="Specification">A IternaryGallery object containing details of the paper format to be added.</param>
    /// <returns>An integer representing the number of rows affected in the database.</returns>
    public static int AddSpecification(SqlConnection conSQ, SpecificationDetails spe)
    {
        int result = 0;
        try
        {
            string query = "Insert Into SpecificationDetails (ProductGuid,Title,FullDesc,AddedOn,AddedIP,AddedBy,Status) values (@ProductGuid,@Title,@FullDesc,@AddedOn,@AddedIP,@AddedBy,@Status) select SCOPE_IDENTITY()";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = spe.Id;
                cmd.Parameters.AddWithValue("@ProductGuid", SqlDbType.NVarChar).Value = spe.ProductGuid;
                cmd.Parameters.AddWithValue("@Title", SqlDbType.NVarChar).Value = spe.Title;
                cmd.Parameters.AddWithValue("@FullDesc", SqlDbType.NVarChar).Value = spe.FullDesc;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = CommonModel.IPAddress();
                cmd.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = spe.AddedBy;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = spe.Status;
                conSQ.Open();
                result = Convert.ToInt32(cmd.ExecuteScalar());
                conSQ.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "AddSpecification", ex.Message);
        }
        return result;
    }
    /// <summary>
    /// Retrieves all details of a paper format from the database based on the format's identifier.
    /// </summary>
    /// <param name="conSQ">The SQL connection object.</param>
    /// <param name="id">The identifier of the paper format.</param>
    /// <returns>A IternaryGallery object containing details of the specified paper format.</returns>

    public static SpecificationDetails GetAllSpecificationDetailsWithId(SqlConnection conSQ, int id)
    {
        var Specification = new SpecificationDetails();
        try
        {
            string query = "Select * from SpecificationDetails where Status='Active' and Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Specification = (from DataRow dr in dt.Rows
                                   select new SpecificationDetails()
                                   {
                                       Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                       ProductGuid = Convert.ToString(dr["ProductGuid"]),
                                       Title = Convert.ToString(dr["Title"]),
                                       FullDesc = Convert.ToString(dr["FullDesc"]),
                                       AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                       AddedIp = Convert.ToString(dr["AddedIP"]),
                                       AddedBy = Convert.ToString(dr["AddedBy"]),
                                       Status = Convert.ToString(dr["Status"])
                                   }).FirstOrDefault();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllSpecificationDetailsWithId", ex.Message);
        }
        return Specification;
    }
    /// <summary>
    /// Retrieves details of all paper formats from the database.
    /// </summary>
    /// <param name="conSQ">The SQL connection object.</param>
    /// <returns>A list of IternaryGallery objects containing details of all paper formats in the database.</returns>

    public static List<SpecificationDetails> GetAllSpecificationWithGuid(SqlConnection conSQ, string ProductGuid)
    {
        var ListOfSpecifications = new List<SpecificationDetails>();
        try
        {
            string query = "Select * from SpecificationDetails where Status=@Status and ProductGuid=@ProductGuid Order by Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                cmd.Parameters.AddWithValue("@ProductGuid", SqlDbType.NVarChar).Value = ProductGuid;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListOfSpecifications = (from DataRow dr in dt.Rows
                               select new SpecificationDetails()
                               {
                                   Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                   ProductGuid = Convert.ToString(dr["ProductGuid"]),
                                   Title = Convert.ToString(dr["Title"]),
                                   FullDesc = Convert.ToString(dr["FullDesc"]),
                                   AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                   AddedIp = Convert.ToString(dr["AddedIP"]),
                                   AddedBy = Convert.ToString(dr["AddedBy"]),
                                   Status = Convert.ToString(dr["Status"])
                               }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllSpecificationWithGuid", ex.Message);
        }
        return ListOfSpecifications;
    }
    /// <summary>
    /// Deletes a paper format from the database.
    /// </summary>
    /// <param name="conSQ">The SQL connection object.</param>
    /// <param name="Image">A IternaryGallery object containing details of the paper format to be deleted.</param>
    /// <returns>An integer representing the number of rows affected in the database.</returns>

    public static int DeleteSpecification(SqlConnection conSQ, SpecificationDetails spe)
    {
        int result = 0;
        try
        {
            string query = "Update SpecificationDetails Set Status=@Status, AddedOn=@AddedOn, AddedIp=@AddedIp Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = spe.Id;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = spe.AddedOn;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = spe.AddedIp;
                conSQ.Open();
                result = cmd.ExecuteNonQuery();
                conSQ.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteSpecification", ex.Message);
        }
        return result;
    }
    public static List<SpecificationDetails> GetAllSpecificationcntWithGuid(SqlConnection conSQ, string ProductGuid)
    {
        var ListOfspes = new List<SpecificationDetails>();
        try
        {
            string query = "Select * from SpecificationDetails where Status=@Status and ProductGuid=@ProductGuid Order by Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                cmd.Parameters.AddWithValue("@ProductGuid", SqlDbType.NVarChar).Value = ProductGuid;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListOfspes = (from DataRow dr in dt.Rows
                              select new SpecificationDetails()
                              {

                                  Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                  ProductGuid = Convert.ToString(dr["ProductGuid"]),
                                  Title = Convert.ToString(dr["Title"]),
                                  FullDesc = Convert.ToString(dr["FullDesc"]),
                                  AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                  AddedIp = Convert.ToString(dr["AddedIP"]),
                                  AddedBy = Convert.ToString(dr["AddedBy"]),
                                  Status = Convert.ToString(dr["Status"])
                              }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllSpecificationcntWithGuid", ex.Message);
        }
        return ListOfspes;
    }
    public static List<SpecificationDetails> GetAllSpecificationProductGuid(SqlConnection conSQ, string ProductGuid)
    {
        var ListOfDatasheets = new List<SpecificationDetails>();
        try
        {
            string query = "Select * from SpecificationDetails where Status=@Status and ProductGuid=@ProductGuid Order by Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                cmd.Parameters.AddWithValue("@ProductGuid", SqlDbType.NVarChar).Value = ProductGuid;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListOfDatasheets = (from DataRow dr in dt.Rows
                                    select new SpecificationDetails()
                                    {
                                        Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                        ProductGuid = Convert.ToString(dr["ProductGuid"]),
                                        Title = Convert.ToString(dr["Title"]),
                                        FullDesc = Convert.ToString(dr["FullDesc"]),
                                        AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                        AddedIp = Convert.ToString(dr["AddedIP"]),
                                        AddedBy = Convert.ToString(dr["AddedBy"]),
                                        Status = Convert.ToString(dr["Status"])
                                    }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllSpecificationProductGuid", ex.Message);
        }
        return ListOfDatasheets;
    }

}