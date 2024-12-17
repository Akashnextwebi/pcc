using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for VideoDetails
/// </summary>
public class VideoDetails
{
    public VideoDetails()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int Id { get; set; }
    public string VideoLink { get; set; }
    public string ThumbImage { get; set; }
    public DateTime AddedOn { get; set; }
    public string AddedIp {  get; set; }
    public string AddedBy {  get; set; }
    public string Status { get; set; }
    public static VideoDetails GetAllVideoDetailsWithId(SqlConnection conSQ, int id)
    {
        var cat = new VideoDetails();
        try
        {
            string query = "Select * from VideoDetails where Status='Active' and Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cat = (from DataRow dr in dt.Rows
                       select new VideoDetails()
                       {
                           Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                           VideoLink = Convert.ToString(dr["VideoLink"]),
                           ThumbImage = Convert.ToString(dr["ThumbImage"]),                       
                           AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                           AddedIp = Convert.ToString(dr["AddedIp"]),
                           AddedBy = Convert.ToString(dr["AddedBy"]),
                           Status = Convert.ToString(dr["Status"])
                       }).FirstOrDefault();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllVideoDetailsWithId", ex.Message);
        }
        return cat;
    }
    public static int AddVideoLink(SqlConnection conSQ, VideoDetails Cat)
    {
        int result = 0;
        try
        {
            string query = "Insert Into VideoDetails (VideoLink,ThumbImage,AddedOn,AddedBy,AddedIp,Status) values (@VideoLink,@ThumbImage,@AddedOn,@AddedBy,@AddedIp,@Status) select SCOPE_IDENTITY()";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@VideoLink", SqlDbType.NVarChar).Value = Cat.VideoLink;
                cmd.Parameters.AddWithValue("@ThumbImage", SqlDbType.NVarChar).Value = Cat.ThumbImage;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                cmd.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = Cat.AddedBy;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = CommonModel.IPAddress();
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = Cat.Status;

                conSQ.Open();
                result = Convert.ToInt32(cmd.ExecuteNonQuery());
                conSQ.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "AddVideoLink", ex.Message);
        }
        return result;
    }
    public static int UpdateVideoLink(SqlConnection conSQ, VideoDetails Cat)
    {
        int result = 0;
        try
        {
            string query = "Update VideoDetails Set VideoLink=@VideoLink,ThumbImage=@ThumbImage,AddedBy=@AddedBy,AddedOn=@AddedOn,AddedIp=@AddedIp ,Status=@Status Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = Cat.Id;
                cmd.Parameters.AddWithValue("@VideoLink", SqlDbType.NVarChar).Value = Cat.VideoLink;
                cmd.Parameters.AddWithValue("@ThumbImage", SqlDbType.NVarChar).Value = Cat.ThumbImage;
                cmd.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = Cat.AddedBy;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = CommonModel.IPAddress();
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = Cat.Status;
                conSQ.Open();
                result = cmd.ExecuteNonQuery();
                conSQ.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UpdateVideoLink", ex.Message);
        }
        return result;
    }
    public static List<VideoDetails> GetAllVideoLink(SqlConnection conSQ)
    {
        var ListOfVideos = new List<VideoDetails>();
        try
        {
            string query = "Select * from VideoDetails where Status=@Status Order by Id";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListOfVideos = (from DataRow dr in dt.Rows
                                    select new VideoDetails()
                                    {

                                        Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                        VideoLink = Convert.ToString(dr["VideoLink"]),
                                        ThumbImage = Convert.ToString(dr["ThumbImage"]),
                                        AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                        AddedIp = Convert.ToString(dr["AddedIp"]),
                                        AddedBy = Convert.ToString(dr["AddedBy"]),
                                        Status = Convert.ToString(dr["Status"])
                                    }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllVideoLink", ex.Message);
        }
        return ListOfVideos;
    }
    public static int DeleteVideoLink(SqlConnection conSQ, VideoDetails Cat)
    {
        int result = 0;
        try
        {
            string query = "Update VideoDetails Set Status=@Status, AddedOn=@AddedOn, AddedIp=@AddedIp Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = Cat.Id;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = Cat.AddedOn;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = Cat.AddedIp;
                conSQ.Open();
                result = cmd.ExecuteNonQuery();
                conSQ.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteVideoLink", ex.Message);
        }
        return result;
    }
}