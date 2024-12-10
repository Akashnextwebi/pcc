using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for InvestorPdf
/// </summary>
public class InvestorPdf
{
    public InvestorPdf()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int Id {  get; set; }
    public string Investor { get; set; }
    public string PDFTitle { get; set; }
    public string PDF {  get; set; }
    public DateTime AddedOn { get; set; }
    public string AddedIp {  get; set; }
    public string AddedBy {  get; set; }
    public string Status {  get; set; }
    public string InvestorTitle { get; set; }

    public static InvestorPdf GetAllInvestorpdfDetailsWithId(SqlConnection conSQ, int id)
    {
        var cat = new InvestorPdf();
        try
        {
            string query = "Select * from InvestorPdf where Status='Active' and Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cat = (from DataRow dr in dt.Rows
                       select new InvestorPdf()
                       {
                           Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                           Investor = Convert.ToString(dr["Investor"]),
                           PDFTitle = Convert.ToString(dr["PDFTitle"]),
                           PDF = Convert.ToString(dr["PDF"]),
                           AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                           AddedIp = Convert.ToString(dr["AddedIp"]),
                           AddedBy = Convert.ToString(dr["AddedBy"]),
                           Status = Convert.ToString(dr["Status"])
                       }).FirstOrDefault();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllInvestorpdfDetailsWithId", ex.Message);
        }
        return cat;
    }
    public static int AddInvestorpdf(SqlConnection conSQ, InvestorPdf Cat)
    {
        int result = 0;
        try
        {
            string query = "Insert Into InvestorPdf (Investor,PDFTitle,PDF,AddedOn,AddedBy,AddedIp,Status) values (@Investor,@PDFTitle,@PDF,@AddedOn,@AddedBy,@AddedIp,@Status) select SCOPE_IDENTITY()";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Investor", SqlDbType.NVarChar).Value = Cat.Investor;
                cmd.Parameters.AddWithValue("@PDFTitle", SqlDbType.NVarChar).Value = Cat.PDFTitle;
                cmd.Parameters.AddWithValue("@PDF", SqlDbType.NVarChar).Value = Cat.PDF;
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "AddInvestorpdf", ex.Message);
        }
        return result;
    }
    public static int UpdateInvestorpdf(SqlConnection conSQ, InvestorPdf Cat)
    {
        int result = 0;
        try
        {
            string query = "Update InvestorPdf Set Investor=@Investor,PDFTitle=@PDFTitle,PDF=@PDF,AddedBy=@AddedBy,AddedOn=@AddedOn,AddedIp=@AddedIp ,Status=@Status Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = Cat.Id;
                cmd.Parameters.AddWithValue("@Investor", SqlDbType.NVarChar).Value = Cat.Investor;
                cmd.Parameters.AddWithValue("@PDFTitle", SqlDbType.NVarChar).Value = Cat.PDFTitle;
                cmd.Parameters.AddWithValue("@PDF", SqlDbType.NVarChar).Value = Cat.PDF;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = DateTime.UtcNow;
                cmd.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = Cat.AddedBy;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = CommonModel.IPAddress();
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = Cat.Status;
                conSQ.Open();
                result = cmd.ExecuteNonQuery();
                conSQ.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UpdateInvestorpdf", ex.Message);
        }
        return result;
    }
    public static List<InvestorPdf> GetAllInvestorPdf(SqlConnection conSQ)
    {
        var ListOfInvestorPdf = new List<InvestorPdf>();
        try
        {
            string query = "Select *,(Select UserName from CreateUser Where UserGuid=InvestorPdf.AddedBy) as UpdatedBy ,(select InvestorTitle from ManageInvestor where try_convert (nvarchar,ManageInvestor.Id) = InvestorPdf.Investor )as  InvestorTitle from InvestorPdf where Status ='Active'  Order by Id Desc";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListOfInvestorPdf = (from DataRow dr in dt.Rows
                                   select new InvestorPdf()
                                   {

                                       Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                       Investor = Convert.ToString(dr["Investor"]),
                                       PDFTitle = Convert.ToString(dr["PDFTitle"]),
                                       PDF = Convert.ToString(dr["PDF"]),
                                       InvestorTitle = Convert.ToString(dr["InvestorTitle"]),
                                       AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                       AddedIp = Convert.ToString(dr["AddedIp"]),
                                       AddedBy = Convert.ToString(dr["AddedBy"]),
                                       Status = Convert.ToString(dr["Status"])
                                   }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllInvestorPdf", ex.Message);
        }
        return ListOfInvestorPdf;
    }
    public static int DeleteInvestorPdf(SqlConnection conSQ, InvestorPdf Cat)
    {
        int result = 0;
        try
        {
            string query = "Update InvestorPdf Set Status=@Status, AddedOn=@AddedOn, AddedIp=@AddedIp Where Id=@Id ";
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteInvestorPdf", ex.Message);
        }
        return result;
    }
    public static int CheckExist(SqlConnection conSQ, string Name, int id)
    {
        try
        {

            var query = "Select Count(ID) as Cnt from InvestorPdf where (PDFTitle=@PDFTitle ) and (@Id=0 or id != @Id)  and Status !=@Status";
            SqlCommand cmd = new SqlCommand(query, conSQ);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@InvestorTitle", SqlDbType.NVarChar).Value = Name;
           // cmd.Parameters.AddWithValue("@InvestorUrl", SqlDbType.NVarChar).Value = Url;
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
}