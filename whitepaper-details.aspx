<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="whitepaper-details.aspx.cs" Inherits="whitepaper_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/breadcrums.css" rel="stylesheet" />
    <style>
        .mb-130 {
            margin-bottom: 130px;
        }

        .pt-130 {
            padding-top: 130px;
        }

        .event-details-page .section-title1 {
            border-bottom: 1px solid #eee;
            padding-bottom: 25px;
            margin-bottom: 25px;
        }

        .section-title1 {
            display: flex;
            align-items: flex-start;
            justify-content: space-between;
            max-width: 1066px;
            width: 100%;
            gap: 25px;
        }

        .event-details-page .event-info {
            -moz-columns: 2;
            columns: 2;
        }

            .event-details-page .event-info li {
                color: #566064;
                font-size: 16px;
                font-weight: 500;
                margin-bottom: 7px;
                display: flex;
                gap: 15px;
            }

                .event-details-page .event-info li strong {
                    color: #000;
                    font-weight: 600;
                }

        .event-details-page .pic-cap-and-sicial {
            display: flex;
            align-items: center;
            justify-content: space-between;
            margin-bottom: 50px;
        }

            .event-details-page .pic-cap-and-sicial .pic-cap {
                display: flex;
                align-items: center;
                gap: 8px;
                color: #566064;
                font-size: 16px;
                font-weight: 500;
                line-height: 1;
            }

            .event-details-page .pic-cap-and-sicial .social-link {
                gap: 10px;
            }

                .event-details-page .pic-cap-and-sicial .social-link li a {
                    width: 26px;
                    height: 26px;
                    border-radius: 50%;
                    border: 1px solid #eee;
                    display: flex;
                    align-items: center;
                    justify-content: center;
                    transition: 0.35s;
                }

                    .event-details-page .pic-cap-and-sicial .social-link li a i {
                        transition: 0.35s;
                        color: #000;
                    }

        .event-details-page h3 {
            color: #000;
            font-size: 30px;
            font-weight: 400;
        }

        .event-details-page p {
            color: #566064;
            font-size: 16px;
            font-weight: 400;
            line-height: 30px;
            margin-bottom: 10px;
        }

        .event-details-page .event-fetures {
            padding-left: 30px;
            position: relative;
        }

            .event-details-page .event-fetures::before {
                height: 10px;
                width: 10px;
                border-radius: 50%;
                background-color: #2e448d;
                content: "";
                position: absolute;
                left: 0;
                top: 4px;
            }

            .event-details-page .event-fetures h6 {
                font-size: 16px;
                font-weight: 600;
                margin-bottom: 10px;
            }

            .event-details-page .event-fetures .feature-list {
                padding-top: 10px;
                padding-left: 1.5rem;
            }

                .event-details-page .event-fetures .feature-list li {
                    color: #566064;
                    font-size: 15px;
                    font-weight: 500;
                    list-style: decimal;
                    margin-bottom: 12px;
                }

        .event-details-page .event-info {
            -moz-columns: 2;
            columns: 2;
            display: flex;
            justify-content: space-between;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(image/blog/braadcrumb-bg3.jpg);">
        <div class="container-fluid one pl--95">
            <div class="row">
                <div class="col-lg-12">
                    <div class="banner-content">
                        <ul class="breadcrumb-list">
                            <li><a href="Default.aspx">Home</a></li>
                            <li>White Paper</li>
                        </ul>
                        <h1>By providing comprehensive event details, you can enhance attendees.
                        </h1>

                    </div>
                </div>
            </div>
        </div>
    </div>
    <main>
        <div class="event-details-page pt-130 mb-130">
            <div class="container">
                <div class="row justify-content-center g-lg-4 gy-5">
                    <div class="col-lg-10">
                        <div class="section-title1">
                            <h2>By providing comprehensive event details, you can enhance attendees.</h2>
                        </div>

                        <div class="whitepaper-img mb-20">
                            <img src="image/whitepaper/event-thumb.jpg" alt="" class="img-fluid w-100" />
                        </div>
                        <div class="pic-cap-and-sicial">
                            <div class="pic-cap">
                                <svg xmlns="http://www.w3.org/2000/svg" width="12" height="12" viewBox="0 0 12 12">
                                    <path fill-rule="evenodd" clip-rule="evenodd" d="M10.1865 1.06237L0 11.2484L0.751627 12L10.9376 1.81347V8.85645H12V0H3.14355V1.06237H10.1865Z"></path>
                                </svg>
                                P.C Event Gallery
                                                            <p class="mb-0"><strong><span>&nbsp| &nbsp</span>Date:</strong>23/12/2024</p>

                            </div>
                            <ul class="social-link d-flex align-items-center">
                                <li><a href="https://www.facebook.com/"><i class="fa-brands fa-facebook-f"></i></a></li>
                                <li><a href="https://twitter.com/"><i class="fa-brands fa-x-twitter"></i></a></li>
                                <li><a href="https://www.pinterest.com/"><i class="fa-brands fa-linkedin-in"></i></a></li>
                            </ul>
                        </div>
                        <h3>Agenda &amp; Schedule</h3>
                        <p>By providing comprehensive event details, you can enhance attendees' experience and ensure that they have all the information they need to participate in and enjoy your event or conference. Keep the information up-to-date and easily accessible through your event website or promotional materials.</p>
                        <div class="event-fetures mt-30 mb-40">
                            <h6><span>Day-01 :</span>Event Opening and Keynote Sessions</h6>
                            <p>Creating a schedule for a business consulting event involves addressing a wide range of topics to cater to the diverse needs and interests of attendees. Here's a comprehensive list of potential schedule topics for a business consulting event:</p>
                            <ul class="feature-list">
                                <li>Event Introduction and Welcome</li>
                                <li>Keynote Address: Current Business Landscape and Trends</li>
                                <li>The Role of Consulting in Modern Business</li>
                                <li>Industry Insights and Opportunities</li>
                                <li>Successful Consulting Case Studies</li>
                            </ul>
                        </div>
                        <div class="event-fetures mb-40">
                            <h6><span>Day-02 :</span> Core Consulting Strategies and Skills</h6>
                            <p>Creating a schedule for a business consulting event involves addressing a wide range of topics to cater to the diverse needs and interests of attendees. Here's a comprehensive list of potential schedule topics for a business consulting event:</p>
                            <ul class="feature-list">
                                <li>Effective Problem-Solving Techniques</li>
                                <li>Data Analysis and Analytics in Consulting</li>
                                <li>Effective Communication Strategies for Consultants</li>
                                <li>Workshop: Case Study Analysis and Solutions</li>
                            </ul>
                        </div>
                        <div class="event-fetures mb-40">
                            <h6><span>Day-03 :</span> Specialized Consulting Tracks</h6>
                            <p>Creating a schedule for a business consulting event involves addressing a wide range of topics to cater to the diverse needs and interests of attendees. Here's a comprehensive list of potential schedule topics for a business consulting event:</p>
                            <ul class="feature-list">
                                <li>HR and Talent Management Consulting Best Practices</li>
                                <li>Technology and IT Consulting Trends</li>
                                <li>Marketing and Sales Consulting Strategies</li>
                                <li>Operations and Process Improvement Consulting</li>
                            </ul>
                        </div>
                        <div class="event-fetures mb-40">
                            <h6><span>Day-04 :</span> Specialized Consulting Tracks</h6>
                            <p>Creating a schedule for a business consulting event involves addressing a wide range of topics to cater to the diverse needs and interests of attendees. Here's a comprehensive list of potential schedule topics for a business consulting event:</p>
                            <ul class="feature-list">
                                <li>HR and Talent Management Consulting Best Practices</li>
                                <li>Technology and IT Consulting Trends</li>
                                <li>Marketing and Sales Consulting Strategies</li>
                                <li>Operations and Process Improvement Consulting</li>
                            </ul>
                        </div>


                    </div>

                </div>
            </div>
        </div>
    </main>
</asp:Content>

