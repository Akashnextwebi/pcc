using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for WhitePaperDetails
/// </summary>
public class WhitePaperDetails
{
    public WhitePaperDetails()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int Id {  get; set; }
    public string WhitePaperTitle { get; set; }
    public string WhitePaperUrl { get; set; }
    public string Tag { get; set; }
    public string PostedOn { get; set; }
    public string PostedBy { get; set; }
    public string WhitePaperHeading { get; set; }
    public string FullDesc { get; set; }
    public string ThumbImage { get; set; }
    public string DetailImage { get; set; }
    public string BannerImage { get; set; }
    public string PageTitle { get; set; }
    public string MetaKeys { get; set; }
    public string MetaDesc { get; set; }
    public DateTime AddedOn { get; set; }
    public string AddedIp {  get; set; }
    public string AddedBy { get; set; }
    public string Status { get; set; }
    /// <summary>
    /// Retrieves all details of a Whitepaper entry with a specific ID from the database.
    /// </summary>
    /// <param name="conSQ">The SQL connection object.</param>
    /// <param name="id">The ID of the Whitepaper entry to retrieve.</param>
    /// <returns>A list of WhitePaperDetails objects containing the details of the specified Whitepaper entry.</returns>

    public static List<WhitePaperDetails> GetAllWhitepaperDetailsWithId(SqlConnection conSQ, int id)
    {
        List<WhitePaperDetails> categories = new List<WhitePaperDetails>();
        try
        {
            string query = "Select * from WhitePaperDetails where Status=@Status and Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                categories = (from DataRow dr in dt.Rows
                              select new WhitePaperDetails()
                              {
                                  Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                  WhitePaperTitle = Convert.ToString(dr["WhitePaperTitle"]),
                                  WhitePaperUrl = Convert.ToString(dr["WhitePaperUrl"]),
                                  Tag = Convert.ToString(dr["Tag"]),
                                  PostedOn = Convert.ToString(dr["PostedOn"]),
                                  PostedBy = Convert.ToString(dr["PostedBy"]),
                                  WhitePaperHeading = Convert.ToString(dr["WhitePaperHeading"]),
                                  FullDesc = Convert.ToString(dr["FullDesc"]),
                                  ThumbImage = Convert.ToString(dr["ThumbImage"]),
                                  DetailImage = Convert.ToString(dr["DetailImage"]),
                                  BannerImage = Convert.ToString(dr["BannerImage"]),
                                  PageTitle = Convert.ToString(dr["PageTitle"]),
                                  MetaKeys = Convert.ToString(dr["MetaKeys"]),
                                  MetaDesc = Convert.ToString(dr["MetaDesc"]),                   
                                  AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                  AddedBy = Convert.ToString(dr["AddedBy"]),
                                  AddedIp = Convert.ToString(dr["AddedIp"]),
                                  Status = Convert.ToString(dr["Status"])
                              }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllWhitepaperDetailsWithId", ex.Message);
        }
        return categories;
    }
    /// <summary>
    /// Updates the details of an existing Whitepaper entry in the database.
    /// </summary>
    /// <param name="conSQ">The SQL connection object.</param>
    /// <param name="cat">The WhitePaperDetails object containing the updated details of the Whitepaper entry.</param>
    /// <returns>The number of rows affected by the update operation.</returns>

    public static int UpdateWhitepaperDetails(SqlConnection conSQ, WhitePaperDetails cat)
    {
        int result = 0;
        try
        {
            string query = "Update WhitePaperDetails Set WhitePaperTitle=@WhitePaperTitle,WhitePaperUrl=@WhitePaperUrl,Tag = @Tag,PostedOn=@PostedOn,PostedBy=@PostedBy,WhitePaperHeading=@WhitePaperHeading,FullDesc=@FullDesc,ThumbImage=@ThumbImage,DetailImage=@DetailImage,BannerImage=@BannerImage,PageTitle=@PageTitle,MetaKeys=@MetaKeys,MetaDesc=@MetaDesc,AddedOn=@AddedOn,AddedBy=@AddedBy,AddedIp=@AddedIp,Status=@Status Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = cat.Id;
                cmd.Parameters.AddWithValue("@WhitePaperTitle", SqlDbType.NVarChar).Value = cat.WhitePaperTitle;
                cmd.Parameters.AddWithValue("@WhitePaperUrl", SqlDbType.NVarChar).Value = cat.WhitePaperUrl;
                cmd.Parameters.AddWithValue("@Tag", SqlDbType.NVarChar).Value = cat.Tag;
                cmd.Parameters.AddWithValue("@PostedOn", SqlDbType.NVarChar).Value = cat.PostedOn;
                cmd.Parameters.AddWithValue("@PostedBy", SqlDbType.NVarChar).Value = cat.PostedBy;
                cmd.Parameters.AddWithValue("@WhitePaperHeading", SqlDbType.NVarChar).Value = cat.WhitePaperHeading;
                cmd.Parameters.AddWithValue("@ThumbImage", SqlDbType.NVarChar).Value = cat.ThumbImage;
                cmd.Parameters.AddWithValue("@DetailImage", SqlDbType.NVarChar).Value = cat.DetailImage;
                cmd.Parameters.AddWithValue("@BannerImage", SqlDbType.NVarChar).Value = cat.BannerImage;
                cmd.Parameters.AddWithValue("@PageTitle", SqlDbType.NVarChar).Value = cat.PageTitle;
                cmd.Parameters.AddWithValue("@MetaKeys", SqlDbType.NVarChar).Value = cat.MetaKeys;
                cmd.Parameters.AddWithValue("@MetaDesc", SqlDbType.NVarChar).Value = cat.MetaDesc;
                cmd.Parameters.AddWithValue("@FullDesc", SqlDbType.NVarChar).Value = cat.FullDesc;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.DateTime).Value = cat.AddedOn;
                cmd.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = cat.AddedBy;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = cat.AddedIp;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                conSQ.Open();
                result = cmd.ExecuteNonQuery();
                conSQ.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UpdateWhitepaperDetails", ex.Message);
        }
        return result;
    }
    /// <summary>
    /// Inserts the details of a new Whitepaper entry into the database.
    /// </summary>
    /// <param name="conSQ">The SQL connection object.</param>
    /// <param name="cat">The WhitePaperDetails object containing the details of the new Whitepaper entry.</param>
    /// <returns>The ID of the newly inserted Whitepaper entry.</returns>

    public static int InsertWhitepaperDetails(SqlConnection conSQ, WhitePaperDetails cat)
    {
        int result = 0;

        try
        {
            string query = "Insert Into WhitePaperDetails (WhitePaperTitle,WhitePaperUrl,Tag,PostedOn,PostedBy,WhitePaperHeading,ThumbImage,DetailImage,BannerImage,PageTitle,MetaKeys,MetaDesc,FullDesc,AddedOn,AddedBy,AddedIp,Status) values" +
                           "(@WhitePaperTitle,@WhitePaperUrl,@Tag,@PostedOn,@PostedBy,@WhitePaperHeading,@ThumbImage,@DetailImage,@BannerImage,@PageTitle,@MetaKeys,@MetaDesc,@FullDesc,@AddedOn,@AddedBy,@AddedIp,@Status)";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@WhitePaperTitle", SqlDbType.NVarChar).Value = cat.WhitePaperTitle;
                cmd.Parameters.AddWithValue("@WhitePaperUrl", SqlDbType.NVarChar).Value = cat.WhitePaperUrl;
                cmd.Parameters.AddWithValue("@Tag", SqlDbType.NVarChar).Value = cat.Tag;
                cmd.Parameters.AddWithValue("@PostedOn", SqlDbType.NVarChar).Value = cat.PostedOn;
                cmd.Parameters.AddWithValue("@PostedBy", SqlDbType.NVarChar).Value = cat.PostedBy;
                cmd.Parameters.AddWithValue("@WhitePaperHeading", SqlDbType.NVarChar).Value = cat.WhitePaperHeading;
                cmd.Parameters.AddWithValue("@ThumbImage", SqlDbType.NVarChar).Value = cat.ThumbImage;
                cmd.Parameters.AddWithValue("@DetailImage", SqlDbType.NVarChar).Value = cat.DetailImage;
                cmd.Parameters.AddWithValue("@BannerImage", SqlDbType.NVarChar).Value = cat.BannerImage;
                cmd.Parameters.AddWithValue("@PageTitle", SqlDbType.NVarChar).Value = cat.PageTitle;
                cmd.Parameters.AddWithValue("@MetaKeys", SqlDbType.NVarChar).Value = cat.MetaKeys;
                cmd.Parameters.AddWithValue("@MetaDesc", SqlDbType.NVarChar).Value = cat.MetaDesc;
                cmd.Parameters.AddWithValue("@FullDesc", SqlDbType.NVarChar).Value = cat.FullDesc;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.DateTime).Value = cat.AddedOn;
                cmd.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = cat.AddedBy;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = cat.AddedIp;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                conSQ.Open();
                result = cmd.ExecuteNonQuery();
                conSQ.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "InsertWhitepaperDetails", ex.Message);
        }
        return result;
    }
    /// <summary>
    /// Retrieves all details of all Whitepaper entries from the database.
    /// </summary>
    /// <param name="conSQ">The SQL connection object.</param>
    /// <returns>A list of WhitePaperDetails objects containing the details of all Whitepaper entries.</returns>

    public static List<WhitePaperDetails> GetAllWhitepaperDetails(SqlConnection conSQ)
    {
        List<WhitePaperDetails> categories = new List<WhitePaperDetails>();
        try
        {
            string query = "Select *,(Select UserName from CreateUser Where UserGuid=WhitePaperDetails.AddedBy) as UpdatedBy from WhitePaperDetails where Status=@Status Order by Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                categories = (from DataRow dr in dt.Rows
                              select new WhitePaperDetails()
                              {
                                  Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                  WhitePaperTitle = Convert.ToString(dr["WhitePaperTitle"]),
                                  WhitePaperUrl = Convert.ToString(dr["WhitePaperUrl"]),
                                  Tag = Convert.ToString(dr["Tag"]),
                                  PostedOn = Convert.ToString(dr["PostedOn"]),
                                  PostedBy = Convert.ToString(dr["PostedBy"]),
                                  WhitePaperHeading = Convert.ToString(dr["WhitePaperHeading"]),
                                  FullDesc = Convert.ToString(dr["FullDesc"]),
                                  ThumbImage = Convert.ToString(dr["ThumbImage"]),
                                  DetailImage = Convert.ToString(dr["DetailImage"]),
                                  BannerImage = Convert.ToString(dr["BannerImage"]),
                                  PageTitle = Convert.ToString(dr["PageTitle"]),
                                  MetaKeys = Convert.ToString(dr["MetaKeys"]),
                                  MetaDesc = Convert.ToString(dr["MetaDesc"]),
                                  AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                  AddedBy = Convert.ToString(dr["AddedBy"]),
                                  AddedIp = Convert.ToString(dr["AddedIp"]),
                                  Status = Convert.ToString(dr["Status"])
                              }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllWhitepaperDetails", ex.Message);
        }
        return categories;
    }
    /// <summary>
    /// Deletes the details of a Whitepaper entry from the database.
    /// </summary>
    /// <param name="conSQ">The SQL connection object.</param>
    /// <param name="cat">The WhitePaperDetails object containing the details of the Whitepaper entry to be deleted.</param>
    /// <returns>The number of rows affected by the delete operation.</returns>

    public static int DeleteWhitepaperDetails(SqlConnection conSQ, WhitePaperDetails cat)
    {
        int result = 0;
        try
        {
            string query = "Update WhitePaperDetails Set Status=@Status, AddedOn=@AddedOn, AddedIp=@AddedIp Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = cat.Id;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = cat.AddedOn;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = cat.AddedIp;
                conSQ.Open();
                result = cmd.ExecuteNonQuery();
                conSQ.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteWhitepaperDetails", ex.Message);
        }
        return result;
    }
}