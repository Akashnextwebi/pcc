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
    public string IndustryGuid {  get; set; }
    public string IndustryName { get; set; }
    public string IndustryUrl { get; set; }
    public string BannerImage { get; set; }
    public string DescHeading {  get; set; }
    public string FullDesc {  get; set; }
    public string IndustryOrder {  get; set; }
    public string BannerImage2 {  get; set; }
    public string DescHeading2 {  get; set; }
    public string FullDesc2 {  get; set; }
    public string PageTitle { get; set; }
    public string MetaKeys { get; set; }
    public string MetaDesc { get; set; }
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
                           BannerImage = Convert.ToString(dr["BannerImage"]),
                           DescHeading = Convert.ToString(dr["DescHeading"]),
                           FullDesc = Convert.ToString(dr["FullDesc"]),
                           IndustryOrder = Convert.ToString(dr["IndustryOrder"]),
                           BannerImage2 = Convert.ToString(dr["BannerImage2"]),
                           DescHeading2 = Convert.ToString(dr["DescHeading2"]),
                           FullDesc2 = Convert.ToString(dr["FullDesc2"]),
                           PageTitle = Convert.ToString(dr["PageTitle"]),
                           MetaKeys = Convert.ToString(dr["MetaKeys"]),
                           MetaDesc = Convert.ToString(dr["MetaDesc"]),
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
            string query = "Insert Into IndustryDetails (IndustryGuid,IndustryName,IndustryUrl,BannerImage,DescHeading,FullDesc,IndustryOrder,BannerImage2,DescHeading2,FullDesc2,PageTitle,MetaKeys,MetaDesc,AddedOn,AddedBy,AddedIp,Status) values (@IndustryGuid,@IndustryName,@IndustryUrl,@BannerImage,@DescHeading,@FullDesc,@IndustryOrder,@BannerImage2,@DescHeading2,@FullDesc2,@PageTitle,@MetaKeys,@MetaDesc,@AddedOn,@AddedBy,@AddedIp,@Status) select SCOPE_IDENTITY()";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))

            {
                cmd.Parameters.AddWithValue("@IndustryGuid", SqlDbType.NVarChar).Value = Cat.IndustryGuid;
                cmd.Parameters.AddWithValue("@IndustryName", SqlDbType.NVarChar).Value = Cat.IndustryName;
                cmd.Parameters.AddWithValue("@IndustryUrl", SqlDbType.NVarChar).Value = Cat.IndustryUrl;
                cmd.Parameters.AddWithValue("@BannerImage", SqlDbType.NVarChar).Value = Cat.BannerImage;
                cmd.Parameters.AddWithValue("@DescHeading", SqlDbType.NVarChar).Value = Cat.DescHeading;
                cmd.Parameters.AddWithValue("@FullDesc", SqlDbType.NVarChar).Value = Cat.FullDesc;
                cmd.Parameters.AddWithValue("@IndustryOrder", SqlDbType.NVarChar).Value = Cat.IndustryOrder;
                cmd.Parameters.AddWithValue("@BannerImage2", SqlDbType.NVarChar).Value = Cat.BannerImage2;
                cmd.Parameters.AddWithValue("@DescHeading2", SqlDbType.NVarChar).Value = Cat.DescHeading2;
                cmd.Parameters.AddWithValue("@FullDesc2", SqlDbType.NVarChar).Value = Cat.FullDesc2;
                cmd.Parameters.AddWithValue("@PageTitle", SqlDbType.NVarChar).Value = Cat.PageTitle;
                cmd.Parameters.AddWithValue("@MetaKeys", SqlDbType.NVarChar).Value = Cat.MetaKeys;
                cmd.Parameters.AddWithValue("@MetaDesc", SqlDbType.NVarChar).Value = Cat.MetaDesc;
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
            string query = "Update IndustryDetails Set IndustryName=@IndustryName,IndustryUrl=@IndustryUrl,BannerImage=@BannerImage,DescHeading=@DescHeading,FullDesc=@FullDesc,IndustryOrder=@IndustryOrder,BannerImage2=@BannerImage2,DescHeading2=@DescHeading2,FullDesc2=@FullDesc2,PageTitle=@PageTitle,MetaKeys=@MetaKeys,MetaDesc=@MetaDesc,AddedBy=@AddedBy,AddedOn=@AddedOn,AddedIp=@AddedIp ,Status=@Status Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = Cat.Id;
                cmd.Parameters.AddWithValue("@IndustryName", SqlDbType.NVarChar).Value = Cat.IndustryName;
                cmd.Parameters.AddWithValue("@IndustryUrl", SqlDbType.NVarChar).Value = Cat.IndustryUrl;
                cmd.Parameters.AddWithValue("@BannerImage", SqlDbType.NVarChar).Value = Cat.BannerImage;
                cmd.Parameters.AddWithValue("@DescHeading", SqlDbType.NVarChar).Value = Cat.DescHeading;
                cmd.Parameters.AddWithValue("@FullDesc", SqlDbType.NVarChar).Value = Cat.FullDesc;
                cmd.Parameters.AddWithValue("@IndustryOrder", SqlDbType.NVarChar).Value = Cat.IndustryOrder;
                cmd.Parameters.AddWithValue("@BannerImage2", SqlDbType.NVarChar).Value = Cat.BannerImage2;
                cmd.Parameters.AddWithValue("@DescHeading2", SqlDbType.NVarChar).Value = Cat.DescHeading2;
                cmd.Parameters.AddWithValue("@FullDesc2", SqlDbType.NVarChar).Value = Cat.FullDesc2;
                cmd.Parameters.AddWithValue("@PageTitle", SqlDbType.NVarChar).Value = Cat.PageTitle;
                cmd.Parameters.AddWithValue("@MetaKeys", SqlDbType.NVarChar).Value = Cat.MetaKeys;
                cmd.Parameters.AddWithValue("@MetaDesc", SqlDbType.NVarChar).Value = Cat.MetaDesc;
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
                                       IndustryGuid = Convert.ToString(dr["IndustryGuid"]),
                                       IndustryName = Convert.ToString(dr["IndustryName"]),
                                       IndustryUrl = Convert.ToString(dr["IndustryUrl"]),
                                       BannerImage = Convert.ToString(dr["BannerImage"]),
                                       DescHeading = Convert.ToString(dr["DescHeading"]),
                                       IndustryOrder = Convert.ToString(dr["IndustryOrder"]),
                                       FullDesc = Convert.ToString(dr["FullDesc"]),
                                       BannerImage2 = Convert.ToString(dr["BannerImage2"]),
                                       DescHeading2 = Convert.ToString(dr["DescHeading2"]),
                                       FullDesc2 = Convert.ToString(dr["FullDesc2"]),
                                       PageTitle = Convert.ToString(dr["PageTitle"]),
                                       MetaKeys = Convert.ToString(dr["MetaKeys"]),
                                       MetaDesc = Convert.ToString(dr["MetaDesc"]),
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
                                        BannerImage = Convert.ToString(dr["BannerImage"]),
                                        DescHeading = Convert.ToString(dr["DescHeading"]),
                                        FullDesc = Convert.ToString(dr["FullDesc"]),
                                        IndustryOrder = Convert.ToString(dr["IndustryOrder"]),
                                        BannerImage2 = Convert.ToString(dr["BannerImage2"]),
                                        DescHeading2 = Convert.ToString(dr["DescHeading2"]),
                                        FullDesc2 = Convert.ToString(dr["FullDesc2"]),
                                        PageTitle = Convert.ToString(dr["PageTitle"]),
                                        MetaKeys = Convert.ToString(dr["MetaKeys"]),
                                        MetaDesc = Convert.ToString(dr["MetaDesc"]),
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
    public static List<IndustryDetails> GetIndustryDetails(SqlConnection conSQ)
    {
        List<IndustryDetails> categories = new List<IndustryDetails>();
        try
        {
            string query = "Select * from IndustryDetails where status = 'Active' Order By Try_Convert(int,IndustryOrder)";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                categories = (from DataRow dr in dt.Rows
                              select new IndustryDetails()
                              {
                                  Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                  IndustryGuid = Convert.ToString(dr["IndustryGuid"]),
                                  IndustryName = Convert.ToString(dr["IndustryName"]),
                                  IndustryUrl = Convert.ToString(dr["IndustryUrl"]),
                                  BannerImage = Convert.ToString(dr["BannerImage"]),
                                  DescHeading = Convert.ToString(dr["DescHeading"]),
                                  FullDesc = Convert.ToString(dr["FullDesc"]),
                                  IndustryOrder = Convert.ToString(dr["IndustryOrder"]),
                                  BannerImage2 = Convert.ToString(dr["BannerImage2"]),
                                  DescHeading2 = Convert.ToString(dr["DescHeading2"]),
                                  FullDesc2 = Convert.ToString(dr["FullDesc2"]),
                                  PageTitle = Convert.ToString(dr["PageTitle"]),
                                  MetaKeys = Convert.ToString(dr["MetaKeys"]),
                                  MetaDesc = Convert.ToString(dr["MetaDesc"]),
                                  AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                  AddedIp = Convert.ToString(dr["AddedIp"]),
                                  AddedBy = Convert.ToString(dr["AddedBy"]),
                                  Status = Convert.ToString(dr["Status"])
                              }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetIndustryDetails", ex.Message);
        }
        return categories;
    }
    public static IndustryDetails GetAllIndustryWithUrl(SqlConnection conSQ, string Url)
    {
        var Ind = new IndustryDetails();
        try
        {
            string query = "Select * from IndustryDetails where Status!=@Status and IndustryUrl=@IndustryUrl ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@IndustryUrl", SqlDbType.Int).Value = Url;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Ind = (from DataRow dr in dt.Rows
                       select new IndustryDetails()
                       {
                           Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                           IndustryGuid = Convert.ToString(dr["IndustryGuid"]),
                           IndustryName = Convert.ToString(dr["IndustryName"]),
                           IndustryUrl = Convert.ToString(dr["IndustryUrl"]),
                           BannerImage = Convert.ToString(dr["BannerImage"]),
                           DescHeading = Convert.ToString(dr["DescHeading"]),
                           FullDesc = Convert.ToString(dr["FullDesc"]),
                           IndustryOrder = Convert.ToString(dr["IndustryOrder"]),
                           BannerImage2 = Convert.ToString(dr["BannerImage2"]),
                           DescHeading2 = Convert.ToString(dr["DescHeading2"]),
                           FullDesc2 = Convert.ToString(dr["FullDesc2"]),
                           PageTitle = Convert.ToString(dr["PageTitle"]),
                           MetaKeys = Convert.ToString(dr["MetaKeys"]),
                           MetaDesc = Convert.ToString(dr["MetaDesc"]),
                           AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                           AddedIp = Convert.ToString(dr["AddedIp"]),
                           AddedBy = Convert.ToString(dr["AddedBy"]),
                           Status = Convert.ToString(dr["Status"])
                       }).FirstOrDefault();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllIndustryWithUrl", ex.Message);
        }
        return Ind;
    }
    public static int UpdateIndustryOrder(SqlConnection conSQ, IndustryDetails cat)
    {
        int result = 0;
        try
        {
            string query = "Update IndustryDetails Set AddedOn=@AddedOn,AddedIp=@AddedIp,IndustryOrder=@IndustryOrder Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = cat.Id;
                cmd.Parameters.AddWithValue("@IndustryOrder", SqlDbType.NVarChar).Value = cat.IndustryOrder;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = TimeStamps.UTCTime();
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = CommonModel.IPAddress();
                conSQ.Open();
                result = cmd.ExecuteNonQuery();
                conSQ.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UpdateIndustryOrder", ex.Message);
        }
        return result;
    }
    public static List<IndustryDetails> GetAllIndustryDetails(SqlConnection conSQ)
    {
        var ListOfBolgs = new List<IndustryDetails>();
        try
        {
            string query = "Select * from IndustryDetails where Status !='Deleted' Order by Id desc ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListOfBolgs = (from DataRow dr in dt.Rows
                               select new IndustryDetails()
                               {
                                   Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                   IndustryGuid = Convert.ToString(dr["IndustryGuid"]),
                                   IndustryName = Convert.ToString(dr["IndustryName"]),
                                   IndustryUrl = Convert.ToString(dr["IndustryUrl"]),
                                   BannerImage = Convert.ToString(dr["BannerImage"]),
                                   DescHeading = Convert.ToString(dr["DescHeading"]),
                                   IndustryOrder = Convert.ToString(dr["IndustryOrder"]),
                                   FullDesc = Convert.ToString(dr["FullDesc"]),
                                   BannerImage2 = Convert.ToString(dr["BannerImage2"]),
                                   DescHeading2 = Convert.ToString(dr["DescHeading2"]),
                                   FullDesc2 = Convert.ToString(dr["FullDesc2"]),
                                   PageTitle = Convert.ToString(dr["PageTitle"]),
                                   MetaKeys = Convert.ToString(dr["MetaKeys"]),
                                   MetaDesc = Convert.ToString(dr["MetaDesc"]),
                                   AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                   AddedIp = Convert.ToString(dr["AddedIp"]),
                                   AddedBy = Convert.ToString(dr["AddedBy"]),
                                   Status = Convert.ToString(dr["Status"])

                               }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllIndustryDetails", ex.Message);
        }
        return ListOfBolgs;
    }
}



