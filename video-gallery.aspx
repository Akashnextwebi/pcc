<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="video-gallery.aspx.cs" Inherits="video_gallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/breadcrums.css" rel="stylesheet" />
    <style>
        .service-card .image .icon {
            position: absolute;
            left: 18%;
            top: 37%;
            top: 50%;
            transform: translate(-53%, -39%);
        }

            .service-card .image .icon img {
                filter: unset !important;
            }

        .service-card .image .icon {
            background: unset !important;
            border: unset !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(image/blog/braadcrumb-bg3.jpg);">
        <div class="container-fluid one pl--95">
            <div class="row">
                <div class="col-lg-12">
                    <div class="banner-content">
                        <h1>Video Gallery</h1>
                        <ul class="breadcrumb-list">
                            <li><a href="Default.aspx">Home</a></li>
                            <li>Video Gallery</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <mian>
        <section class="section-padding">
            <div class="container">
                <div class="row">
                    <div class="services-slider-pcc">
                        <div class="col-lg-4 col-md-6">
                            <div class="service-card">
                                <div class="card-inner">

                                    <div class="image">
                                        <div class="icon">
                                            <a href="https://www.youtube.com/watch?v=D0UnqGm_miA" class="video-i popup-video" contenteditable="false" style="cursor: pointer;">
                                                <span class="play-icon">
                                                    <i class="fa-solid fa-play"></i>
                                                    <span class="playvideo_animation"></span>
                                                    <span class="playvideo_animation" style="animation-delay: 0.4s"></span>
                                                    <span class="playvideo_animation" style="animation-delay: 0.6s"></span>
                                                </span>
                                            </a>
                                        </div>
                                        <img src="image/data-solution.jpg" alt="" />
                                    </div>
                                  <div class="product-link">
      <a href="https://www.youtube.com/watch?v=D0UnqGm_miA" class="video-i popup-video custom-btn" contenteditable="false" style="cursor: pointer;">Watch Now</a>
  </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 col-md-6">
                            <div class="service-card">
                                <div class="card-inner">

                                    <div class="image">
                                        <div class="icon">
                                            <a href="https://www.youtube.com/watch?v=D0UnqGm_miA" class="video-i popup-video" contenteditable="false" style="cursor: pointer;">
                                                <span class="play-icon">
                                                    <i class="fa-solid fa-play"></i>
                                                    <span class="playvideo_animation"></span>
                                                    <span class="playvideo_animation" style="animation-delay: 0.4s"></span>
                                                    <span class="playvideo_animation" style="animation-delay: 0.6s"></span>
                                                </span>
                                            </a>
                                        </div>
                                        <img src="image/time-solution.jpg" alt="" />
                                    </div>
                                   <div class="product-link">
      <a href="https://www.youtube.com/watch?v=D0UnqGm_miA" class="video-i popup-video custom-btn" contenteditable="false" style="cursor: pointer;">Watch Now</a>
  </div>
                                </div>
                            </div>
                        </div>

                        <div class="col-lg-4 col-md-6">
                            <div class="service-card">
                                <div class="card-inner">

                                    <div class="image">
                                        <div class="icon">
                                            <a href="https://www.youtube.com/watch?v=D0UnqGm_miA" class="video-i popup-video" contenteditable="false" style="cursor: pointer;">
                                                <span class="play-icon">
                                                    <i class="fa-solid fa-play"></i>
                                                    <span class="playvideo_animation"></span>
                                                    <span class="playvideo_animation" style="animation-delay: 0.4s"></span>
                                                    <span class="playvideo_animation" style="animation-delay: 0.6s"></span>
                                                </span>
                                            </a>
                                        </div>
                                        <img src="image/power-generation.jpg" alt="" />
                                    </div>
                                 <div class="product-link">
      <a href="https://www.youtube.com/watch?v=D0UnqGm_miA" class="video-i popup-video custom-btn" contenteditable="false" style="cursor: pointer;">Watch Now</a>
  </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 col-md-6">
                            <div class="service-card">
                                <div class="card-inner">

                                    <div class="image">
                                        <div class="icon">
                                            <a href="https://www.youtube.com/watch?v=D0UnqGm_miA" class="video-i popup-video" contenteditable="false" style="cursor: pointer;">
                                                <span class="play-icon">
                                                    <i class="fa-solid fa-play"></i>
                                                    <span class="playvideo_animation"></span>
                                                    <span class="playvideo_animation" style="animation-delay: 0.4s"></span>
                                                    <span class="playvideo_animation" style="animation-delay: 0.6s"></span>
                                                </span>
                                            </a>
                                        </div>
                                        <img src="image/indigenization.jpg" alt="" />
                                    </div>
                                    <div class="product-link">
                                        <a href="https://www.youtube.com/watch?v=D0UnqGm_miA" class="video-i popup-video custom-btn" contenteditable="false" style="cursor: pointer;">Watch Now</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </mian>
</asp:Content>

