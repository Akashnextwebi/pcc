<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="evolution.aspx.cs" Inherits="evolution" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/breadcrums.css" rel="stylesheet" />
    <style>
        .history-section .inner-box:first-child .image-box, .history-section .inner-box:nth-child(3) .image-box {
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

        .history-section .inner-box:first-child .image-box .link-box, .history-section .inner-box:nth-child(3) .image-box .link-box {
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
                background: #e4492e;
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

        .history-section .inner-box:first-child .content-box .text:before, .history-section .inner-box:nth-child(3) .content-box .text:before {
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
        .history-section .inner-box:nth-child(2) .image-box, .history-section .inner-box:nth-child(4) .image-box {
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
}.history-section .inner-box:nth-child(2) .content-box .text:before, .history-section .inner-box:nth-child(4) .content-box .text:before {
    left: 50px;
}
        .history-section .inner-box:nth-child(2) .content-box .text, .history-section .inner-box:nth-child(4) .content-box .text {
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
        }

        .clearfix::after {
            display: block;
            clear: both;
            content: "";
        }.history-section .inner-box:nth-child(2) .image-box .link-box, .history-section .inner-box:nth-child(4) .image-box .link-box {
    left: 0px;
}.history-section .image-box .link-box {
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
                                <h2>2010</h2>
                                <div class="text">
                                    <h3>Company was Founded</h3>
                                    <p>Indignation and dislike men who are so demoralized by charms pleasure of the moment,trouble that are bound to ensue  obligations of business.</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="inner-box">
                    <div class="row clearfix">
                        <div class="col-lg-6 col-md-6 col-sm-12 content-column">
                            <div class="content-box">
                                <h2>2014</h2>
                                <div class="text">
                                    <h3>500 Projects Milestone</h3>
                                    <p>Indignation and dislike men who are so demoralized by charms pleasure of the moment.</p>
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
                                <h2>2019</h2>
                                <div class="text">
                                    <h3>Introduce New Technology</h3>
                                    <p>Indignation and dislike men who are so demoralized by charms pleasure of the moment,trouble that are bound to ensue  obligations of business.</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="inner-box">
                    <div class="row clearfix">
                        <div class="col-lg-6 col-md-6 col-sm-12 content-column">
                            <div class="content-box">
                                <h2>2022</h2>
                                <div class="text">
                                    <h3>Best Company Award</h3>
                                    <p>Indignation and dislike men who are so demoralized by charms pleasure of the moment.</p>
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
            </div>

        </section>
    </main>
</asp:Content>

