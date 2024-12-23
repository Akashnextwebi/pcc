<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="product-lisitng.aspx.cs" Inherits="product_lisitng" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <link href="css/breadcrums.css" rel="stylesheet" />

    <style>
        .magnetic-wrap {
            position: relative;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .people-card2 .people-content .name-deg {
            border: 1px solid #eee;
            padding: 22px 20px;
        }

            .people-card2 .people-content .name-deg h5 {
                margin-bottom: 0;
            }

            .people-card2 .people-content .name-deg span {
                color: #000;
                font-size: 14px;
                font-weight: 500;
            }

        .people-card2 .people-content .contact-area {
            border-bottom: 1px solid #eee;
            border-right: 1px solid #eee;
            display: flex;
            align-items: center;
            justify-content: space-between;
        }

            .people-card2 .people-content .contact-area .contact-number {
                display: flex;
                align-items: center;
            }

                .people-card2 .people-content .contact-area .contact-number .icon {
                    width: 50px;
                    height: 45px;
                    display: flex;
                    align-items: center;
                    justify-content: center;
                    background-color: #e8f1fb;
                    transition: 0.35s;
                }

                .people-card2 .people-content .contact-area .contact-number .content {
                    line-height: 1;
                    padding-left: 15px;
                    padding-right: 15px;
                }

        .people-card2 .people-content .contact-area {
            border-bottom: 1px solid #eee;
            border-right: 1px solid #eee;
            display: flex;
            align-items: center;
            justify-content: space-between;
        }

            .people-card2 .people-content .contact-area .social-icon {
                display: flex;
                align-items: center;
            }

                .people-card2 .people-content .contact-area .social-icon li {
                    line-height: 1;
                    border-left: 1px solid #eee;
                }

            .people-card2 .people-content .contact-area .contact-number .icon {
                width: max-content;
                height: 45px;
                padding-right: 24px;
                display: flex;
                align-items: center;
                justify-content: center;
                background-color: #e8f1fb;
                transition: 0.35s;
                padding-left: 20px;
            }

            .people-card2 .people-content .contact-area .social-icon li {
                line-height: 1;
                border-left: 1px solid #eee;
            }

                .people-card2 .people-content .contact-area .social-icon li a {
                    height: 45px;
                    width: 45px;
                    display: flex;
                    align-items: center;
                    justify-content: center;
                    transition: 0.35s;
                }

        .contact-area li {
            display: inline-block;
            margin: 0px 0px 0px 0 !important;
        }

        .people-card2 .people-content .contact-area .social-icon {
            display: flex;
            align-items: center;
            background: #fff;
        }

        .people-card2 .people-content .contact-area {
            border-bottom: 1px solid #eee;
            border-right: 1px solid #eee;
            display: flex;
            background: #e8f1fb;
            align-items: center;
            justify-content: space-between;
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
            margin-top: 15px;
        }

            .broacher-content span {
                border-bottom: 1px solid #000;
                color: #79010c;
                font-weight: 600;
                font-size: 18px !important;
            }


            .broacher-content h4 {
                font-size: 24px;
                margin-top: 10px;
            }

        .industry-details-blog-section {
            background-color: #000;
            padding: 90px 0 170px;
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

            .section-title1.white h2 {
                max-width: 920px;
                color: #fff;
            }

            .section-title1.two h2 {
                margin-top: 0;
                padding-top: 10px;
            }

            .section-title1 h2 {
                font-size: 40px;
                font-weight: 400;
                margin-bottom: 0;
                max-width: 740px;
                margin-top: -10px;
            }

        .slider-btn-group {
            display: flex;
            align-items: center;
            justify-content: space-between;
        }

        .slider-btn-group {
            display: flex;
            align-items: center;
            justify-content: space-between;
        }

            .slider-btn-group .slider-btn {
                height: 40px;
                width: 40px;
                background-color: #fff;
                border-radius: 50%;
                display: flex;
                align-items: center;
                justify-content: center;
                transition: 0.4s;
                cursor: pointer;
                border: 1px solid rgba(217, 217, 217, 0.9019607843);
            }

                .slider-btn-group .slider-btn svg {
                    fill: #2e448d;
                    transition: 0.4s;
                }

                .slider-btn-group .slider-btn:hover {
                    background-color: #2e448d;
                    border-color: #2e448d;
                }

                    .slider-btn-group .slider-btn:hover svg {
                        fill: #fff;
                    }

                .slider-btn-group .slider-btn.swiper-button-disabled {
                    opacity: 0.2;
                }

            .slider-btn-group.w-100 {
                max-width: 100px;
                min-width: 100px;
                width: 100%;
            }

        .industry-details-blog-card {
            margin-top: -170px;
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
                            <ul class="breadcrumb-list">
                                <li><a href="Default.aspx">Home</a></li>
                                <li>Advance Data Solutions</li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <section class="section-padding">
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
        <section class="wptb-shop section-padding">
            <div class="container">
                <div class="row gy-4">

                    <div class="col-lg-3">
                        <div class="magnetic-wrap">
                            <div class="people-card2 magnetic-item" style="">
                                <div class="people-img">
                                    <img src="image/shop/1.jpg" alt="">
                                </div>
                                <div class="people-content">
                                    <div class="name-deg">
                                        <h5 class="d-flex justify-content-between"><a href="#">Air Product 1</a><span class="text-danger fw-bold">PARK-RTD-02</span></h5>





                                    </div>
                                    <div class="contact-area">
                                        <div class="contact-number">
                                            <div class="icon">
                                                View Product
                                            </div>

                                        </div>
                                        <ul class="social-icon">
                                            <li><a href="product-details.aspx"><i class="fa-solid fa-arrow-right-long"></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3">
                        <div class="magnetic-wrap">
                            <div class="people-card2 magnetic-item" style="">
                                <div class="people-img">
                                    <img src="image/shop/1.jpg" alt="">
                                </div>
                                <div class="people-content">
                                    <div class="name-deg">
                                        <h5 class="d-flex justify-content-between"><a href="#">Air Product 1</a><span class="text-danger fw-bold">PARK-RTD-02</span></h5>





                                    </div>
                                    <div class="contact-area">
                                        <div class="contact-number">
                                            <div class="icon">
                                                View Product
                                            </div>

                                        </div>
                                        <ul class="social-icon">
                                            <li><a href="product-details.aspx"><i class="fa-solid fa-arrow-right-long"></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3">
                        <div class="magnetic-wrap">
                            <div class="people-card2 magnetic-item" style="">
                                <div class="people-img">
                                    <img src="image/shop/1.jpg" alt="">
                                </div>
                                <div class="people-content">
                                    <div class="name-deg">
                                        <h5 class="d-flex justify-content-between"><a href="#">Air Product 1</a><span class="text-danger fw-bold">PARK-RTD-02</span></h5>





                                    </div>
                                    <div class="contact-area">
                                        <div class="contact-number">
                                            <div class="icon">
                                                View Product
                                            </div>

                                        </div>
                                        <ul class="social-icon">
                                            <li><a href="product-details.aspx"><i class="fa-solid fa-arrow-right-long"></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3">
                        <div class="magnetic-wrap">
                            <div class="people-card2 magnetic-item" style="">
                                <div class="people-img">
                                    <img src="image/shop/1.jpg" alt="">
                                </div>
                                <div class="people-content">
                                    <div class="name-deg">
                                        <h5 class="d-flex justify-content-between"><a href="#">Air Product 1</a><span class="text-danger fw-bold">PARK-RTD-02</span></h5>





                                    </div>
                                    <div class="contact-area">
                                        <div class="contact-number">
                                            <div class="icon">
                                                View Product
                                            </div>

                                        </div>
                                        <ul class="social-icon">
                                            <li><a href="product-details.aspx"><i class="fa-solid fa-arrow-right-long"></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>


                    <div class="col-lg-3">
                        <div class="magnetic-wrap">
                            <div class="people-card2 magnetic-item" style="">
                                <div class="people-img">
                                    <img src="image/shop/1.jpg" alt="">
                                </div>
                                <div class="people-content">
                                    <div class="name-deg">
                                        <h5 class="d-flex justify-content-between"><a href="#">Air Product 1</a><span class="text-danger fw-bold">PARK-RTD-02</span></h5>





                                    </div>
                                    <div class="contact-area">
                                        <div class="contact-number">
                                            <div class="icon">
                                                View Product
                                            </div>

                                        </div>
                                        <ul class="social-icon">
                                            <li><a href="product-details.aspx"><i class="fa-solid fa-arrow-right-long"></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3">
                        <div class="magnetic-wrap">
                            <div class="people-card2 magnetic-item" style="">
                                <div class="people-img">
                                    <img src="image/shop/1.jpg" alt="">
                                </div>
                                <div class="people-content">
                                    <div class="name-deg">
                                        <h5 class="d-flex justify-content-between"><a href="#">Air Product 1</a><span class="text-danger fw-bold">PARK-RTD-02</span></h5>





                                    </div>
                                    <div class="contact-area">
                                        <div class="contact-number">
                                            <div class="icon">
                                                View Product
                                            </div>

                                        </div>
                                        <ul class="social-icon">
                                            <li><a href="product-details.aspx"><i class="fa-solid fa-arrow-right-long"></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3">
                        <div class="magnetic-wrap">
                            <div class="people-card2 magnetic-item" style="">
                                <div class="people-img">
                                    <img src="image/shop/1.jpg" alt="">
                                </div>
                                <div class="people-content">
                                    <div class="name-deg">
                                        <h5 class="d-flex justify-content-between"><a href="#">Air Product 1</a><span class="text-danger fw-bold">PARK-RTD-02</span></h5>





                                    </div>
                                    <div class="contact-area">
                                        <div class="contact-number">
                                            <div class="icon">
                                                View Product
                                            </div>

                                        </div>
                                        <ul class="social-icon">
                                            <li><a href="product-details.aspx"><i class="fa-solid fa-arrow-right-long"></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3">
                        <div class="magnetic-wrap">
                            <div class="people-card2 magnetic-item" style="">
                                <div class="people-img">
                                    <img src="image/shop/1.jpg" alt="">
                                </div>
                                <div class="people-content">
                                    <div class="name-deg">
                                        <h5 class="d-flex justify-content-between"><a href="#">Air Product 1</a><span class="text-danger fw-bold">PARK-RTD-02</span></h5>





                                    </div>
                                    <div class="contact-area">
                                        <div class="contact-number">
                                            <div class="icon">
                                                View Product
                                            </div>

                                        </div>
                                        <ul class="social-icon">
                                            <li><a href="product-details.aspx"><i class="fa-solid fa-arrow-right-long"></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3">
                        <div class="magnetic-wrap">
                            <div class="people-card2 magnetic-item" style="">
                                <div class="people-img">
                                    <img src="image/shop/1.jpg" alt="">
                                </div>
                                <div class="people-content">
                                    <div class="name-deg">
                                        <h5 class="d-flex justify-content-between"><a href="#">Air Product 1</a><span class="text-danger fw-bold">PARK-RTD-02</span></h5>





                                    </div>
                                    <div class="contact-area">
                                        <div class="contact-number">
                                            <div class="icon">
                                                View Product
                                            </div>

                                        </div>
                                        <ul class="social-icon">
                                            <li><a href="product-details.aspx"><i class="fa-solid fa-arrow-right-long"></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>


                    <!-- Sidebar  -->

                </div>

            </div>
        </section>


        <div class="industry-details-blog-section" id="latestInsight">
            <div class="container-fluid">
                <div class="row">
                    <div
                        class="col-lg-12  gap-lg-5 gap-4 d-flex flex-lg-nowrap flex-wrap align-items-end justify-content-between mb-60">
                        <div class="section-title1 two white">
                            <h2>Product Brochure for Automatic Solution</h2>
                        </div>
                        <div class="slider-btn-group w-100">
                            <div class="slider-btn prev-5">
                                <svg xmlns="http://www.w3.org/2000/svg"
                                    width="15" height="11" viewBox="0 0 15 11">
                                    <path fill-rule="evenodd"
                                        clip-rule="evenodd"
                                        d="M0.416666 5.9668H15V4.7168H0.416666V5.9668Z" />
                                    <path fill-rule="evenodd"
                                        clip-rule="evenodd"
                                        d="M1.04115 4.7168C3.98115 4.7168 6.38281 7.3018 6.38281 10.0585V10.6835H5.13281V10.0585C5.13281 7.96596 3.26448 5.9668 1.04115 5.9668H0.416979V4.7168H1.04115Z" />
                                    <path fill-rule="evenodd"
                                        clip-rule="evenodd"
                                        d="M1.04115 5.96667C3.98115 5.96667 6.38281 3.38167 6.38281 0.625V0H5.13281V0.625C5.13281 2.71833 3.26448 4.71667 1.04115 4.71667H0.416979V5.96667H1.04115Z" />
                                </svg>
                            </div>
                            <div class="slider-btn next-5">
                                <svg xmlns="http://www.w3.org/2000/svg"
                                    width="15" height="11" viewBox="0 0 15 11">
                                    <path fill-rule="evenodd"
                                        clip-rule="evenodd"
                                        d="M14.5833 5.9668H0V4.7168H14.5833V5.9668Z" />
                                    <path fill-rule="evenodd"
                                        clip-rule="evenodd"
                                        d="M13.9589 4.7168C11.0189 4.7168 8.61719 7.3018 8.61719 10.0585V10.6835H9.86719V10.0585C9.86719 7.96596 11.7355 5.9668 13.9589 5.9668H14.583V4.7168H13.9589Z" />
                                    <path fill-rule="evenodd"
                                        clip-rule="evenodd"
                                        d="M13.9589 5.96667C11.0189 5.96667 8.61719 3.38167 8.61719 0.625V0H9.86719V0.625C9.86719 2.71833 11.7355 4.71667 13.9589 4.71667H14.583V5.96667H13.9589Z" />
                                </svg>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="industry-details-blog-card mb-130">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="row g-4">
                            <div class="swiper overflow-hidden bolg-slider">
                                <div class="swiper-wrapper">

                                    <div class="swiper-slide">
                                        <div class="broacher-card">
                                            <div class="broacher-img">
                                                <a href="#">
                                                    <img src="image/brochure/1.png" alr="img" /></a>

                                            </div>
                                            <div class="broacher-content">
                                                <a href="#">
                                                    <span>White Paper</span>
                                                    <h4>Innovative Jet Control Communication Solutions
                                                    </h4>
                                                    <p>Jet control and communication systems are critical for ensuring safe and efficient aviation operations. Advanced technologies enable seamless coordination between pilots, ground crews, and air traffic.</p>
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <div class="broacher-card">
                                            <div class="broacher-img">
                                                <a href="#">
                                                    <img src="image/brochure/1.png" alr="img" /></a>

                                            </div>
                                            <div class="broacher-content">
                                                <a href="#">
                                                    <span>White Paper</span>
                                                    <h4>Innovative Jet Control Communication Solutions
                                                    </h4>
                                                    <p>Jet control and communication systems are critical for ensuring safe and efficient aviation operations. Advanced technologies enable seamless coordination between pilots, ground crews, and air traffic.</p>
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <div class="broacher-card">
                                            <div class="broacher-img">
                                                <a href="#">
                                                    <img src="image/brochure/1.png" alr="img" /></a>

                                            </div>
                                            <div class="broacher-content">
                                                <a href="#">
                                                    <span>White Paper</span>
                                                    <h4>Innovative Jet Control Communication Solutions
                                                    </h4>
                                                    <p>Jet control and communication systems are critical for ensuring safe and efficient aviation operations. Advanced technologies enable seamless coordination between pilots, ground crews, and air traffic.</p>
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <div class="broacher-card">
                                            <div class="broacher-img">
                                                <a href="#">
                                                    <img src="image/brochure/1.png" alr="img" /></a>

                                            </div>
                                            <div class="broacher-content">
                                                <a href="#">
                                                    <span>White Paper</span>
                                                    <h4>Innovative Jet Control Communication Solutions
                                                    </h4>
                                                    <p>Jet control and communication systems are critical for ensuring safe and efficient aviation operations. Advanced technologies enable seamless coordination between pilots, ground crews, and air traffic.</p>
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <div class="broacher-card">
                                            <div class="broacher-img">
                                                <a href="#">
                                                    <img src="image/brochure/1.png" alr="img" /></a>

                                            </div>
                                            <div class="broacher-content">
                                                <a href="#">
                                                    <span>White Paper</span>
                                                    <h4>Innovative Jet Control Communication Solutions
                                                    </h4>
                                                    <p>Jet control and communication systems are critical for ensuring safe and efficient aviation operations. Advanced technologies enable seamless coordination between pilots, ground crews, and air traffic.</p>
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="swiper-slide">
                                        <div class="broacher-card">
                                            <div class="broacher-img">
                                                <a href="#">
                                                    <img src="image/brochure/1.png" alr="img" /></a>

                                            </div>
                                            <div class="broacher-content">
                                                <a href="#">
                                                    <span>White Paper</span>
                                                    <h4>Innovative Jet Control Communication Solutions
                                                    </h4>
                                                    <p>Jet control and communication systems are critical for ensuring safe and efficient aviation operations. Advanced technologies enable seamless coordination between pilots, ground crews, and air traffic.</p>
                                                </a>
                                            </div>
                                        </div>
                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </main>
</asp:Content>

