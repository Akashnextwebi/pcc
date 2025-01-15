using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Activities.Expressions;

/// <summary>
/// Summary description for SeminarDetails
/// </summary>
public class SeminarDetails
{
    public SeminarDetails()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int Id { get; set; }
    public string SeminarTitle { get; set; }
    public string ThumbImage { get; set; }
    public string Tag { get; set; }
    public string VideoUrl { get; set; }
    public DateTime AddedOn { get; set; }
    public string AddedIp {  get; set; }
    public string AddedBy {  get; set; }
    public string Status {  get; set; }
    public static SeminarDetails GetAllSeminarDetailsWithId(SqlConnection conSQ, int id)
    {
        SeminarDetails categories = new SeminarDetails();
        try
        {
            string query = "Select * from SeminarDetails where Status=@Status and Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                categories = (from DataRow dr in dt.Rows
                              select new SeminarDetails()
                              {
                                  Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                  SeminarTitle = Convert.ToString(dr["SeminarTitle"]),
                                  ThumbImage = Convert.ToString(dr["ThumbImage"]),
                                  Tag = Convert.ToString(dr["Tag"]),
                                  VideoUrl = Convert.ToString(dr["VideoUrl"]),
                                  AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                  AddedBy = Convert.ToString(dr["AddedBy"]),
                                  AddedIp = Convert.ToString(dr["AddedIP"]),
                                  Status = Convert.ToString(dr["Status"])
                              }).FirstOrDefault();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllSeminarDetailsWithId", ex.Message);
        }
        return categories;
    }
    public static int UpdateSeminarDetails(SqlConnection conSQ, SeminarDetails cat)
    {
        int result = 0;
        try
        {
            string query = "Update SeminarDetails Set SeminarTitle=@SeminarTitle,ThumbImage=@ThumbImage,Tag=@Tag,VideoUrl=@VideoUrl,AddedOn=@AddedOn,AddedIp=@AddedIp,AddedBy=@AddedBy,Status=@Status Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = cat.Id;
                cmd.Parameters.AddWithValue("@SeminarTitle", SqlDbType.NVarChar).Value = cat.SeminarTitle;
                cmd.Parameters.AddWithValue("@ThumbImage", SqlDbType.NVarChar).Value = cat.ThumbImage;
                cmd.Parameters.AddWithValue("@Tag", SqlDbType.NVarChar).Value = cat.Tag;
                cmd.Parameters.AddWithValue("@VideoUrl", SqlDbType.NVarChar).Value = cat.VideoUrl;
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UpdateSeminarDetails", ex.Message);
        }
        return result;
    }
    public static int InsertSeminar(SqlConnection conSQ, SeminarDetails cat)
    {
        int result = 0;

        try
        {
            string query = "Insert Into SeminarDetails (SeminarTitle,ThumbImage,Tag,VideoUrl,AddedOn,AddedBy, AddedIp,Status) values(@SeminarTitle,@ThumbImage,@Tag,@VideoUrl,@AddedOn,@AddedBy,@AddedIp,@Status) ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@SeminarTitle", SqlDbType.NVarChar).Value = cat.SeminarTitle;
                cmd.Parameters.AddWithValue("@ThumbImage", SqlDbType.NVarChar).Value = cat.ThumbImage;
                cmd.Parameters.AddWithValue("@Tag", SqlDbType.NVarChar).Value = cat.Tag;
                cmd.Parameters.AddWithValue("@VideoUrl", SqlDbType.NVarChar).Value = cat.VideoUrl;
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "InsertSeminar", ex.Message);
        }
        return result;
    }
    public static List<SeminarDetails> GetSeminarDetails(SqlConnection conSQ)
    {
        List<SeminarDetails> zips = new List<SeminarDetails>();
        try
        {
            string query = "Select *,(Select UserName from CreateUser Where UserGuid=SeminarDetails.AddedBy) as UpdatedBy from SeminarDetails where Status !=@Status  Order by Id Desc ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                zips = (from DataRow dr in dt.Rows
                        select new SeminarDetails()
                        {
                            Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                            SeminarTitle = Convert.ToString(dr["SeminarTitle"]),
                            ThumbImage = Convert.ToString(dr["ThumbImage"]),
                            Tag = Convert.ToString(dr["Tag"]),
                            VideoUrl = Convert.ToString(dr["VideoUrl"]),
                            AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                            AddedBy = Convert.ToString(dr["AddedBy"]),
                            AddedIp = Convert.ToString(dr["AddedIP"]),
                            Status = Convert.ToString(dr["Status"])
                        }).ToList();

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetSeminarDetails", ex.Message);
        }
        return zips;
    }
    public static int DeleteSeminar(SqlConnection conSQ, SeminarDetails con)
    {
        int result = 0;

        try
        {
            string query = "Update SeminarDetails set Status=@Status Where Id=@Id ";
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteSeminar", ex.Message);
        }
        return result;
    }
    public static List<SeminarDetails> GetAllSeminars(SqlConnection _con)
    {
        List<SeminarDetails> seminar = new List<SeminarDetails>();
        try
        {
            string query = "Select *,(Select UserName from CreateUser Where UserGuid=SeminarDetails.AddedBy) as UpdatedBy from SeminarDetails where Status=@Status Order by Id ";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                seminar = (from DataRow dr in dt.Rows
                      select new SeminarDetails()
                      {
                          Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                          SeminarTitle = Convert.ToString(dr["SeminarTitle"]),
                          ThumbImage = Convert.ToString(dr["ThumbImage"]),
                          Tag = Convert.ToString(dr["Tag"]),
                          VideoUrl = Convert.ToString(dr["VideoUrl"]),
                          AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                          AddedBy = Convert.ToString(dr["AddedBy"]),
                          AddedIp = Convert.ToString(dr["AddedIP"]),
                          Status = Convert.ToString(dr["Status"])
                      }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllSeminars", ex.Message);
        }
        return seminar;
    }
}