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
    </main>
</asp:Content>

