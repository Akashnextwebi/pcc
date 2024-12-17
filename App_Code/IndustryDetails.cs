using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IndustryDetails
/// </summary>
public class IndustryDetails
{
    public IndustryDetails()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int Id { get; set; }
    public string IndustryName { get; set; }
    public string IndustryUrl { get; set; }
    public DateTime AddedOn { get; set; }
    public string AddedIp { get; set; }
    public string AddedBy { get; set; }
    public string Status { get; set; }

    public static IndustryDetails GetAllIndustryDetailsWithId(SqlConnection conSQ, int id)
    {
        var cat = new IndustryDetails();
        try
        {
            string query = "Select * from IndustryDetails where Status='Active' and Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cat = (from DataRow dr in dt.Rows
                       select new IndustryDetails()
                       {
                           Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                           IndustryName = Convert.ToString(dr["IndustryName"]),
                           IndustryUrl = Convert.ToString(dr["IndustryUrl"]),
                           AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                           AddedIp = Convert.ToString(dr["AddedIp"]),
                           AddedBy = Convert.ToString(dr["AddedBy"]),
                           Status = Convert.ToString(dr["Status"])
                       }).FirstOrDefault();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllIndustryDetailsWithId", ex.Message);
        }
        return cat;
    }
    public static int AddIndustry(SqlConnection conSQ, IndustryDetails Cat)
    {
        int result = 0;
        try
        {
            string query = "Insert Into IndustryDetails (IndustryName,IndustryUrl,AddedOn,AddedBy,AddedIp,Status) values (@IndustryName,@IndustryUrl,@AddedOn,@AddedBy,@AddedIp,@Status) select SCOPE_IDENTITY()";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@IndustryName", SqlDbType.NVarChar).Value = Cat.IndustryName;
                cmd.Parameters.AddWithValue("@IndustryUrl", SqlDbType.NVarChar).Value = Cat.IndustryUrl;
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "AddIndustry", ex.Message);
        }
        return result;
    }
    public static int UpdateIndustry(SqlConnection conSQ, IndustryDetails Cat)
    {
        int result = 0;
        try
        {
            string query = "Update IndustryDetails Set IndustryName=@IndustryName,IndustryUrl=@IndustryUrl,AddedBy=@AddedBy,AddedOn=@AddedOn,AddedIp=@AddedIp ,Status=@Status Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = Cat.Id;
                cmd.Parameters.AddWithValue("@IndustryName", SqlDbType.NVarChar).Value = Cat.IndustryName;
                cmd.Parameters.AddWithValue("@IndustryUrl", SqlDbType.NVarChar).Value = Cat.IndustryUrl;
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UpdateIndustry", ex.Message);
        }
        return result;
    }
    public static List<IndustryDetails> GetAllIndustry(SqlConnection conSQ)
    {
        var ListOfIndustry = new List<IndustryDetails>();
        try
        {
            string query = "Select * from IndustryDetails where Status=@Status Order by Id";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListOfIndustry = (from DataRow dr in dt.Rows
                                   select new IndustryDetails()
                                   {

                                       Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                       IndustryName = Convert.ToString(dr["IndustryName"]),
                                       IndustryUrl = Convert.ToString(dr["IndustryUrl"]),
                                       AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                       AddedIp = Convert.ToString(dr["AddedIp"]),
                                       AddedBy = Convert.ToString(dr["AddedBy"]),
                                       Status = Convert.ToString(dr["Status"])
                                   }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllIndustry", ex.Message);
        }
        return ListOfIndustry;
    }
    public static int DeleteIndustry(SqlConnection conSQ, IndustryDetails Cat)
    {
        int result = 0;
        try
        {
            string query = "Update IndustryDetails Set Status=@Status, AddedOn=@AddedOn, AddedIp=@AddedIp Where Id=@Id ";
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteIndustry", ex.Message);
        }
        return result;
    }
    public static List<IndustryDetails> GetAllIndustries(SqlConnection conSQ)
    {
        var ListOfIndustry = new List<IndustryDetails>();
        try
        {
            string query = "Select *,(Select UserName from CreateUser Where UserGuid=IndustryDetails.AddedBy) as UpdatedBy from IndustryDetails where Status=@Status Order by Id Desc";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListOfIndustry = (from DataRow dr in dt.Rows
                                    select new IndustryDetails()
                                    {
                                        Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                        IndustryName = Convert.ToString(dr["IndustryName"]),
                                        IndustryUrl = Convert.ToString(dr["IndustryUrl"]),
                                        AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                        AddedIp = Convert.ToString(dr["AddedIp"]),
                                        AddedBy = Convert.ToString(dr["AddedBy"]),
                                        Status = Convert.ToString(dr["Status"])
                                    }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllIndustries", ex.Message);
        }
        return ListOfIndustry;
    }
    public static int CheckExist(SqlConnection conSQ, string Name, string Url, int id)
    {
        try
        {

            var query = "Select Count(ID) as Cnt from IndustryDetails where (IndustryName=@IndustryName OR IndustryUrl=@IndustryUrl) and (@Id=0 or id != @Id)  and Status !=@Status";
            SqlCommand cmd = new SqlCommand(query, conSQ);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@IndustryName", SqlDbType.NVarChar).Value = Name;
            cmd.Parameters.AddWithValue("@IndustryUrl", SqlDbType.NVarChar).Value = Url;
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


