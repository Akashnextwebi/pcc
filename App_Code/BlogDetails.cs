using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BlogDetails
/// </summary>
public class BlogDetails
{
    public BlogDetails()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int Id { get; set; }
    public string BlogTitle { get; set; }
    public string BlogURL { get; set; }
    public string PostedBy { get; set; }
    public string PostedOn { get; set; }
    public string FullDescription { get; set; }
    public string PageTitle { get; set; }
    public string MetaKeys { get; set; }
    public string MetaDescription { get; set; }
    public string BlogImage { get; set; }
    public string ThumbImage {  get; set; }
    public string Tag {  get; set; }
    public DateTime AddedOn { get; set; }
    public string AddedIp {  get; set; }
    public string AddedBy {  get; set; }
    public string Status {  get; set; }
    //Extra
    public string TotalCount {  get; set; }
   
    /// <summary>
    /// Retrieves all details of a blog entry with a specific ID from the database.
    /// </summary>
    /// <param name="conSQ">The SQL connection object.</param>
    /// <param name="id">The ID of the blog entry to retrieve.</param>
    /// <returns>A list of BlogDetails objects containing the details of the specified blog entry.</returns>

    public static List<BlogDetails> GetAllBlogDetailsWithId(SqlConnection conSQ, int id)
    {
        List<BlogDetails> categories = new List<BlogDetails>();
        try
        {
            string query = "Select * from BlogDetails where Status=@Status and Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                categories = (from DataRow dr in dt.Rows
                              select new BlogDetails()
                              {
                                  Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                  BlogImage = Convert.ToString(dr["BlogImage"]),
                                  ThumbImage = Convert.ToString(dr["ThumbImage"]),
                                  BlogTitle = Convert.ToString(dr["BlogTitle"]),
                                  BlogURL = Convert.ToString(dr["BlogURL"]),
                                  PostedBy = Convert.ToString(dr["PostedBy"]),
                                  PageTitle = Convert.ToString(dr["PageTitle"]),
                                  MetaKeys = Convert.ToString(dr["MetaKeys"]),
                                  MetaDescription = Convert.ToString(dr["MetaDescription"]),
                                  FullDescription = Convert.ToString(dr["FullDescription"]),
                                  Tag = Convert.ToString(dr["Tag"]),
                                  AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                  PostedOn = Convert.ToString(dr["PostedOn"]),
                                  AddedBy = Convert.ToString(dr["AddedBy"]),
                                  AddedIp = Convert.ToString(dr["AddedIp"]),
                                  Status = Convert.ToString(dr["Status"])
                              }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllBlogDetailsWithId", ex.Message);
        }
        return categories;
    }
    /// <summary>
    /// Updates the details of an existing blog entry in the database.
    /// </summary>
    /// <param name="conSQ">The SQL connection object.</param>
    /// <param name="cat">The BlogDetails object containing the updated details of the blog entry.</param>
    /// <returns>The number of rows affected by the update operation.</returns>

    public static int UpdateBlogDetails(SqlConnection conSQ, BlogDetails cat)
    {
        int result = 0;
        try
        {
            string query = "Update BlogDetails Set ThumbImage=@ThumbImage,BlogImage=@BlogImage,PostedOn = @PostedOn,PostedBy=@PostedBy,BlogTitle=@BlogTitle,BlogURL=@BlogURL,PageTitle=@PageTitle,MetaKeys=@MetaKeys,MetaDescription=@MetaDescription,FullDescription=@FullDescription,Tag=@Tag,AddedOn=@AddedOn,AddedBy=@AddedBy,AddedIp=@AddedIp Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = cat.Id;
                cmd.Parameters.AddWithValue("@ThumbImage", SqlDbType.NVarChar).Value = cat.ThumbImage;
                cmd.Parameters.AddWithValue("@BlogImage", SqlDbType.NVarChar).Value = cat.BlogImage;
                cmd.Parameters.AddWithValue("@BlogTitle", SqlDbType.NVarChar).Value = cat.BlogTitle;
                cmd.Parameters.AddWithValue("@BlogURL", SqlDbType.NVarChar).Value = cat.BlogURL;
                cmd.Parameters.AddWithValue("@PostedBy", SqlDbType.NVarChar).Value = cat.PostedBy;
                cmd.Parameters.AddWithValue("@PageTitle", SqlDbType.NVarChar).Value = cat.PageTitle;
                cmd.Parameters.AddWithValue("@MetaKeys", SqlDbType.NVarChar).Value = cat.MetaKeys;
                cmd.Parameters.AddWithValue("@MetaDescription", SqlDbType.NVarChar).Value = cat.MetaDescription;
                cmd.Parameters.AddWithValue("@FullDescription", SqlDbType.NVarChar).Value = cat.FullDescription;
                cmd.Parameters.AddWithValue("@Tag", SqlDbType.NVarChar).Value = cat.Tag;
                cmd.Parameters.AddWithValue("@PostedOn", SqlDbType.DateTime).Value = cat.PostedOn;
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UpdateBlogDetails", ex.Message);
        }
        return result;
    }
    /// <summary>
    /// Inserts the details of a new blog entry into the database.
    /// </summary>
    /// <param name="conSQ">The SQL connection object.</param>
    /// <param name="cat">The BlogDetails object containing the details of the new blog entry.</param>
    /// <returns>The ID of the newly inserted blog entry.</returns>

    public static int InsertBlogDetails(SqlConnection conSQ, BlogDetails cat)
    {
        int result = 0;

        try
        {
            string query = "Insert Into BlogDetails (ThumbImage,BlogImage,BlogTitle,BlogURL,PostedBy,PageTitle,MetaKeys,MetaDescription,FullDescription,Tag,PostedOn,AddedOn,AddedBy,AddedIp,Status) values" +
                           "(@ThumbImage,@BlogImage,@BlogTitle,@BlogURL,@PostedBy,@PageTitle,@MetaKeys,@MetaDescription,@FullDescription,@Tag,@PostedOn,@AddedOn,@AddedBy,@AddedIp,@Status)";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@ThumbImage", SqlDbType.NVarChar).Value = cat.ThumbImage;
                cmd.Parameters.AddWithValue("@BlogImage", SqlDbType.NVarChar).Value = cat.BlogImage;
                cmd.Parameters.AddWithValue("@BlogTitle", SqlDbType.NVarChar).Value = cat.BlogTitle;
                cmd.Parameters.AddWithValue("@BlogURL", SqlDbType.NVarChar).Value = cat.BlogURL;
                cmd.Parameters.AddWithValue("@PostedBy", SqlDbType.NVarChar).Value = cat.PostedBy;
                cmd.Parameters.AddWithValue("@PageTitle", SqlDbType.NVarChar).Value = cat.PageTitle;
                cmd.Parameters.AddWithValue("@MetaKeys", SqlDbType.NVarChar).Value = cat.MetaKeys;
                cmd.Parameters.AddWithValue("@MetaDescription", SqlDbType.NVarChar).Value = cat.MetaDescription;
                cmd.Parameters.AddWithValue("@FullDescription", SqlDbType.NVarChar).Value = cat.FullDescription;
                cmd.Parameters.AddWithValue("@Tag", SqlDbType.NVarChar).Value = cat.Tag;
                cmd.Parameters.AddWithValue("@PostedOn", SqlDbType.DateTime).Value = cat.PostedOn;
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "InsertBlogDetails", ex.Message);
        }
        return result;
    }
    /// <summary>
    /// Retrieves all details of all blog entries from the database.
    /// </summary>
    /// <param name="conDT">The SQL connection object.</param>
    /// <returns>A list of BlogDetails objects containing the details of all blog entries.</returns>

    public static List<BlogDetails> GetAllBlogDetails(SqlConnection conDT)
    {
        List<BlogDetails> categories = new List<BlogDetails>();
        try
        {
            string query = "Select *,(Select UserName from CreateUser Where UserGuid=BlogDetails.AddedBy) as UpdatedBy from BlogDetails where Status=@Status Order by Id ";
            using (SqlCommand cmd = new SqlCommand(query, conDT))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                categories = (from DataRow dr in dt.Rows
                              select new BlogDetails()
                              {
                                  Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                  BlogImage = Convert.ToString(dr["BlogImage"]),
                                  ThumbImage = Convert.ToString(dr["ThumbImage"]),
                                  BlogTitle = Convert.ToString(dr["BlogTitle"]),
                                  BlogURL = Convert.ToString(dr["BlogURL"]),
                                  PostedBy = Convert.ToString(dr["PostedBy"]),
                                  PageTitle = Convert.ToString(dr["PageTitle"]),
                                  MetaKeys = Convert.ToString(dr["MetaKeys"]),
                                  MetaDescription = Convert.ToString(dr["MetaDescription"]),
                                  FullDescription = Convert.ToString(dr["FullDescription"]),
                                  Tag = Convert.ToString(dr["Tag"]),
                                  AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                  PostedOn = Convert.ToString(dr["PostedOn"]),
                                  AddedBy = Convert.ToString(dr["AddedBy"]),
                                  AddedIp = Convert.ToString(dr["AddedIp"]),
                                  Status = Convert.ToString(dr["Status"])
                              }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllBlogDetails", ex.Message);
        }
        return categories;
    }
    /// <summary>
    /// Deletes the details of a blog entry from the database.
    /// </summary>
    /// <param name="conSQ">The SQL connection object.</param>
    /// <param name="cat">The BlogDetails object containing the details of the blog entry to be deleted.</param>
    /// <returns>The number of rows affected by the delete operation.</returns>

    public static int DeleteBlogDetails(SqlConnection conSQ, BlogDetails cat)
    {
        int result = 0;
        try
        {
            string query = "Update BlogDetails Set Status=@Status, AddedOn=@AddedOn, AddedIp=@AddedIp Where Id=@Id ";
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteBlogDetails", ex.Message);
        }
        return result;
    }
    public static int CheckExist(SqlConnection conSQ, string Name, string Url, int id)
    {
        try
        {

            var query = "Select Count(ID) as Cnt from BlogDetails where (BlogTitle=@BlogTitle OR BlogURL=@BlogURL) and (@Id=0 or id != @Id)  and Status !=@Status";
            SqlCommand cmd = new SqlCommand(query, conSQ);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@BlogTitle", SqlDbType.NVarChar).Value = Name;
            cmd.Parameters.AddWithValue("@BlogURL", SqlDbType.NVarChar).Value = Url;
            cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = id;
            //cmd.Parameters.AddWithValue("@Model", SqlDbType.NVarChar).Value = Model;
            cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                int cnt = 0;
                int.TryParse(Convert.ToString(dt.Rows[0]["Cnt"]), out cnt);
                return cnt;
            }
            return 0;

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "CheckExist", ex.Message);
            return 0;
        }
    }
    public static List<BlogDetails> GetAllBlogDetailsWithFilters(SqlConnection conSQ, string PgNo, string Plenght)
    {
        var BlogDetails = new List<BlogDetails>();
        try
        {
            int pageNo = (Convert.ToInt32(PgNo) - 1) * Convert.ToInt32(Plenght);


            string query = @"SELECT *,
       COUNT(*) OVER () AS TotalCount
FROM BlogDetails
WHERE  Status = 'Active'
ORDER BY Id DESC
OFFSET @PageNumber ROWS FETCH NEXT @PageLength ROWS ONLY;";

            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {


                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";
                cmd.Parameters.AddWithValue("@PageNumber", SqlDbType.NVarChar).Value = pageNo;
                cmd.Parameters.AddWithValue("@PageLength", SqlDbType.NVarChar).Value = Convert.ToInt32(Plenght);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BlogDetails = (from DataRow dr in dt.Rows
                               select new BlogDetails()
                               {
                                   Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                   BlogImage = Convert.ToString(dr["BlogImage"]),
                                   ThumbImage = Convert.ToString(dr["ThumbImage"]),
                                   BlogTitle = Convert.ToString(dr["BlogTitle"]),
                                   BlogURL = Convert.ToString(dr["BlogURL"]),
                                   PostedBy = Convert.ToString(dr["PostedBy"]),
                                   PageTitle = Convert.ToString(dr["PageTitle"]),
                                   MetaKeys = Convert.ToString(dr["MetaKeys"]),
                                   MetaDescription = Convert.ToString(dr["MetaDescription"]),
                                   FullDescription = Convert.ToString(dr["FullDescription"]),
                                   Tag = Convert.ToString(dr["Tag"]),
                                   AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                   PostedOn = Convert.ToString(dr["PostedOn"]),
                                   AddedBy = Convert.ToString(dr["AddedBy"]),
                                   AddedIp = Convert.ToString(dr["AddedIp"]),
                                   Status = Convert.ToString(dr["Status"]),
                                   TotalCount = Convert.ToString(dr["TotalCount"])

                               }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllBlogDetailsWithFilters", ex.Message);
        }
        return BlogDetails;
    }
    public static List<BlogDetails> GetAllBlogDetailsWithUrl(SqlConnection conSQ, string Url)
    {
        List<BlogDetails> categories = new List<BlogDetails>();
        try
        {
            string query = "Select  * from BlogDetails where Status=@Status and BlogURL=@BlogURL ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@BlogURL", SqlDbType.Int).Value = Url;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                categories = (from DataRow dr in dt.Rows
                              select new BlogDetails()
                              {
                                  Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                  BlogImage = Convert.ToString(dr["BlogImage"]),
                                  ThumbImage = Convert.ToString(dr["ThumbImage"]),
                                  BlogTitle = Convert.ToString(dr["BlogTitle"]),
                                  BlogURL = Convert.ToString(dr["BlogURL"]),
                                  PostedBy = Convert.ToString(dr["PostedBy"]),
                                  PageTitle = Convert.ToString(dr["PageTitle"]),
                                  MetaKeys = Convert.ToString(dr["MetaKeys"]),
                                  MetaDescription = Convert.ToString(dr["MetaDescription"]),
                                  FullDescription = Convert.ToString(dr["FullDescription"]),
                                  Tag = Convert.ToString(dr["Tag"]),
                                  AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                  PostedOn = Convert.ToString(dr["PostedOn"]),
                                  AddedBy = Convert.ToString(dr["AddedBy"]),
                                  AddedIp = Convert.ToString(dr["AddedIp"]),
                                  Status = Convert.ToString(dr["Status"]),
                                 
                              }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllBlogDetailsWithUrl", ex.Message);
        }
        return categories;
    }
    public static BlogDetails GetPrevBlogDetails(SqlConnection conSQ, int id)
    {
        BlogDetails categories = new BlogDetails();
        try
        {
            string query = "Select BlogTitle,BlogURL from BlogDetails where Status=@Status and id < @Id Order by Id Desc";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = id;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                categories = (from DataRow dr in dt.Rows
                              select new BlogDetails()
                              {
                                  BlogTitle = Convert.ToString(dr["BlogTitle"]),
                                  BlogURL = Convert.ToString(dr["BlogURL"]),
                              }).FirstOrDefault();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetPrevBlogDetails", ex.Message);
        }
        return categories;
    }
    public static BlogDetails GetNextBlogDetails(SqlConnection conSQ, int id)
    {
        BlogDetails categories = new BlogDetails();
        try
        {
            string query = "Select BlogTitle,BlogURL from BlogDetails where Status=@Status and id > @Id Order by Id";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = id;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                categories = (from DataRow dr in dt.Rows
                              select new BlogDetails()
                              {
                                  BlogTitle = Convert.ToString(dr["BlogTitle"]),
                                  BlogURL = Convert.ToString(dr["BlogURL"]),
                              }).FirstOrDefault();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetNextBlogDetails", ex.Message);
        }
        return categories;
    }
}