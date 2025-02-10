<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="evolution.aspx.cs" Inherits="evolution" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/breadcrums.css" rel="stylesheet" />
    <style>
        .history-section .inner-box:first-child .image-box,
        .history-section .inner-box:nth-child(3) .image-box,
        .history-section .inner-box:nth-child(5) .image-box,
        .history-section .inner-box:nth-child(7) .image-box,
        .history-section .inner-box:nth-child(9) .image-box,
        .history-section .inner-box:nth-child(11) .image-box {
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
            right: 50px;
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

        .history-section ul {
            --col-gap: 2rem;
            --row-gap: 2rem;
            --line-w: 0.25rem;
            display: grid;
            grid-template-columns: var(--line-w) 1fr;
            grid-auto-columns: max-content;
            column-gap: var(--col-gap);
            list-style: none;
            width: min(60rem, 100%);
            margin-inline: auto;
        }

            /* line */
            .history-section ul::before {
                content: "";
                grid-column: 1;
                grid-row: 1 / span 20;
                background: rgb(225, 225, 225);
                border-radius: calc(var(--line-w) / 2);
            }

            /* columns*/

            /* row gaps */
            .history-section ul li:not(:last-child) {
                margin-bottom: var(--row-gap);
            }

            /* card */
            .history-section ul li {
                grid-column: 2;
                --inlineP: 1.5rem;
                margin-inline: var(--inlineP);
                grid-row: span 2;
                display: grid;
                grid-template-rows: min-content min-content min-content;
            }

                /* date */
                .history-section ul li .date {
                    --dateH: 3rem;
                    height: var(--dateH);
                    margin-inline: calc(var(--inlineP) * -1);
                    text-align: center;
                    background-color: #a62a2a;
                    color: white;
                    font-size: 1.25rem;
                    font-weight: 700;
                    display: grid;
                    place-content: center;
                    position: relative;
                    border-radius: calc(var(--dateH) / 2) 0 0 calc(var(--dateH) / 2);
                }

                    /* date flap */
                    .history-section ul li .date::before {
                        content: "";
                        width: var(--inlineP);
                        aspect-ratio: 1;
                        background: #074b74;
                        background-image: linear-gradient(rgba(0, 0, 0, 0.2) 100%, transparent);
                        position: absolute;
                        top: 100%;
                        clip-path: polygon(0 0, 100% 0, 0 100%);
                        right: 0;
                    }

                    /* circle */
                    .history-section ul li .date::after {
                        content: "";
                        position: absolute;
                        width: 2rem;
                        aspect-ratio: 1;
                        background: var(--bgColor);
                        border: 0.3rem solid var(--accent-color);
                        border-radius: 50%;
                        top: 50%;
                        transform: translate(50%, -50%);
                        right: calc(100% + var(--col-gap) + var(--line-w) / 2);
                    }

                /* title descr */
                .history-section ul li .title,
                .history-section ul li .descr {
                    background: var(--bgColor);
                    position: relative;
                    padding-inline: 1.5rem;
                }

                .history-section ul li .title {
                    overflow: hidden;
                    padding-block-start: 1.5rem;
                    padding-block-end: 1rem;
                    font-weight: 500;
                }

                .history-section ul li .descr {
                    padding-block-end: 1.5rem;
                    font-weight: 300;
                }

                    /* shadows */
                    .history-section ul li .title::before,
                    .history-section ul li .descr::before {
                        content: "";
                        position: absolute;
                        width: 90%;
                        height: 0.5rem;
                        background: rgba(0, 0, 0, 0.5);
                        left: 50%;
                        border-radius: 50%;
                        filter: blur(4px);
                        transform: translate(-50%, 50%);
                    }

                .history-section ul li .title::before {
                    bottom: calc(100% + 0.125rem);
                }

                .history-section ul li .descr::before {
                    z-index: -1;
                    bottom: 0.25rem;
                }

        @media (min-width: 40rem) {
            .history-section ul {
                grid-template-columns: 1fr var(--line-w) 1fr;
            }

                .history-section ul::before {
                    grid-column: 2;
                }

                .history-section ul li:nth-child(odd) {
                    grid-column: 1;
                }

                .history-section ul li:nth-child(even) {
                    grid-column: 3;
                }

                /* start second card */
                .history-section ul li:nth-child(2) {
                    grid-row: 2/4;
                }

                .history-section ul li:nth-child(odd) .date::before {
                    clip-path: polygon(0 0, 100% 0, 100% 100%);
                    left: 0;
                }

                .history-section ul li:nth-child(odd) .date::after {
                    transform: translate(-50%, -50%);
                    left: calc(100% + var(--col-gap) + var(--line-w) / 2);
                }

                .history-section ul li:nth-child(odd) .date {
                    border-radius: 0 calc(var(--dateH) / 2) calc(var(--dateH) / 2) 0;
                }
        }

        .credits {
            margin-top: 1rem;
            text-align: right;
        }

            .credits a {
                color: var(--color);
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(image/blog/braadcrumb-bg3.jpg);">
        <div class="container">
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
        <section class="section-padding history-section d-none ">
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
                                        Indigenization of the GURT Test Equipment Complex.
                                    </p>    <br />
                                    <p>
                                        Health & Utility Management System DAU for Aircraft.



    
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
                                        Fuel Flow Metering Unit for the Sukhoi Aircraft.
                                    </p>
                                    <br />
                                    <p>Engine Control Unit for Military Ground Vehicles from 300 Hp to 1500 Hp.</p>    <br />
                                    <p>Integrated Demodulation System for Telemetry Ground Station.</p>    <br />


                                    <p>
                                        Heavy Vehicles Digital Display Units for Armoured carriers and other surface vehicles.







                                    </p>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

        </section>
        <section class="section-padding history-section ">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="text-center mb-5">
                            <h1>1989 - INCORPORATED
                            </h1>
                        </div>
                        <ul>
                            <li style="--accent-color: #41516C">
                                <div class="date">
                                    1993
                                </div>
                                <div class="title">
                                    PC add on cards for telemetry and other applications 
                                </div>
                            </li>
                            <li style="--accent-color: #FBCA3E">
                                <div class="date">
                                    1997
                                </div>
                                <div class="title">
                                    Time synchronization and count down timing systems 
                                </div>
                            </li>
                            <li style="--accent-color: #E24A68">
                                <div class="date">
                                    2002 - 2006
                                </div>
                                <div class="title">
                                    Tools for upgrade of Legacy systems   
Ground Telemetry data acquisition and processing stations
                                </div>
                            </li>
                            <li style="--accent-color: #1B5F8C">
                                <div class="date">
                                    2006 -  2010
                                </div>
                                <div class="title">
                                    Airborne Data acquisition and Control Systems for Aero & Defense Sub Systems
                                </div>
                            </li>
                            <li style="--accent-color: #4CADAD">
                                <div class="date">
                                    2010 - 2013
                                </div>
                                <div class="title">
                                    Mobile & Fixed – End to End Telemetry Stations
Engine Instrumentation Unit
                                </div>
                            </li>
                            <li style="--accent-color: #1B5F8C">
                                <div class="date">
                                    2015 - 2016

                                </div>
                                <div class="title">
                                    Airborne RF Transmitters/Power Amplifiers
Generator Control Unit
                                </div>
                            </li>
                            <li style="--accent-color: #4CADAD">
                                <div class="date">
                                    2016 - 17

                                </div>
                                <div class="title">
                                    Control Guidance Electronics for Laser Guided Bombs
Turret Control Unit (Gun Stabilization)

                                </div>
                            </li>
                            <li style="--accent-color: #1B5F8C">
                                <div class="date">
                                    2017 - 18


                                </div>
                                <div class="title">
                                    Precision Time Reference Systems
SSDVRS  for MIG 21 Bison Aircraft
PCAMi-1000 Flight Instrumentation & Recording System

                                </div>
                            </li>
                            <li style="--accent-color: #4CADAD">
                                <div class="date">
                                    2019 - 22


                                </div>
                                <div class="title">
                                    D&D and supply of Full Authority Digital Engine Control (FADEC) unit for Airworthy Diesel Engine


                                </div>
                            </li>
                                                        <li style="--accent-color: #1B5F8C">
                                <div class="date">
                                   2022 - 23



                                </div>
                                <div class="title">
                                 <p>  Indigenization of the GURT Test Equipment Complex</p><p>
Health & Utility Management System DAU for Aircraft</p>



                                </div>
                            </li>
                            <li style="--accent-color: #4CADAD">
                                <div class="date">
                                 2024 - 2025



                                </div>
                                <div class="title">

<P>Fuel Flow Metering Unit for the Sukhoi Aircraft</p>
                                  

<P>Engine Control Unit for Military Ground Vehicles from 300 Hp to 1500 Hp</p>
                                   

<P>Integrated Demodulation System for Telemetry Ground Station</p>
                                   

<P>Heavy Vehicles Digital Display Units for Armoured carriers and other surface vehicles</p>



                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </section>

    </main>
</asp:Content>

