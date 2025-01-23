using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ManageInvestor
/// </summary>
public class ManageInvestor
{
    public ManageInvestor()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int Id { get; set; }
    public string InvestorTitle { get; set; }
    public string InvestorUrl {  get; set; }
    public DateTime AddedOn { get; set; }
    public string AddedIp { get; set; }
    public string AddedBy { get; set; }
    public string Status { get; set; }


    public static ManageInvestor GetAllInvestorDetailsWithId(SqlConnection conSQ, int id)
    {
        var cat = new ManageInvestor();
        try
        {
            string query = "Select * from ManageInvestor where Status='Active' and Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cat = (from DataRow dr in dt.Rows
                       select new ManageInvestor()
                       {
                           Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                           InvestorTitle = Convert.ToString(dr["InvestorTitle"]),
                           InvestorUrl = Convert.ToString(dr["InvestorUrl"]),
                           AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                           AddedIp = Convert.ToString(dr["AddedIp"]),
                           AddedBy = Convert.ToString(dr["AddedBy"]),
                           Status = Convert.ToString(dr["Status"])
                       }).FirstOrDefault();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllInvestorDetailsWithId", ex.Message);
        }
        return cat;
    }
    public static int AddInvestor(SqlConnection conSQ, ManageInvestor Cat)
    {
        int result = 0;
        try
        {
            string query = "Insert Into ManageInvestor (InvestorTitle,InvestorUrl,AddedOn,AddedBy,AddedIp,Status) values (@InvestorTitle,@InvestorUrl,@AddedOn,@AddedBy,@AddedIp,@Status) select SCOPE_IDENTITY()";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@InvestorTitle", SqlDbType.NVarChar).Value = Cat.InvestorTitle;
                cmd.Parameters.AddWithValue("@InvestorUrl", SqlDbType.NVarChar).Value = Cat.InvestorUrl;
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "AddInvestor", ex.Message);
        }
        return result;
    }
    public static int UpdateInvestor(SqlConnection conSQ, ManageInvestor Cat)
    {
        int result = 0;
        try
        {
            string query = "Update ManageInvestor Set InvestorTitle=@InvestorTitle,InvestorUrl=@InvestorUrl,AddedBy=@AddedBy,AddedOn=@AddedOn,AddedIp=@AddedIp ,Status=@Status Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = Cat.Id;
                cmd.Parameters.AddWithValue("@InvestorTitle", SqlDbType.NVarChar).Value = Cat.InvestorTitle;
                cmd.Parameters.AddWithValue("@InvestorUrl", SqlDbType.NVarChar).Value = Cat.InvestorUrl;
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UpdateInvestor", ex.Message);
        }
        return result;
    }
    public static List<ManageInvestor> GetAllInvestor(SqlConnection conSQ)
    {
        var ListOfInvestors = new List<ManageInvestor>();
        try
        {
            string query = "Select * from ManageInvestor where Status=@Status Order by Id";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListOfInvestors = (from DataRow dr in dt.Rows
                                select new ManageInvestor()
                                {

                                    Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                    InvestorTitle = Convert.ToString(dr["InvestorTitle"]),
                                    InvestorUrl = Convert.ToString(dr["InvestorUrl"]),
                                    AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                    AddedIp = Convert.ToString(dr["AddedIp"]),
                                    AddedBy = Convert.ToString(dr["AddedBy"]),
                                    Status = Convert.ToString(dr["Status"])
                                }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllInvestor", ex.Message);
        }
        return ListOfInvestors;
    }
    public static int DeleteInvestor(SqlConnection conSQ, ManageInvestor Cat)
    {
        int result = 0;
        try
        {
            string query = "Update ManageInvestor Set Status=@Status, AddedOn=@AddedOn, AddedIp=@AddedIp Where Id=@Id ";
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteInvestor", ex.Message);
        }
        return result;
    }
    public static List<ManageInvestor> GetAllInvestorpdf(SqlConnection conSQ)
    {
        var ListOfInvestor = new List<ManageInvestor>();
        try
        {
            string query = "Select *,(Select UserName from CreateUser Where UserGuid=ManageInvestor.AddedBy) as UpdatedBy from ManageInvestor where Status=@Status Order by Id Desc";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListOfInvestor = (from DataRow dr in dt.Rows
                                    select new ManageInvestor()
                                    {
                                        Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                        InvestorTitle = Convert.ToString(dr["InvestorTitle"]),
                                        InvestorUrl = Convert.ToString(dr["InvestorUrl"]),
                                        AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                        AddedIp = Convert.ToString(dr["AddedIp"]),
                                        AddedBy = Convert.ToString(dr["AddedBy"]),
                                        Status = Convert.ToString(dr["Status"])
                                    }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllInvestorpdf", ex.Message);
        }
        return ListOfInvestor;
    }
    public static int CheckExist(SqlConnection conSQ, string Name, string Url, int id)
    {
        try
        {

            var query = "Select Count(ID) as Cnt from ManageInvestor where (InvestorTitle=@InvestorTitle OR InvestorUrl=@InvestorUrl) and (@Id=0 or id != @Id)  and Status !=@Status";
            SqlCommand cmd = new SqlCommand(query, conSQ);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@InvestorTitle", SqlDbType.NVarChar).Value = Name;
            cmd.Parameters.AddWithValue("@InvestorUrl", SqlDbType.NVarChar).Value = Url;
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
    public static List<ManageInvestor> GetAllInvestors(SqlConnection _con)
    {
        List<ManageInvestor> Investor = new List<ManageInvestor>();
        try
        {
            string query = "Select *,(Select UserName from CreateUser Where UserGuid=ManageInvestor.AddedBy) as UpdatedBy from ManageInvestor where Status=@Status Order by Id ";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Investor = (from DataRow dr in dt.Rows
                       select new ManageInvestor()
                       {
                           Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                           InvestorTitle = Convert.ToString(dr["InvestorTitle"]),
                           InvestorUrl = Convert.ToString(dr["InvestorUrl"]),
                           AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                           AddedIp = Convert.ToString(dr["AddedIp"]),
                           AddedBy = Convert.ToString(dr["AddedBy"]),
                           Status = Convert.ToString(dr["Status"])
                       }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllInvestors", ex.Message);
        }
        return Investor;
    }
    public static ManageInvestor getInvestordetailsByUrl(SqlConnection _con, string InvestorUrl)
    {
        ManageInvestor inv = new ManageInvestor();
        try
        {
            string query = "Select top 1 * from ManageInvestor where Status='Active' and InvestorUrl=@InvestorUrl";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@InvestorUrl", SqlDbType.Int).Value = InvestorUrl;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    inv.Id = Convert.ToInt32(Convert.ToString(dt.Rows[0]["Id"]));
                    inv.InvestorTitle = Convert.ToString(dt.Rows[0]["InvestorTitle"]);
                    inv.InvestorUrl = Convert.ToString(dt.Rows[0]["InvestorUrl"]);
                    inv.AddedOn = Convert.ToDateTime(Convert.ToString(dt.Rows[0]["AddedOn"]));
                    inv.AddedBy = Convert.ToString(dt.Rows[0]["AddedBy"]);
                    inv.AddedIp = Convert.ToString(dt.Rows[0]["AddedIp"]);
                    inv.Status = Convert.ToString(dt.Rows[0]["Status"]);

                }
                else
                {
                    inv = null;
                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "getInvestordetailsByUrl", ex.Message);
        }
        return inv;
    }

}