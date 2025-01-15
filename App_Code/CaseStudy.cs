using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Activities.Expressions;

/// <summary>
/// Summary description for CaseStudy
/// </summary>
public class CaseStudy
{
    public CaseStudy()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int Id { get; set; }
    public string CSThumbImage { get; set; }
    public string CSDetailImage { get; set; }
    public string UploadPDF { get; set; }
    public string CaseStudyName { get; set; }
    public string CaseStudyUrl { get; set; }
    public string Category { get; set; }
    public DateTime PostedOn { get; set; }
    public string Location { get; set; }
    public string Client { get; set; }
    public string PageTitle { get; set; }
    public string MetaKeys { get; set; }
    public string MetaDesc { get; set; }
    public string OverviewTitle { get; set; }
    public string OVDesc { get; set; }
    public string PSTitle { get; set; }
    public string PSDesc { get; set; }
    public string PSImages { get; set; }
    public string OATitle { get; set; }
    public string OADesc { get; set; }
    public string OAImages { get; set; }
    public string TUTitle { get; set; }
    public string TUDesc { get; set; }
    public string CETitle { get; set; }
    public string CEDesc { get; set; }
    public string DBPTitle { get; set; }
    public string DBPDesc { get; set; }
    public DateTime AddedOn { get; set; }
    public string AddedIP { get; set; }
    public string AddedBy { get; set; }
    public string Status { get; set; }
    public static int InsertCaseStudies(SqlConnection _con, CaseStudy cat)
    {
        int result = 0;


        try
        {
            string query = "Insert Into CaseStudy (CSThumbImage,CSDetailImage,UploadPDF,CaseStudyName,CaseStudyUrl,Category,PostedOn,Client,Location,PageTitle,MetaKeys,MetaDesc,OverviewTitle,OVDesc,PSTitle,PSDesc,PSImages,OATitle,OADesc,OAImages,TUTitle,TUDesc,CETitle,CEDesc,DBPTitle,DBPDesc,AddedBy,AddedOn,AddedIP,Status) values" +
                           "(@CSThumbImage,@CSDetailImage,@UploadPDF,@CaseStudyName,@CaseStudyUrl,@Category,@PostedOn,@Client,@Location,@PageTitle,@MetaKeys,@MetaDesc,@OverviewTitle,@OVDesc,@PSTitle,@PSDesc,@PSImages,@OATitle,@OADesc,@OAImages,@TUTitle,@TUDesc,@CETitle,@CEDesc,@DBPTitle,@DBPDesc,@AddedBy,@AddedOn,@AddedIP,@Status)";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@CSThumbImage", SqlDbType.NVarChar).Value = cat.CSThumbImage;
                cmd.Parameters.AddWithValue("@CSDetailImage", SqlDbType.NVarChar).Value = cat.CSDetailImage;
                cmd.Parameters.AddWithValue("@UploadPDF", SqlDbType.NVarChar).Value = cat.UploadPDF;
                cmd.Parameters.AddWithValue("@CaseStudyName", SqlDbType.NVarChar).Value = cat.CaseStudyName;
                cmd.Parameters.AddWithValue("@CaseStudyUrl", SqlDbType.NVarChar).Value = cat.CaseStudyUrl;
                cmd.Parameters.AddWithValue("@Category", SqlDbType.NVarChar).Value = cat.Category;
                cmd.Parameters.AddWithValue("@PostedOn", SqlDbType.DateTime).Value = cat.PostedOn;
                cmd.Parameters.AddWithValue("@Client", SqlDbType.NVarChar).Value = cat.Client;
                cmd.Parameters.AddWithValue("@Location", SqlDbType.NVarChar).Value = cat.Location;
                cmd.Parameters.AddWithValue("@PageTitle", SqlDbType.NVarChar).Value = cat.PageTitle;
                cmd.Parameters.AddWithValue("@MetaKeys", SqlDbType.NVarChar).Value = cat.MetaKeys;
                cmd.Parameters.AddWithValue("@MetaDesc", SqlDbType.NVarChar).Value = cat.MetaDesc;
                cmd.Parameters.AddWithValue("@OverviewTitle", SqlDbType.NVarChar).Value = cat.OverviewTitle;
                cmd.Parameters.AddWithValue("@OVDesc", SqlDbType.NVarChar).Value = cat.OVDesc;
                cmd.Parameters.AddWithValue("@PSTitle", SqlDbType.NVarChar).Value = cat.PSTitle;
                cmd.Parameters.AddWithValue("@PSDesc", SqlDbType.NVarChar).Value = cat.PSDesc;
                cmd.Parameters.AddWithValue("@PSImages", SqlDbType.NVarChar).Value = cat.PSImages;
                cmd.Parameters.AddWithValue("@OATitle", SqlDbType.NVarChar).Value = cat.OATitle;
                cmd.Parameters.AddWithValue("@OADesc", SqlDbType.NVarChar).Value = cat.OADesc;
                cmd.Parameters.AddWithValue("@OAImages", SqlDbType.NVarChar).Value = cat.OAImages;
                cmd.Parameters.AddWithValue("@TUTitle", SqlDbType.NVarChar).Value = cat.TUTitle;
                cmd.Parameters.AddWithValue("@TUDesc", SqlDbType.NVarChar).Value = cat.TUDesc;
                cmd.Parameters.AddWithValue("@CETitle", SqlDbType.NVarChar).Value = cat.CETitle;
                cmd.Parameters.AddWithValue("@CEDesc", SqlDbType.NVarChar).Value = cat.CEDesc;
                cmd.Parameters.AddWithValue("@DBPTitle", SqlDbType.NVarChar).Value = cat.DBPTitle;
                cmd.Parameters.AddWithValue("@DBPDesc", SqlDbType.NVarChar).Value = cat.DBPDesc;
                cmd.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = cat.AddedBy;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.DateTime).Value = cat.AddedOn;
                cmd.Parameters.AddWithValue("@AddedIP", SqlDbType.NVarChar).Value = cat.AddedIP;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                _con.Open();
                result = cmd.ExecuteNonQuery();
                _con.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "InsertCaseStudies", ex.Message);
        }
        return result;
    }
    public static int UpdateCaseStudies(SqlConnection _con, CaseStudy cat)
    {
        int result = 0;
        try
        {
            string query = "Update CaseStudy Set CSThumbImage=@CSThumbImage,CSDetailImage=@CSDetailImage,OverviewTitle=@OverviewTitle,OVDesc=@OVDesc,DBPTitle=@DBPTitle,DBPDesc=@DBPDesc,UploadPDF=@UploadPDF,CaseStudyName=@CaseStudyName,CaseStudyUrl=@CaseStudyUrl,CEDesc=@CEDesc,Category=@Category,PageTitle=@PageTitle,MetaKeys=@MetaKeys,Location=@Location,Client=@Client,PSDesc=@PSDesc,PStitle=@PStitle,OAImages=@OAImages,OATitle=@OATitle,TUTitle=@TUTitle,TUDesc=@TUDesc,CETitle=@CETitle,OADesc=@OADesc, PSImages=@PSImages, MetaDesc=@MetaDesc,PostedOn=@PostedOn,AddedOn=@AddedOn,AddedBy=@AddedBy,AddedIP=@AddedIP Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = cat.Id;
                cmd.Parameters.AddWithValue("@CSThumbImage", SqlDbType.NVarChar).Value = cat.CSThumbImage;
                cmd.Parameters.AddWithValue("@CSDetailImage", SqlDbType.NVarChar).Value = cat.CSDetailImage;
                cmd.Parameters.AddWithValue("@UploadPDF", SqlDbType.NVarChar).Value = cat.UploadPDF;
                cmd.Parameters.AddWithValue("@CaseStudyName", SqlDbType.NVarChar).Value = cat.CaseStudyName;
                cmd.Parameters.AddWithValue("@CaseStudyUrl", SqlDbType.NVarChar).Value = cat.CaseStudyUrl;
                cmd.Parameters.AddWithValue("@Category", SqlDbType.NVarChar).Value = cat.Category;
                cmd.Parameters.AddWithValue("@PostedOn", SqlDbType.DateTime).Value = cat.PostedOn;
                cmd.Parameters.AddWithValue("@Client", SqlDbType.NVarChar).Value = cat.Client;
                cmd.Parameters.AddWithValue("@Location", SqlDbType.NVarChar).Value = cat.Location;
                cmd.Parameters.AddWithValue("@PageTitle", SqlDbType.NVarChar).Value = cat.PageTitle;
                cmd.Parameters.AddWithValue("@MetaKeys", SqlDbType.NVarChar).Value = cat.MetaKeys;
                cmd.Parameters.AddWithValue("@MetaDesc", SqlDbType.NVarChar).Value = cat.MetaDesc;
                cmd.Parameters.AddWithValue("@OverviewTitle", SqlDbType.NVarChar).Value = cat.OverviewTitle;
                cmd.Parameters.AddWithValue("@OVDesc", SqlDbType.NVarChar).Value = cat.OVDesc;
                cmd.Parameters.AddWithValue("@PSTitle", SqlDbType.NVarChar).Value = cat.PSTitle;
                cmd.Parameters.AddWithValue("@PSDesc", SqlDbType.NVarChar).Value = cat.PSDesc;
                cmd.Parameters.AddWithValue("@PSImages", SqlDbType.NVarChar).Value = cat.PSImages;
                cmd.Parameters.AddWithValue("@OATitle", SqlDbType.NVarChar).Value = cat.OATitle;
                cmd.Parameters.AddWithValue("@OADesc", SqlDbType.NVarChar).Value = cat.OADesc;
                cmd.Parameters.AddWithValue("@OAImages", SqlDbType.NVarChar).Value = cat.OAImages;
                cmd.Parameters.AddWithValue("@TUTitle", SqlDbType.NVarChar).Value = cat.TUTitle;
                cmd.Parameters.AddWithValue("@TUDesc", SqlDbType.NVarChar).Value = cat.TUDesc;
                cmd.Parameters.AddWithValue("@CETitle", SqlDbType.NVarChar).Value = cat.CETitle;
                cmd.Parameters.AddWithValue("@CEDesc", SqlDbType.NVarChar).Value = cat.CEDesc;
                cmd.Parameters.AddWithValue("@DBPTitle", SqlDbType.NVarChar).Value = cat.DBPTitle;
                cmd.Parameters.AddWithValue("@DBPDesc", SqlDbType.NVarChar).Value = cat.DBPDesc;
                cmd.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = cat.AddedBy;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.DateTime).Value = cat.AddedOn;
                cmd.Parameters.AddWithValue("@AddedIP", SqlDbType.NVarChar).Value = cat.AddedIP;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                _con.Open();
                result = cmd.ExecuteNonQuery();
                _con.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UpdateCaseStudies", ex.Message);
        }
        return result;
    }
    public static CaseStudy getCaseStudiesById(SqlConnection _con, int id)
    {
        CaseStudy Case = new CaseStudy();
        try
        {
            string query = "Select top 1 * from CaseStudy where Status='Active' and Id=@Id";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Case.Id = Convert.ToInt32(Convert.ToString(dt.Rows[0]["Id"]));
                    Case.CSThumbImage = Convert.ToString(dt.Rows[0]["CSThumbImage"]);
                    Case.CSDetailImage = Convert.ToString(dt.Rows[0]["CSDetailImage"]);
                    Case.UploadPDF = Convert.ToString(dt.Rows[0]["UploadPDF"]);
                    Case.CaseStudyName = Convert.ToString(dt.Rows[0]["CaseStudyName"]);
                    Case.CaseStudyUrl = Convert.ToString(dt.Rows[0]["CaseStudyUrl"]);
                    Case.PageTitle = Convert.ToString(dt.Rows[0]["PageTitle"]);
                    Case.MetaKeys = Convert.ToString(dt.Rows[0]["MetaKeys"]);
                    Case.MetaDesc = Convert.ToString(dt.Rows[0]["MetaDesc"]);
                    Case.Category = Convert.ToString(dt.Rows[0]["Category"]);
                    Case.OVDesc = Convert.ToString(dt.Rows[0]["OVDesc"]);
                    Case.PSTitle = Convert.ToString(dt.Rows[0]["PSTitle"]);
                    Case.Client = Convert.ToString(dt.Rows[0]["Client"]);
                    Case.PSDesc = Convert.ToString(dt.Rows[0]["PSDesc"]);
                    Case.OADesc = Convert.ToString(dt.Rows[0]["OADesc"]);
                    Case.OATitle = Convert.ToString(dt.Rows[0]["OATitle"]);
                    Case.OAImages = Convert.ToString(dt.Rows[0]["OAImages"]);
                    Case.TUTitle = Convert.ToString(dt.Rows[0]["TUTitle"]);
                    Case.TUDesc = Convert.ToString(dt.Rows[0]["TUDesc"]);
                    Case.CETitle = Convert.ToString(dt.Rows[0]["CETitle"]);
                    Case.CEDesc = Convert.ToString(dt.Rows[0]["CEDesc"]);
                    Case.DBPTitle = Convert.ToString(dt.Rows[0]["DBPTitle"]);
                    Case.DBPDesc = Convert.ToString(dt.Rows[0]["DBPDesc"]);
                    Case.AddedOn = Convert.ToDateTime(Convert.ToString(dt.Rows[0]["AddedOn"]));
                    Case.PostedOn = Convert.ToDateTime(Convert.ToString(dt.Rows[0]["PostedOn"]));
                    Case.Location = Convert.ToString(dt.Rows[0]["Location"]);
                    Case.AddedBy = Convert.ToString(dt.Rows[0]["AddedBy"]);
                    Case.AddedIP = Convert.ToString(dt.Rows[0]["AddedIP"]);
                    Case.Status = Convert.ToString(dt.Rows[0]["Status"]);
                    Case.OverviewTitle = Convert.ToString(dt.Rows[0]["OverviewTitle"]);
                    Case.PSImages = Convert.ToString(dt.Rows[0]["PSImages"]);




                }
                else
                {
                    Case = null;
                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "getCaseStudyById", ex.Message);
        }
        return Case;
    }
    public static List<CaseStudy> GetAllCaseStudies(SqlConnection _con)
    {
        List<CaseStudy> categories = new List<CaseStudy>();
        try
        {
            string query = "Select *,(Select UserName from CreateUser Where UserGuid=CaseStudy.AddedBy) as UpdatedBy from CaseStudy where Status=@Status Order by Id ";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                categories = (from DataRow dr in dt.Rows
                              select new CaseStudy()
                              {
                                  Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                  CSThumbImage = Convert.ToString(dr["CSThumbImage"]),
                                  CSDetailImage = Convert.ToString(dr["CSDetailImage"]),
                                  UploadPDF = Convert.ToString(dr["UploadPDF"]),
                                  CaseStudyName = Convert.ToString(dr["CaseStudyName"]),
                                  CaseStudyUrl = Convert.ToString(dr["CaseStudyUrl"]),
                                  PageTitle = Convert.ToString(dr["PageTitle"]),
                                  MetaKeys = Convert.ToString(dr["MetaKeys"]),
                                  MetaDesc = Convert.ToString(dr["MetaDesc"]),
                                  Category = Convert.ToString(dr["Category"]),
                                  OVDesc = Convert.ToString(dr["OVDesc"]),
                                  PSTitle = Convert.ToString(dr["PSTitle"]),
                                  Client = Convert.ToString(dr["Client"]),
                                  PSDesc = Convert.ToString(dr["PSDesc"]),
                                  OADesc = Convert.ToString(dr["OADesc"]),
                                  OATitle = Convert.ToString(dr["OATitle"]),
                                  OAImages = Convert.ToString(dr["OAImages"]),
                                  TUTitle = Convert.ToString(dr["TUTitle"]),
                                  TUDesc = Convert.ToString(dr["TUDesc"]),
                                  CETitle = Convert.ToString(dr["CETitle"]),
                                  CEDesc = Convert.ToString(dr["CEDesc"]),
                                  DBPTitle = Convert.ToString(dr["DBPTitle"]),
                                  DBPDesc = Convert.ToString(dr["DBPDesc"]),
                                  AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                  PostedOn = Convert.ToDateTime(Convert.ToString(dr["PostedOn"])),
                                  Location = Convert.ToString(dr["Location"]),
                                  AddedBy = Convert.ToString(dr["AddedBy"]),
                                  AddedIP = Convert.ToString(dr["AddedIP"]),
                                  Status = Convert.ToString(dr["Status"]),
                                  OverviewTitle = Convert.ToString(dr["OverviewTitle"]),
                                  PSImages = Convert.ToString(dr["PSImages"]),
                              }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllCaseStudies", ex.Message);
        }
        return categories;
    }
    public static int DeleteCaseStudy(SqlConnection _con, CaseStudy cat)
    {
        int result = 0;
        try
        {
            string query = "Update CaseStudy Set Status=@Status, AddedOn=@AddedOn, AddedIP=@AddedIP Where Id=@Id ";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = cat.Id;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = cat.AddedOn;
                cmd.Parameters.AddWithValue("@AddedIP", SqlDbType.NVarChar).Value = cat.AddedIP;
                _con.Open();
                result = cmd.ExecuteNonQuery();
                _con.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteCaseStudy", ex.Message);
        }
        return result;
    }
    public static List<CaseStudy> GetAllCasestudies(SqlConnection _con)
    {
        List<CaseStudy> cs = new List<CaseStudy>();
        try
        {
            string query = "Select *,(Select UserName from CreateUser Where UserGuid=CaseStudy.AddedBy) as UpdatedBy from CaseStudy where Status=@Status Order by Id ";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cs = (from DataRow dr in dt.Rows
                      select new CaseStudy()
                      {
                          Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                          CSThumbImage = Convert.ToString(dr["CSThumbImage"]),
                          CSDetailImage = Convert.ToString(dr["CSDetailImage"]),
                          UploadPDF = Convert.ToString(dr["UploadPDF"]),
                          CaseStudyName = Convert.ToString(dr["CaseStudyName"]),
                          CaseStudyUrl = Convert.ToString(dr["CaseStudyUrl"]),
                          PageTitle = Convert.ToString(dr["PageTitle"]),
                          MetaKeys = Convert.ToString(dr["MetaKeys"]),
                          MetaDesc = Convert.ToString(dr["MetaDesc"]),
                          Category = Convert.ToString(dr["Category"]),
                          OVDesc = Convert.ToString(dr["OVDesc"]),
                          PSTitle = Convert.ToString(dr["PSTitle"]),
                          Client = Convert.ToString(dr["Client"]),
                          PSDesc = Convert.ToString(dr["PSDesc"]),
                          OADesc = Convert.ToString(dr["OADesc"]),
                          OATitle = Convert.ToString(dr["OATitle"]),
                          OAImages = Convert.ToString(dr["OAImages"]),
                          TUTitle = Convert.ToString(dr["TUTitle"]),
                          TUDesc = Convert.ToString(dr["TUDesc"]),
                          CETitle = Convert.ToString(dr["CETitle"]),
                          CEDesc = Convert.ToString(dr["CEDesc"]),
                          DBPTitle = Convert.ToString(dr["DBPTitle"]),
                          DBPDesc = Convert.ToString(dr["DBPDesc"]),
                          AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                          PostedOn = Convert.ToDateTime(Convert.ToString(dr["PostedOn"])),
                          Location = Convert.ToString(dr["Location"]),
                          AddedBy = Convert.ToString(dr["AddedBy"]),
                          AddedIP = Convert.ToString(dr["AddedIP"]),
                          Status = Convert.ToString(dr["Status"]),
                          OverviewTitle = Convert.ToString(dr["OverviewTitle"]),
                          PSImages = Convert.ToString(dr["PSImages"]),
                      }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllCasestudies", ex.Message);
        }
        return cs;
    }
    public static CaseStudy getCasestudiesDetailsByUrl(SqlConnection _con, string CaseStudyUrl)
    {
        CaseStudy cs = new CaseStudy();
        try
        {
            string query = "Select top 1 * from CaseStudy where Status='Active' and CaseStudyUrl=@CaseStudyUrl";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@CaseStudyUrl", SqlDbType.Int).Value = CaseStudyUrl;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cs.Id = Convert.ToInt32(Convert.ToString(dt.Rows[0]["Id"]));
                    cs.CSThumbImage = Convert.ToString(dt.Rows[0]["CSThumbImage"]);
                    cs.CSDetailImage = Convert.ToString(dt.Rows[0]["CSDetailImage"]);
                    cs.UploadPDF = Convert.ToString(dt.Rows[0]["UploadPDF"]);
                    cs.CaseStudyName = Convert.ToString(dt.Rows[0]["CaseStudyName"]);
                    cs.CaseStudyUrl = Convert.ToString(dt.Rows[0]["CaseStudyUrl"]);
                    cs.PageTitle = Convert.ToString(dt.Rows[0]["PageTitle"]);
                    cs.MetaKeys = Convert.ToString(dt.Rows[0]["MetaKeys"]);
                    cs.MetaDesc = Convert.ToString(dt.Rows[0]["MetaDesc"]);
                    cs.Category = Convert.ToString(dt.Rows[0]["Category"]);
                    cs.OVDesc = Convert.ToString(dt.Rows[0]["OVDesc"]);
                    cs.PSTitle = Convert.ToString(dt.Rows[0]["PSTitle"]);
                    cs.Client = Convert.ToString(dt.Rows[0]["Client"]);
                    cs.PSDesc = Convert.ToString(dt.Rows[0]["PSDesc"]);
                    cs.OADesc = Convert.ToString(dt.Rows[0]["OADesc"]);
                    cs.OATitle = Convert.ToString(dt.Rows[0]["OATitle"]);
                    cs.OAImages = Convert.ToString(dt.Rows[0]["OAImages"]);
                    cs.TUTitle = Convert.ToString(dt.Rows[0]["TUTitle"]);
                    cs.TUDesc = Convert.ToString(dt.Rows[0]["TUDesc"]);
                    cs.CETitle = Convert.ToString(dt.Rows[0]["CETitle"]);
                    cs.CEDesc = Convert.ToString(dt.Rows[0]["CEDesc"]);
                    cs.DBPTitle = Convert.ToString(dt.Rows[0]["DBPTitle"]);
                    cs.DBPDesc = Convert.ToString(dt.Rows[0]["DBPDesc"]);
                    cs.AddedOn = Convert.ToDateTime(Convert.ToString(dt.Rows[0]["AddedOn"]));
                    cs.PostedOn = Convert.ToDateTime(Convert.ToString(dt.Rows[0]["PostedOn"]));
                    cs.Location = Convert.ToString(dt.Rows[0]["Location"]);
                    cs.AddedBy = Convert.ToString(dt.Rows[0]["AddedBy"]);
                    cs.AddedIP = Convert.ToString(dt.Rows[0]["AddedIP"]);
                    cs.Status = Convert.ToString(dt.Rows[0]["Status"]);
                    cs.OverviewTitle = Convert.ToString(dt.Rows[0]["OverviewTitle"]);
                    cs.PSImages = Convert.ToString(dt.Rows[0]["PSImages"]);
                }
                else
                {
                    cs = null;
                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "getCasestudiesDetailsByUrl", ex.Message);
        }
        return cs;
    }
}