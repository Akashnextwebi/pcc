<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="testimonials.aspx.cs" Inherits="testimonials" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/breadcrums.css" rel="stylesheet" />
    <style>
        .single-testimonial {
  position: relative;
  background-color: #fff;
  padding: 30px;
  margin: 0 0 9px;
  box-shadow: 0px 4px 16px 0px rgba(0, 0, 0, 0.07);
  border-radius: 0;
  height:100%;
}


.single-testimonial  .testi-img {
  float: left;
  margin-bottom: 20px;
  position: absolute;
  left: 0;
  top: 80px;
}
.single-testimonial  .ta-info {
  overflow: hidden;
  float: left;
  padding-left: 0;
  margin-top: 35px;
}
.ta-info h6{
    color:#000;
}
.single-testimonial p{
  overflow: unset;
    text-overflow: unset;
    -webkit-line-clamp: unset;
    display: unset;
    -webkit-box-orient: unset;
}
.ta-info span{
    color:#999;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(image/blog/braadcrumb-bg3.jpg);">
    <div class="container-fluid one pl--95">
        <div class="row">
            <div class="col-lg-12">
                <div class="banner-content">
                    <h1>Testimonials</h1>
                    <ul class="breadcrumb-list">
                        <li><a href="Default.aspx">Home</a></li>
                        <li>Testimonials</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
    <section
  id="testimonial"
  class="testimonial-area pt-100 pb-100 p-relative fix"
>
  <div class="container">
    
    <div class="row">
      <div class="col-lg-12">
        <div
          class="pcc-section-heading wow fadeInDown animated"
          data-animation="fadeInDown"
          data-delay=".4s"
        >
          <span>Testimonials</span>
          <h2>What Our Client's Say</h2>
        </div>
      </div>
      <div class="col-lg-12">

          
        <div
          class="row gy-4"
          data-animation="fadeInUp"
          data-delay=".4s"
        >
            <%=strtestimonial %>
         <%-- <div class="testimonial-box">
            <div class="single-testimonial">
              <div class="review-icon">
                <img src="image/icons/review-icon.png" alt="img" />
              </div>
              <p>
                “Park Controls & Communications (P) Ltd., Bangalore has
                been supplying PCM Decommutation Systems for last fifteen
                years. The products supplied by the company are presently
                in use with us for Flight Trials and testing”
              </p>
              <div class="testi-author">
                <div class="ta-info">
                  <h6>
                    Mr. S. Venugopal <span>/PD, ASTRA Project</span>
                  </h6>
                </div>
              </div>
            </div>
          </div>
          <div class="testimonial-box">
            <div class="single-testimonial">
              <div class="review-icon">
                <img src="image/icons/review-icon.png" alt="img" />
              </div>
              <p>
                Park Controls & Communications (P) Ltd., Bangalore has
                been supplying Telemetry equipments for last fifteen
                years. The products supplied by the company are presently
                in use with us for LCA Flight trials and testing.
              </p>
              <div class="testi-author">
                <div class="ta-info">
                  <h6>Mr. B. Umashankar <span>/ NFTC / ADA</span></h6>
                </div>
              </div>
            </div>
          </div>
          <div class="testimonial-box">
            <div class="single-testimonial">
              <div class="review-icon">
                <img src="image/icons/review-icon.png" alt="img" />
              </div>
              <p>
                Park Controls and Communications supplied the Telemetry
                Receiving station for Brahmos Aerospace Pvt Ltd. The
                system is robust, rich in feature and user friendly. The
                performance of the system is excellent and meets our
                requirement.
              </p>
              <div class="testi-author">
                <div class="ta-info">
                  <h6>
                    S Masood Ahmed <span>/Addl General manager</span>
                  </h6>
                </div>
              </div>
            </div>
          </div>
          <div class="testimonial-box">
            <div class="single-testimonial">
              <div class="review-icon">
                <img src="image/icons/review-icon.png" alt="img" />
              </div>
              <p>
                Park Controls & Communications (P) Ltd., Bangalore has
                been supplying Telemetry equipments for last fifteen
                years. The products supplied by the company are presently
                in use with us for LCA Flight trials and testing.
              </p>
              <div class="testi-author">
                <div class="ta-info">
                  <h6>Mr. B. Umashankar <span>/ NFTC / ADA</span></h6>
                </div>
              </div>
            </div>
          </div>--%>
            </div>
        </div>
    </div>
  </div>
</section>
</asp:Content>

