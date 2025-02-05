using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Activities.Statements;
using System.Xml.Linq;

/// <summary>
/// Summary description for SubCapability
/// </summary>
public class SubCapability
{
    public SubCapability()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int Id { get; set; }
    public string Capabilities { get; set; }
    public string SubCapabilityName { get; set; }
    public string SubCapabilityUrl { get; set; }
    public string ThumbImage { get; set; }
    public string Tag { get; set; }
    public string BannerTitle { get; set; }
    public string DescHeading { get; set; }
    public string FullDesc { get; set; }
    public string BannerImage { get; set; }
    public DateTime AddedOn {get; set;}
    public string AddedIp {  get; set; }
    public string AddedBy { get; set; }
    public string Status {  get; set; }
    public string CapabilityTitle {  get; set; }

    public static SubCapability GetAllSubCapabilityDetailsWithId(SqlConnection conSQ, int id)
    {
        SubCapability categories = new SubCapability();
        try
        {
            string query = "Select * from SubCapability where Status=@Status and Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                categories = (from DataRow dr in dt.Rows
                              select new SubCapability()
                              {
                                  Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                  Capabilities = Convert.ToString(dr["Capabilities"]),
                                  SubCapabilityName = Convert.ToString(dr["SubCapabilityName"]),
                                  SubCapabilityUrl = Convert.ToString(dr["SubCapabilityUrl"]),
                                  ThumbImage = Convert.ToString(dr["ThumbImage"]),
                                  Tag = Convert.ToString(dr["Tag"]),
                                  BannerTitle = Convert.ToString(dr["BannerTitle"]),
                                  DescHeading = Convert.ToString(dr["DescHeading"]),
                                  FullDesc = Convert.ToString(dr["FullDesc"]),
                                  BannerImage = Convert.ToString(dr["BannerImage"]),
                                  AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                  AddedBy = Convert.ToString(dr["AddedBy"]),
                                  AddedIp = Convert.ToString(dr["AddedIP"]),
                                  Status = Convert.ToString(dr["Status"])
                              }).FirstOrDefault();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllSubCapabilityDetailsWithId", ex.Message);
        }
        return categories;
    }
    public static int UpdateSubCapabilityDetails(SqlConnection conSQ, SubCapability cat)
    {
        int result = 0;
        try
        {
            string query = "Update SubCapability Set Capabilities=@Capabilities,SubCapabilityName=@SubCapabilityName,SubCapabilityUrl=@SubCapabilityUrl,ThumbImage=@ThumbImage,Tag=@Tag,BannerTitle=@BannerTitle,DescHeading=@DescHeading,FullDesc=@FullDesc,BannerImage=@BannerImage,AddedOn=@AddedOn,AddedIp=@AddedIp,AddedBy=@AddedBy,Status=@Status Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = cat.Id;
                cmd.Parameters.AddWithValue("@Capabilities", SqlDbType.NVarChar).Value = cat.Capabilities;
                cmd.Parameters.AddWithValue("@SubCapabilityName", SqlDbType.NVarChar).Value = cat.SubCapabilityName;
                cmd.Parameters.AddWithValue("@SubCapabilityUrl", SqlDbType.NVarChar).Value = cat.SubCapabilityUrl;
                cmd.Parameters.AddWithValue("@ThumbImage", SqlDbType.NVarChar).Value = cat.ThumbImage;
                cmd.Parameters.AddWithValue("@Tag", SqlDbType.NVarChar).Value = cat.Tag;
                cmd.Parameters.AddWithValue("@BannerTitle", SqlDbType.NVarChar).Value = cat.BannerTitle;
                cmd.Parameters.AddWithValue("@DescHeading", SqlDbType.NVarChar).Value = cat.DescHeading;
                cmd.Parameters.AddWithValue("@FullDesc", SqlDbType.NVarChar).Value = cat.FullDesc;
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UpdateSubCapabilityDetails", ex.Message);
        }
        return result;
    }
    public static int InsertSubCapability(SqlConnection conSQ, SubCapability cat)
    {
        int result = 0;

        try
        {
            string query = "Insert Into SubCapability (Capabilities,SubCapabilityName,SubCapabilityUrl,ThumbImage,Tag,BannerTitle,DescHeading,FullDesc,BannerImage,AddedOn,AddedBy, AddedIp,Status) values(@Capabilities,@SubCapabilityName,@SubCapabilityUrl,@ThumbImage,@Tag,@BannerTitle,@DescHeading,@FullDesc,@BannerImage,@AddedOn,@AddedBy,@AddedIp,@Status) ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Capabilities", SqlDbType.NVarChar).Value = cat.Capabilities;
                cmd.Parameters.AddWithValue("@SubCapabilityName", SqlDbType.NVarChar).Value = cat.SubCapabilityName;
                cmd.Parameters.AddWithValue("@SubCapabilityUrl", SqlDbType.NVarChar).Value = cat.SubCapabilityUrl;
                cmd.Parameters.AddWithValue("@ThumbImage", SqlDbType.NVarChar).Value = cat.ThumbImage;
                cmd.Parameters.AddWithValue("@Tag", SqlDbType.NVarChar).Value = cat.Tag;
                cmd.Parameters.AddWithValue("@BannerTitle", SqlDbType.NVarChar).Value = cat.BannerTitle;
                cmd.Parameters.AddWithValue("@DescHeading", SqlDbType.NVarChar).Value = cat.DescHeading;
                cmd.Parameters.AddWithValue("@FullDesc", SqlDbType.NVarChar).Value = cat.FullDesc;
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "InsertSubCapability", ex.Message);
        }
        return result;
    }
    public static int CheckExist(SqlConnection conSQ, string Name, string Url, int id)
    {
        try
        {

            var query = "Select Count(ID) as Cnt from SubCapability where (SubCapabilityName=@SubCapabilityName OR SubCapabilityUrl=@SubCapabilityUrl) and (@Id=0 or id != @Id)  and Status !=@Status";
            SqlCommand cmd = new SqlCommand(query, conSQ);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@SubCapabilityName", SqlDbType.NVarChar).Value = Name;
            cmd.Parameters.AddWithValue("@SubCapabilityUrl", SqlDbType.NVarChar).Value = Url;
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
    public static List<SubCapability> GetSubcapabilityDetails(SqlConnection conSQ)
    {
        List<SubCapability> zips = new List<SubCapability>();
        try
        {
            string query = "Select *,(Select UserName from CreateUser Where UserGuid=SubCapability.AddedBy) as UpdatedBy ,(select CapabilityName from Capability where try_convert (nvarchar,Capability.Id) = SubCapability.Capabilities )as  CapabilityTitle from SubCapability where Status ='Active'  Order by Id Desc";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                zips = (from DataRow dr in dt.Rows
                        select new SubCapability()
                        {
                            Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                            Capabilities = Convert.ToString(dr["Capabilities"]),
                            SubCapabilityName = Convert.ToString(dr["SubCapabilityName"]),
                            SubCapabilityUrl = Convert.ToString(dr["SubCapabilityUrl"]),
                            CapabilityTitle = Convert.ToString(dr["CapabilityTitle"]),
                            ThumbImage = Convert.ToString(dr["ThumbImage"]),
                            Tag = Convert.ToString(dr["Tag"]),
                            BannerTitle = Convert.ToString(dr["BannerTitle"]),
                            DescHeading = Convert.ToString(dr["DescHeading"]),
                            FullDesc = Convert.ToString(dr["FullDesc"]),
                            BannerImage = Convert.ToString(dr["BannerImage"]),
                            AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                            AddedBy = Convert.ToString(dr["AddedBy"]),
                            AddedIp = Convert.ToString(dr["AddedIP"]),
                            Status = Convert.ToString(dr["Status"])
                        }).ToList();

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetSubcapabilityDetails", ex.Message);
        }
        return zips;
    }
    public static int DeleteSubcapability(SqlConnection conSQ, SubCapability con)
    {
        int result = 0;

        try
        {
            string query = "Update SubCapability set Status=@Status Where Id=@Id ";
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteSubcapability", ex.Message);
        }
        return result;
    }
    public static List<SubCapability> GetAllSubCapability(SqlConnection conSQ)
    {
        var ListOfSubCapability = new List<SubCapability>();
        try
        {
            string query = "Select *,(Select UserName from CreateUser Where UserGuid=SubCapability.AddedBy) as UpdatedBy from SubCapability where Status=@Status Order by Id Desc";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListOfSubCapability = (from DataRow dr in dt.Rows
                                    select new SubCapability()
                                    {
                                        Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                        Capabilities = Convert.ToString(dr["Capabilities"]),
                                        SubCapabilityName = Convert.ToString(dr["SubCapabilityName"]),
                                        SubCapabilityUrl = Convert.ToString(dr["SubCapabilityUrl"]),
                                        ThumbImage = Convert.ToString(dr["ThumbImage"]),
                                        Tag = Convert.ToString(dr["Tag"]),
                                        BannerTitle = Convert.ToString(dr["BannerTitle"]),
                                        DescHeading = Convert.ToString(dr["DescHeading"]),
                                        FullDesc = Convert.ToString(dr["FullDesc"]),
                                        BannerImage = Convert.ToString(dr["BannerImage"]),
                                        AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                        AddedBy = Convert.ToString(dr["AddedBy"]),
                                        AddedIp = Convert.ToString(dr["AddedIP"]),
                                        Status = Convert.ToString(dr["Status"])
                                    }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllSubCapability", ex.Message);
        }
        return ListOfSubCapability;
    }
    public static List<SubCapability> GetAllSubcapability(SqlConnection conSQ, string name)
    {
        List<SubCapability> categories = new List<SubCapability>();
        try
        {
            string query = @"select * from SubCapability Where Capabilities=@Capabilities and status='Active'";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                // cmd.Parameters.AddWithValue("@id", SqlDbType.NVarChar).Value = id;
                cmd.Parameters.AddWithValue("@Capabilities", SqlDbType.NVarChar).Value = name;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                categories = (from DataRow dr in dt.Rows
                              select new SubCapability()
                              {
                                  Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                  Capabilities = Convert.ToString(dr["Capabilities"]),
                                  SubCapabilityName = Convert.ToString(dr["SubCapabilityName"]),
                                  SubCapabilityUrl = Convert.ToString(dr["SubCapabilityUrl"]),
                                  ThumbImage = Convert.ToString(dr["ThumbImage"]),
                                  Tag = Convert.ToString(dr["Tag"]),
                                  BannerTitle = Convert.ToString(dr["BannerTitle"]),
                                  DescHeading = Convert.ToString(dr["DescHeading"]),
                                  FullDesc = Convert.ToString(dr["FullDesc"]),
                                  BannerImage = Convert.ToString(dr["BannerImage"]),
                                  AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                  AddedBy = Convert.ToString(dr["AddedBy"]),
                                  AddedIp = Convert.ToString(dr["AddedIP"]),
                                  Status = Convert.ToString(dr["Status"])
                              }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllSubcapability", ex.Message);
        }
        return categories;
    }
    public static SubCapability GetAllSubCapabilityWithUrl(SqlConnection conSQ, string Url)
    {
        var Scap = new SubCapability();
        try
        {
            string query = "Select * from SubCapability where Status!=@Status and SubCapabilityUrl=@SubCapabilityUrl ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@SubCapabilityUrl", SqlDbType.Int).Value = Url;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Scap = (from DataRow dr in dt.Rows
                       select new SubCapability()
                       {
                           Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                           Capabilities = Convert.ToString(dr["Capabilities"]),
                           SubCapabilityName = Convert.ToString(dr["SubCapabilityName"]),
                           SubCapabilityUrl = Convert.ToString(dr["SubCapabilityUrl"]),
                           ThumbImage = Convert.ToString(dr["ThumbImage"]),
                           Tag = Convert.ToString(dr["Tag"]),
                           BannerTitle = Convert.ToString(dr["BannerTitle"]),
                           DescHeading = Convert.ToString(dr["DescHeading"]),
                           FullDesc = Convert.ToString(dr["FullDesc"]),
                           BannerImage = Convert.ToString(dr["BannerImage"]),
                           AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                           AddedBy = Convert.ToString(dr["AddedBy"]),
                           AddedIp = Convert.ToString(dr["AddedIP"]),
                           Status = Convert.ToString(dr["Status"])
                       }).FirstOrDefault();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllSubCapabilityWithUrl", ex.Message);
        }
        return Scap;
    }
    //public static List<SubCapability> GetSubCapabilityByUrl(SqlConnection conSQ, string url)
    //{
    //    List<SubCapability> categories = new List<SubCapability>();
    //    try
    //    {
    //        string query = "Select *,(SELECT TOP 1 CapabilityName FROM Capability WHERE id = SubCapability.Capabilities) AS Capabilities from SubCapability Where Status='Active' and SubCapabilityUrl=@SubCapabilityUrl";
    //        using (SqlCommand cmd = new SqlCommand(query, conSQ))
    //        {
    //            DataTable dt = new DataTable();
    //            cmd.Parameters.AddWithValue("@SubCapabilityUrl", SqlDbType.NVarChar).Value = url;
    //            SqlDataAdapter sda = new SqlDataAdapter(cmd);
    //            sda.Fill(dt);
    //            if (dt.Rows.Count > 0)
    //            {
    //                for (int i = 0; i < dt.Rows.Count; i++)
    //                {
    //                    SubCapability cat = new SubCapability();
    //                    cat.Id = Convert.ToInt32(Convert.ToString(dt.Rows[i]["Id"]));
    //                    cat.Capabilities = Convert.ToString(dt.Rows[i]["Capabilities"]);
    //                    cat.SubCapabilityName = Convert.ToString(dt.Rows[i]["SubCapabilityName"]);
    //                    cat.SubCapabilityUrl = Convert.ToString(dt.Rows[i]["SubCapabilityUrl"]);
    //                    cat.ThumbImage = Convert.ToString(dt.Rows[i]["ThumbImage"]);
    //                    cat.Tag = Convert.ToString(dt.Rows[i]["Tag"]);
    //                    cat.BannerTitle = Convert.ToString(dt.Rows[i]["BannerTitle"]);
    //                    cat.DescHeading = Convert.ToString(dt.Rows[i]["DescHeading"]);
    //                    cat.FullDesc = Convert.ToString(dt.Rows[i]["FullDesc"]);
    //                    cat.BannerImage = Convert.ToString(dt.Rows[i]["BannerImage"]);
    //                    cat.AddedIp = Convert.ToString(dt.Rows[i]["AddedIP"]);
    //                    cat.AddedBy = Convert.ToString(dt.Rows[i]["AddedBy"]);
    //                    cat.AddedOn = Convert.ToDateTime(Convert.ToString(dt.Rows[i]["AddedOn"]));
    //                    cat.Status = Convert.ToString(dt.Rows[i]["Status"]);
    //                    categories.Add(cat);
    //                }
    //            }
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        CommonModel.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetSubCapabilityByUrl", ex.Message);
    //    }
    //    return categories;
    //}
}
