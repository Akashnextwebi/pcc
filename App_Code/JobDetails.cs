using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for JobDetails
/// </summary>
public class JobDetails
{
    public JobDetails()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int Id { get; set; }
    public string JobTitle { get; set; }
    public string JobUrl { get; set; }
    public DateTime PostedOn { get; set; }
    public string EmploymentType { get; set; }    
    public string JobLocation { get; set; }
    public string Education { get; set; }
    public string JobDescription { get; set; }
    public string KeyResponsibilities { get; set; }
    public string Experience { get; set; }
    public string Salary { get; set; }
    public string PageTitle { get; set; }
    public string MetaKeys { get; set; }
    public string MetaDesc { get; set; }
    public string ThumbImage { get; set; }
    public DateTime AddedOn { get; set; }
    public string AddedIp { get; set; }
    public string AddedBy { get; set; }
    public string Status {  get; set; }

    public static JobDetails GetJobDetailsById(SqlConnection _con, int id)
    {
        JobDetails Job = new JobDetails();
        try
        {
            string query = "Select top 1 * from JobDetails where Status='Active' and Id=@Id";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Job.Id = Convert.ToInt32(Convert.ToString(dt.Rows[0]["Id"]));
                    Job.JobTitle = Convert.ToString(dt.Rows[0]["JobTitle"]);
                    Job.JobUrl = Convert.ToString(dt.Rows[0]["JobUrl"]);
                    Job.PostedOn = Convert.ToDateTime(dt.Rows[0]["PostedOn"]);
                    Job.EmploymentType = Convert.ToString(dt.Rows[0]["EmploymentType"]);
                    Job.JobLocation = Convert.ToString(dt.Rows[0]["JobLocation"]);
                    Job.Education = Convert.ToString(dt.Rows[0]["Education"]);
                    Job.JobDescription = Convert.ToString(dt.Rows[0]["JobDescription"]);
                    Job.KeyResponsibilities = Convert.ToString(dt.Rows[0]["KeyResponsibilities"]);
                    Job.Salary = Convert.ToString(dt.Rows[0]["Salary"]);              
                    Job.Experience = Convert.ToString(dt.Rows[0]["Experience"]);
                    Job.ThumbImage = Convert.ToString(dt.Rows[0]["ThumbImage"]);
                    Job.PageTitle = Convert.ToString(dt.Rows[0]["PageTitle"]);
                    Job.MetaKeys = Convert.ToString(dt.Rows[0]["MetaKeys"]);
                    Job.MetaDesc = Convert.ToString(dt.Rows[0]["MetaDesc"]);
                    Job.AddedIp = Convert.ToString(dt.Rows[0]["AddedIp"]);
                    Job.AddedOn = Convert.ToDateTime(dt.Rows[0]["AddedOn"]);
                    Job.AddedBy = Convert.ToString(dt.Rows[0]["AddedBy"]);
                    Job.Status = Convert.ToString(dt.Rows[0]["Status"]);
                }
                else
                {
                    Job = null;
                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetJobDetailsById", ex.Message);
        }
        return Job;
    }
    public static int InsertJobDetails(SqlConnection _con, JobDetails cat)
    {
        int result = 0;

        try
        {
            string query = "Insert Into JobDetails (JobTitle,JobUrl,PostedOn,EmploymentType,JobLocation,Education,JobDescription,KeyResponsibilities,Salary,Experience,ThumbImage,PageTitle,MetaKeys,MetaDesc,AddedIp,AddedOn,AddedBy,Status) values " +
                "(@JobTitle,@JobUrl,@PostedOn,@EmploymentType,@JobLocation,@Education,@JobDescription,@KeyResponsibilities,@Salary,@Experience,@ThumbImage,@PageTitle,@MetaKeys,@MetaDesc,@AddedIp,@AddedOn,@AddedBy,@Status) ";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@JobTitle", SqlDbType.NVarChar).Value = cat.JobTitle;
                cmd.Parameters.AddWithValue("@JobUrl", SqlDbType.NVarChar).Value = cat.JobUrl;
                cmd.Parameters.AddWithValue("@PostedOn", SqlDbType.NVarChar).Value = cat.PostedOn;
                cmd.Parameters.AddWithValue("@EmploymentType", SqlDbType.DateTime).Value = cat.EmploymentType;
                cmd.Parameters.AddWithValue("@JobLocation", SqlDbType.NVarChar).Value = cat.JobLocation;
                cmd.Parameters.AddWithValue("@Education", SqlDbType.NVarChar).Value = cat.Education;  
                cmd.Parameters.AddWithValue("@JobDescription", SqlDbType.NVarChar).Value = cat.JobDescription;
                cmd.Parameters.AddWithValue("@KeyResponsibilities", SqlDbType.NVarChar).Value = cat.KeyResponsibilities;
                cmd.Parameters.AddWithValue("@Salary", SqlDbType.NVarChar).Value = cat.Salary;
                cmd.Parameters.AddWithValue("@Experience", SqlDbType.NVarChar).Value = cat.Experience;
                cmd.Parameters.AddWithValue("@ThumbImage", SqlDbType.NVarChar).Value = cat.ThumbImage;
                cmd.Parameters.AddWithValue("@PageTitle", SqlDbType.NVarChar).Value = cat.PageTitle;
                cmd.Parameters.AddWithValue("@MetaKeys", SqlDbType.NVarChar).Value = cat.MetaKeys;
                cmd.Parameters.AddWithValue("@MetaDesc", SqlDbType.NVarChar).Value = cat.MetaDesc;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = cat.AddedIp;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.DateTime).Value = cat.AddedOn;
                cmd.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = cat.AddedBy;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = cat.Status;

                _con.Open();
                result = cmd.ExecuteNonQuery();
                _con.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "InsertJobDetails", ex.Message);
        }
        return result;
    }
    public static int UpdateJobDetails(SqlConnection _con, JobDetails cat)
    {
        int result = 0;
        try
        {
            string query = "Update JobDetails Set JobTitle=@JobTitle,JobUrl=@JobUrl,PostedOn = @PostedOn,EmploymentType=@EmploymentType,JobLocation=@JobLocation,Education=@Education,MetaDesc=@MetaDesc,JobDescription=@JobDescription,KeyResponsibilities=@KeyResponsibilities,Salary=@Salary,ThumbImage=@ThumbImage,Experience=@Experience,PageTitle=@PageTitle,MetaKeys=@MetaKeys,AddedOn=@AddedOn,AddedBy=@AddedBy,AddedIp=@AddedIp,Status=@Status Where Id=@Id  ";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = cat.Id;
                cmd.Parameters.AddWithValue("@JobTitle", SqlDbType.NVarChar).Value = cat.JobTitle;
                cmd.Parameters.AddWithValue("@JobUrl", SqlDbType.NVarChar).Value = cat.JobUrl;
                cmd.Parameters.AddWithValue("@PostedOn", SqlDbType.NVarChar).Value = cat.PostedOn;
                cmd.Parameters.AddWithValue("@EmploymentType", SqlDbType.DateTime).Value = cat.EmploymentType;
                cmd.Parameters.AddWithValue("@JobLocation", SqlDbType.NVarChar).Value = cat.JobLocation;
                cmd.Parameters.AddWithValue("@Education", SqlDbType.NVarChar).Value = cat.Education;
                cmd.Parameters.AddWithValue("@JobDescription", SqlDbType.NVarChar).Value = cat.JobDescription;
                cmd.Parameters.AddWithValue("@KeyResponsibilities", SqlDbType.NVarChar).Value = cat.KeyResponsibilities;
                cmd.Parameters.AddWithValue("@Salary", SqlDbType.NVarChar).Value = cat.Salary;
                cmd.Parameters.AddWithValue("@Experience", SqlDbType.NVarChar).Value = cat.Experience;
                cmd.Parameters.AddWithValue("@ThumbImage", SqlDbType.NVarChar).Value = cat.ThumbImage;
                cmd.Parameters.AddWithValue("@PageTitle", SqlDbType.NVarChar).Value = cat.PageTitle;
                cmd.Parameters.AddWithValue("@MetaKeys", SqlDbType.NVarChar).Value = cat.MetaKeys;
                cmd.Parameters.AddWithValue("@MetaDesc", SqlDbType.NVarChar).Value = cat.MetaDesc;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = cat.AddedIp;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.DateTime).Value = cat.AddedOn;
                cmd.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = cat.AddedBy;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = cat.Status;

                _con.Open();
                result = cmd.ExecuteNonQuery();
                _con.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UpdateJobDetails", ex.Message);
        }
        return result;
    }
    public static List<JobDetails> GetAllJobDetails(SqlConnection _con)
    {
        List<JobDetails> categories = new List<JobDetails>();
        try
        {
            string query = "Select *,(Select UserName from CreateUser Where UserGuid=JobDetails.AddedBy) as UpdatedBy from JobDetails where Status=@Status Order by Id ";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                categories = (from DataRow dr in dt.Rows
                              select new JobDetails()
                              {
                                  Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                  JobTitle = Convert.ToString(dr["JobTitle"]),
                                  JobUrl = Convert.ToString(dr["JobUrl"]),
                                  PostedOn = Convert.ToDateTime(dr["PostedOn"]),
                                  EmploymentType = Convert.ToString(dr["EmploymentType"]),
                                  JobLocation = Convert.ToString(dr["JobLocation"]),
                                  Education = Convert.ToString(dr["Education"]),
                                  JobDescription = Convert.ToString(dr["JobDescription"]),
                                  KeyResponsibilities = Convert.ToString(dr["KeyResponsibilities"]),
                                  Salary = Convert.ToString(dr["Salary"]),
                                  Experience = Convert.ToString(dr["Experience"]),
                                  ThumbImage = Convert.ToString(dr["ThumbImage"]),
                                  PageTitle = Convert.ToString(dr["PageTitle"]),
                                  MetaKeys = Convert.ToString(dr["MetaKeys"]),
                                  MetaDesc = Convert.ToString(dr["MetaDesc"]),
                                  AddedIp = Convert.ToString(dr["AddedIp"]),
                                  AddedOn = Convert.ToDateTime(dr["AddedOn"]),
                                  AddedBy = Convert.ToString(dr["AddedBy"]),
                                  Status = Convert.ToString(dr["Status"]),
                              }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllJobBlogDetails", ex.Message);
        }
        return categories;
    }
    public static int DeleteJobDetails(SqlConnection _con, JobDetails cat)
    {
        int result = 0;
        try
        {
            string query = "Update JobDetails Set Status=@Status, AddedOn=@AddedOn, AddedIp=@AddedIp Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = cat.Id;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = cat.AddedOn;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = cat.AddedIp;
                _con.Open();
                result = cmd.ExecuteNonQuery();
                _con.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteJobDetails", ex.Message);
        }
        return result;
    }
}