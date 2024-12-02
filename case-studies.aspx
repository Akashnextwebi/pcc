<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="case-studies.aspx.cs" Inherits="case_studies" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        .breadcrumb-section {
            background-size: cover;
            background-repeat: no-repeat;
            background-position: right;
            padding: 305px 0 200px;
            position: relative;
        }

        .container-fluid.one {
            max-width: 1746px;
        }

        .pl--95 {
            padding-left: 70px;
        }

        .breadcrumb-list {
            display: inline-flex;
            align-items: center;
            gap: 10px;
            border: 1px solid rgba(255, 255, 255, 0.2);
            padding: 10px 20px;
            flex-wrap: wrap;
        }

        .breadcrumb-section .banner-content h1 {
            color: #fff;
            font-size: 75px;
            font-weight: 400;
        }

        .breadcrumb-section .banner-content .breadcrumb-list li:first-child {
            padding-left: 0;
        }

        .breadcrumb-section .banner-content .breadcrumb-list li {
            line-height: 1;
            color: #fff;
            font-size: 16px;
            font-weight: 500;
            padding-left: 16px;
            position: relative;
        }

            .breadcrumb-section .banner-content .breadcrumb-list li a {
                color: #fff;
                transition: 0.35s;
            }

        .banner-content .breadcrumb-list li {
            line-height: 1;
            color: #fff;
            font-size: 16px;
            font-weight: 500;
            padding-left: 16px;
            position: relative;
        }

        .breadcrumb-section .banner-content .breadcrumb-list li::before {
            content: "";
            width: 6px;
            height: 6px;
            border-radius: 50%;
            background-color: #cacaca;
            position: absolute;
            left: 0;
            top: 50%;
            transform: translateY(-50%);
        }

        .magnetic-wrap {
            position: relative;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .case-study-card2 {
            position: relative;
        }

            .case-study-card2 .case-img img {
                min-height: 350px;
                -o-object-fit: cover;
                object-fit: cover;
            }

            .case-study-card2 .case-content {
                background: linear-gradient(73deg, rgba(13, 23, 32, 0.8) 0%, rgba(13, 23, 32, 0.1) 60.4%);
                padding: 35px;
                position: absolute;
                left: 0;
                top: 0;
                width: 100%;
                height: 100%;
                display: inline-flex;
                flex-direction: column;
                justify-content: end;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(image/blog/braadcrumb-bg3.jpg);">
        <div class="container-fluid one pl--95">
            <div class="row">
                <div class="col-lg-12">
                    <div class="banner-content">
                        <h1>Case Study</h1>
                        <ul class="breadcrumb-list">
                            <li><a href="index.html">Home</a></li>
                            <li>Case Study</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <section class="section-padding">
        <div class="container">
            <siv class="row">
                <div class="col-lg-6">
                    <div class="magnetic-wrap">
                        <div class="case-study-card2 magnetic-item" style="">
                            <div class="case-img">
                                <img src="assets/img/inner-pages/case-01.jpg" alt="">
                            </div>
                            <div class="case-content">
                                <div class="category-and-title">
                                    <a href="case-study1.html">Marketing</a>
                                    <h4><a href="case-study-details.html">A Business Consulting to Increase Marketing Analaytic on Markio Logistics</a></h4>
                                </div>
                                <div class="details-btn">
                                    <a class="primary-btn2 btn-hover" href="case-study-details.html">Read More
                                        <svg xmlns="http://www.w3.org/2000/svg" width="12" height="12" viewBox="0 0 12 12">
                                            <path fill-rule="evenodd" clip-rule="evenodd" d="M10.1865 1.06237L0 11.2484L0.751627 12L10.9376 1.81347V8.85645H12V0H3.14355V1.06237H10.1865Z"></path>
                                        </svg>
                                        <span style="top: 51.7875px; left: 100.853px;"></span>
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </siv>
        </div>
    </section>
</asp:Content>

