<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="blogs-details.aspx.cs" Inherits="blogs_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/about.css" rel="stylesheet" />
    <link href="css/breadcrums.css" rel="stylesheet" />
    <style>
        .details-navigation {
            display: flex;
            align-items: center;
            justify-content: space-between;
            gap: 20px;
            padding: 20px 0px;
        }

            .details-navigation .single-navigation {
                display: flex;
                align-items: center;
                gap: 20px;
                transition: 0.35s;
            }

                .details-navigation .single-navigation .arrow {
                    width: 30px;
                    height: 60px;
                    border-radius: 5px;
                    border: 1px solid rgba(13, 23, 32, 0.16);
                    display: flex;
                    align-items: center;
                    justify-content: center;
                    transition: 0.35s;
                }

                    .details-navigation .single-navigation .arrow svg {
                        fill: rgba(13, 23, 32, 0.16);
                        transition: 0.35s;
                    }

                .details-navigation .single-navigation .content {
                    max-width: 301px;
                    width: 100%;
                    line-height: 1;
                    transition: 0.35s;
                }

                    .details-navigation .single-navigation .content > a {
                        color: var(--paragraph-color);
                        font-family: var(--font-montserrat);
                        font-size: 14px;
                        font-weight: 500;
                        transition: 0.35s;
                        margin-bottom: 5px;
                        display: inline-block;
                    }

                    .details-navigation .single-navigation .content h6 {
                        transition: 0.35s;
                        margin-bottom: 0;
                        line-height: 1;
                    }

        .blog-img {
            margin-bottom: 30px;
        }

        .wptb-page-heading .wptb-item--inner {
            position: relative;
            padding: 300px 0px 150px 0px;
            text-align: center;
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
                            <li><a href="Default.aspx">Blog</a></li>

                            <li>The Blueprint for quality: Engineering excellence in product and service delivery</li>
                        </ul>
                        <h1>The Blueprint for quality: Engineering excellence in product and service delivery</h1>

                    </div>
                </div>
            </div>
        </div>
    </div>
    <main>
        <section class="section-padding">
            <div class="container">
                <div class="row justify-content-center">
                    <div class="col-lg-10">
                        <div class="blog-details">
                            <div class="blog-img">
                                <img src="image/blog/1.png" class="img-fluid" alt="blog-image-name" />

                            </div>
                        </div>
                        <h3>Navigating the Digital Frontier</h3>
                        <p>
                            One of the key drivers behind the growing demand for digital engineering services is the increasing reliance on technology across industries. As businesses seek to digitize their operations and leverage data-driven insights, they require the expertise of skilled professionals who can design, develop, and implement cutting-edge solutions tailored to their specific needs.

                        </p>
                        <p>
                            Moreover, the rapid pace of technological innovation means that businesses must continually adapt and evolve to keep pace with changing market dynamics. Digital engineering services offer the agility and flexibility that organizations need to respond quickly to emerging trends and opportunities, ensuring that they remain at the forefront of their respective industries.

                        </p>
                    </div>
                </div>
                <div class="row justify-content-center">
                    <div class="col-lg-10">
                        <div class="details-navigation">
                            <div class="single-navigation">
                                <a class="arrow" href="#blog-details">
                                    <svg width="9" height="15" viewBox="0 0 8 13" xmlns="http://www.w3.org/2000/svg">
                                        <path d="M0 6.50008L8 0L2.90909 6.50008L8 13L0 6.50008Z"></path>
                                    </svg>
                                </a>
                                <div class="content">
                                    <a href="#blog-details">Prev Post</a>
                                    <h6><a href="#blog-details">Consulting vs. In-House Expertise: Finding the Right Balance</a></h6>
                                </div>
                            </div>

                            <div class="single-navigation two text-end">
                                <div class="content">
                                    <a href="#blog-details">Next Post</a>
                                    <h6><a href="#blog-details">Consulting Industry Adapts to the Changing Business Landscape</a></h6>
                                </div>
                                <a class="arrow" href="#blog-details">
                                    <svg width="9" height="15" viewBox="0 0 8 13" xmlns="http://www.w3.org/2000/svg">
                                        <path d="M8 6.50008L0 0L5.09091 6.50008L0 13L8 6.50008Z"></path>
                                    </svg>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </main>
</asp:Content>

