using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for manageCapabilities
/// </summary>
public class manageCapabilities
{
    public manageCapabilities()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int Id { get; set; }
    public string ProductGuid { get; set; }
    public string Title { get; set; }
    public string ThumbImage { get; set; }
    public string FullDesc { get; set; }
    public DateTime AddedOn { get; set; }
    public string AddedBy {  get; set; }    
    public string AddedIp { get; set; }
    public string Status {  get; set; }


    public static manageCapabilities GetAllCapabilitiesDetailsWithId(SqlConnection conSQ, int id)
    {
        var Capabilities = new manageCapabilities();
        try
        {
            string query = "Select * from manageCapabilities where Status='Active' and Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Capabilities = (from DataRow dr in dt.Rows
                              select new manageCapabilities()
                              {
                                  Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                  ProductGuid = Convert.ToString(dr["ProductGuid"]),
                                  Title = Convert.ToString(dr["Title"]),
                                  ThumbImage = Convert.ToString(dr["ThumbImage"]),
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllCapabilitiesDetailsWithId", ex.Message);
        }
        return Capabilities;
    }
    public static int UpdateCapabilities(SqlConnection conSQ, manageCapabilities cap)
    {
        int result = 0;
        try
        {
            string query = "Update manageCapabilities Set ProductGuid=@ProductGuid,Title=@Title,ThumbImage=@ThumbImage,FullDesc=@FullDesc,AddedOn=@AddedOn,AddedIp=@AddedIp, AddedBy=@AddedBy,Status=@Status Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = cap.Id;
                cmd.Parameters.AddWithValue("@ProductGuid", SqlDbType.NVarChar).Value = cap.ProductGuid;
                cmd.Parameters.AddWithValue("@Title", SqlDbType.NVarChar).Value = cap.Title;
                cmd.Parameters.AddWithValue("@ThumbImage", SqlDbType.NVarChar).Value = cap.ThumbImage;
                cmd.Parameters.AddWithValue("@FullDesc", SqlDbType.NVarChar).Value = cap.FullDesc;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = CommonModel.IPAddress();
                cmd.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = cap.AddedBy;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = cap.Status;

                conSQ.Open();
                result = cmd.ExecuteNonQuery();
                conSQ.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UpdateCapabilities", ex.Message);
        }
        return result;
    }
    public static int AddCapabilities(SqlConnection conSQ, manageCapabilities cap)
    {
        int result = 0;
        try
        {
            string query = "Insert Into manageCapabilities (ProductGuid,Title,ThumbImage,FullDesc,AddedOn,AddedIP,AddedBy,Status) values (@ProductGuid,@Title,@ThumbImage,@FullDesc,@AddedOn,@AddedIP,@AddedBy,@Status) select SCOPE_IDENTITY()";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@ProductGuid", SqlDbType.NVarChar).Value = cap.ProductGuid;
                cmd.Parameters.AddWithValue("@Title", SqlDbType.NVarChar).Value = cap.Title;
                cmd.Parameters.AddWithValue("@ThumbImage", SqlDbType.NVarChar).Value = cap.ThumbImage;
                cmd.Parameters.AddWithValue("@FullDesc", SqlDbType.NVarChar).Value = cap.FullDesc;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = CommonModel.IPAddress();
                cmd.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = cap.AddedBy;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = cap.Status;
                conSQ.Open();
                result = Convert.ToInt32(cmd.ExecuteScalar());
                conSQ.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "AddCapabilities", ex.Message);
        }
        return result;
    }
    public static List<manageCapabilities> GetAllCapabilitiesWithGuid(SqlConnection conSQ, string ProductGuid)
    {
        var ListOFaqs = new List<manageCapabilities>();
        try
        {
            string query = "Select * from manageCapabilities where Status=@Status and ProductGuid=@ProductGuid Order by Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                cmd.Parameters.AddWithValue("@ProductGuid", SqlDbType.NVarChar).Value = ProductGuid;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListOFaqs = (from DataRow dr in dt.Rows
                             select new manageCapabilities()
                             {
                                 Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                 ProductGuid = Convert.ToString(dr["ProductGuid"]),
                                 Title = Convert.ToString(dr["Title"]),
                                 ThumbImage = Convert.ToString(dr["ThumbImage"]),
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllCapabilitiesWithGuid", ex.Message);
        }
        return ListOFaqs;
    }
    public static int DeleteCapabilities(SqlConnection conSQ, manageCapabilities faq)
    {
        int result = 0;
        try
        {
            string query = "Update manageCapabilities Set Status=@Status, AddedOn=@AddedOn, AddedIp=@AddedIp Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = faq.Id;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = faq.AddedOn;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = faq.AddedIp;
                conSQ.Open();
                result = cmd.ExecuteNonQuery();
                conSQ.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteCapabilities", ex.Message);
        }
        return result;
    }
    public static List<manageCapabilities> GetAllcapabilitiesWithGuid(SqlConnection conSQ, string ProductGuid)
    {
        var ListOfcaps = new List<manageCapabilities>();
        try
        {
            string query = "Select * from manageCapabilities where Status=@Status and ProductGuid=@ProductGuid Order by Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                cmd.Parameters.AddWithValue("@ProductGuid", SqlDbType.NVarChar).Value = ProductGuid;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListOfcaps = (from DataRow dr in dt.Rows
                               select new manageCapabilities()
                               {

                                   Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                   ProductGuid = Convert.ToString(dr["ProductGuid"]),
                                   Title = Convert.ToString(dr["Title"]),
                                   ThumbImage = Convert.ToString(dr["ThumbImage"]),
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllcapabilitiesWithGuid", ex.Message);
        }
        return ListOfcaps;
    }
    public static List<manageCapabilities> GetAllCapabilitiesProductGuid(SqlConnection conSQ, string ProductGuid)
    {
        var ListOfDatasheets = new List<manageCapabilities>();
        try
        {
            string query = "Select * from manageCapabilities where Status=@Status and ProductGuid=@ProductGuid Order by Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                cmd.Parameters.AddWithValue("@ProductGuid", SqlDbType.NVarChar).Value = ProductGuid;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListOfDatasheets = (from DataRow dr in dt.Rows
                                    select new manageCapabilities()
                                    {
                                        Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                        ProductGuid = Convert.ToString(dr["ProductGuid"]),
                                        Title = Convert.ToString(dr["Title"]),
                                        ThumbImage = Convert.ToString(dr["ThumbImage"]),
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllCapabilitiesProductGuid", ex.Message);
        }
        return ListOfDatasheets;
    }
}