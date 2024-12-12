using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ContactUs
/// </summary>
public class ContactUs
{
    public ContactUs()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Message { get; set; }
    public DateTime AddedOn { get; set; }
    public string AddedIp {  get; set; }
    public string Status { get; set; }
    public static int InsertContactUs(SqlConnection conSQ, ContactUs con)
    {
        int result = 0;

        try
        {
            string query = "Insert Into ContactUs (Name,Email,Subject,Message,AddedOn, AddedIp,Status) values(@Name,@Email,@Subject,@Message,@AddedOn,@AddedIp,@Status) ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = con.Name;
                cmd.Parameters.AddWithValue("@Email", SqlDbType.NVarChar).Value = con.Email;
                cmd.Parameters.AddWithValue("@Subject", SqlDbType.NVarChar).Value = con.Subject;
                cmd.Parameters.AddWithValue("@Message", SqlDbType.NVarChar).Value = con.Message;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = con.AddedOn;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = con.AddedIp;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                conSQ.Open();
                result = cmd.ExecuteNonQuery();
                conSQ.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "InsertContactUs", ex.Message);
        }
        return result;
    }
    public static List<ContactUs> GetAllContact(SqlConnection _con)
    {
        List<ContactUs> categories = new List<ContactUs>();
        try
        {
            string query = "Select * from ContactUs  where Status !='Deleted'";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                categories = (from DataRow dr in dt.Rows
                              select new ContactUs()
                              {
                                  Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                  Name = Convert.ToString(dr["Name"]),
                                  Email = Convert.ToString(dr["Email"]),
                                  Subject = Convert.ToString(dr["Subject"]),
                                  Message = Convert.ToString(dr["Message"]),
                                  Status = Convert.ToString(dr["Status"]),
                                  AddedIp = Convert.ToString(dr["AddedIp"]),
                                  AddedOn = Convert.ToDateTime(dr["AddedOn"]),


                              }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllContact", ex.Message);
        }
        return categories;
    }
    public static int DeleteContact(SqlConnection _con, ContactUs cat)
    {
        int result = 0;
        try
        {
            string query = "Update ContactUs Set Status=@Status Where Id=@Id";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = cat.Id;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";
                _con.Open();
                result = cmd.ExecuteNonQuery();
                _con.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteContact", ex.Message);
        }
        return result;
    }
    //public static List<ContactUs> GetContactEnquiryById(SqlConnection conSQ, string id)
    //{
    //    List<ContactUs> zips = new List<ContactUs>();
    //    try
    //    {
    //        string query = "Select * from ContactUs where Status !=@Status and Id=@Id  Order by Id Desc ";
    //        using (SqlCommand cmd = new SqlCommand(query, conSQ))
    //        {
    //            cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";
    //            cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = id;
    //            SqlDataAdapter sda = new SqlDataAdapter(cmd);
    //            DataTable dt = new DataTable();
    //            sda.Fill(dt);
    //            zips = (from DataRow dr in dt.Rows
    //                    select new ContactUs()
    //                    {
    //                        Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
    //                        Name = Convert.ToString(dr["Name"]),
    //                        Email = Convert.ToString(dr["Email"]),
    //                        Subject = Convert.ToString(dr["Subject"]),
    //                        Message = Convert.ToString(dr["Message"]),
    //                        Status = Convert.ToString(dr["Status"]),
    //                        AddedIp = Convert.ToString(dr["AddedIp"]),
    //                        AddedOn = Convert.ToDateTime(dr["AddedOn"]),
    //                    }).ToList();

    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetContactEnquiryById", ex.Message);
    //    }
    //    return zips;
    //}
    public static ContactUs GetMessageById(SqlConnection conSQ, int id)
    {
        ContactUs categories = new ContactUs();
        try
        {
            string query = "Select * from Capability where Status=@Status and Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                categories = (from DataRow dr in dt.Rows
                              select new ContactUs()
                              {
                                  Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                  Name = Convert.ToString(dr["Name"]),
                                  Email = Convert.ToString(dr["Email"]),
                                  Subject = Convert.ToString(dr["Subject"]),
                                  Message = Convert.ToString(dr["Message"]),
                                  Status = Convert.ToString(dr["Status"]),
                                  AddedIp = Convert.ToString(dr["AddedIp"]),
                                  AddedOn = Convert.ToDateTime(dr["AddedOn"]),
                              }).FirstOrDefault();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetMessageById", ex.Message);
        }
        return categories;
    }
    public static string GetMessageById(SqlConnection conSQ, string id)
    {
        string message = null;
        try
        {
            string query = "SELECT TOP 1 Message FROM ContactUs WHERE Id = @Id AND Status != 'Deleted'";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                conSQ.Open();
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    message = result.ToString();
                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetMessageById", ex.Message);
        }
        finally
        {
            if (conSQ.State == ConnectionState.Open)
            {
                conSQ.Close();
            }
        }
        return message;
    }
}