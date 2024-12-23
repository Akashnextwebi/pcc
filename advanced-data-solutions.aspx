<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="advanced-data-solutions.aspx.cs" Inherits="advanced_data_solutions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/breadcrums.css" rel="stylesheet" />
    <style>
        .service-card p {
            font-size: 16px !important;
            line-height: 28px !important;
            opacity: 1 !important;
            padding: 0px !important;
        }

        .service-card h3 {
            font-size: 20px;
            font-weight: 700 !important;
        }

        .service-card .image > img {
            height: unset !important;
        }

        .service-card {
            padding: 0px !important;
        }

            .service-card .title {
                padding: 20px 20px 20px;
            }

        .project__item-two {
            position: relative;
            z-index: 1;
            margin-bottom: 25px;
        }

        .project__thumb-two {
            position: relative;
            overflow: hidden;
        }

            .project__thumb-two::before {
                content: "";
                position: absolute;
                left: 0;
                top: 0;
                width: 100%;
                height: 100%;
                opacity: 0;
                background: #272727;
                z-index: 1;
                pointer-events: none;
                -webkit-transition: all 0.3s ease-out 0s;
                -moz-transition: all 0.3s ease-out 0s;
                -ms-transition: all 0.3s ease-out 0s;
                -o-transition: all 0.3s ease-out 0s;
                transition: all 0.3s ease-out 0s;
            }

            .project__thumb-two img {
                width: 100%;
                height: 450px;
                object-fit: cover;
            }

            .project__thumb-two .shape {
                content: "";
                position: absolute;
                right: -60%;
                top: 20%;
                transform: translateY(-50%) rotate(135deg);
                width: 320px;
                height: 1030px;
                background: linear-gradient(180deg, #181717 0%, rgba(18, 18, 18, 0) 100%);
                opacity: 0;
                -webkit-transition: all 0.3s ease-out 0s;
                -moz-transition: all 0.3s ease-out 0s;
                -ms-transition: all 0.3s ease-out 0s;
                -o-transition: all 0.3s ease-out 0s;
                transition: all 0.3s ease-out 0s;
                margin-right: -60px;
                z-index: 1;
                pointer-events: none;
            }

            .project__thumb-two::after {
                content: "";
                position: absolute;
                right: -2%;
                top: 50%;
                transform: translateY(-50%) rotate(135deg);
                width: 240px;
                height: 964px;
                background: linear-gradient(180deg, #262626 8.61%, rgba(18, 18, 18, 0) 100%);
                opacity: 0;
                -webkit-transition: all 0.3s ease-out 0s;
                -moz-transition: all 0.3s ease-out 0s;
                -ms-transition: all 0.3s ease-out 0s;
                -o-transition: all 0.3s ease-out 0s;
                transition: all 0.3s ease-out 0s;
                margin-right: -90px;
                pointer-events: none;
            }

        .project__content-two {
            position: absolute;
            left: 30px;
            right: 30px;
            bottom: 60px;
            border-top: 4px solid #fff;
            padding-top: 22px;
            opacity: 1;
            z-index: 3;
            -webkit-transform: translateY(50px);
            -moz-transform: translateY(50px);
            -ms-transform: translateY(50px);
            -o-transform: translateY(50px);
            transform: translateY(50px);
            -webkit-transition: all 0.3s ease-out 0s;
            -moz-transition: all 0.3s ease-out 0s;
            -ms-transition: all 0.3s ease-out 0s;
            -o-transition: all 0.3s ease-out 0s;
            transition: all 0.3s ease-out 0s;
        }

        .project__item-two .project__thumb-two::before {
            opacity: 0.4;
        }

        .project__content-two .title {
            margin-bottom: 10px;
            color: #fff;
            font-size: 24px;
            font-weight: 500;
        }

        .eg-card3.three {
            position: relative;
            padding: 0;
            height: 100%;
            transition: 0.5s;
        }

            .eg-card3.three .card-img {
                height: 100%;
            }

            .eg-card3.three .card-content {
                background: linear-gradient(357deg, #000 1.72%, rgba(0, 0, 0, 0) 49.89%);
                position: absolute;
                left: 0;
                top: 0;
                width: 100%;
                height: 100%;
                transform: unset;
                padding: 50px 40px;
                display: flex;
                justify-content: end;
                flex-direction: column;
                transition: 0.5s;
            }

            .eg-card3.three .card-img img {
                min-height: 350px;
                height: 100%;
                -o-object-fit: cover;
                object-fit: cover;
            }

            .eg-card3.three .card-content .view-btn {
                position: absolute;
                right: 85px;
                top: 85px;
                transition: 0.5s;
                opacity: 0;
            }

            .eg-card3.three .card-content .catgory-and-title > a {
                border-radius: 16px;
                border: 1px solid rgba(255, 255, 255, 0.5);
                background: 0 0;
                display: inline-block;
                color: #fff;
                text-align: center;
                font-size: 12px;
                font-weight: 500;
                padding: 2px 17px;
                margin-bottom: 13px;
            }

        .eg-card3 .card-content .catgory-and-title h5 a {
            color: #fff;
            font-size: 40px;
            font-weight: 500;
            transition: 0.35s;
        }

        .eg-card3.three .card-content .catgory-and-title h5 {
            margin-bottom: 0;
        }

            .eg-card3.three .card-content .catgory-and-title h5 a {
                font-size: 24px;
            }

        .eg-card3.two .card-content .catgory-and-title h5 a {
            font-size: 24px;
        }

        .eg-card3.two:hover .card-content .view-btn {
            right: 35px;
            top: 35px;
            opacity: 1;
        }

        .eg-card3.three:hover .card-content .view-btn {
            right: 35px;
            top: 35px;
            opacity: 1;
        }

        .eg-card3.three .card-content .view-btn {
            position: absolute;
            right: 85px;
            top: 85px;
            transition: 0.5s;
            opacity: 0;
        }

        .single-scroll-container {
            background-size: cover;
            background-position: center;
            background-repeat: no-repeat;
        }

            .single-scroll-container .horizontal-scrolling-content {
                max-width: 700px;
                width: 100%;
                background: #000;
                margin-left: 630px;
                padding: 100px 30px;
            }

                .single-scroll-container .horizontal-scrolling-content .section-title1 {
                    margin-bottom: 10px;
                }

        .section-title1.two {
            flex-direction: column;
        }

        .section-title1 {
            display: flex;
            align-items: flex-start;
            justify-content: space-between;
            max-width: 1066px;
            width: 100%;
            gap: 25px;
        }

        .single-scroll-container .horizontal-scrolling-content .section-title1 span {
            color: #fff;
            border-color: #fff;
        }

        .single-scroll-container .horizontal-scrolling-content .section-title1 h2 {
            color: #fff;
            margin-bottom: 0;
        }

        .section-title1.two h2 {
            margin-top: 0;
            padding-top: 10px;
        }

        .section-title1 h2 {
            font-size: 40px;
            font-weight: 400;
            margin-bottom: 0;
            max-width: 640px;
            margin-top: -10px;
        }

        .section-title1 > span {
            color: #0d1720;
            text-align: center;
            font-size: 16px;
            font-weight: 400;
            line-height: 1;
            display: inline-block;
            border-radius: 16px;
            border: 1px solid #000;
            padding: 7px 20px;
            white-space: nowrap;
        }

        .single-scroll-container .horizontal-scrolling-content p {
            color: #fff;
            font-size: 16px;
            font-weight: 400;
            line-height: 30px;
        }

        .broacher-card {
    padding: 10px;
    box-shadow: rgba(149, 157, 165, 0.2) 0px 8px 24px;
}
        .broacher-content {
            margin-top:15px;

        }
        .broacher-content span {
            border-bottom:1px solid #000;
            color:#79010c;
            font-weight:600;
            font-size:18px !important;
        }


          .broacher-content h4 {
    font-size:24px;
              margin-top:10px;
  }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <main class="wrapper">
        <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(image/blog/braadcrumb-bg3.jpg);">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="banner-content">
                            <h1>Advance Data Solutions</h1>
                            <div class="">
                                <ul class="breadcrumb-list">
                                    <li><a href="Default.aspx">Home</a></li>
                                    <li>Advance Data Solutions</li>
                                </ul>
                            </div>

                            <div class="slider-btn mt-30 ">
                                <a href="#" class="btn ss-btn mr-15" data-animation="fadeInLeft" data-delay=".4s" tabindex="0" contenteditable="false" style="animation-delay: 0.4s; cursor: pointer;"><i class="fal fa fa-download"></i>Download the broacher</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <section class="section-padding pb-0">
            <div class="container">
                <div class="row">
                    <div class="col-lg-10">
                        <h2>Advance Data Solutions: Revolutionizing Park Control and Communications

                        </h2>
                        <p>Advance Data Solutions is at the forefront of developing advanced technologies for park control and communication systems. With a focus on innovation, the company delivers seamless, integrated solutions that enhance efficiency, safety, and user experience. From managing traffic flow in parking facilities to ensuring robust communication networks, Advance Data Solutions combines cutting-edge technology with industry expertise to meet the demands of modern infrastructure. Their solutions are tailored to optimize operations, reduce downtime, and provide reliable, scalable systems for diverse applications.</p>
                    </div>
                </div>

            </div>
        </section>
        <section class="section-padding">
            <div class="container">
                <div class="row gy-4">
                    <div class="col-lg-4 col-md-6">
                        <div class="eg-card3 three">
                            <div class="card-img">
                                <img src="image/sub1/1.png" alt="">
                            </div>
                            <div class="card-content">
                                <a class="view-btn" href="product-lisitng.aspx">
                                    <img src="image/sub1/right-arrow2.png" alt="">
                                </a>
                                <div class="catgory-and-title">
                                    <a href="product-lisitng.aspx">Technology</a>
                                    <h5><a href="product-lisitng.aspx">Management Consulting</a></h5>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-6">
                        <div class="eg-card3 three">
                            <div class="card-img">
                                <img src="image/sub1/2.png" alt="">
                            </div>
                            <div class="card-content">
                                <a class="view-btn" href="product-lisitng.aspx">
                                    <img src="image/sub1/right-arrow2.png" alt="">
                                </a>
                                <div class="catgory-and-title">
                                    <a href="product-lisitng.aspx">Technology</a>
                                    <h5><a href="product-lisitng.aspx">Management Consulting</a></h5>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-6">
                        <div class="eg-card3 three">
                            <div class="card-img">
                                <img src="image/sub1/3.png" alt="">
                            </div>
                            <div class="card-content">
                                <a class="view-btn" href="product-lisitng.aspx">
                                    <img src="image/sub1/right-arrow2.png" alt="">
                                </a>
                                <div class="catgory-and-title">
                                    <a href="product-lisitng.aspx">Technology</a>
                                    <h5><a href="product-lisitng.aspx">Management Consulting</a></h5>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-6">
                        <div class="eg-card3 three">
                            <div class="card-img">
                                <img src="image/sub1/4.png" alt="">
                            </div>
                            <div class="card-content">
                                <a class="view-btn" href="product-lisitng.aspx">
                                    <img src="image/sub1/right-arrow2.png" alt="">
                                </a>
                                <div class="catgory-and-title">
                                    <a href="product-lisitng.aspx">Technology</a>
                                    <h5><a href="product-lisitng.aspx">Management Consulting</a></h5>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-6">
                        <div class="eg-card3 three">
                            <div class="card-img">
                                <img src="image/sub1/5.png" alt="">
                            </div>
                            <div class="card-content">
                                <a class="view-btn" href="product-lisitng.aspx">
                                    <img src="image/sub1/right-arrow2.png" alt="">
                                </a>
                                <div class="catgory-and-title">
                                    <a href="product-lisitng.aspx">Technology</a>
                                    <h5><a href="product-lisitng.aspx">Management Consulting</a></h5>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-6">
                        <div class="eg-card3 three">
                            <div class="card-img">
                                <img src="image/sub1/6.png" alt="">
                            </div>
                            <div class="card-content">
                                <a class="view-btn" href="product-lisitng.aspx">
                                    <img src="image/sub1/right-arrow2.png" alt="">
                                </a>
                                <div class="catgory-and-title">
                                    <a href="product-lisitng.aspx">Technology</a>
                                    <h5><a href="product-lisitng.aspx">Management Consulting</a></h5>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <div class="horizontal-scrolling-section ">
            <div class="single-scroll-container" style="background-image: linear-gradient(180deg, rgba(0, 0, 0, 0.2) 0%, rgba(0, 0, 0, 0.2) 100%), url(image/scroll-bg-1.jpg);">
                <div class="container-fluid one pl--95">
                    <div class="horizontal-scrolling-content">
                        <div class="section-title1 two">
                            <span>Real Estate</span>
                            <h2>Defense Solutions Product Guide
                            </h2>
                        </div>
                        <p>
                            Explore Curtiss-Wright's mission-critical solutions based on the latest technologies and open standards. These innovative solutions are trusted and proven for aerospace and defense applications.
                        </p>
                        <div class="slider-btn mt-30 ">
                            <a href="#" class="btn ss-btn mr-15" data-animation="fadeInLeft" data-delay=".4s" tabindex="0" contenteditable="false" style="animation-delay: 0.4s; cursor: pointer;"><i class="fal fa fa-download"></i>Download the product guide</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <section class="section-padding">

            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="pcc-section-heading mb-0">
                            <span>Our Core Competence</span>
                            <h2>Brochure for Advance Data Solutions
</h2>
                        </div>
                    </div>
                </div>
                <div class="row mt-4">
                    <div class="col-lg-3">
                        <div class="broacher-card">
                            <div class="broacher-img">
                                <img src="image/brochure/1.png" alr="img" />

                            </div>
                            <div class="broacher-content">
                                <span>White Paper</span>
                                <h4>Innovative Jet Control Communication Solutions
                                </h4>
                                <p>Jet control and communication systems are critical for ensuring safe and efficient aviation operations. Advanced technologies enable seamless coordination between pilots, ground crews, and air traffic.</p>
                            </div>
                        </div>

                    </div>
                      <div class="col-lg-3">
      <div class="broacher-card">
          <div class="broacher-img">
              <img src="image/brochure/1.png" alr="img" />

          </div>
          <div class="broacher-content">
              <span>White Paper</span>
              <h4>Innovative Jet Control Communication Solutions
              </h4>
              <p>Jet control and communication systems are critical for ensuring safe and efficient aviation operations. Advanced technologies enable seamless coordination between pilots, ground crews, and air traffic.</p>
          </div>
      </div>

  </div>  <div class="col-lg-3">
      <div class="broacher-card">
          <div class="broacher-img">
              <img src="image/brochure/1.png" alr="img" />

          </div>
          <div class="broacher-content">
              <span>White Paper</span>
              <h4>Innovative Jet Control Communication Solutions
              </h4>
              <p>Jet control and communication systems are critical for ensuring safe and efficient aviation operations. Advanced technologies enable seamless coordination between pilots, ground crews, and air traffic.</p>
          </div>
      </div>

  </div>  <div class="col-lg-3">
      <div class="broacher-card">
          <div class="broacher-img">
              <img src="image/brochure/1.png" alr="img" />

          </div>
          <div class="broacher-content">
              <span>White Paper</span>
              <h4>Innovative Jet Control Communication Solutions
              </h4>
              <p>Jet control and communication systems are critical for ensuring safe and efficient aviation operations. Advanced technologies enable seamless coordination between pilots, ground crews, and air traffic.</p>
          </div>
      </div>

  </div>
                </div>
            </div>

        </section>
    </main>
</asp:Content>

