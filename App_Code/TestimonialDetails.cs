using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Drawing;

/// <summary>
/// Summary description for TestimonialDetails
/// </summary>
public class TestimonialDetails
{
    public TestimonialDetails()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int Id { get; set; } 
    public string Name { get; set; }
    public string Ratings { get; set; }
    public string TestimonialDesc { get; set; }
    public DateTime AddedOn { get; set; }   
    public string AddedIp {  get; set; }
    public string AddedBy { get; set; }

    public string Status { get; set; }
    /// <summary>
    /// Inserts a new testimonial into the database.
    /// </summary>
    /// <param name="conSQ">The SQL connection object.</param>
    /// <param name="con">The TestimonialDetails object containing the details of the testimonial to be added.</param>
    /// <returns>The number of rows affected by the insert operation.</returns>

    public static int InsertTestimonial(SqlConnection conSQ, TestimonialDetails con)
    {
        int result = 0;

        try
        {
            string query = "Insert Into TestimonialDetails (Name,Ratings,TestimonialDesc,AddedOn,AddedBy, AddedIp,Status) values(@Name,@Ratings,@TestimonialDesc,@AddedOn,@AddedBy, @AddedIp,@Status) ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = con.Name;
                cmd.Parameters.AddWithValue("@Ratings", SqlDbType.NVarChar).Value = con.Ratings;
                cmd.Parameters.AddWithValue("@TestimonialDesc", SqlDbType.NVarChar).Value = con.TestimonialDesc;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = con.AddedOn;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = con.AddedIp;
                cmd.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = con.AddedBy;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                conSQ.Open();
                result = cmd.ExecuteNonQuery();
                conSQ.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "InsertTestimonial", ex.Message);
        }
        return result;
    }

    /// <summary>
    /// Updates existing testimonial details in the database.
    /// </summary>
    /// <param name="conSQ">The SQL connection object.</param>
    /// <param name="cat">The TestimonialDetails object containing the updated details of the testimonial.</param>
    /// <returns>The number of rows affected by the update operation.</returns>

    public static int UpdateTestimonialDetails(SqlConnection conSQ, TestimonialDetails cat)
    {
        int result = 0;
        try
        {
            string query = "Update TestimonialDetails Set Name=@Name,Ratings=@Ratings,TestimonialDesc=@TestimonialDesc,AddedOn=@AddedOn,AddedIp=@AddedIp,AddedBy=@AddedBy Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = cat.Id;
                cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = cat.Name;
                cmd.Parameters.AddWithValue("@Ratings", SqlDbType.NVarChar).Value = cat.Ratings;
                cmd.Parameters.AddWithValue("@TestimonialDesc", SqlDbType.NVarChar).Value = cat.TestimonialDesc;
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UpdateTestimonialDetails", ex.Message);
        }
        return result;
    }
    /// <summary>
    /// Retrieves all testimonial details with a specific ID from the database.
    /// </summary>
    /// <param name="conSQ">The SQL connection object.</param>
    /// <param name="id">The ID of the testimonial details.</param>
    /// <returns>A TestimonialDetails object representing testimonial details.</returns>

    public static TestimonialDetails GetAllTestimonialDetailsWithId(SqlConnection conSQ, int id)
    {
        TestimonialDetails categories = new TestimonialDetails();
        try
        {
            string query = "Select * from TestimonialDetails where Status=@Status and Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                categories = (from DataRow dr in dt.Rows
                              select new TestimonialDetails()
                              {
                                  Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                  Name = Convert.ToString(dr["Name"]),
                                  Ratings = Convert.ToString(dr["Ratings"]),
                                  TestimonialDesc = Convert.ToString(dr["TestimonialDesc"]),
                                  AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                  AddedBy = Convert.ToString(dr["AddedBy"]),
                                  AddedIp = Convert.ToString(dr["AddedIP"]),
                                  Status = Convert.ToString(dr["Status"])
                              }).FirstOrDefault();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllBlogDetailsWithId", ex.Message);
        }
        return categories;
    }
    /// <summary>
    /// Deletes a testimonial from the database.
    /// </summary>
    /// <param name="conSQ">The SQL connection object.</param>
    /// <param name="con">The TestimonialDetails object containing the details of the testimonial to be deleted.</param>
    /// <returns>The number of rows affected by the delete operation.</returns>

    public static int DeleteTestimonial(SqlConnection conSQ, TestimonialDetails con)
    {
        int result = 0;

        try
        {
            string query = "Update TestimonialDetails set Status=@Status Where Id=@Id ";
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteTestimonial", ex.Message);
        }
        return result;
    }
    /// <summary>
    /// Retrieves all testimonial details from the database.
    /// </summary>
    /// <param name="conSQ">The SQL connection object.</param>
    /// <returns>A list of TestimonialDetails objects representing testimonial details.</returns>

    public static List<TestimonialDetails> GetTestimonialDetails(SqlConnection conSQ)
    {
        List<TestimonialDetails> zips = new List<TestimonialDetails>();
        try
        {
            string query = "Select *,(Select UserName from CreateUser Where UserGuid=TestimonialDetails.AddedBy) as UpdatedBy from TestimonialDetails where Status !=@Status  Order by Id Desc ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                zips = (from DataRow dr in dt.Rows
                        select new TestimonialDetails()
                        {
                            Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                            Name = Convert.ToString(dr["Name"]),
                            Ratings = Convert.ToString(dr["Ratings"]),
                            TestimonialDesc = Convert.ToString(dr["TestimonialDesc"]),
                            AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                            AddedBy = Convert.ToString(dr["UpdatedBy"]),
                            AddedIp = Convert.ToString(dr["AddedIP"]),
                            Status = Convert.ToString(dr["Status"])
                        }).ToList();

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetTestimonialDetails", ex.Message);
        }
        return zips;
    }
}