<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="product-lisitng.aspx.cs" Inherits="product_lisitng" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <link href="/css/breadcrums.css" rel="stylesheet" />
    <link href="/css/industries.css" rel="stylesheet" />

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
            background-color: #222222;
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
        <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(/<%=strBanner%>);">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="banner-content">
                            <h1><%=strBannertitle %></h1>
                            <ul class="breadcrumb-list">
                                <li><a href="/Default.aspx">Home</a></li>
                                <li><%=strBannertitle %></li>
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
                        <h2><%=strDesctitle %>

                        </h2>
                        <p><%=strDesc %></p>
                    </div>
                </div>
            </div>
        </section>
        <section class="wptb-shop section-padding">
            <div class="container">
                <div class="row gy-4">
                    <%=strProduct %>
                </div>

            </div>
        </section>
    </main>
</asp:Content>

