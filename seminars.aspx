<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="seminars.aspx.cs" Inherits="seminars" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/breadcrums.css" rel="stylesheet" />
    <style>
        .eg-card4 .card-img {
            margin-bottom: 35px;
        }

            .eg-card4 .card-img img {
                min-height: 280px;
                -o-object-fit: cover;
                object-fit: cover;
            }

        .eg-card4 .card-content > a {
            color: #000;
            font-size: 12px;
            font-weight: 500;
            border: 1px solid #0d1720;
            border-radius: 15px;
            line-height: 1;
            display: inline-flex;
            padding: 4px 12px;
            margin-bottom: 15px;
        }

        .eg-card4 .card-content .title-and-btn {
            display: flex;
            flex-wrap: wrap;
            align-items: center;
            justify-content: space-between;
            gap: 10px;
            margin-bottom: 30px;
        }

            .eg-card4 .card-content .title-and-btn h4 {
                margin-bottom: 0;
            }

        .explore-btn {
            color: #000;
            font-size: 15px;
            font-weight: 500;
            display: flex;
            align-items: baseline;
            gap: 8px;
            transition: 0.35s;
            white-space: nowrap;
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(image/blog/braadcrumb-bg3.jpg);">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="banner-content">
                        <h1>Seminars</h1>
                        <ul class="breadcrumb-list">
                            <li><a href="index.html">Home</a></li>
                            <li>Seminars</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <main>
        <section class="section-padding">
            <div class="container">
                <div class="row g-md-4 gy-5 mb-70">
                    <div class="col-md-6">
                        <div class="eg-card4">
                            <div class="card-img">
                                <img src="image/seminar/1.png" alt="">
                            </div>
                            <div class="card-content">
                                <a href="portfolio-two-column.html">Technology</a>
                                <div class="title-and-btn">
                                    <h4><a href="portfolio-details.html">Technology Assessment</a></h4>
                                    <a href="https://www.youtube.com/watch?v=D0UnqGm_miA" class="video-i popup-video explore-btn" contenteditable="false" style="cursor: pointer;">Watch Now
    <svg xmlns="http://www.w3.org/2000/svg" width="12" height="12" viewBox="0 0 12 12">
        <path fill-rule="evenodd" clip-rule="evenodd" d="M10.1865 1.06237L0 11.2484L0.751627 12L10.9376 1.81347V8.85645H12V0H3.14355V1.06237H10.1865Z"></path>
    </svg>
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="eg-card4">
                            <div class="card-img">
                                <img src="image/seminar/2.png" alt="">
                            </div>
                            <div class="card-content">
                                <a href="portfolio-two-column.html">Management</a>
                                <div class="title-and-btn">
                                    <h4><a href="portfolio-details.html">To Change Management</a></h4>
                                    <a href="https://www.youtube.com/watch?v=D0UnqGm_miA" class="video-i popup-video explore-btn" contenteditable="false" style="cursor: pointer;">Watch Now
    <svg xmlns="http://www.w3.org/2000/svg" width="12" height="12" viewBox="0 0 12 12">
        <path fill-rule="evenodd" clip-rule="evenodd" d="M10.1865 1.06237L0 11.2484L0.751627 12L10.9376 1.81347V8.85645H12V0H3.14355V1.06237H10.1865Z"></path>
    </svg>
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="eg-card4">
                            <div class="card-img">
                                <img src="image/seminar/3.png" alt="">
                            </div>
                            <div class="card-content">
                                <a href="portfolio-two-column.html">Marketing</a>
                                <div class="title-and-btn">
                                    <h4><a href="portfolio-details.html">Marketing and Sales Consulting</a></h4>
                                    <a href="https://www.youtube.com/watch?v=D0UnqGm_miA" class="video-i popup-video explore-btn" contenteditable="false" style="cursor: pointer;">Watch Now
       <svg xmlns="http://www.w3.org/2000/svg" width="12" height="12" viewBox="0 0 12 12">
           <path fill-rule="evenodd" clip-rule="evenodd" d="M10.1865 1.06237L0 11.2484L0.751627 12L10.9376 1.81347V8.85645H12V0H3.14355V1.06237H10.1865Z"></path>
       </svg>
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="eg-card4">
                            <div class="card-img">
                                <img src="image/seminar/4.png" alt="">
                            </div>
                            <div class="card-content">
                                <a href="portfolio-two-column.html">Finance</a>
                                <div class="title-and-btn">
                                    <h4><a href="portfolio-details.html">Financial Consulting</a></h4>
                                    <a href="https://www.youtube.com/watch?v=D0UnqGm_miA" class="video-i popup-video explore-btn" contenteditable="false" style="cursor: pointer;">Watch Now
       <svg xmlns="http://www.w3.org/2000/svg" width="12" height="12" viewBox="0 0 12 12">
           <path fill-rule="evenodd" clip-rule="evenodd" d="M10.1865 1.06237L0 11.2484L0.751627 12L10.9376 1.81347V8.85645H12V0H3.14355V1.06237H10.1865Z"></path>
       </svg>
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </section>
    </main>
</asp:Content>

