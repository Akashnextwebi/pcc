<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="air.aspx.cs" Inherits="air" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/breadcrums.css" rel="stylesheet" />
    <style>
        .mb-80 {
            margin-bottom: 80px;
        }

        .pt-80 {
            padding-top: 80px;
        }

        .sub-title span {
            color: #0d1720;
            text-align: center;
            font-size: 24px;
            font-weight: 500;
            line-height: 1;
            display: inline-block;
            border-radius: 16px;
            border: 1px solid #000;
            padding: 10px 25px;
            white-space: nowrap;
        }

        .mb-60 {
            margin-bottom: 60px;
        }

        .section-title1 {
            display: flex;
            align-items: flex-start;
            justify-content: space-between;
            width: 100%;
            gap: 25px;
        }

            .section-title1 h2 {
                color: #000;
                font-size: 40px;
                font-weight: 400;
                margin-bottom: 0;
                max-width: 740px;
                margin-top: -10px;
            }

        .solution-section .company-logo {
            position: absolute;
            left: -300px;
            bottom: 18px;
            line-height: 1;
            z-index: -1;
        }

        .solution-section .company-logo1 {
            position: absolute;
            right: -300px;
            bottom: 18px;
            line-height: 1;
            z-index: 1;
        }

        .solution-section .company-logo h2 {
            font-size: 198px;
            font-weight: 400;
            background: linear-gradient(180deg, #623a36 0%, #fff 100%);
            background-clip: text;
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            margin-bottom: 0;
        }

        .solution-section .company-logo1 h2 {
            font-size: 198px;
            font-weight: 400;
            background: linear-gradient(180deg, #623a36 0%, #fff 100%);
            background-clip: text;
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            margin-bottom: 0;
        }

        .eg-card-2.style-2 {
            flex-direction: column;
            padding: 40px 25px;
            position: relative;
        }

        .eg-card-2 {
            padding: 40px;
            border: 1px solid #eee;
            display: flex;
            align-items: flex-start;
            gap: 30px;
            transition: 0.35s;
        }

            .eg-card-2.style-2 .sl-no {
                position: absolute;
                top: 30px;
                right: 25px;
                line-height: 1;
            }

            .eg-card-2 .icon {
                display: flex;
                flex-direction: column;
                align-items: center;
                transition: 0.35s;
            }
    </style>
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

        .add-read-more.show-less-content .second-section,
        .add-read-more.show-less-content .read-less {
            display: none;
        }

        .add-read-more.show-more-content .read-more {
            display: none;
        }

        .add-read-more .read-more,
        .add-read-more .read-less {
            font-weight: bold;
            margin-left: 2px;
            color: blue;
            cursor: pointer;
        }

        .add-read-more {
            width: 100%;
            margin: 0 auto;
        }

        .single-scroll-container {
            background-size: cover;
            background-position: center;
            background-repeat: no-repeat;
            padding-top: 100px;
            padding-bottom: 100px;
        }

            .single-scroll-container .horizontal-scrolling-content {
                max-width: 750px;
                width: 100%;
            }.single-scroll-container .horizontal-scrolling-content .section-title1 {
    margin-bottom: 10px;
}
.section-title1.two {
    flex-direction: column;
}
.section-title1 {
    display: flex
;
    align-items: flex-start;
    justify-content: space-between;
    max-width: 1066px;
    width: 100%;
    gap: 25px;
}
        .single-scroll-container .horizontal-scrolling-content .section-title1 span {
            color:#fff;
            border-color: #fff;
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
        .single-scroll-container .horizontal-scrolling-content .section-title1 h2 {
    color: #fff;
    margin-bottom: 0;
}
.section-title1.two h2 {
    margin-top: 0;
    padding-top: 10px;
}
        .section-title1 h2 {
            color: #fff;
            font-size: 40px;
            font-weight: 400;
            margin-bottom: 0;
            max-width: 740px;
            margin-top: -10px;
        }
        .single-scroll-container .horizontal-scrolling-content p {
    color: #fff;
    font-size: 16px;
    font-weight: 400;
    line-height: 30px;
    margin-bottom: 30px;
}

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(image/blog/braadcrumb-bg3.jpg);">
        <div class="container-fluid one pl--95">
            <div class="row">
                <div class="col-lg-12">
                    <div class="banner-content">
                        <h1>Air</h1>
                        <ul class="breadcrumb-list">
                            <li><a href="Default.aspx">Home</a></li>
                            <li>Air</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="solution-section pt-80 mb-80">
        <div class="container-fluid">
            <div class="row g-4">
                <div class="col-lg-4 ">
                    <div class="sub-title mb-60   text-center">
                        <span>Telemetry Data Aquisition
                        </span>
                    </div>
                    <div class="text-center   ">
                        <img src="image/9121320.jpg" width="320" />

                    </div>
                </div>
                <div class="col-lg-8">
                    <div class="row">
                        <div class="col-lg-12 gap-lg-5 gap-4 d-flex flex-lg-nowrap flex-wrap align-items-start justify-content-between mb-60">
                            <div class="section-title1 one">
                                <p class="add-read-more show-less-content">
                                    Telemetry Data Acquisition is the technology for measuring the characteristics of a distant object that can be transmitted to any acquisition and receiving station for display, record and analysis of the data by wireless, satellite or fibre optic media. It is typically used in test flight of aircraft and other air vehicles and in hostile ground environments like Power generation plants, Liquid propulsion test centres, etc. PCC has been extending powerful Telemetry Data Acquisition Solutions for the past quarter century and takes up jobs for the establishment of world class telemetry station.  The Server/client distributed system on the network seamlessly and efficiently captures telemetry data; receiving, recording and distributing, without any loss. The RF front end of the Telemetry Data Acquisition Solutions comprises of a tracking dish antenna system that could be of any size, up to 5 mts, and supports single, dual and three axes, could either be installed on ground or a mobile platform for acquiring data from any target air vehicle such as aircraft, missile, satellite, Unmanned Air Vehicles, etc. The equally efficient RF Telemetry Receiver that supports cutting edge modulation schemes in a wide band that includes L & extended S, ensures the best data reception quality. The baseband system that decommutates and distributed the data is built around comprehensive telemetry application software which is quick and simple in its processing. The recorded data can be archived with world class storage can be accessed effortlessly for replay and post flight analysis.

                                </p>
                            </div>
                        </div>
                        <div class="col-lg-12 d-flex align-items-center position-relative">
                            <div class="row gy-4 justify-content-end">

                                <div class="col-lg-4">
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
                                <div class="col-lg-4">
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
                                <div class="col-lg-4">
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
                                <div class="col-lg-4">
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


                                <div class="col-lg-4">
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
                            <div class="right-shape">
                                <img src="assets/img/home2/shape-01.png" alt="">
                            </div>
                            <div class="company-logo">
                                <h2>PCC</h2>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <div class="horizontal-scrolling-section ">
        <div class="single-scroll-container" style="background-image: linear-gradient(180deg, rgb(0 0 0 / 58%) 0%, rgb(0 0 0 / 20%) 100%), url(image/cta.png)">
            <div class="container-fluid one pl--95">
                <div class="horizontal-scrolling-content">
                    <div class="section-title1 two">
                        <span>Real Estate</span>
                        <h2>A Business Consulting to Increase Marketing Analaytic on Markio Logistics</h2>
                    </div>
                    <p>Business consultants are typically hired by organizations of all sizes, from small startups to large corporations, and across various industries.</p>
                  <div class="slider-btn ">
                  <a href="#" class="btn ss-btn mr-15" data-animation="fadeInLeft" data-delay=".4s" tabindex="0" style="animation-delay: 0.4s;"><i class="fal fa-long-arrow-right"></i> Read more</a>
                </div>
                </div>
            </div>
        </div>
    </div>





















    
    <script src="js/vendor/jquery-3.6.0.min.js"></script>

    <script>
        $(document).ready(function () {
            function AddReadMore() {
                //This limit you can set after how much characters you want to show Read More.
                var carLmt = 300;
                // Text to show when text is collapsed
                var readMoreTxt = " ...read more";
                // Text to show when text is expanded
                var readLessTxt = " read less";


                //Traverse all selectors with this class and manupulate HTML part to show Read More
                $(".add-read-more").each(function () {
                    if ($(this).find(".first-section").length)
                        return;

                    var allstr = $(this).text();
                    if (allstr.length > carLmt) {
                        var firstSet = allstr.substring(0, carLmt);
                        var secdHalf = allstr.substring(carLmt, allstr.length);
                        var strtoadd = firstSet + "<span class='second-section'>" + secdHalf + "</span><span class='read-more'  title='Click to Show More'>" + readMoreTxt + "</span><span class='read-less' title='Click to Show Less'>" + readLessTxt + "</span>";
                        $(this).html(strtoadd);
                    }
                });

                //Read More and Read Less Click Event binding
                $(document).on("click", ".read-more,.read-less", function () {
                    $(this).closest(".add-read-more").toggleClass("show-less-content show-more-content");
                });
            }

            AddReadMore();
        });

    </script>
</asp:Content>

