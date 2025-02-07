using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for EnquiryDetails
/// </summary>
public class EnquiryDetails
{
    public EnquiryDetails()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int Id {  get; set; }
    public string Fullname { get; set; }
    public string Contact { get; set; }
    public string Email { get; set; }
    public string Message { get; set; }
    public DateTime AddedOn { get; set; }
    public string AddedIp { get; set; }
    public string Status { get; set; }


    public static int InsertEnquiry(SqlConnection conSQ, EnquiryDetails con)
    {
        int result = 0;

        try
        {
            string query = "Insert Into EnquiryDetails (Fullname,Contact,Email,Message,AddedOn, AddedIp,Status) values(@Fullname,@Contact,@Email,@Message,@AddedOn,@AddedIp,@Status) ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Fullname", SqlDbType.NVarChar).Value = con.Fullname;
                cmd.Parameters.AddWithValue("@Contact", SqlDbType.NVarChar).Value = con.Contact;
                cmd.Parameters.AddWithValue("@Email", SqlDbType.NVarChar).Value = con.Email;
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "InsertEnquiry", ex.Message);
        }
        return result;
    }
}