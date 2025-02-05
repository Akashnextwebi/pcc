using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string strtestimonial = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        BindTestimonials();
    }
    private void BindTestimonials()
    {

        try
        {
            strtestimonial = "";
            var Testimonial = TestimonialDetails.GetAllTestimonials(conSQ).ToList();
            if (Testimonial.Count > 0)
            {
                for (int i = 0; i < Testimonial.Count; i++)
                {


                    strtestimonial += @"<div class='testimonial-box'>
              <div class='single-testimonial'>
                  <div class='review-icon'>
                      <img src='image/icons/review-icon.png' alt='img' />
                  </div>
                  <p>
                     <a href='testimonials.aspx'>" + Testimonial[i].TestimonialDesc + @"</a>
                  </p>
                  <div class='testi-author'>
                      <div class='ta-info'>
                          <a href='testimonials.aspx'<h6>" + Testimonial[i].Name + @" <span>/"+ Testimonial[i].Designation + @"</span></h6></a>
                      </div>
                  </div>
              </div>
          </div>";

                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindTestimonials", ex.Message);
        }
    }
}