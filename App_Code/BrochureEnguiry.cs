using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BrochureEnguiry
/// </summary>
public class BrochureEnguiry
{
    public BrochureEnguiry()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Contact { get; set; }
    public string Status { get; set; }
    public DateTime AddedOn { get; set; }
    public string AddedIP { get; set; }
    public string AddedBy { get; set; }

    public static int InsertBroucherEnguiry(SqlConnection conSQ, BrochureEnguiry cat)
    {
        int result = 0;
        try
        {
            string cmdText = "Insert Into BrochureEnguiry (FullName,Email,Contact,AddedIP,AddedOn,AddedBy,Status) values(@FullName,@Email,@Contact,@AddedIP,@AddedOn,@AddedBy,@Status) ";
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, conSQ))
            {
                sqlCommand.Parameters.AddWithValue("@FullName", SqlDbType.NVarChar).Value = cat.FullName;
                sqlCommand.Parameters.AddWithValue("@Email", SqlDbType.NVarChar).Value = cat.Email;
                sqlCommand.Parameters.AddWithValue("@Contact", SqlDbType.NVarChar).Value = cat.Contact;
                sqlCommand.Parameters.AddWithValue("@AddedIP", SqlDbType.NVarChar).Value = cat.AddedIP;
                sqlCommand.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = cat.AddedOn;
                sqlCommand.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = cat.AddedBy;
                sqlCommand.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = cat.Status;
                conSQ.Open();
                result = sqlCommand.ExecuteNonQuery();
                conSQ.Close();
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "InsertBroucherEnguiry", ex.Message);
        }

        return result;
    }
    public static string GetBroucherPDF(SqlConnection conSQ, int Id)
    {
        string ResPDF = "";
        try
        {
            string query = "Select Broucher from productdetails where Id=@Id";
            SqlCommand cmd = new SqlCommand(query, conSQ);
            cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = Id;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                ResPDF = Convert.ToString(dt.Rows[0]["Broucher"]);
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetBroucherPDF", ex.Message);
        }
        return ResPDF;
    }
}