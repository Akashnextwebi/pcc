using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ManageFeature
/// </summary>
public class ManageFeature
{
    public ManageFeature()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int Id {  get; set; }
    public string IndustryGuid { get; set; }
    public string Title { get; set; }
    public string FullDesc { get; set; }
    public string ThumbImage { get; set; }
    public DateTime AddedOn {  get; set; }
    public string AddedBy { get; set; }
    public string AddedIp { get; set; }
    public string Status { get; set; }


    public static int AddFeature(SqlConnection conSQ, ManageFeature Fea)
    {
        int result = 0;
        try
        {
            string query = "Insert Into ManageFeature (IndustryGuid,Title,FullDesc,ThumbImage,AddedOn,AddedIp,Status,AddedBy) values (@IndustryGuid,@Title,@FullDesc,@ThumbImage,@AddedOn,@AddedIp,@Status,@AddedBy) select SCOPE_IDENTITY()";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@IndustryGuid", SqlDbType.NVarChar).Value = Fea.IndustryGuid;
                cmd.Parameters.AddWithValue("@Title", SqlDbType.NVarChar).Value = Fea.Title;
                cmd.Parameters.AddWithValue("@FullDesc", SqlDbType.NVarChar).Value = Fea.FullDesc;
                cmd.Parameters.AddWithValue("@ThumbImage", SqlDbType.NVarChar).Value = Fea.ThumbImage;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = CommonModel.IPAddress();
                cmd.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = Fea.AddedBy;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = Fea.Status;
                conSQ.Open();
                result = Convert.ToInt32(cmd.ExecuteScalar());
                conSQ.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "AddFeature", ex.Message);
        }
        return result;
    }
    public static int UpdateFeature(SqlConnection conSQ, ManageFeature Fea)
    {
        int result = 0;
        try
        {
            string query = "Update ManageFeature Set IndustryGuid=@IndustryGuid,Title=@Title,FullDesc=@FullDesc,ThumbImage=@ThumbImage,AddedOn=@AddedOn,AddedIp=@AddedIp, AddedBy=@AddedBy Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = Fea.Id;
                cmd.Parameters.AddWithValue("@IndustryGuid", SqlDbType.NVarChar).Value = Fea.IndustryGuid;
                cmd.Parameters.AddWithValue("@Title", SqlDbType.NVarChar).Value = Fea.Title;
                cmd.Parameters.AddWithValue("@FullDesc", SqlDbType.NVarChar).Value = Fea.FullDesc;
                cmd.Parameters.AddWithValue("@ThumbImage", SqlDbType.NVarChar).Value = Fea.ThumbImage;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = CommonModel.IPAddress();
                cmd.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = Fea.AddedBy;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = Fea.Status;

                conSQ.Open();
                result = cmd.ExecuteNonQuery();
                conSQ.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UpdateFeature", ex.Message);
        }
        return result;
    }
    public static List<ManageFeature> GetAllFeatureWithGuid(SqlConnection conSQ, string IndustryGuid)
    {
        var ListOfFeatures= new List<ManageFeature>();
        try
        {
            string query = "Select * from ManageFeature where Status=@Status and IndustryGuid=@IndustryGuid Order by Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                cmd.Parameters.AddWithValue("@IndustryGuid", SqlDbType.NVarChar).Value = IndustryGuid;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListOfFeatures = (from DataRow dr in dt.Rows
                               select new ManageFeature()
                               {
                                   Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                   IndustryGuid = Convert.ToString(dr["IndustryGuid"]),
                                   Title = Convert.ToString(dr["Title"]),
                                   FullDesc = Convert.ToString(dr["FullDesc"]),
                                   ThumbImage = Convert.ToString(dr["ThumbImage"]),
                                   AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                   AddedIp = Convert.ToString(dr["AddedIP"]),
                                   AddedBy = Convert.ToString(dr["AddedBy"]),
                                   Status = Convert.ToString(dr["Status"])
                               }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllFeatureWithGuid", ex.Message);
        }
        return ListOfFeatures;
    }
    public static ManageFeature GetAllFeatureDetailsWithId(SqlConnection conSQ, int id)
    {
        var Feature = new ManageFeature();
        try
        {
            string query = "Select * from ManageFeature where Status='Active' and Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Feature = (from DataRow dr in dt.Rows
                                  select new ManageFeature()
                                  {
                                      Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                      IndustryGuid = Convert.ToString(dr["IndustryGuid"]),
                                      Title = Convert.ToString(dr["Title"]),
                                      FullDesc = Convert.ToString(dr["FullDesc"]),
                                      ThumbImage = Convert.ToString(dr["ThumbImage"]),
                                      AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                      AddedIp = Convert.ToString(dr["AddedIP"]),
                                      AddedBy = Convert.ToString(dr["AddedBy"]),
                                      Status = Convert.ToString(dr["Status"])
                                  }).FirstOrDefault();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllFeatureDetailsWithId", ex.Message);
        }
        return Feature;
    }
    public static int DeleteFeature(SqlConnection conSQ, ManageFeature Fea)
    {
        int result = 0;
        try
        {
            string query = "Update ManageFeature Set Status=@Status, AddedOn=@AddedOn, AddedIp=@AddedIp Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = Fea.Id;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = Fea.AddedOn;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = Fea.AddedIp;
                conSQ.Open();
                result = cmd.ExecuteNonQuery();
                conSQ.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteFeature", ex.Message);
        }
        return result;
    }
    public static List<ManageFeature> GetAllFeaturecntWithGuid(SqlConnection conSQ, string IndustryGuid)
    {
        var ListOfFea = new List<ManageFeature>();
        try
        {
            string query = "Select * from ManageFeature where Status=@Status and IndustryGuid=@IndustryGuid Order by Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                cmd.Parameters.AddWithValue("@IndustryGuid", SqlDbType.NVarChar).Value = IndustryGuid;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListOfFea = (from DataRow dr in dt.Rows
                              select new ManageFeature()
                              {

                                  Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                  IndustryGuid = Convert.ToString(dr["IndustryGuid"]),
                                  Title = Convert.ToString(dr["Title"]),
                                  FullDesc = Convert.ToString(dr["FullDesc"]),
                                  ThumbImage = Convert.ToString(dr["ThumbImage"]),
                                  AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                  AddedIp = Convert.ToString(dr["AddedIP"]),
                                  AddedBy = Convert.ToString(dr["AddedBy"]),
                                  Status = Convert.ToString(dr["Status"])
                              }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllFeaturecntWithGuid", ex.Message);
        }
        return ListOfFea;
    }
    public static List<ManageFeature> GetAllFeatureGuid(SqlConnection conSQ, string IndustryGuid)
    {
        var ListOfFeature = new List<ManageFeature>();
        try
        {
            string query = "Select * from ManageFeature where Status=@Status and IndustryGuid=@IndustryGuid Order by Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                cmd.Parameters.AddWithValue("@IndustryGuid", SqlDbType.NVarChar).Value = IndustryGuid;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListOfFeature = (from DataRow dr in dt.Rows
                                    select new ManageFeature()
                                    {
                                        Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                        IndustryGuid = Convert.ToString(dr["IndustryGuid"]),
                                        Title = Convert.ToString(dr["Title"]),
                                        FullDesc = Convert.ToString(dr["FullDesc"]),
                                        ThumbImage = Convert.ToString(dr["ThumbImage"]),
                                        AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                        AddedIp = Convert.ToString(dr["AddedIP"]),
                                        AddedBy = Convert.ToString(dr["AddedBy"]),
                                        Status = Convert.ToString(dr["Status"])
                                    }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllFeatureGuid", ex.Message);
        }
        return ListOfFeature;
    }
}