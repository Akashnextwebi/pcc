<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="evolution.aspx.cs" Inherits="evolution" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/breadcrums.css" rel="stylesheet" />
    <style>
        .history-section .inner-box:first-child .image-box, 
        .history-section .inner-box:nth-child(3) .image-box,
         .history-section .inner-box:nth-child(5) .image-box,
         .history-section .inner-box:nth-child(7) .image-box,
         .history-section .inner-box:nth-child(9) .image-box,
         .history-section .inner-box:nth-child(11) .image-box{
            margin-right: 70px;
            padding-right: 30px;
        }

        .history-section .inner-box {
            position: relative;
            display: block;
            margin-bottom: 60px;
        }

        .history-section .image-box {
            position: relative;
            display: block;
        }

            .history-section .image-box .image {
                position: relative;
                display: block;
            }

                .history-section .image-box .image img {
                    width: 100%;
                }

        .history-section .inner-box:first-child .image-box .link-box,
        .history-section .inner-box:nth-child(3) .image-box .link-box,
        .history-section .inner-box:nth-child(5) .image-box .link-box,
        .history-section .inner-box:nth-child(7) .image-box .link-box,
        .history-section .inner-box:nth-child(9) .image-box .link-box,
        .history-section .inner-box:nth-child(11) .image-box .link-box {
            right: 0px;
        }

        .history-section .image-box .link-box {
            position: absolute;
            top: 50px;
        }

            .history-section .image-box .link-box a {
                position: relative;
                display: inline-block;
                width: 70px;
                height: 70px;
                line-height: 76px;
                text-align: center;
                font-size: 30px;
                color: #fff;
            }

            .history-section .image-box .link-box a {
                background: #79010c;
            }

        .history-section .content-box {
            position: relative;
            display: block;
            margin-top: -16px;
        }

        .clearfix::after {
            display: block;
            clear: both;
            content: "";
        }

        .history-section .content-box h2 {
            position: relative;
            display: block;
            font-size: 72px;
            line-height: 82px;
            color: #e2e2e2;
            font-weight: 700;
            padding-bottom: 18px;
            border-bottom: 1px solid #e2e2e2;
        }

        .history-section .content-box .text {
            position: relative;
            padding-bottom: 27px;
            padding-top: 41px;
        }

        .history-section .inner-box:first-child .content-box .text:before,
        .history-section .inner-box:nth-child(3) .content-box .text:before,
        .history-section .inner-box:nth-child(5) .content-box .text:before,
        .history-section .inner-box:nth-child(7) .content-box .text:before,
        .history-section .inner-box:nth-child(9) .content-box .text:before,
        .history-section .inner-box:nth-child(11) .content-box .text:before {
            right: 50px;
        }

        .history-section .content-box .text:before {
            position: absolute;
            content: '';
            background: #e2e2e2;
            width: 1px;
            height: calc(100% + 16px);
            top: 0px;
        }

        .history-section .content-box h3 {
            position: relative;
            display: block;
            font-size: 24px;
            line-height: 34px;
            font-weight: 700;
            margin-bottom: 15px;
        }

        .history-section .inner-box:nth-child(2) .image-box,
        .history-section .inner-box:nth-child(4) .image-box,
        .history-section .inner-box:nth-child(6) .image-box,
        .history-section .inner-box:nth-child(8) .image-box,
        .history-section .inner-box:nth-child(10) .image-box,
        .history-section .inner-box:nth-child(12) .image-box {
            margin-left: 70px;
            padding-left: 30px;
        }

        .history-section .content-box {
            position: relative;
            display: block;
            margin-top: -16px;
        }

        .history-section .image-box .image {
            position: relative;
            display: block;
        }

        .history-section .inner-box:nth-child(2) .content-box .text:before,
        .history-section .inner-box:nth-child(4) .content-box .text:before,
        .history-section .inner-box:nth-child(6) .content-box .text:before,
        .history-section .inner-box:nth-child(8) .content-box .text:before,
        .history-section .inner-box:nth-child(10) .content-box .text:before,
        .history-section .inner-box:nth-child(12) .content-box .text:before {
            left: 50px;
        }

        .history-section .inner-box:nth-child(2) .content-box .text,
        .history-section .inner-box:nth-child(4) .content-box .text,
        .history-section .inner-box:nth-child(6) .content-box .text,
        .history-section .inner-box:nth-child(8) .content-box .text,
        .history-section .inner-box:nth-child(10) .content-box .text,
        .history-section .inner-box:nth-child(12) .content-box .text,
        {
            padding-left: 100px;
        }

        .history-section .content-box .text {
            position: relative;
            padding-bottom: 27px;
            padding-top: 41px;
        }


        .history-section .image-box .link-box {
            position: absolute;
            top: 50px;
        }

        .history-section .content-box p {
            max-width: 440px;
            font-size: 24px;
            line-height: 30px;
            font-weight: 600;
        }

        .clearfix::after {
            display: block;
            clear: both;
            content: "";
        }

        .history-section .inner-box:nth-child(2) .image-box .link-box,
        .history-section .inner-box:nth-child(4) .image-box .link-box,
        .history-section .inner-box:nth-child(6) .image-box .link-box,
        .history-section .inner-box:nth-child(8) .image-box .link-box,
        .history-section .inner-box:nth-child(10) .image-box .link-box,
        .history-section .inner-box:nth-child(12) .image-box .link-box {
            left: 0px;
        }

        .history-section .image-box .link-box {
            position: absolute;
            top: 50px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(image/blog/braadcrumb-bg3.jpg);">
        <div class="container-fluid one pl--95">
            <div class="row">
                <div class="col-lg-12">
                    <div class="banner-content">
                        <h1>Evolution</h1>
                        <ul class="breadcrumb-list">
                            <li><a href="Default.aspx">Home</a></li>
                            <li>Evolution</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <main>
        <section class="section-padding history-section ">
            <div class="container">
                <div class="inner-box">
                    <div class="row clearfix">
                        <div class="col-lg-6 col-md-6 col-sm-12 image-column">
                            <div class="image-box">
                                <figure class="image">
                                    <img src="image/evolution/history-1.jpg" alt="">
                                </figure>
                                <div class="link-box"><a href="#"><i class="fa-solid fa-arrow-right-long"></i></a></div>
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-12 content-column">
                            <div class="content-box">
                                <h2>1993
                                </h2>
                                <div class="text">
                                    <p>
                                        PC add on cards for telemetry and other applications 
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="inner-box">
                    <div class="row clearfix">
                        <div class="col-lg-6 col-md-6 col-sm-12 content-column">
                            <div class="content-box">
                                <h2>1997</h2>
                                <div class="text">
                                    <p>
                                        Time synchronization and count down timing systems 
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-12 image-column">
                            <div class="image-box">
                                <figure class="image">
                                    <img src="image/evolution/history-1.jpg" alt="">
                                </figure>
                                <div class="link-box"><a href="#"><i class="fa-solid fa-arrow-right-long"></i></a></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="inner-box">
                    <div class="row clearfix">
                        <div class="col-lg-6 col-md-6 col-sm-12 image-column">
                            <div class="image-box">
                                <figure class="image">
                                    <img src="image/evolution/history-1.jpg" alt="">
                                </figure>
                                <div class="link-box"><a href="#"><i class="fa-solid fa-arrow-right-long"></i></a></div>
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-12 content-column">
                            <div class="content-box">
                                <h2>2002 - 2006
                                </h2>
                                <div class="text">
                                    <p>
                                        Tools for upgrade of Legacy systems   
Ground Telemetry data acquisition and processing stations

                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="inner-box">
                    <div class="row clearfix">
                        <div class="col-lg-6 col-md-6 col-sm-12 content-column">
                            <div class="content-box">
                                <h2>2006 -  2010
                                </h2>
                                <div class="text">
                                    <p>
                                        Airborne Data acquisition and Control Systems for Aero & Defense Sub Systems
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-12 image-column">
                            <div class="image-box">
                                <figure class="image">
                                    <img src="image/evolution/history-1.jpg" alt="">
                                </figure>
                                <div class="link-box"><a href="#"><i class="fa-solid fa-arrow-right-long"></i></a></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="inner-box">
                    <div class="row clearfix">
                        <div class="col-lg-6 col-md-6 col-sm-12 image-column">
                            <div class="image-box">
                                <figure class="image">
                                    <img src="image/evolution/history-1.jpg" alt="">
                                </figure>
                                <div class="link-box"><a href="#"><i class="fa-solid fa-arrow-right-long"></i></a></div>
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-12 content-column">
                            <div class="content-box">
                                <h2>2010 - 2013

                                </h2>
                                <div class="text">
                                    <p>
                                        Mobile & Fixed – End to End Telemetry Stations
Engine Instrumentation Unit


                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="inner-box">
                    <div class="row clearfix">
                        <div class="col-lg-6 col-md-6 col-sm-12 content-column">
                            <div class="content-box">
                                <h2>2015 - 2016

                                </h2>
                                <div class="text">
                                    <p>
                                        Airborne RF Transmitters/Power Amplifiers
Generator Control Unit
    
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-12 image-column">
                            <div class="image-box">
                                <figure class="image">
                                    <img src="image/evolution/history-1.jpg" alt="">
                                </figure>
                                <div class="link-box"><a href="#"><i class="fa-solid fa-arrow-right-long"></i></a></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="inner-box">
                    <div class="row clearfix">
                        <div class="col-lg-6 col-md-6 col-sm-12 image-column">
                            <div class="image-box">
                                <figure class="image">
                                    <img src="image/evolution/history-1.jpg" alt="">
                                </figure>
                                <div class="link-box"><a href="#"><i class="fa-solid fa-arrow-right-long"></i></a></div>
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-12 content-column">
                            <div class="content-box">
                                <h2>2016 - 17


                                </h2>
                                <div class="text">
                                    <p>
                                        Control Guidance Electronics for Laser Guided Bombs
Turret Control Unit (Gun Stabilization)



                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="inner-box">
                    <div class="row clearfix">
                        <div class="col-lg-6 col-md-6 col-sm-12 content-column">
                            <div class="content-box">
                                <h2>2017 - 18


                                </h2>
                                <div class="text">
                                    <p>
                                        Precision Time Reference Systems
SSDVRS  for MIG 21 Bison Aircraft
PCAMi-1000 Flight Instrumentation & Recording System

    
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-12 image-column">
                            <div class="image-box">
                                <figure class="image">
                                    <img src="image/evolution/history-1.jpg" alt="">
                                </figure>
                                <div class="link-box"><a href="#"><i class="fa-solid fa-arrow-right-long"></i></a></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="inner-box">
                    <div class="row clearfix">
                        <div class="col-lg-6 col-md-6 col-sm-12 image-column">
                            <div class="image-box">
                                <figure class="image">
                                    <img src="image/evolution/history-1.jpg" alt="">
                                </figure>
                                <div class="link-box"><a href="#"><i class="fa-solid fa-arrow-right-long"></i></a></div>
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-12 content-column">
                            <div class="content-box">
                                <h2>2019-2022



                                </h2>
                                <div class="text">
                                    <p>
                                        D&D and supply of Full Authority Digital Engine Control (FADEC) unit for Airworthy Diesel Engine




                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="inner-box">
                    <div class="row clearfix">
                        <div class="col-lg-6 col-md-6 col-sm-12 content-column">
                            <div class="content-box">
                                <h2>2022 - 23



                                </h2>
                                <div class="text">
                                    <p>
                                        Indigenization of the GURT Test Equipment Complex
Health & Utility Management System DAU for Aircraft



    
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-12 image-column">
                            <div class="image-box">
                                <figure class="image">
                                    <img src="image/evolution/history-1.jpg" alt="">
                                </figure>
                                <div class="link-box"><a href="#"><i class="fa-solid fa-arrow-right-long"></i></a></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="inner-box">
                    <div class="row clearfix">
                        <div class="col-lg-6 col-md-6 col-sm-12 image-column">
                            <div class="image-box">
                                <figure class="image">
                                    <img src="image/evolution/history-1.jpg" alt="">
                                </figure>
                                <div class="link-box"><a href="#"><i class="fa-solid fa-arrow-right-long"></i></a></div>
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-12 content-column">
                            <div class="content-box">
                                <h2>2024 - 2025




                                </h2>
                                <div class="text">
                                    <p>
                                        D&D and supply of Full Authority Digital Engine Control (FADEC) unit for Airworthy Diesel Engine




                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

        </section>
    </main>
</asp:Content>

