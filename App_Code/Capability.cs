using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Capability
/// </summary>
public class Capability
{
    public Capability()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int Id {  get; set; }
    public string CapabilityName { get; set; }
    public string CapabilityUrl { get; set; }
    public string BannerTitle {  get; set; }
    public string DescHeading {  get; set; }
    public string FullDesc { get; set; }
    public string CompetenciesOrder {  get; set; }
    public string BannerImage { get; set; }
    public DateTime AddedOn { get; set; }
    public string AddedIp {  get; set; }
    public string AddedBy { get; set; }
    public string Status { get; set; }
   
    


    public static Capability GetAllCapabilityDetailsWithId(SqlConnection conSQ, int id)
    {
        Capability categories = new Capability();
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
                              select new Capability()
                              {
                                  Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                  CapabilityName = Convert.ToString(dr["CapabilityName"]),
                                  CapabilityUrl = Convert.ToString(dr["CapabilityUrl"]),
                                  BannerTitle = Convert.ToString(dr["BannerTitle"]),
                                  DescHeading = Convert.ToString(dr["DescHeading"]),
                                  FullDesc = Convert.ToString(dr["FullDesc"]),
                                  CompetenciesOrder = Convert.ToString(dr["CompetenciesOrder"]),
                                  BannerImage = Convert.ToString(dr["BannerImage"]),
                                  AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                  AddedBy = Convert.ToString(dr["AddedBy"]),
                                  AddedIp = Convert.ToString(dr["AddedIp"]),
                                  Status = Convert.ToString(dr["Status"])
                              }).FirstOrDefault();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllCapabilityDetailsWithId", ex.Message);
        }
        return categories;
    }
   
    public int UpdateCapabilityDetails(SqlConnection conSQ, Capability cat)
    {
        
        int result = 0;
        try
        {
            string query = "Update Capability Set CapabilityName=@CapabilityName,CapabilityUrl=@CapabilityUrl,BannerTitle=@BannerTitle,DescHeading=@DescHeading,FullDesc=@FullDesc,CompetenciesOrder=@CompetenciesOrder,BannerImage=@BannerImage,AddedOn=@AddedOn,AddedIp=@AddedIp,AddedBy=@AddedBy,Status=@Status Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = cat.Id;
                cmd.Parameters.AddWithValue("@CapabilityName", SqlDbType.NVarChar).Value = cat.CapabilityName;
                cmd.Parameters.AddWithValue("@CapabilityUrl", SqlDbType.NVarChar).Value = cat.CapabilityUrl;
                cmd.Parameters.AddWithValue("@BannerTitle", SqlDbType.NVarChar).Value = cat.BannerTitle;
                cmd.Parameters.AddWithValue("@DescHeading", SqlDbType.NVarChar).Value = cat.DescHeading;
                cmd.Parameters.AddWithValue("@FullDesc", SqlDbType.NVarChar).Value = cat.FullDesc;
                cmd.Parameters.AddWithValue("@CompetenciesOrder", SqlDbType.NVarChar).Value = cat.CompetenciesOrder;
                cmd.Parameters.AddWithValue("@BannerImage", SqlDbType.NVarChar).Value = cat.BannerImage;
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UpdateCapabilityDetails", ex.Message);
        }
        return result;
    }
    public static int InsertCapability(SqlConnection conSQ, Capability cat)
    {
        int result = 0;

        try
        {
            string query = "Insert Into Capability (CapabilityName,CapabilityUrl,BannerTitle,DescHeading,FullDesc,CompetenciesOrder,BannerImage,AddedOn,AddedBy, AddedIp,Status) values(@CapabilityName,@CapabilityUrl,@BannerTitle,@DescHeading,@FullDesc,@CompetenciesOrder,@BannerImage,@AddedOn,@AddedBy,@AddedIp,@Status) ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@CapabilityName", SqlDbType.NVarChar).Value = cat.CapabilityName;
                cmd.Parameters.AddWithValue("@CapabilityUrl", SqlDbType.NVarChar).Value = cat.CapabilityUrl;
                cmd.Parameters.AddWithValue("@BannerTitle", SqlDbType.NVarChar).Value = cat.BannerTitle;
                cmd.Parameters.AddWithValue("@DescHeading", SqlDbType.NVarChar).Value = cat.DescHeading;
                cmd.Parameters.AddWithValue("@FullDesc", SqlDbType.NVarChar).Value = cat.FullDesc;
                cmd.Parameters.AddWithValue("@CompetenciesOrder", SqlDbType.NVarChar).Value = cat.CompetenciesOrder;
                cmd.Parameters.AddWithValue("@BannerImage", SqlDbType.NVarChar).Value = cat.BannerImage;
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "InsertCapability", ex.Message);
        }
        return result;
    }
    public static List<Capability> GetCapabilityDetails(SqlConnection conSQ)
    {
        List<Capability> Caps = new List<Capability>();
        try
        {
            string query = "Select *,(Select UserName from CreateUser Where UserGuid=Capability.AddedBy) as UpdatedBy from Capability where Status !=@Status  Order by Id Desc ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Caps = (from DataRow dr in dt.Rows
                        select new Capability()
                        {
                            Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                            CapabilityName = Convert.ToString(dr["CapabilityName"]),
                            CapabilityUrl = Convert.ToString(dr["CapabilityUrl"]),
                            BannerTitle = Convert.ToString(dr["BannerTitle"]),
                            DescHeading = Convert.ToString(dr["DescHeading"]),
                            FullDesc = Convert.ToString(dr["FullDesc"]),
                            CompetenciesOrder = Convert.ToString(dr["CompetenciesOrder"]),
                            BannerImage = Convert.ToString(dr["BannerImage"]),
                            AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                            AddedBy = Convert.ToString(dr["AddedBy"]),
                            AddedIp = Convert.ToString(dr["AddedIp"]),
                            Status = Convert.ToString(dr["Status"])
                        }).ToList();

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetCapabilityDetails", ex.Message);
        }
        return Caps;
    }
    public static int DeleteCapability(SqlConnection conSQ, Capability con)
    {
        int result = 0;

        try
        {
            string query = "Update Capability set Status=@Status Where Id=@Id ";
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteCapability", ex.Message);
        }
        return result;
    }
    public static int CheckExist(SqlConnection conSQ, string Name, string Url, int id)
    {
        try
        {

            var query = "Select Count(ID) as Cnt from Capability where (CapabilityName=@CapabilityName OR CapabilityUrl=@CapabilityUrl) and (@Id=0 or id != @Id)  and Status !=@Status";
            SqlCommand cmd = new SqlCommand(query, conSQ);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@CapabilityName", SqlDbType.NVarChar).Value = Name;
            cmd.Parameters.AddWithValue("@CapabilityUrl", SqlDbType.NVarChar).Value = Url;
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
    public static List<Capability> GetAllCapability(SqlConnection conSQ)
    {
        var ListOfCapability = new List<Capability>();
        try
        {
            string query = "Select *,(Select UserName from CreateUser Where UserGuid=Capability.AddedBy) as UpdatedBy from Capability where Status=@Status Order by Id Desc";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListOfCapability = (from DataRow dr in dt.Rows
                                   select new Capability()
                                   {
                                       Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                       CapabilityName = Convert.ToString(dr["CapabilityName"]),
                                       CapabilityUrl = Convert.ToString(dr["CapabilityUrl"]),
                                       BannerTitle = Convert.ToString(dr["BannerTitle"]),
                                       DescHeading = Convert.ToString(dr["DescHeading"]),
                                       FullDesc = Convert.ToString(dr["FullDesc"]),
                                       CompetenciesOrder = Convert.ToString(dr["CompetenciesOrder"]),
                                       BannerImage = Convert.ToString(dr["BannerImage"]),
                                       AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                       AddedBy = Convert.ToString(dr["AddedBy"]),
                                       AddedIp = Convert.ToString(dr["AddedIp"]),
                                       Status = Convert.ToString(dr["Status"])
                                   }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllCapability", ex.Message);
        }
        return ListOfCapability;
    }
    public static List<Capability> GetCompetenciesDetails(SqlConnection conSQ)
    {
        List<Capability> categories = new List<Capability>();
        try
        {
            string query = "Select * from Capability where status = 'Active' Order By Try_Convert(int,CompetenciesOrder) ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                categories = (from DataRow dr in dt.Rows
                              select new Capability()
                              {
                                  Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                  CapabilityName = Convert.ToString(dr["CapabilityName"]),
                                  CapabilityUrl = Convert.ToString(dr["CapabilityUrl"]),
                                  BannerTitle = Convert.ToString(dr["BannerTitle"]),
                                  DescHeading = Convert.ToString(dr["DescHeading"]),
                                  FullDesc = Convert.ToString(dr["FullDesc"]),
                                  CompetenciesOrder = Convert.ToString(dr["CompetenciesOrder"]),
                                  BannerImage = Convert.ToString(dr["BannerImage"]),
                                  AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                  AddedBy = Convert.ToString(dr["AddedBy"]),
                                  AddedIp = Convert.ToString(dr["AddedIp"]),
                                  Status = Convert.ToString(dr["Status"])
                              }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetCompetenciesDetails", ex.Message);
        }
        return categories;
    }
    public static Capability GetAllCapabilityWithUrl(SqlConnection conSQ, string Url)
    {
        var Cap = new Capability();
        try
        {
            string query = "Select * from Capability where Status!=@Status and CapabilityUrl=@CapabilityUrl ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@CapabilityUrl", SqlDbType.Int).Value = Url;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Cap = (from DataRow dr in dt.Rows
                              select new Capability()
                              {
                                  Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                  CapabilityName = Convert.ToString(dr["CapabilityName"]),
                                  CapabilityUrl = Convert.ToString(dr["CapabilityUrl"]),
                                  BannerTitle = Convert.ToString(dr["BannerTitle"]),
                                  DescHeading = Convert.ToString(dr["DescHeading"]),
                                  FullDesc = Convert.ToString(dr["FullDesc"]),
                                  CompetenciesOrder = Convert.ToString(dr["CompetenciesOrder"]),
                                  BannerImage = Convert.ToString(dr["BannerImage"]),
                                  AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                  AddedBy = Convert.ToString(dr["AddedBy"]),
                                  AddedIp = Convert.ToString(dr["AddedIp"]),
                                  Status = Convert.ToString(dr["Status"])
                              }).FirstOrDefault();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllCapabilityWithUrl", ex.Message);
        }
        return Cap;
    }
    public static int UpdateCompetenciesOrder(SqlConnection conSQ, Capability cat)
    {
        int result = 0;
        try
        {
            string query = "Update Capability Set AddedOn=@AddedOn,AddedIp=@AddedIp,CompetenciesOrder=@CompetenciesOrder Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = cat.Id;
                cmd.Parameters.AddWithValue("@CompetenciesOrder", SqlDbType.NVarChar).Value = cat.CompetenciesOrder;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = TimeStamps.UTCTime();
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = CommonModel.IPAddress();
                conSQ.Open();
                result = cmd.ExecuteNonQuery();
                conSQ.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UpdateCompetenciesOrder", ex.Message);
        }
        return result;
    }
    public static List<Capability> GetAllCompetenciesDetails(SqlConnection conSQ)
    {
        var ListOfBolgs = new List<Capability>();
        try
        {
            string query = "Select * from Capability where Status !='Deleted' Order by Id desc ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListOfBolgs = (from DataRow dr in dt.Rows
                               select new Capability()
                               {
                                   Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                   CapabilityName = Convert.ToString(dr["CapabilityName"]),
                                   CapabilityUrl = Convert.ToString(dr["CapabilityUrl"]),
                                   BannerTitle = Convert.ToString(dr["BannerTitle"]),
                                   DescHeading = Convert.ToString(dr["DescHeading"]),
                                   FullDesc = Convert.ToString(dr["FullDesc"]),
                                   CompetenciesOrder = Convert.ToString(dr["CompetenciesOrder"]),
                                   BannerImage = Convert.ToString(dr["BannerImage"]),
                                   AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                   AddedBy = Convert.ToString(dr["AddedBy"]),
                                   AddedIp = Convert.ToString(dr["AddedIp"]),
                                   Status = Convert.ToString(dr["Status"])

                               }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllCompetenciesDetails", ex.Message);
        }
        return ListOfBolgs;
    }
}