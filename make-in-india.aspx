﻿<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="make-in-india.aspx.cs" Inherits="make_in_india" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        .banner-area6 {
            background-image: linear-gradient(180deg, rgba(255, 255, 255, 0.85) 0%, rgba(255, 255, 255, 0.85) 100%), url(image/india/bacground-img.png);
            background-size: cover;
            background-repeat: repeat;
            background-position: center center;
            padding: 200px 0 100px;
        }

            .banner-area6 .banner-left-content {
                max-width: 1035px;
                width: 100%;
            }

                .banner-area6 .banner-left-content h1 {
                    color: #000;
                    ;
                    font-size: 60px;
                    font-weight: 400;
                    margin-bottom: 40px;
                    line-height: 70px;
                }

                .banner-area6 .banner-left-content .quate-text {
                    display: flex;
                    align-items: center;
                    max-width: 690px;
                    width: 100%;
                    gap: 20px;
                    margin-bottom: 60px;
                }

                    .banner-area6 .banner-left-content .quate-text .icon svg {
                        fill: var(--primary-color);
                    }

                    .banner-area6 .banner-left-content .quate-text .content p {
                        color: #000;
                        font-size: 20px;
                        font-weight: 400;
                        line-height: 30px;
                        margin-bottom: 0;
                    }

                .banner-area6 .banner-left-content .btn-group {
                    display: flex;
                    align-items: center;
                    flex-wrap: wrap;
                    gap: 30px;
                    padding-top: 30px;
                    border-top: 1px solid #eee;
                }

                    .banner-area6 .banner-left-content .btn-group li.success-rate {
                        color: #000;
                        font-size: 16px;
                        font-weight: 400;
                        line-height: 1;
                        border: 1px solid #000;
                        border-radius: 16px;
                        padding: 7px 20px;
                        display: flex;
                        align-items: center;
                        gap: 30px;
                    }

                    .banner-area6 .banner-left-content .btn-group li a {
                        color: #000;
                        font-size: 16px;
                        font-weight: 400;
                        line-height: 1;
                        border: 1px solid #000;
                        border-radius: 16px;
                        padding: 7px 20px;
                        display: flex;
                        align-items: center;
                        gap: 24px;
                        overflow: hidden;
                        position: relative;
                        z-index: 1;
                        transition: all 0.6s;
                    }

                    .banner-area6 .banner-left-content .btn-group li {
                        line-height: 1;
                    }

        .magnetic-wrap {
            position: relative;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .banner1-section .banner-top .banner-btn a {
            position: relative;
            line-height: 1;
            transition: 0.5s;
            height: 178px;
            width: 178px;
            display: inline-flex;
            align-items: center;
            justify-content: center;
        }

        .pcc-header .header-mid {
            padding: 10px 40px;
            border-bottom: 1px solid #000;
        }

        .banner1-section .banner-top .banner-btn a .bg {
            line-height: 1;
            transition: 0.5s;
        }

            .banner1-section .banner-top .banner-btn a .bg svg {
                fill: #fff;
                stroke: #000;
                transition: 0.5s;
            }

        .magnetic-wrap {
            position: relative;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .magnetic-wrap {
            position: relative;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .banner1-section .banner-bottom .banner-right-content {
            width: 100%;
            margin-left: auto;
        }

            .banner1-section .banner-bottom .banner-right-content h5 {
                color: #000;
                font-size: 20px;
                font-weight: 400;
                line-height: 28px;
                border-bottom: 1px solid rgba(13, 23, 32, 0.0784313725);
                padding-bottom: 20px;
            }

            .banner1-section .banner-bottom .banner-right-content .btn-group {
                display: flex;
                align-items: center;
                flex-wrap: wrap;
                gap: 30px;
                padding-top: 5px;
            }

                .banner1-section .banner-bottom .banner-right-content .btn-group li.success-rate {
                    color: #000;
                    font-size: 16px;
                    font-weight: 400;
                    line-height: 1;
                    border: 1px solid #000;
                    border-radius: 16px;
                    padding: 7px 20px;
                    display: flex;
                    align-items: center;
                    gap: 30px;
                }

                .banner1-section .banner-bottom .banner-right-content .btn-group li {
                    line-height: 1;
                }

                    .banner1-section .banner-bottom .banner-right-content .btn-group li a {
                        color: #000;
                        font-size: 16px;
                        font-weight: 400;
                        line-height: 1;
                        border: 1px solid #000;
                        border-radius: 16px;
                        padding: 7px 20px;
                        display: flex;
                        align-items: center;
                        gap: 24px;
                        overflow: hidden;
                        position: relative;
                        z-index: 1;
                        transition: all 0.6s;
                    }

            .banner1-section .banner-bottom .banner-right-content .features {
                padding-top: 55px;
            }

                .banner1-section .banner-bottom .banner-right-content .features li {
                    line-height: 1;
                    color: #566064;
                    font-size: 16px;
                    font-weight: 500;
                    display: flex;
                    align-items: center;
                    gap: 6px;
                    margin-bottom: 20px;
                }

        .sub-title span {
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

        .section-title1 {
            display: flex;
            align-items: flex-start;
            justify-content: space-between;
            max-width: 1066px;
            width: 100%;
            gap: 25px;
        }

            .section-title1 h2 {
                color: #000;
                font-size: 40px;
                font-weight: 400;
                margin-bottom: 0;
                max-width: 740px;
                margin-top: -10px;
            }

        .eg-card-2 {
            padding: 40px;
            border: 1px solid #ffc5c5;
            display: flex;
            align-items: flex-start;
            gap: 30px;
            transition: 0.35s;
        }

            .eg-card-2 .icon {
                display: flex;
                flex-direction: column;
                align-items: center;
                transition: 0.35s;
            }

            .eg-card-2 .content h5 {
                color: #000;
                font-size: 22px;
                font-weight: 400;
                margin-bottom: 10px;
            }

            .eg-card-2 .content p {
                color: #566064;
                font-size: 14px;
                font-weight: 400;
                line-height: 25px;
                margin-bottom: 0;
            }

        .section-padding {
            padding: 60px 0px;
        }

        .badge {
            position: unset !important;
        }

        .title {
            display: flex;
            align-items: center;
            gap: 8px;
            margin-bottom: 25px;
        }

        .statement-content-bottom ul {
            width: 100%;
        }

            .statement-content-bottom ul li {
                display: inline-flex;
                align-items: center;
                gap: 8px;
                color: #000;
                font-size: 16px;
                font-weight: 500;
                line-height: 1.3;
                margin-bottom: 15px;
            }

        .home5-protfolio-section .section-title1 {
            position: sticky;
            top: 100px;
        }

        .section-title1 {
            display: flex;
            align-items: flex-start;
            justify-content: space-between;
            max-width: 1066px;
            width: 100%;
            gap: 25px;
        }

            .section-title1.two {
                flex-direction: column;
            }

            .section-title1 > span {
                color: #0d1720;
                text-align: center;
                font-family: var(--font-montserrat);
                font-size: 16px;
                font-weight: 400;
                line-height: 1;
                display: inline-block;
                border-radius: 16px;
                border: 1px solid var(--title-color);
                padding: 7px 20px;
                white-space: nowrap;
            }

            .section-title1.two h2 {
                margin-top: 0;
                padding-top: 10px;
            }

            .section-title1 h2 {
                color: #000;
                font-size: 40px;
                font-weight: 400;
                margin-bottom: 0;
                max-width: 740px;
                margin-top: -10px;
            }

        .eg-card4 .card-img {
            margin-bottom: 35px;
        }

            .eg-card4 .card-img img {
                min-height: 280px;
                -o-object-fit: cover;
                object-fit: cover;
            }

        .eg-card4 .card-content .title-and-btn h4 a {
            color: #0d1720;
            font-size: 24px;
            font-style: normal;
            font-weight: 400;
            line-height: normal;
            transition: 0.35s;
        }

        .eg-card4 .card-content > a {
            color: #0000;
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
            }        .magnetic-wrap {
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
            }.people-card2 .people-content .contact-area .social-icon li {
    line-height: 1;
    border-left: 1px solid #eee;
}.people-card2 .people-content .contact-area .social-icon li a {
    height: 45px;
    width: 45px;
    display: flex
;
    align-items: center;
    justify-content: center;
    transition: 0.35s;
}.contact-area li {
    display: inline-block;
    margin: 0px 0px 0px 0 !important;
}.people-card2 .people-content .contact-area .social-icon {
    display: flex
;
    align-items: center;
    background: #fff;
}

.people-card2 .people-content .contact-area {
    border-bottom: 1px solid #eee;
    border-right: 1px solid #eee;
    display: flex
;
    background: #e8f1fb;
    align-items: center;
    justify-content: space-between;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="banner-area6">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 d-flex flex-lg-row flex-column align-items-xxl-end align-items-lg-center justify-content-between gap-5">
                    <div class="banner-left-content">
                        <h1>Introduction to Make in India
</h1>
                        <div class="quate-text1 w-50">
                            <h3 class="mb-3">The Make in India Initiative
</h3>
                            <div class="content">
                                <p>
                                    Launched in September 2014, the Make in India campaign is a flagship initiative of the Government of India aimed at transforming the country into a global manufacturing hub. Its key goals include:


                                </p>
                            </div>
                        </div>
                        <ul class="btn-group">
                            <li class="success-rate">Success Rate <span>90%</span></li>
                            <li><a href="#">Determine Problem</a></li>
                            <li><a href="#">Unqiue Solution</a></li>
                        </ul>
                    </div>
                    <div class="magnetic-wrap">
                        <div class="banner-btn magnetic-item">
                            <div class="badge">
                                <img src="image/makein-india.png" alt="" class="make-in-india">
                                <img src="image/element-1.png" alt="feature" class="spin-animation">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="section-padding">

        <div class="container">
            <div class="row g-lg-4 gy-5">
                <div class="col-lg-4">
                    <div class="advantage-img two">
                        <img src="image/india/2.png" alt="">
                    </div>
                </div>
                <div class="col-lg-8">
                    <div class="statement-content pl-50">
                        <div class="details-section-title mb-30">

                            <h2>About Park Controls’ Contribution
</h2>
                        </div>
                        <p>
                            Park Controls has been at the forefront of India’s Make in India movement, dedicated to building advanced, high-quality systems locally. With a vision to reduce dependency on imports, the company emphasizes in-house design, engineering, and manufacturing processes.

                        </p>
                        <div class="statement-content-bottom">
                            <div class="title">
                                <svg xmlns="http://www.w3.org/2000/svg" width="7" height="10" viewBox="0 0 7 10">
                                    <path d="M0 10V0L7 5L0 10Z"></path>
                                </svg>
                                <h6 class="mb-0">Key Facts

 </h6>
                            </div>
                            <ul>
                                <li>
                                    <svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 14 14">
                                        <path d="M12.1223 3.1903C12.1631 3.23094 12.1954 3.27922 12.2174 3.33237C12.2395 3.38552 12.2508 3.4425 12.2508 3.50005C12.2508 3.5576 12.2395 3.61458 12.2174 3.66773C12.1954 3.72088 12.1631 3.76916 12.1223 3.8098L5.99731 9.9348C5.95667 9.97554 5.9084 10.0079 5.85524 10.0299C5.80209 10.052 5.74511 10.0633 5.68756 10.0633C5.63002 10.0633 5.57304 10.052 5.51988 10.0299C5.46673 10.0079 5.41845 9.97554 5.37781 9.9348L2.31531 6.8723C2.23316 6.79015 2.18701 6.67873 2.18701 6.56255C2.18701 6.44637 2.23316 6.33495 2.31531 6.2528C2.39747 6.17065 2.50889 6.1245 2.62506 6.1245C2.74124 6.1245 2.85266 6.17065 2.93481 6.2528L5.68756 9.00642L11.5028 3.1903C11.5435 3.14956 11.5917 3.11723 11.6449 3.09518C11.698 3.07312 11.755 3.06177 11.8126 3.06177C11.8701 3.06177 11.9271 3.07312 11.9802 3.09518C12.0334 3.11723 12.0817 3.14956 12.1223 3.1903Z"></path>
                                    </svg>
                                    Domestic Manufacturing: Over 80% of components used in production are sourced from Indian suppliers, demonstrating the company’s strong reliance on local industries.
</li>
                                <li>
                                    <svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 14 14">
                                        <path d="M12.1223 3.1903C12.1631 3.23094 12.1954 3.27922 12.2174 3.33237C12.2395 3.38552 12.2508 3.4425 12.2508 3.50005C12.2508 3.5576 12.2395 3.61458 12.2174 3.66773C12.1954 3.72088 12.1631 3.76916 12.1223 3.8098L5.99731 9.9348C5.95667 9.97554 5.9084 10.0079 5.85524 10.0299C5.80209 10.052 5.74511 10.0633 5.68756 10.0633C5.63002 10.0633 5.57304 10.052 5.51988 10.0299C5.46673 10.0079 5.41845 9.97554 5.37781 9.9348L2.31531 6.8723C2.23316 6.79015 2.18701 6.67873 2.18701 6.56255C2.18701 6.44637 2.23316 6.33495 2.31531 6.2528C2.39747 6.17065 2.50889 6.1245 2.62506 6.1245C2.74124 6.1245 2.85266 6.17065 2.93481 6.2528L5.68756 9.00642L11.5028 3.1903C11.5435 3.14956 11.5917 3.11723 11.6449 3.09518C11.698 3.07312 11.755 3.06177 11.8126 3.06177C11.8701 3.06177 11.9271 3.07312 11.9802 3.09518C12.0334 3.11723 12.0817 3.14956 12.1223 3.1903Z"></path>
                                    </svg>
                                    Vendor Partnerships: Collaborations with Indian SMEs and vendors ensure a robust supply chain and encourage the growth of allied industries.
</li>

                            </ul>
                        </div>
                        <div class="statement-content-bottom">
                            <div class="title">
                                <svg xmlns="http://www.w3.org/2000/svg" width="7" height="10" viewBox="0 0 7 10">
                                    <path d="M0 10V0L7 5L0 10Z"></path>
                                </svg>
                                <h6 class="mb-0">Empowering Indian Talent



 </h6>
                            </div>
                            <ul>
                                <li>
                                    <svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 14 14">
                                        <path d="M12.1223 3.1903C12.1631 3.23094 12.1954 3.27922 12.2174 3.33237C12.2395 3.38552 12.2508 3.4425 12.2508 3.50005C12.2508 3.5576 12.2395 3.61458 12.2174 3.66773C12.1954 3.72088 12.1631 3.76916 12.1223 3.8098L5.99731 9.9348C5.95667 9.97554 5.9084 10.0079 5.85524 10.0299C5.80209 10.052 5.74511 10.0633 5.68756 10.0633C5.63002 10.0633 5.57304 10.052 5.51988 10.0299C5.46673 10.0079 5.41845 9.97554 5.37781 9.9348L2.31531 6.8723C2.23316 6.79015 2.18701 6.67873 2.18701 6.56255C2.18701 6.44637 2.23316 6.33495 2.31531 6.2528C2.39747 6.17065 2.50889 6.1245 2.62506 6.1245C2.74124 6.1245 2.85266 6.17065 2.93481 6.2528L5.68756 9.00642L11.5028 3.1903C11.5435 3.14956 11.5917 3.11723 11.6449 3.09518C11.698 3.07312 11.755 3.06177 11.8126 3.06177C11.8701 3.06177 11.9271 3.07312 11.9802 3.09518C12.0334 3.11723 12.0817 3.14956 12.1223 3.1903Z"></path>
                                    </svg>
                                    The company actively invests in upskilling Indian workers, providing training in advanced manufacturing techniques and cutting-edge technology applications.
</li>
                                <li>
                                    <svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 14 14">
                                        <path d="M12.1223 3.1903C12.1631 3.23094 12.1954 3.27922 12.2174 3.33237C12.2395 3.38552 12.2508 3.4425 12.2508 3.50005C12.2508 3.5576 12.2395 3.61458 12.2174 3.66773C12.1954 3.72088 12.1631 3.76916 12.1223 3.8098L5.99731 9.9348C5.95667 9.97554 5.9084 10.0079 5.85524 10.0299C5.80209 10.052 5.74511 10.0633 5.68756 10.0633C5.63002 10.0633 5.57304 10.052 5.51988 10.0299C5.46673 10.0079 5.41845 9.97554 5.37781 9.9348L2.31531 6.8723C2.23316 6.79015 2.18701 6.67873 2.18701 6.56255C2.18701 6.44637 2.23316 6.33495 2.31531 6.2528C2.39747 6.17065 2.50889 6.1245 2.62506 6.1245C2.74124 6.1245 2.85266 6.17065 2.93481 6.2528L5.68756 9.00642L11.5028 3.1903C11.5435 3.14956 11.5917 3.11723 11.6449 3.09518C11.698 3.07312 11.755 3.06177 11.8126 3.06177C11.8701 3.06177 11.9271 3.07312 11.9802 3.09518C12.0334 3.11723 12.0817 3.14956 12.1223 3.1903Z"></path>
                                    </svg>
                                    It promotes innovation-driven growth by encouraging employees to engage in research and development activities, fostering a culture of creativity and problem-solving within the organization.
</li>

                            </ul>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
    <div class="feature-card-section section-padding" style="background: #f4f9fd;">
        <div class="container">
            <div class="row g-4">

                <div class="col-lg-12">
                    <div class="row">
                        <div class="col-lg-12 gap-lg-5 gap-4 d-flex flex-lg-nowrap flex-wrap align-items-start justify-content-between mb-60">
                            <div class="section-title1 one">
                                <h2>Industry We Serve</h2>
                            </div>

                        </div>
                        <div class="col-lg-12">
                            <div class="row g-4">
                                <div class="col-xxl-6 col-sm-6">
                                    <div class="eg-card-2">
                                        <div class="icon">
                                            <img src="image/india/airplane.png" />
                                        </div>
                                        <div class="content">
                                            <h5>Air</h5>
                                            <p>Providing advanced solutions for avionics and flight testing to ensure safety and efficiency in aviation operations.</p>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-xxl-6 col-sm-6">
                                    <div class="eg-card-2">
                                        <div class="icon">
                                            <img src="image/india/startup.png" />
                                        </div>
                                        <div class="content">
                                            <h5>Space</h5>
                                            <p>Supporting space exploration and satellite systems with state-of-the-art testing and simulation technologies.</p>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-xxl-6 col-sm-6">
                                    <div class="eg-card-2">
                                        <div class="icon">
                                            <img src="image/india/defence.png" />
                                        </div>
                                        <div class="content">
                                            <h5>Defence</h5>
                                            <p>Delivering mission-critical systems for communication, radar, and weapons testing to enhance national security.</p>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-xxl-6 col-sm-6">
                                    <div class="eg-card-2">
                                        <div class="icon">
                                            <img src="image/india/cruise.png" />
                                        </div>
                                        <div class="content">
                                            <h5>Sea</h5>
                                            <p>Enabling maritime advancements through cutting-edge navigation and surveillance technologies for naval operations.</p>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="home5-protfolio-section mb-130 section-padding">
        <div class="container-fluid one">
            <div class="row g-lg-4 gy-5">
                <div class="col-lg-5 pl--95 pr--95">
                    <div class="section-title1 two">
                        <h2>Products Designed and Manufactured in India</h2>
                       <div class="slider-btn mt-30 mb-105">
   <a
     href="#"
     class="btn ss-btn mr-15"
     data-animation="fadeInLeft"
     data-delay=".4s"
     ><i class="fal fa-long-arrow-right"></i> Explore More</a
   >
 </div>
                    </div>
                </div>
                <div class="col-lg-7 ">
                    <div class="row gy-4">

                        <div class="col-lg-4">
                            <div class="magnetic-wrap">
                                <div class="people-card2 magnetic-item" style="">
                                    <div class="people-img">
                                        <img src="image/shop/1.jpg" alt="">
                                    </div>
                                    <div class="people-content">
                                        <div class="name-deg">
                                            <h5><a href="#">Air Product 1</a></h5>
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
                        <div class="col-lg-4">
                            <div class="magnetic-wrap">
                                <div class="people-card2 magnetic-item" style="">
                                    <div class="people-img">
                                        <img src="image/shop/1.jpg" alt="">
                                    </div>
                                    <div class="people-content">
                                        <div class="name-deg">
                                            <h5><a href="#">Air Product 1</a></h5>
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
                        <div class="col-lg-4">
                            <div class="magnetic-wrap">
                                <div class="people-card2 magnetic-item" style="">
                                    <div class="people-img">
                                        <img src="image/shop/1.jpg" alt="">
                                    </div>
                                    <div class="people-content">
                                        <div class="name-deg">
                                            <h5><a href="#">Air Product 1</a></h5>
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
                        <div class="col-lg-4">
                            <div class="magnetic-wrap">
                                <div class="people-card2 magnetic-item" style="">
                                    <div class="people-img">
                                        <img src="image/shop/1.jpg" alt="">
                                    </div>
                                    <div class="people-content">
                                        <div class="name-deg">
                                            <h5><a href="#">Air Product 1</a></h5>
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


                        <div class="col-lg-4">
                            <div class="magnetic-wrap">
                                <div class="people-card2 magnetic-item" style="">
                                    <div class="people-img">
                                        <img src="image/shop/1.jpg" alt="">
                                    </div>
                                    <div class="people-content">
                                        <div class="name-deg">
                                            <h5><a href="#">Air Product 1</a></h5>
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
                        <div class="col-lg-4">
                            <div class="magnetic-wrap">
                                <div class="people-card2 magnetic-item" style="">
                                    <div class="people-img">
                                        <img src="image/shop/1.jpg" alt="">
                                    </div>
                                    <div class="people-content">
                                        <div class="name-deg">
                                            <h5><a href="#">Air Product 1</a></h5>
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
                        <div class="col-lg-4">
                            <div class="magnetic-wrap">
                                <div class="people-card2 magnetic-item" style="">
                                    <div class="people-img">
                                        <img src="image/shop/1.jpg" alt="">
                                    </div>
                                    <div class="people-content">
                                        <div class="name-deg">
                                            <h5><a href="#">Air Product 1</a></h5>
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
                        <div class="col-lg-4">
                            <div class="magnetic-wrap">
                                <div class="people-card2 magnetic-item" style="">
                                    <div class="people-img">
                                        <img src="image/shop/1.jpg" alt="">
                                    </div>
                                    <div class="people-content">
                                        <div class="name-deg">
                                            <h5><a href="#">Air Product 1</a></h5>
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
                        <div class="col-lg-4">
                            <div class="magnetic-wrap">
                                <div class="people-card2 magnetic-item" style="">
                                    <div class="people-img">
                                        <img src="image/shop/1.jpg" alt="">
                                    </div>
                                    <div class="people-content">
                                        <div class="name-deg">
                                            <h5><a href="#">Air Product 1</a></h5>
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
            </div>
        </div>
    </div>
</asp:Content>

