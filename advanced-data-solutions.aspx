<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="advanced-data-solutions.aspx.cs" Inherits="advanced_data_solutions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/about.css" rel="stylesheet" />
    <style>
        .service-card p {
            font-size: 16px !important;
            line-height: 28px !important;
            opacity: 1 !important;
            padding: 0px !important;
        }

        .service-card h3 {
            font-size: 20px;
            font-weight: 700 !important;
        }

        .service-card .image > img {
            height: unset !important;
        }

        .service-card {
            padding: 0px !important;
        }

            .service-card .title {
                padding: 20px 20px 20px;
            }

        .project__item-two {
            position: relative;
            z-index: 1;
            margin-bottom: 25px;
        }

        .project__thumb-two {
            position: relative;
            overflow: hidden;
        }

            .project__thumb-two::before {
                content: "";
                position: absolute;
                left: 0;
                top: 0;
                width: 100%;
                height: 100%;
                opacity: 0;
                background: #272727;
                z-index: 1;
                pointer-events: none;
                -webkit-transition: all 0.3s ease-out 0s;
                -moz-transition: all 0.3s ease-out 0s;
                -ms-transition: all 0.3s ease-out 0s;
                -o-transition: all 0.3s ease-out 0s;
                transition: all 0.3s ease-out 0s;
            }

            .project__thumb-two img {
                width: 100%;
                height: 450px;
                object-fit: cover;
            }

            .project__thumb-two .shape {
                content: "";
                position: absolute;
                right: -60%;
                top: 20%;
                transform: translateY(-50%) rotate(135deg);
                width: 320px;
                height: 1030px;
                background: linear-gradient(180deg, #181717 0%, rgba(18, 18, 18, 0) 100%);
                opacity: 0;
                -webkit-transition: all 0.3s ease-out 0s;
                -moz-transition: all 0.3s ease-out 0s;
                -ms-transition: all 0.3s ease-out 0s;
                -o-transition: all 0.3s ease-out 0s;
                transition: all 0.3s ease-out 0s;
                margin-right: -60px;
                z-index: 1;
                pointer-events: none;
            }

            .project__thumb-two::after {
                content: "";
                position: absolute;
                right: -2%;
                top: 50%;
                transform: translateY(-50%) rotate(135deg);
                width: 240px;
                height: 964px;
                background: linear-gradient(180deg, #262626 8.61%, rgba(18, 18, 18, 0) 100%);
                opacity: 0;
                -webkit-transition: all 0.3s ease-out 0s;
                -moz-transition: all 0.3s ease-out 0s;
                -ms-transition: all 0.3s ease-out 0s;
                -o-transition: all 0.3s ease-out 0s;
                transition: all 0.3s ease-out 0s;
                margin-right: -90px;
                pointer-events: none;
            }

        .project__content-two {
            position: absolute;
            left: 30px;
            right: 30px;
            bottom: 60px;
            border-top: 4px solid #fff;
            padding-top: 22px;
            opacity: 1;
            z-index: 3;
            -webkit-transform: translateY(50px);
            -moz-transform: translateY(50px);
            -ms-transform: translateY(50px);
            -o-transform: translateY(50px);
            transform: translateY(50px);
            -webkit-transition: all 0.3s ease-out 0s;
            -moz-transition: all 0.3s ease-out 0s;
            -ms-transition: all 0.3s ease-out 0s;
            -o-transition: all 0.3s ease-out 0s;
            transition: all 0.3s ease-out 0s;
        }

        .project__item-two .project__thumb-two::before {
            opacity: 0.4;
        }

        .project__content-two .title {
            margin-bottom: 10px;
            color: #fff;
            font-size: 24px;
            font-weight: 500;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <main class="wrapper">

        <div class="wptb-page-heading" style="position: relative; background-image: url('image/about/2.png');">
            <!-- Overlay -->
            <div class="overlay" style="position: absolute; top: 0; left: 0; width: 100%; height: 100%; background-color: rgba(0, 0, 0, 0.5); z-index: 1;"></div>

            <div class="container" style="position: relative; z-index: 2;">
                <div class="wptb-item--inner">
                    <h2 class="wptb-item--title text-white mb-2">Advanced Data Solutions</h2>
                    <div class="wptb-breadcrumb-wrap">
                        <ul class="wptb-breadcrumb">
                            <li><a href="#">Home</a></li>
                            <li><span>Advanced Data Solutions</span></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <section class="section-padding">
            <div class="container">
                <div class="wptb-heading">
                    <div class="wptb-item--inner text-center">
                        <h6 class="wptb-item--subtitle">Advanced S CATEGORIES
                            </h6>
                        <h1 class="wptb-item--title">We have high variety of quality products</h1>
                        <div class="wptb-item--divider"></div>
                    </div>
                </div>
                <div class="row gy-4">
                    <div class="col-lg-3">
                        <div class="service-card">
                            <div class="card-inner">
                                <div class="image">

                                    <img src="image/data-solution.jpg" alt="">
                                </div>
                                <div class="title text-start mb-0">
                                    <h3>Advance Data
                                       
                                        Solutions</h3>

                                </div>


                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3">
                        <div class="service-card">
                            <div class="card-inner">
                                <div class="image">

                                    <img src="image/data-solution.jpg" alt="">
                                </div>
                                <div class="title text-start mb-0">
                                    <h3>Advance Data
                   
                    Solutions</h3>

                                </div>


                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3">
                        <div class="service-card">
                            <div class="card-inner">
                                <div class="image">

                                    <img src="image/data-solution.jpg" alt="">
                                </div>
                                <div class="title text-start mb-0">
                                    <h3>Advance Data
                   
                    Solutions</h3>

                                </div>


                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3">
                        <div class="service-card">
                            <div class="card-inner">
                                <div class="image">

                                    <img src="image/data-solution.jpg" alt="">
                                </div>
                                <div class="title text-start mb-0">
                                    <h3>Advance Data
                   
                    Solutions</h3>

                                </div>


                            </div>
                        </div>
                    </div>


                </div>
                <div class="row mt-50">
                    <div class="col-lg-4">
                        <div class="project__item-two">
                            <div class="project__thumb-two">
                                <a href="project-details.html" contenteditable="false" style="cursor: pointer;">
                                    <img src="image/sub/inner_project07.jpg" alt="img"></a>
                                <span class="shape"></span>
                            </div>
                            <div class="project__content-two">
                                <h2 class="title"><a href="project-details.html" contenteditable="false" style="cursor: pointer;">Service Company Building</a></h2>
                            </div>

                        </div>
                    </div>
                    <div class="col-lg-4">
                        <div class="project__item-two">
                            <div class="project__thumb-two">
                                <a href="project-details.html" contenteditable="false" style="cursor: pointer;">
                                    <img src="image/sub/inner_project07.jpg" alt="img"></a>
                                <span class="shape"></span>
                            </div>
                            <div class="project__content-two">
                                <h2 class="title"><a href="project-details.html" contenteditable="false" style="cursor: pointer;">Service Company Building</a></h2>
                            </div>

                        </div>
                    </div>
                    <div class="col-lg-4">
                        <div class="project__item-two">
                            <div class="project__thumb-two">
                                <a href="project-details.html" contenteditable="false" style="cursor: pointer;">
                                    <img src="image/sub/inner_project07.jpg" alt="img"></a>
                                <span class="shape"></span>
                            </div>
                            <div class="project__content-two">
                                <h2 class="title"><a href="project-details.html" contenteditable="false" style="cursor: pointer;">Service Company Building</a></h2>
                            </div>

                        </div>
                    </div>
                </div>

            </div>
        </section>
    </main>
</asp:Content>

