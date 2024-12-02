<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="job-listing.aspx.cs" Inherits="job_listing" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/about.css" rel="stylesheet" />
    <link href="css/breadcrums.css" rel="stylesheet" />
    <style>
        .job-list-three {
            background: #fff;
            border: 1px solid #EBEBEB;
            border-radius: 10px;
            padding: 28px 40px 30px;
            transition: all .2s ease-in-out 0s;
        }

            .job-list-three .main-wrapper {
                position: relative;
                display: flex;
                flex-direction: column;
            }

                .job-list-three .main-wrapper .list-header {
                    border-bottom: 1px solid #EAEAEA;
                    padding-bottom: 30px;
                    margin-bottom: 25px;
                }

                .job-list-three .main-wrapper .logo {
                    width: 50px;
                }

                .job-list-three .main-wrapper .info-wrapper {
                    width: calc(100% - 50px);
                    padding-left: 22px;
                    padding-right: 37px;
                }

                .job-list-three .main-wrapper .title {
                    font-size: 18px;
                    color: #000;
                    margin-bottom: 7px;
                }

        .style-none {
            list-style: none;
            padding-left: 0;
            margin-bottom: 0;
        }

        .job-list-three .main-wrapper .info-data li {
            font-size: 14px;
            font-weight: 500;
            color: #244034b3;
            position: relative;
            margin-right: 20px;
        }

            .job-list-three .main-wrapper .info-data li:before {
                content: ".";
                position: absolute;
                right: -10px;
                top: 0;
            }

        .job-list-three .main-wrapper p {
            font-size: 14px;
            line-height: 28px;
            margin-bottom: 25px;
        }

        .job-list-three .main-wrapper .job-duration {
            display: inline-block;
            font-size: .875rem;
            font-weight: 500;
            color: #000;
            border-radius: 50px;
            padding: 5px 21px;
            background: #f3e8c1;
        }


        .job-list-three .main-wrapper .apply-btn {
            width: 80px;
            line-height: 30px;
            font-weight: 500;
            font-size: 12px;
            letter-spacing: 1px;
            color: #fff;
            text-transform: uppercase;
            border-radius: 17px;
            background: #31795a;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <main class="wrapper">

         <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(image/blog/braadcrumb-bg3.jpg);">
      <div class="container-fluid one pl--95">
          <div class="row">
              <div class="col-lg-12">
                  <div class="banner-content">
                      <h1>Career</h1>
                      <ul class="breadcrumb-list">
                          <li><a href="index.html">Home</a></li>
                          <li>Career</li>
                      </ul>
                  </div>
              </div>
          </div>
      </div>
  </div>
        <section class="section-padding">
            <div class="container">
                <div class="row justify-content-center">
                    <div class="col-lg-8">
                        <div class="text-center mb-100">
                            <h2>About Career at PCC</h2>
                            <p>
                                Park Controls and Communications Ltd. (ParkControls) is an Indian company specializing in defense and aerospace technologies. They are known for developing cutting-edge systems like flight data recorders, telemetry systems, and other high-tech solutions for the defense and aviation sectors.

                            </p>
                        </div>
                    </div>
                </div>
                <div class="row justify-content-center align-items-center ">
                    <div class="col-lg-3">
                        <div class="career__gallery-img">
                            <img src="image/career/11.png" class="img-fluid w-100" alt="Image">
                        </div>
                    </div>
                    <div class="col-xxl-5 col-xl-5 col-lg-5 col-md-5 d-none d-md-block">
                        <div class="career__gallery-img img-anim">
                            <img src="image/career/111.png" alt="Image" class="img-fluid w-100" data-speed="auto" data-lag="0">
                        </div>
                    </div>
                    <div class="col-xxl-4 col-xl-4 col-lg-4 col-md-4 d-none d-lg-block">
                        <div class="career__gallery-img">
                            <div class="mb-30">
                                <img src="image/career/1111.png" class="img-fluid w-100" alt="Image">
                            </div>
                            <img src="image/career/2222.png" class="img-fluid w-100" alt="Image">
                        </div>
                    </div>

                </div>
            </div>
        </section>
        <section class="section-padding bg-dark">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="text-center mb-50">
                            <h2 class="text-white">Current Job Opening</h2>
                        </div>


                    </div>
                </div>
                <div class="row gy-4">
                    <div class="col-lg-6">
                        <div class="job-list-three d-flex h-100 w-100">
                            <div class="main-wrapper h-100 w-100">
                                <a href="job-details-v2" class="save-btn text-center rounded-circle tran3s" title="Save Job"><i class="bi bi-bookmark-dash"></i></a>
                                <div class="list-header d-flex align-items-center">
                                    <a href="/job-details-v2" class="logo">
                                        <img src="/image/media_37.png" data-src="/image/media_37.png" alt="" class="lazy-img m-auto"></a>
                                    <div class="info-wrapper">
                                        <a href="/job-details-v2" class="title fw-500 tran3s">Developer &amp; expert in java c++</a>
                                        <ul class="style-none d-flex flex-wrap info-data">
                                            <li>$30-$50/hour</li>
                                            <li>Intermediate</li>
                                            <li>Spain, Barcelona</li>
                                        </ul>
                                    </div>
                                </div>
                                <p>
                                    We would like to design a page on Figma to promote Workroom as All-in-one
													solutions for Marketing, Sales, Support teams...
                                </p>
                                <div class="d-sm-flex align-items-center justify-content-between mt-auto">
                                    <div class="d-flex align-items-center">
                                        <a href="/job-details-v2" class="job-duration fw-500">Fulltime</a>
                                    </div>
                                    <a href="#" class="btn2 " data-animation="fadeInLeft" data-delay=".4s">Apply Now <i class="fal fa-long-arrow-right"></i></a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-6">
    <div class="job-list-three d-flex h-100 w-100">
        <div class="main-wrapper h-100 w-100">
            <a href="job-details-v2" class="save-btn text-center rounded-circle tran3s" title="Save Job"><i class="bi bi-bookmark-dash"></i></a>
            <div class="list-header d-flex align-items-center">
                <a href="/job-details-v2" class="logo">
                    <img src="/image/media_37.png" data-src="/image/media_37.png" alt="" class="lazy-img m-auto"></a>
                <div class="info-wrapper">
                    <a href="/job-details-v2" class="title fw-500 tran3s">Developer &amp; expert in java c++</a>
                    <ul class="style-none d-flex flex-wrap info-data">
                        <li>$30-$50/hour</li>
                        <li>Intermediate</li>
                        <li>Spain, Barcelona</li>
                    </ul>
                </div>
            </div>
            <p>
                We would like to design a page on Figma to promote Workroom as All-in-one
											solutions for Marketing, Sales, Support teams...
            </p>
            <div class="d-sm-flex align-items-center justify-content-between mt-auto">
                <div class="d-flex align-items-center">
                    <a href="/job-details-v2" class="job-duration fw-500">Fulltime</a>
                </div>
                <a href="#" class="btn2 " data-animation="fadeInLeft" data-delay=".4s">Apply Now <i class="fal fa-long-arrow-right"></i></a>
            </div>
        </div>
    </div>
</div><div class="col-lg-6">
    <div class="job-list-three d-flex h-100 w-100">
        <div class="main-wrapper h-100 w-100">
            <a href="job-details-v2" class="save-btn text-center rounded-circle tran3s" title="Save Job"><i class="bi bi-bookmark-dash"></i></a>
            <div class="list-header d-flex align-items-center">
                <a href="/job-details-v2" class="logo">
                    <img src="/image/media_37.png" data-src="/image/media_37.png" alt="" class="lazy-img m-auto"></a>
                <div class="info-wrapper">
                    <a href="/job-details-v2" class="title fw-500 tran3s">Developer &amp; expert in java c++</a>
                    <ul class="style-none d-flex flex-wrap info-data">
                        <li>$30-$50/hour</li>
                        <li>Intermediate</li>
                        <li>Spain, Barcelona</li>
                    </ul>
                </div>
            </div>
            <p>
                We would like to design a page on Figma to promote Workroom as All-in-one
											solutions for Marketing, Sales, Support teams...
            </p>
            <div class="d-sm-flex align-items-center justify-content-between mt-auto">
                <div class="d-flex align-items-center">
                    <a href="/job-details-v2" class="job-duration fw-500">Fulltime</a>
                </div>
                <a href="#" class="btn2 " data-animation="fadeInLeft" data-delay=".4s">Apply Now <i class="fal fa-long-arrow-right"></i></a>
            </div>
        </div>
    </div>
</div><div class="col-lg-6">
    <div class="job-list-three d-flex h-100 w-100">
        <div class="main-wrapper h-100 w-100">
            <a href="job-details-v2" class="save-btn text-center rounded-circle tran3s" title="Save Job"><i class="bi bi-bookmark-dash"></i></a>
            <div class="list-header d-flex align-items-center">
                <a href="/job-details-v2" class="logo">
                    <img src="/image/media_37.png" data-src="/image/media_37.png" alt="" class="lazy-img m-auto"></a>
                <div class="info-wrapper">
                    <a href="/job-details-v2" class="title fw-500 tran3s">Developer &amp; expert in java c++</a>
                    <ul class="style-none d-flex flex-wrap info-data">
                        <li>$30-$50/hour</li>
                        <li>Intermediate</li>
                        <li>Spain, Barcelona</li>
                    </ul>
                </div>
            </div>
            <p>
                We would like to design a page on Figma to promote Workroom as All-in-one
											solutions for Marketing, Sales, Support teams...
            </p>
            <div class="d-sm-flex align-items-center justify-content-between mt-auto">
                <div class="d-flex align-items-center">
                    <a href="/job-details-v2" class="job-duration fw-500">Fulltime</a>
                </div>
                <a href="#" class="btn2 " data-animation="fadeInLeft" data-delay=".4s">Apply Now <i class="fal fa-long-arrow-right"></i></a>
            </div>
        </div>
    </div>
</div><div class="col-lg-6">
    <div class="job-list-three d-flex h-100 w-100">
        <div class="main-wrapper h-100 w-100">
            <a href="job-details-v2" class="save-btn text-center rounded-circle tran3s" title="Save Job"><i class="bi bi-bookmark-dash"></i></a>
            <div class="list-header d-flex align-items-center">
                <a href="/job-details-v2" class="logo">
                    <img src="/image/media_37.png" data-src="/image/media_37.png" alt="" class="lazy-img m-auto"></a>
                <div class="info-wrapper">
                    <a href="/job-details-v2" class="title fw-500 tran3s">Developer &amp; expert in java c++</a>
                    <ul class="style-none d-flex flex-wrap info-data">
                        <li>$30-$50/hour</li>
                        <li>Intermediate</li>
                        <li>Spain, Barcelona</li>
                    </ul>
                </div>
            </div>
            <p>
                We would like to design a page on Figma to promote Workroom as All-in-one
											solutions for Marketing, Sales, Support teams...
            </p>
            <div class="d-sm-flex align-items-center justify-content-between mt-auto">
                <div class="d-flex align-items-center">
                    <a href="/job-details-v2" class="job-duration fw-500">Fulltime</a>
                </div>
                <a href="#" class="btn2 " data-animation="fadeInLeft" data-delay=".4s">Apply Now <i class="fal fa-long-arrow-right"></i></a>
            </div>
        </div>
    </div>
</div><div class="col-lg-6">
    <div class="job-list-three d-flex h-100 w-100">
        <div class="main-wrapper h-100 w-100">
            <a href="job-details-v2" class="save-btn text-center rounded-circle tran3s" title="Save Job"><i class="bi bi-bookmark-dash"></i></a>
            <div class="list-header d-flex align-items-center">
                <a href="/job-details-v2" class="logo">
                    <img src="/image/media_37.png" data-src="/image/media_37.png" alt="" class="lazy-img m-auto"></a>
                <div class="info-wrapper">
                    <a href="/job-details-v2" class="title fw-500 tran3s">Developer &amp; expert in java c++</a>
                    <ul class="style-none d-flex flex-wrap info-data">
                        <li>$30-$50/hour</li>
                        <li>Intermediate</li>
                        <li>Spain, Barcelona</li>
                    </ul>
                </div>
            </div>
            <p>
                We would like to design a page on Figma to promote Workroom as All-in-one
											solutions for Marketing, Sales, Support teams...
            </p>
            <div class="d-sm-flex align-items-center justify-content-between mt-auto">
                <div class="d-flex align-items-center">
                    <a href="/job-details-v2" class="job-duration fw-500">Fulltime</a>
                </div>
                <a href="#" class="btn2 " data-animation="fadeInLeft" data-delay=".4s">Apply Now <i class="fal fa-long-arrow-right"></i></a>
            </div>
        </div>
    </div>
</div>
                </div>
            </div>
        </section>
    </main>
</asp:Content>

