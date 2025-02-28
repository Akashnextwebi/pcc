﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ApplyJobs
/// </summary>
public class ApplyJobs
{
    public ApplyJobs()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int Id { get; set; }
    public string Fullname { get; set; }
    public string Emailid { get; set; }
    public string Contactnumber { get; set; }
    public string Experience { get; set; }
    public string Location { get; set; }
    public string CurrentCompany { get; set; }
    public string Noticeperiod { get; set; }
    public string Resume { get; set; }
    public string Message { get; set; }
    public string Status { get; set; }
    public string AddedIp { get; set; }
    public DateTime AddedOn { get; set; }
    public int JobId { get; set; }
    public string JobTitle {  get; set; }

    public static int InsertApplyjobs(SqlConnection _con, ApplyJobs cat)
    {
        int result = 0;

        try
        {
            string query = "Insert Into ApplyJobs (Fullname,Emailid,Contactnumber,Experience,Location,CurrentCompany,JobId,JobTitle,Noticeperiod,Resume,Message,Status,AddedIp,AddedOn) values " +
                "(@Fullname,@Emailid,@Contactnumber,@Experience,@Location,@CurrentCompany,@JobId,@JobTitle,@Noticeperiod,@Resume,@Message,@Status,@AddedIp,@AddedOn) ";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@Fullname", SqlDbType.NVarChar).Value = cat.Fullname;
                cmd.Parameters.AddWithValue("@Emailid", SqlDbType.NVarChar).Value = cat.Emailid;
                cmd.Parameters.AddWithValue("@Contactnumber", SqlDbType.NVarChar).Value = cat.Contactnumber;
                cmd.Parameters.AddWithValue("@Experience", SqlDbType.NVarChar).Value = cat.Experience;
                cmd.Parameters.AddWithValue("@Location", SqlDbType.NVarChar).Value = cat.Location;
                cmd.Parameters.AddWithValue("@CurrentCompany", SqlDbType.NVarChar).Value = cat.CurrentCompany;
                cmd.Parameters.AddWithValue("@JobTitle", SqlDbType.NVarChar).Value = cat.JobTitle;
                cmd.Parameters.AddWithValue("@JobId", SqlDbType.NVarChar).Value = cat.JobId;
                cmd.Parameters.AddWithValue("@Noticeperiod", SqlDbType.NVarChar).Value = cat.Noticeperiod;
                cmd.Parameters.AddWithValue("@Resume", SqlDbType.NVarChar).Value = cat.Resume;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = cat.Status;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = cat.AddedIp;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = cat.AddedOn;             
                cmd.Parameters.AddWithValue("@Message", SqlDbType.NVarChar).Value = cat.Message;

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
    public static List<ApplyJobs> GetAllApplyjobs(SqlConnection _con)
    {
        List<ApplyJobs> categories = new List<ApplyJobs>();
        try
        {
            string query = "Select * from ApplyJobs  where Status !='Deleted' ORDER BY AddedOn DESC";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                categories = (from DataRow dr in dt.Rows
                              select new ApplyJobs()
                              {
                                  Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                  Fullname = Convert.ToString(dr["Fullname"]),
                                  Emailid = Convert.ToString(dr["Emailid"]),
                                  Contactnumber = Convert.ToString(dr["Contactnumber"]),
                                  Experience = Convert.ToString(dr["Experience"]),
                                  Location = Convert.ToString(dr["Location"]),
                                  Message = Convert.ToString(dr["Message"]),
                                  Status = Convert.ToString(dr["Status"]),
                                  CurrentCompany = Convert.ToString(dr["CurrentCompany"]),
                                  Noticeperiod = Convert.ToString(dr["Noticeperiod"]),
                                  Resume = Convert.ToString(dr["Resume"]),
                                  AddedIp = Convert.ToString(dr["AddedIp"]),
                                  AddedOn = Convert.ToDateTime(dr["AddedOn"]),
                                  JobTitle = Convert.ToString(dr["JobTitle"]),
                                  JobId = Convert.ToInt32(Convert.ToString(dr["JobId"])),
                              }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllApplyjobs", ex.Message);
        }
        return categories;
    }
    public static int DeleteApplyjobs(SqlConnection _con, ApplyJobs cat)
    {
        int result = 0;
        try
        {
            string query = "Update ApplyJobs Set Status=@Status, AddedOn=@AddedOn, AddedIp=@AddedIp Where Id=@Id";
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteApplyjobs", ex.Message);
        }
        return result;
    }
}