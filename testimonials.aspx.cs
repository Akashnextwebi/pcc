﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class testimonials : System.Web.UI.Page
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


                    strtestimonial += @"<div class='col-lg-4'>
                                <div class='single-testimonial'>
                                    <div class='review-icon'>
                                        <img src='image/icons/review-icon.png' alt='img'>
                                    </div>
                                    <p>
                                        "+ Testimonial[i].TestimonialDesc + @"
                                    </p>
                                    <div class='testi-author'>
                                        <div class='ta-info'>
                                            <h6>"+ Testimonial[i].Name + @"<span>/"+ Testimonial[i].Designation + @"</span>
                                            </h6>
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
