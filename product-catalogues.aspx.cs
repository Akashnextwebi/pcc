using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class product_catalogues : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string strcatalogues = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        BindProductcatalogues();
    }
    private void BindProductcatalogues()
    {

        try
        {
            strcatalogues = "";
            var pc = ProductCatalogue.GetAllProductcatalogues(conSQ).ToList();
            if (pc.Count > 0)
            {
                for (int i = 0; i < pc.Count; i++)
                {

                    strcatalogues += @"<div class='col-lg-4'>
                        <div class='magnetic-wrap'>
                            <div class='case-study-card2 magnetic-item' style=''>
                                <div class='case-img'>
                                    <img src='/" + pc[i].ThumbImage +@"' alt=''>
                                </div>
                                <div class='case-content'>
                                    <div class='category-and-title'>
                                        <h4><a href='javascript:void(0);'>" + pc[i].CatalogueName + @"</a></h4>
                                    </div>
                                    <div class='details-btn text-center'>
                                        <a class='primary-btn2 btn-hover w-100 text-center' href='" + pc[i].PDFLink +@"' download=''>Download &nbsp;
                 <svg xmlns='http://www.w3.org/2000/svg' width='12' height='12' viewBox='0 0 12 12'>
                     <path fill-rule='evenodd' clip-rule='evenodd' d='M10.1865 1.06237L0 11.2484L0.751627 12L10.9376 1.81347V8.85645H12V0H3.14355V1.06237H10.1865Z'></path>
                 </svg>
                                            <span style='top: 51.7875px; left: 100.853px;'></span>
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>";

                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindProductcatalogues", ex.Message);
        }
    }
}