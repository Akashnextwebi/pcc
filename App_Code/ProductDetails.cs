using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Threading;

/// <summary>
/// Summary description for ProductDetails
/// </summary>
public class ProductDetails
{
    public ProductDetails()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int Id { get; set; }
    public string ProductGuid { get; set; }    
    public string ProductName { get; set; }
    public string ProductUrl { get; set; }
    public string ThumbImage { get; set; }
    public string SKUCode { get; set; }
    public string Broucher { get; set; }
    public string DatasheetName { get; set; }
    public string DatasheetLink { get; set; }
    public string Enquiry {  get; set; }
    public string Capability {  get; set; }
    public string SubCapability { get; set; }
    public string Industry { get; set; }
    public string FullDesc { get; set; }
    public string PageTitle { get; set; }
    public string MetaKeys { get; set; }
    public string MetaDesc { get; set; }
    public DateTime AddedOn { get; set; }
    public string AddedIp { get; set; }
    public string AddedBy { get; set; }
    public string Status { get; set; }
    public string SubcapabilityTitle { get; set; }
    public string CapabilityTitle {  get; set; }
    public string IndustryTitle {  get; set; }

    public string TotalCount { set; get; }
    public static ProductDetails getProductsById(SqlConnection _con, int id)
    {
        ProductDetails pro = new ProductDetails();
        try
        {
            string query = "Select top 1 * from ProductDetails where Status='Active' and Id=@Id";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    pro.Id = Convert.ToInt32(Convert.ToString(dt.Rows[0]["Id"]));
                    pro.ProductGuid = Convert.ToString(dt.Rows[0]["ProductGuid"]);
                    pro.ProductName = Convert.ToString(dt.Rows[0]["ProductName"]);
                    pro.ProductUrl = Convert.ToString(dt.Rows[0]["ProductUrl"]);
                    pro.ThumbImage = Convert.ToString(dt.Rows[0]["ThumbImage"]);
                    pro.SKUCode = Convert.ToString(dt.Rows[0]["SKUCode"]);
                    pro.Broucher = Convert.ToString(dt.Rows[0]["Broucher"]);
                    pro.DatasheetName = Convert.ToString(dt.Rows[0]["DatasheetName"]);
                    pro.DatasheetLink = Convert.ToString(dt.Rows[0]["DatasheetLink"]);
                    pro.Enquiry = Convert.ToString(dt.Rows[0]["Enquiry"]);
                    pro.Capability = Convert.ToString(dt.Rows[0]["Capability"]);
                    pro.SubCapability = Convert.ToString(dt.Rows[0]["SubCapability"]);
                    pro.Industry = Convert.ToString(dt.Rows[0]["Industry"]);
                    pro.FullDesc = Convert.ToString(dt.Rows[0]["FullDesc"]);
                    pro.PageTitle = Convert.ToString(dt.Rows[0]["PageTitle"]);
                    pro.MetaKeys = Convert.ToString(dt.Rows[0]["MetaKeys"]);
                    pro.MetaDesc = Convert.ToString(dt.Rows[0]["MetaDesc"]);
                    pro.AddedOn = Convert.ToDateTime(Convert.ToString(dt.Rows[0]["AddedOn"]));
                    pro.AddedBy = Convert.ToString(dt.Rows[0]["AddedBy"]);
                    pro.AddedIp = Convert.ToString(dt.Rows[0]["AddedIp"]);
                    pro.Status = Convert.ToString(dt.Rows[0]["Status"]);
                   

                }
                else
                {
                    pro = null;
                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "getProductsById", ex.Message);
        }
        return pro;
    }
    public static int UpdateProducts(SqlConnection _con, ProductDetails cat)
    {
        int result = 0;
        try
        {
            string query = "Update ProductDetails Set ProductName=@ProductName,ProductUrl=@ProductUrl,Industry=@Industry,ThumbImage=@ThumbImage,SKUCode=@SKUCode,Broucher=@Broucher,DatasheetName=@DatasheetName,DatasheetLink=@DatasheetLink,Enquiry=@Enquiry,Capability=@Capability,SubCapability=@SubCapability,FullDesc=@FullDesc,PageTitle=@PageTitle,MetaKeys=@MetaKeys,MetaDesc=@MetaDesc,AddedOn=@AddedOn,AddedBy=@AddedBy,AddedIp=@AddedIp,Status=@Status Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = cat.Id;
                cmd.Parameters.AddWithValue("@ProductName", SqlDbType.NVarChar).Value = cat.ProductName;
                cmd.Parameters.AddWithValue("@ProductUrl", SqlDbType.NVarChar).Value = cat.ProductUrl;
                cmd.Parameters.AddWithValue("@ThumbImage", SqlDbType.NVarChar).Value = cat.ThumbImage;
                cmd.Parameters.AddWithValue("@SKUCode", SqlDbType.NVarChar).Value = cat.SKUCode;
                cmd.Parameters.AddWithValue("@Broucher", SqlDbType.NVarChar).Value = cat.Broucher;
                cmd.Parameters.AddWithValue("@DatasheetName", SqlDbType.NVarChar).Value = cat.DatasheetName;
                cmd.Parameters.AddWithValue("@DatasheetLink", SqlDbType.NVarChar).Value = cat.DatasheetLink;
                cmd.Parameters.AddWithValue("@Enquiry", SqlDbType.NVarChar).Value = cat.Enquiry;
                cmd.Parameters.AddWithValue("@Capability", SqlDbType.NVarChar).Value = cat.Capability;
                cmd.Parameters.AddWithValue("@SubCapability", SqlDbType.NVarChar).Value = cat.SubCapability;
                cmd.Parameters.AddWithValue("@Industry", SqlDbType.NVarChar).Value = cat.Industry;
                cmd.Parameters.AddWithValue("@FullDesc", SqlDbType.NVarChar).Value = cat.FullDesc;
                cmd.Parameters.AddWithValue("@PageTitle", SqlDbType.NVarChar).Value = cat.PageTitle;
                cmd.Parameters.AddWithValue("@MetaKeys", SqlDbType.NVarChar).Value = cat.MetaKeys;
                cmd.Parameters.AddWithValue("@MetaDesc", SqlDbType.NVarChar).Value = cat.MetaDesc;               
                cmd.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = cat.AddedBy;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.DateTime).Value = cat.AddedOn;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = cat.AddedIp;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                _con.Open();
                result = cmd.ExecuteNonQuery();
                _con.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UpdateProducts", ex.Message);
        }
        return result;
    }
    public static int InsertProducts(SqlConnection _con, ProductDetails cat)
    {
        int result = 0;


        try
        {
            string query = "Insert Into ProductDetails (ProductGuid,ProductName,ProductUrl,ThumbImage,SKUCode,Broucher,DatasheetName,DatasheetLink,Enquiry,Capability,SubCapability,Industry,FullDesc,PageTitle,MetaKeys,MetaDesc,AddedBy,AddedOn,AddedIp,Status) values" +
                           "(@ProductGuid,@ProductName,@ProductUrl,@ThumbImage,@SKUCode,@Broucher,@DatasheetName,@DatasheetLink,@Enquiry,@Capability,@SubCapability,@Industry,@FullDesc,@PageTitle,@MetaKeys,@MetaDesc,@AddedBy,@AddedOn,@AddedIp,@Status)";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@ProductName", SqlDbType.NVarChar).Value = cat.ProductName;
                cmd.Parameters.AddWithValue("@ProductGuid", SqlDbType.NVarChar).Value = cat.ProductGuid;
                cmd.Parameters.AddWithValue("@ProductUrl", SqlDbType.NVarChar).Value = cat.ProductUrl;
                cmd.Parameters.AddWithValue("@ThumbImage", SqlDbType.NVarChar).Value = cat.ThumbImage;
                cmd.Parameters.AddWithValue("@SKUCode", SqlDbType.NVarChar).Value = cat.SKUCode;
                cmd.Parameters.AddWithValue("@Broucher", SqlDbType.NVarChar).Value = cat.Broucher;
                cmd.Parameters.AddWithValue("@DatasheetName", SqlDbType.NVarChar).Value = cat.DatasheetName;
                cmd.Parameters.AddWithValue("@DatasheetLink", SqlDbType.NVarChar).Value = cat.DatasheetLink;
                cmd.Parameters.AddWithValue("@Enquiry", SqlDbType.NVarChar).Value = cat.Enquiry;
                cmd.Parameters.AddWithValue("@Capability", SqlDbType.NVarChar).Value = cat.Capability;
                cmd.Parameters.AddWithValue("@SubCapability", SqlDbType.NVarChar).Value = cat.SubCapability;
                cmd.Parameters.AddWithValue("@Industry", SqlDbType.NVarChar).Value = cat.Industry;
                cmd.Parameters.AddWithValue("@FullDesc", SqlDbType.NVarChar).Value = cat.FullDesc;
                cmd.Parameters.AddWithValue("@PageTitle", SqlDbType.NVarChar).Value = cat.PageTitle;
                cmd.Parameters.AddWithValue("@MetaKeys", SqlDbType.NVarChar).Value = cat.MetaKeys;
                cmd.Parameters.AddWithValue("@MetaDesc", SqlDbType.NVarChar).Value = cat.MetaDesc;
                cmd.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = cat.AddedBy;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.DateTime).Value = cat.AddedOn;
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = cat.AddedIp;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                _con.Open();
                result = cmd.ExecuteNonQuery();
                _con.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "InsertProducts", ex.Message);
        }
        return result;
    }
    public static List<ProductDetails> GetProductsDetails(SqlConnection conSQ)
    {
        List<ProductDetails> zips = new List<ProductDetails>();
        try
        {
            string query = "Select *,(Select UserName from CreateUser Where UserGuid=ProductDetails.AddedBy) as UpdatedBy ,(select SubCapabilityName from SubCapability where try_convert (nvarchar,SubCapability.Id) = ProductDetails.SubCapability )as  SubCapabilityTitle,(select CapabilityName from Capability where try_convert (nvarchar,Capability.Id) = ProductDetails.Capability )as  CapabilityTitle,(select IndustryName from IndustryDetails where try_convert (nvarchar,IndustryDetails.Id) = ProductDetails.Industry )as IndustryTitle from ProductDetails where Status ='Active'  Order by Id Desc";

            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                zips = (from DataRow dr in dt.Rows
                        select new ProductDetails()
                        {
                            Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                            ProductGuid = Convert.ToString(dr["ProductGuid"]),
                            ProductName = Convert.ToString(dr["ProductName"]),
                            ProductUrl = Convert.ToString(dr["ProductUrl"]),
                            ThumbImage = Convert.ToString(dr["ThumbImage"]),
                            SKUCode = Convert.ToString(dr["SKUCode"]),
                            Broucher = Convert.ToString(dr["Broucher"]),
                            DatasheetName = Convert.ToString(dr["DatasheetName"]),
                            DatasheetLink = Convert.ToString(dr["DatasheetLink"]),
                            Enquiry = Convert.ToString(dr["Enquiry"]),
                            Capability = Convert.ToString(dr["Capability"]),
                            SubCapability = Convert.ToString(dr["SubCapability"]),
                            CapabilityTitle = Convert.ToString(dr["CapabilityTitle"]),
                            SubcapabilityTitle = Convert.ToString(dr["SubcapabilityTitle"]),
                            IndustryTitle = Convert.ToString(dr["IndustryTitle"]),
                            Industry = Convert.ToString(dr["Industry"]),
                            FullDesc = Convert.ToString(dr["FullDesc"]),
                            PageTitle = Convert.ToString(dr["PageTitle"]),
                            MetaKeys = Convert.ToString(dr["MetaKeys"]),
                            MetaDesc = Convert.ToString(dr["MetaDesc"]),
                            AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                            AddedBy = Convert.ToString(dr["AddedBy"]),
                            AddedIp = Convert.ToString(dr["AddedIp"]),
                            Status = Convert.ToString(dr["Status"])
                        }).ToList();

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetProductsDetails", ex.Message);
        }
        return zips;
    }
    public static int DeleteProducts(SqlConnection conSQ, ProductDetails con)
    {
        int result = 0;

        try
        {
            string query = "Update ProductDetails set Status=@Status Where Id=@Id ";
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteProducts", ex.Message);
        }
        return result;
    }
    public static List<ProductDetails> GetProductnameWithGuid(SqlConnection conSQ, string ProductGuid)
    {
        var ListOfnames = new List<ProductDetails>();
        try
        {
            string query = "Select * from ProductDetails where Status=@Status and ProductGuid=@ProductGuid Order by Id ";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                cmd.Parameters.AddWithValue("@ProductGuid", SqlDbType.NVarChar).Value = ProductGuid;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ListOfnames = (from DataRow dr in dt.Rows
                             select new ProductDetails()
                             {
                                 Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                 ProductGuid = Convert.ToString(dr["ProductGuid"]),
                                 ProductName = Convert.ToString(dr["ProductName"]),
                                 ProductUrl = Convert.ToString(dr["ProductUrl"]),
                                 ThumbImage = Convert.ToString(dr["ThumbImage"]),
                                 SKUCode = Convert.ToString(dr["SKUCode"]),
                                 Broucher = Convert.ToString(dr["Broucher"]),
                                 DatasheetName = Convert.ToString(dr["DatasheetName"]),
                                 DatasheetLink = Convert.ToString(dr["DatasheetLink"]),
                                 Enquiry = Convert.ToString(dr["Enquiry"]),
                                 Capability = Convert.ToString(dr["Capability"]),
                                 SubCapability = Convert.ToString(dr["SubCapability"]),
                                 Industry = Convert.ToString(dr["Industry"]),
                                 //CapabilityTitle = Convert.ToString(dr["CapabilityTitle"]),
                                 //SubcapabilityTitle = Convert.ToString(dr["SubcapabilityTitle"]),
                                 FullDesc = Convert.ToString(dr["FullDesc"]),
                                 PageTitle = Convert.ToString(dr["PageTitle"]),
                                 MetaKeys = Convert.ToString(dr["MetaKeys"]),
                                 MetaDesc = Convert.ToString(dr["MetaDesc"]),
                                 AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                 AddedBy = Convert.ToString(dr["AddedBy"]),
                                 AddedIp = Convert.ToString(dr["AddedIp"]),
                                 Status = Convert.ToString(dr["Status"])
                             }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetProductnameWithGuid", ex.Message);
        }
        return ListOfnames;
    }
    public static int CheckExist(SqlConnection conSQ, string Name, string Url, int id)
    {
        try
        {

            var query = "Select Count(ID) as Cnt from ProductDetails where (ProductName=@ProductName OR ProductUrl=@ProductUrl) and (@Id=0 or id != @Id)  and Status !=@Status";
            SqlCommand cmd = new SqlCommand(query, conSQ);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@ProductName", SqlDbType.NVarChar).Value = Name;
            cmd.Parameters.AddWithValue("@ProductUrl", SqlDbType.NVarChar).Value = Url;
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
    public static List<ProductDetails> GetProductListing(SqlConnection conSQ, string PageNo, string PLenght, string Key,string Capability,string Industry)
    {
        int page = (Convert.ToInt32(PageNo) - 1) * Convert.ToInt32(PLenght);
        var result = new List<ProductDetails>();
        try
        {
            DataTable dt = new DataTable();

            var query = @"SELECT 

    pd.*, 
	(   Select Count(ID) from productdetails 
    WHERE   
    Status !='Deleted' And
    (@Key = '' OR pd.ProductName LIKE '%' + @Key + '%') AND
    (@capability = '' OR pd.Capability = @capability) AND
    (@Industry = '' OR pd.Industry = @Industry)
) as TotalCount,
    (SELECT CapabilityName FROM Capability WHERE TRY_CONVERT(nvarchar, Capability.Id) = pd.Capability) AS CapabilityTitle,
    (SELECT IndustryName FROM IndustryDetails WHERE TRY_CONVERT(nvarchar, IndustryDetails.Id) = pd.Industry) AS IndustryTitle,
    (SELECT SubCapabilityName  FROM SubCapability  WHERE TRY_CONVERT(nvarchar, SubCapability .Id) = pd.SubCapability) AS SubCapabilityTitle
FROM productdetails pd
WHERE 
    Status != 'Deleted' AND  
    (@Key = '' OR pd.ProductName LIKE '%' + @Key + '%') AND
    (@capability = '' OR pd.Capability = @capability) AND
    (@Industry = '' OR pd.Industry = @Industry)
ORDER BY 
    id DESC
OFFSET @page ROWS
FETCH NEXT @pageLength ROWS ONLY;";
            SqlCommand cmd = new SqlCommand(query, conSQ);
            //cmd.Parameters.AddWithValue("@ProductGuid", SqlDbType.NVarChar).Value = uid;
            cmd.Parameters.AddWithValue("@Page", SqlDbType.Int).Value = page;
            cmd.Parameters.AddWithValue("@PageLength", SqlDbType.Int).Value = Convert.ToInt32(PLenght);
            cmd.Parameters.AddWithValue("@Key", SqlDbType.NVarChar).Value = Convert.ToString(Key);
            cmd.Parameters.AddWithValue("@Capability", SqlDbType.NVarChar).Value = Convert.ToString(Capability);
            cmd.Parameters.AddWithValue("@Industry", SqlDbType.NVarChar).Value = Convert.ToString(Industry);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            result = (from DataRow dr in dt.Rows
                      select new ProductDetails()
                      {
                          Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                          ProductGuid = Convert.ToString(dr["ProductGuid"]),
                          ProductName = Convert.ToString(dr["ProductName"]),
                          ProductUrl = Convert.ToString(dr["ProductUrl"]),
                          ThumbImage = Convert.ToString(dr["ThumbImage"]),
                          SKUCode = Convert.ToString(dr["SKUCode"]),
                          Broucher = Convert.ToString(dr["Broucher"]),
                          DatasheetName = Convert.ToString(dr["DatasheetName"]),
                          DatasheetLink = Convert.ToString(dr["DatasheetLink"]),
                          Enquiry = Convert.ToString(dr["Enquiry"]),
                          Capability = Convert.ToString(dr["Capability"]),
                          SubCapability = Convert.ToString(dr["SubCapability"]),
                          CapabilityTitle = Convert.ToString(dr["CapabilityTitle"]),
                          SubcapabilityTitle = Convert.ToString(dr["SubcapabilityTitle"]),
                          IndustryTitle = Convert.ToString(dr["IndustryTitle"]),
                          Industry = Convert.ToString(dr["Industry"]),
                          FullDesc = Convert.ToString(dr["FullDesc"]),
                          PageTitle = Convert.ToString(dr["PageTitle"]),
                          MetaKeys = Convert.ToString(dr["MetaKeys"]),
                          MetaDesc = Convert.ToString(dr["MetaDesc"]),
                          AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                          AddedBy = Convert.ToString(dr["AddedBy"]),
                          AddedIp = Convert.ToString(dr["AddedIp"]),
                          Status = Convert.ToString(dr["Status"]),
                          TotalCount = Convert.ToString(dr["TotalCount"])
                      }).ToList();
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetProductListing", ex.Message);
        }
        return result;
    }
    public static List<ProductDetails> GetAllProducts(SqlConnection conSQ, string name)
    {
        List<ProductDetails> pro = new List<ProductDetails>();
        try
        {
            string query = @"select * from ProductDetails Where SubCapability=@SubCapability and status='Active'";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                // cmd.Parameters.AddWithValue("@id", SqlDbType.NVarChar).Value = id;
                cmd.Parameters.AddWithValue("@SubCapability", SqlDbType.NVarChar).Value = name;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                pro = (from DataRow dr in dt.Rows
                              select new ProductDetails()
                              {
                                  Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                  ProductGuid = Convert.ToString(dr["ProductGuid"]),
                                  ProductName = Convert.ToString(dr["ProductName"]),
                                  ProductUrl = Convert.ToString(dr["ProductUrl"]),
                                  ThumbImage = Convert.ToString(dr["ThumbImage"]),
                                  SKUCode = Convert.ToString(dr["SKUCode"]),
                                  Broucher = Convert.ToString(dr["Broucher"]),
                                  DatasheetName = Convert.ToString(dr["DatasheetName"]),
                                  DatasheetLink = Convert.ToString(dr["DatasheetLink"]),
                                  Enquiry = Convert.ToString(dr["Enquiry"]),
                                  Capability = Convert.ToString(dr["Capability"]),
                                  SubCapability = Convert.ToString(dr["SubCapability"]),
                                  Industry = Convert.ToString(dr["Industry"]),
                                  FullDesc = Convert.ToString(dr["FullDesc"]),
                                  PageTitle = Convert.ToString(dr["PageTitle"]),
                                  MetaKeys = Convert.ToString(dr["MetaKeys"]),
                                  MetaDesc = Convert.ToString(dr["MetaDesc"]),
                                  AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                  AddedBy = Convert.ToString(dr["AddedBy"]),
                                  AddedIp = Convert.ToString(dr["AddedIp"]),

                              }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllProducts", ex.Message);
        }
        return pro;
    }
    public static ProductDetails getProductdetailsByUrl(SqlConnection _con, string ProductUrl)
    {
        ProductDetails pro = new ProductDetails();
        try
        {
            string query = "Select top 1 * from ProductDetails where Status='Active' and ProductUrl=@ProductUrl";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@ProductUrl", SqlDbType.Int).Value = ProductUrl;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    pro.Id = Convert.ToInt32(Convert.ToString(dt.Rows[0]["Id"]));
                    pro.ProductGuid = Convert.ToString(dt.Rows[0]["ProductGuid"]);
                    pro.ProductName = Convert.ToString(dt.Rows[0]["ProductName"]);
                    pro.ProductUrl = Convert.ToString(dt.Rows[0]["ProductUrl"]);
                    pro.ThumbImage = Convert.ToString(dt.Rows[0]["ThumbImage"]);
                    pro.SKUCode = Convert.ToString(dt.Rows[0]["SKUCode"]);
                    pro.Broucher = Convert.ToString(dt.Rows[0]["Broucher"]);
                    pro.DatasheetName = Convert.ToString(dt.Rows[0]["DatasheetName"]);
                    pro.DatasheetLink = Convert.ToString(dt.Rows[0]["DatasheetLink"]);
                    pro.Enquiry = Convert.ToString(dt.Rows[0]["Enquiry"]);
                    pro.Capability = Convert.ToString(dt.Rows[0]["Capability"]);
                    pro.SubCapability = Convert.ToString(dt.Rows[0]["SubCapability"]);
                    pro.Industry = Convert.ToString(dt.Rows[0]["Industry"]);
                    pro.FullDesc = Convert.ToString(dt.Rows[0]["FullDesc"]);
                    pro.PageTitle = Convert.ToString(dt.Rows[0]["PageTitle"]);
                    pro.MetaKeys = Convert.ToString(dt.Rows[0]["MetaKeys"]);
                    pro.MetaDesc = Convert.ToString(dt.Rows[0]["MetaDesc"]);
                    pro.AddedOn = Convert.ToDateTime(Convert.ToString(dt.Rows[0]["AddedOn"]));
                    pro.AddedBy = Convert.ToString(dt.Rows[0]["AddedBy"]);
                    pro.AddedIp = Convert.ToString(dt.Rows[0]["AddedIp"]);
                    pro.Status = Convert.ToString(dt.Rows[0]["Status"]);
                }
                else
                {
                    pro = null;
                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "getProductdetailsByUrl", ex.Message);
        }
        return pro;
    }
    public static List<ProductDetails> GetAllProduct(SqlConnection conSQ, string name)
    {
        List<ProductDetails> categories = new List<ProductDetails>();
        try
        {
            string query = @"select * from ProductDetails Where Industry=@Industry and status='Active'";
            using (SqlCommand cmd = new SqlCommand(query, conSQ))
            {
                // cmd.Parameters.AddWithValue("@id", SqlDbType.NVarChar).Value = id;
                cmd.Parameters.AddWithValue("@Industry", SqlDbType.NVarChar).Value = name;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                categories = (from DataRow dr in dt.Rows
                              select new ProductDetails()
                              {
                                  Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                  ProductGuid = Convert.ToString(dr["ProductGuid"]),
                                  ProductName = Convert.ToString(dr["ProductName"]),
                                  ProductUrl = Convert.ToString(dr["ProductUrl"]),
                                  ThumbImage = Convert.ToString(dr["ThumbImage"]),
                                  SKUCode = Convert.ToString(dr["SKUCode"]),
                                  Broucher = Convert.ToString(dr["Broucher"]),
                                  DatasheetName = Convert.ToString(dr["DatasheetName"]),
                                  DatasheetLink = Convert.ToString(dr["DatasheetLink"]),
                                  Enquiry = Convert.ToString(dr["Enquiry"]),
                                  Capability = Convert.ToString(dr["Capability"]),
                                  SubCapability = Convert.ToString(dr["SubCapability"]),
                                  Industry = Convert.ToString(dr["Industry"]),
                                  FullDesc = Convert.ToString(dr["FullDesc"]),
                                  PageTitle = Convert.ToString(dr["PageTitle"]),
                                  MetaKeys = Convert.ToString(dr["MetaKeys"]),
                                  MetaDesc = Convert.ToString(dr["MetaDesc"]),
                                  AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                  AddedBy = Convert.ToString(dr["AddedBy"]),
                                  AddedIp = Convert.ToString(dr["AddedIp"]),
                              }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllProduct", ex.Message);
        }
        return categories;
    }
}


public class Searchproduct
{
    public string LineItems { get; set; }
    public int TotalCount { get; set; }
    public string Status { get; set; }
    public string StatusMessage { get; set; }
}
