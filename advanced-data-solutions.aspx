<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="advanced-data-solutions.aspx.cs" Inherits="advanced_data_solutions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="/css/breadcrums.css" rel="stylesheet" />
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

        .eg-card3.three {
            position: relative;
            padding: 0;
            height: 100%;
            overflow: hidden;
            transition: 0.5s;
        }

            .eg-card3.three .card-img {
                height: 100%;
            }

            .eg-card3.three .card-content {
                background: linear-gradient(357deg, #000 1.72%, rgba(0, 0, 0, 0) 49.89%);
                position: absolute;
                left: 0;
                top: 0;
                width: 100%;
                height: 100%;
                transform: unset;
                padding: 50px 40px;
                display: flex;
                justify-content: end;
                flex-direction: column;
                transition: 0.5s;
            }

            .eg-card3.three:hover img {
                transform: scale(1.15)
            }

            .eg-card3.three .card-img img {
                min-height: 350px;
                height: 100%;
                -o-object-fit: cover;
                object-fit: cover;
            }

            .eg-card3.three .card-content .view-btn {
                position: absolute;
                right: 85px;
                top: 85px;
                transition: 0.5s;
                opacity: 0;
            }

            .eg-card3.three .card-content .catgory-and-title > a {
                border-radius: 16px;
                border: 1px solid rgba(255, 255, 255, 0.5);
                background: 0 0;
                display: inline-block;
                color: #fff;
                text-align: center;
                font-size: 12px;
                font-weight: 500;
                padding: 2px 17px;
                margin-bottom: 13px;
            }

        .eg-card3 .card-content .catgory-and-title h5 a {
            color: #fff;
            font-size: 40px;
            font-weight: 500;
            transition: 0.35s;
        }

        .eg-card3.three .card-content .catgory-and-title h5 {
            margin-bottom: 0;
        }

            .eg-card3.three .card-content .catgory-and-title h5 a {
                font-size: 24px;
            }

        .eg-card3.two .card-content .catgory-and-title h5 a {
            font-size: 24px;
        }

        .eg-card3.two:hover .card-content .view-btn {
            right: 35px;
            top: 35px;
            opacity: 1;
        }

        .eg-card3.three:hover .card-content .view-btn {
            right: 35px;
            top: 35px;
            opacity: 1;
        }

        .eg-card3.three .card-content .view-btn {
            position: absolute;
            right: 85px;
            top: 85px;
            transition: 0.5s;
            opacity: 0;
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

        .breadcrumb-section {
            background-size: 100% 90%;
            background-repeat: no-repeat;
            background-position: right;
            padding: 305px 0 200px;
            position: relative;
        }

        .broacher-content h4 {
            font-size: 24px;
           
            margin-top: 10px;
        }
        .broacher-content h5 {
            font-size:24px;
            line-height:30px;
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
                            <div>
                                <ul class="breadcrumb-list">
                                    <li><a href="/">Home</a></li>
                                    <li><%=strBannertitle %></li>
                                </ul>
                            </div>
                            <div class="slider-btn mt-30 ">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <section class="section-padding pb-0">
            <div class="container">
                <div class="row">
                    <div class="col-lg-10">
                        <h2><%=strDesctitle %></h2>
                        <p><%=strDesc %></p>
                    </div>
                </div>
            </div>
        </section>
        <section class="section-padding" id="divCap" runat="server" >
            <div class="container">
                <div class="row gy-4"><%=strsubcapability %></div>
            </div>
        </section>
    </main>
</asp:Content>

