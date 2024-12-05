<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="case-study-details.aspx.cs" Inherits="case_study_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        <style >
        .breadcrumb-section {
            background-size: cover;
            background-repeat: no-repeat;
            background-position: right;
            padding: 305px 0 200px;
            position: relative;
        }

        .section-padding {
            padding: 60px 0px;
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

        .mb-130 {
            margin-bottom: 130px;
        }

        .pt-130 {
            padding-top: 130px;
        }

        .container-fluid.one {
            max-width: 1746px;
        }

        .pl--95 {
            padding-left: 70px;
        }

        .details-page-content h2 {
            color: #000;
            font-size: 40px;
            font-weight: 400;
            line-height: 1.2;
            margin-bottom: 25px;
        }

        .details-page-content p {
            color: #566064;
            font-size: 16px;
            font-weight: 400;
            line-height: 1.7;
            margin-bottom: 12px;
        }

        .case-study-details-wrapper .case-study-details-top .case-study-details-info-wrap {
            background: #f4f9fd;
            padding: 60px;
            max-width: 445px;
            width: 100%;
        }

        .case-study-details-wrapper .case-study-details-top .case-study-details-info-wrap {
            background: #f4f9fd;
            padding: 60px;
            max-width: 445px;
            width: 100%;
        }

            .case-study-details-wrapper .case-study-details-top .case-study-details-info-wrap table {
                width: 100%;
                margin-bottom: 50px;
            }

                .case-study-details-wrapper .case-study-details-top .case-study-details-info-wrap table tbody tr td {
                    color: #000;
                    font-size: 18px;
                    font-weight: 400;
                    line-height: 1;
                    padding-bottom: 25px;
                    width: 50%;
                }

            .case-study-details-wrapper .case-study-details-top .case-study-details-info-wrap .download-btns li {
                margin-bottom: 20px;
            }

                .case-study-details-wrapper .case-study-details-top .case-study-details-info-wrap .download-btns li a {
                    color: #000;
                    font-size: 15px;
                    font-weight: 500;
                    line-height: 1;
                    white-space: nowrap;
                    display: flex;
                    align-items: center;
                    justify-content: center;
                    gap: 10px;
                    padding: 14px 20px;
                    background-color: #dfebf7;
                    transition: 0.5s;
                }

        .case-study-details-wrapper .case-study-details-top .case-study-details-info-wrap {
            background: #f4f9fd;
            padding: 60px;
            max-width: 445px;
            width: 100%;
        }

        .details-section-title {
            display: flex;
            align-items: center;
            gap: 8px;
            background-color: #f4f9fd;
            padding: 14px 30px;
        }

            .details-section-title h4 {
                color: #000;
                font-size: 24px;
                font-weight: 400;
                line-height: 1.2;
                margin-bottom: 0;
            }

        .case-study-details-wrapper .case-study-statement .statement-content p {
            color: #000;
            font-size: 16px;
            font-weight: 400;
            line-height: 1.7;
            margin-bottom: 35px;
        }

        .case-study-details-wrapper .case-study-statement .statement-content .statement-content-bottom .title {
            display: flex;
            align-items: center;
            gap: 8px;
            margin-bottom: 25px;
        }

            .case-study-details-wrapper .case-study-statement .statement-content .statement-content-bottom .title h6 {
                color: #566064;
                font-size: 18px;
                font-weight: 600;
                line-height: 1;
                margin-bottom: 0;
            }

        .case-study-details-wrapper .case-study-statement .statement-content .statement-content-bottom ul {
            -moz-columns: 3;
            columns: 3;
            width: 100%;
        }

            .case-study-details-wrapper .case-study-statement .statement-content .statement-content-bottom ul li {
                display: inline-flex;
                align-items: center;
                gap: 8px;
                color: #566064;
                font-size: 16px;
                font-weight: 500;
                line-height: 1.3;
                margin-bottom: 15px;
            }

        .case-study-details-wrapper .case-study-statement .advantage-img {
            height: 100%;
        }

            .case-study-details-wrapper .case-study-statement .advantage-img img {
                height: 100%;
                -o-object-fit: cover;
                object-fit: cover;
            }

        .case-study-details-wrapper .case-study-approach .approach-img {
            height: 100%;
        }

            .case-study-details-wrapper .case-study-approach .approach-img img {
                height: 100%;
                -o-object-fit: cover;
                object-fit: cover;
                -o-object-position: right;
                object-position: right;
            }

        .case-study-details-wrapper .case-study-approach .approach-content ul {
            list-style: decimal;
            padding-left: 20px;
            -moz-columns: 2;
            columns: 2;
            -moz-column-gap: 30px;
            column-gap: 30px;
            max-width: 740px;
            width: 100%;
        }

            .case-study-details-wrapper .case-study-approach .approach-content ul li {
                color: #566064;
                font-size: 16px;
                font-weight: 500;
                line-height: 1.5;
                margin-bottom: 15px;
            }

        .mb-130 {
            margin-bottom: 130px;
        }

        .implementation-section h2 {
            color: #000;
            font-size: 40px;
            font-weight: 400;
            line-height: 1.2;
            margin-bottom: 30px;
        }

        .implementation-section .single-implementation .title {
            padding-bottom: 25px;
            border-bottom: 1px solid #eee;
            margin-bottom: 25px;
        }

            .implementation-section .single-implementation .title h6 {
                color: #000;
                font-size: 16px;
                font-weight: 600;
                line-height: 1.2;
                margin-bottom: 0;
            }

        .implementation-section .single-implementation ul li {
            display: flex;
            gap: 8px;
            color: #566064;
            font-size: 15px;
            font-weight: 400;
            line-height: 1.8;
            margin-bottom: 15px;
            align-items: baseline;
        }        .details-navigation {
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
    padding:300px 0px 150px 0px;
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
                        <h1>Case Study</h1>
                        <ul class="breadcrumb-list">
                            <li><a href="Default.aspx">Home</a></li>
                            <li>Case Study</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <main>
        <section class="section-padding">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="case-study-details-wrapper pt-130 mb-130">
                            <div class="container-fluid one pl--95">
                                <div class="case-study-details-top mb-70">
                                    <div class="row g-lg-4 gy-5">
                                        <div class="col-lg-8">
                                            <div class="details-page-content">
                                                <h2>Digital Banking Transformation</h2>
                                                <p class="first-para">T he banking industry is a multifaceted sector of the economy that involves the buying, selling, development, management, and financing of real property, which includes land and physical structures. It plays a significant role in the global economy and encompasses various aspects of real estate transactions and operations. The real estate industry is influenced by economic conditions, population growth, urbanization trends, and government policies. It is a vital part of the economy, providing housing, commercial spaces, and infrastructure for communities and businesses , helping individuals and organizations navigate property transactions and investments.</p>
                                                <p>In a rapidly evolving and complex healthcare landscape, health and care consulting serves as a valuable resource for healthcare organizations looking to navigate challenges, improve patient care, and remain competitive. The advantages of consulting services are often realized through improved outcomes, increased patient satisfaction, and better overall healthcare delivery. Real estate professionals, from realtors to property developers, play crucial roles in this industry.</p>
                                                <p class="moretext">To empower organizations to thrive and achieve their full potential by providing strategic insights, innovative solutions, and expert guidance. We partner with our clients to enhance efficiency, competitiveness, and sustainability in an ever-evolving business landscape. moreless-button</p>
                                            </div>
                                        </div>
                                        <div class="col-lg-4 pl--95">
                                            <div class="case-study-details-info-wrap">
                                                <table>
                                                    <tbody>
                                                        <tr>
                                                            <td>Category:</td>
                                                            <td><span>Fintect</span></td>
                                                        </tr>
                                                        <tr>
                                                            <td>Clients:</td>
                                                            <td><span>Mr. Marko Paul</span></td>
                                                        </tr>
                                                        <tr>
                                                            <td>Location:</td>
                                                            <td><span>Newyork, USA</span></td>
                                                        </tr>
                                                        <tr>
                                                            <td>Date:</td>
                                                            <td><span>02/22/2023</span></td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                                <ul class="download-btns">
                                                    <li>
                                                        <a href="assets/case-study.pdf" download="#">
                                                            <img src="assets/img/inner-pages/Vector/pdf-icon.svg" alt="">
                                                            Download Pdf
</a>
                                                    </li>
                                                   
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="case-study-statement mb-70">
                                    <div class="row g-lg-4 gy-5">
                                        <div class="col-lg-8">
                                            <div class="statement-content">
                                                <div class="details-section-title mb-30">
                                                    <svg xmlns="http://www.w3.org/2000/svg" width="10" height="14" viewBox="0 0 10 14">
                                                        <path d="M0 14V0L10 7L0 14Z"></path>
                                                    </svg>
                                                    <h4>Problem Statements</h4>
                                                </div>
                                                <p>Health and care consulting offers several advantages for healthcare organizations, providers, and stakeholders. These advantages can help improve the quality of healthcare services, enhance operational efficiency, and address complex challenges within the healthcare industry.</p>
                                                <div class="statement-content-bottom">
                                                    <div class="title">
                                                        <svg xmlns="http://www.w3.org/2000/svg" width="7" height="10" viewBox="0 0 7 10">
                                                            <path d="M0 10V0L7 5L0 10Z"></path>
                                                        </svg>
                                                        <h6>Challenges </h6>
                                                    </div>
                                                    <ul>
                                                        <li>
                                                            <svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 14 14">
                                                                <path d="M12.1223 3.1903C12.1631 3.23094 12.1954 3.27922 12.2174 3.33237C12.2395 3.38552 12.2508 3.4425 12.2508 3.50005C12.2508 3.5576 12.2395 3.61458 12.2174 3.66773C12.1954 3.72088 12.1631 3.76916 12.1223 3.8098L5.99731 9.9348C5.95667 9.97554 5.9084 10.0079 5.85524 10.0299C5.80209 10.052 5.74511 10.0633 5.68756 10.0633C5.63002 10.0633 5.57304 10.052 5.51988 10.0299C5.46673 10.0079 5.41845 9.97554 5.37781 9.9348L2.31531 6.8723C2.23316 6.79015 2.18701 6.67873 2.18701 6.56255C2.18701 6.44637 2.23316 6.33495 2.31531 6.2528C2.39747 6.17065 2.50889 6.1245 2.62506 6.1245C2.74124 6.1245 2.85266 6.17065 2.93481 6.2528L5.68756 9.00642L11.5028 3.1903C11.5435 3.14956 11.5917 3.11723 11.6449 3.09518C11.698 3.07312 11.755 3.06177 11.8126 3.06177C11.8701 3.06177 11.9271 3.07312 11.9802 3.09518C12.0334 3.11723 12.0817 3.14956 12.1223 3.1903Z"></path>
                                                            </svg>
                                                            Digital Disruption
</li>
                                                        <li>
                                                            <svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 14 14">
                                                                <path d="M12.1223 3.1903C12.1631 3.23094 12.1954 3.27922 12.2174 3.33237C12.2395 3.38552 12.2508 3.4425 12.2508 3.50005C12.2508 3.5576 12.2395 3.61458 12.2174 3.66773C12.1954 3.72088 12.1631 3.76916 12.1223 3.8098L5.99731 9.9348C5.95667 9.97554 5.9084 10.0079 5.85524 10.0299C5.80209 10.052 5.74511 10.0633 5.68756 10.0633C5.63002 10.0633 5.57304 10.052 5.51988 10.0299C5.46673 10.0079 5.41845 9.97554 5.37781 9.9348L2.31531 6.8723C2.23316 6.79015 2.18701 6.67873 2.18701 6.56255C2.18701 6.44637 2.23316 6.33495 2.31531 6.2528C2.39747 6.17065 2.50889 6.1245 2.62506 6.1245C2.74124 6.1245 2.85266 6.17065 2.93481 6.2528L5.68756 9.00642L11.5028 3.1903C11.5435 3.14956 11.5917 3.11723 11.6449 3.09518C11.698 3.07312 11.755 3.06177 11.8126 3.06177C11.8701 3.06177 11.9271 3.07312 11.9802 3.09518C12.0334 3.11723 12.0817 3.14956 12.1223 3.1903Z"></path>
                                                            </svg>
                                                            perational Inefficiency
</li>
                                                        <li>
                                                            <svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 14 14">
                                                                <path d="M12.1223 3.1903C12.1631 3.23094 12.1954 3.27922 12.2174 3.33237C12.2395 3.38552 12.2508 3.4425 12.2508 3.50005C12.2508 3.5576 12.2395 3.61458 12.2174 3.66773C12.1954 3.72088 12.1631 3.76916 12.1223 3.8098L5.99731 9.9348C5.95667 9.97554 5.9084 10.0079 5.85524 10.0299C5.80209 10.052 5.74511 10.0633 5.68756 10.0633C5.63002 10.0633 5.57304 10.052 5.51988 10.0299C5.46673 10.0079 5.41845 9.97554 5.37781 9.9348L2.31531 6.8723C2.23316 6.79015 2.18701 6.67873 2.18701 6.56255C2.18701 6.44637 2.23316 6.33495 2.31531 6.2528C2.39747 6.17065 2.50889 6.1245 2.62506 6.1245C2.74124 6.1245 2.85266 6.17065 2.93481 6.2528L5.68756 9.00642L11.5028 3.1903C11.5435 3.14956 11.5917 3.11723 11.6449 3.09518C11.698 3.07312 11.755 3.06177 11.8126 3.06177C11.8701 3.06177 11.9271 3.07312 11.9802 3.09518C12.0334 3.11723 12.0817 3.14956 12.1223 3.1903Z"></path>
                                                            </svg>
                                                            Compliance Complexity
</li>
                                                        <li>
                                                            <svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 14 14">
                                                                <path d="M12.1223 3.1903C12.1631 3.23094 12.1954 3.27922 12.2174 3.33237C12.2395 3.38552 12.2508 3.4425 12.2508 3.50005C12.2508 3.5576 12.2395 3.61458 12.2174 3.66773C12.1954 3.72088 12.1631 3.76916 12.1223 3.8098L5.99731 9.9348C5.95667 9.97554 5.9084 10.0079 5.85524 10.0299C5.80209 10.052 5.74511 10.0633 5.68756 10.0633C5.63002 10.0633 5.57304 10.052 5.51988 10.0299C5.46673 10.0079 5.41845 9.97554 5.37781 9.9348L2.31531 6.8723C2.23316 6.79015 2.18701 6.67873 2.18701 6.56255C2.18701 6.44637 2.23316 6.33495 2.31531 6.2528C2.39747 6.17065 2.50889 6.1245 2.62506 6.1245C2.74124 6.1245 2.85266 6.17065 2.93481 6.2528L5.68756 9.00642L11.5028 3.1903C11.5435 3.14956 11.5917 3.11723 11.6449 3.09518C11.698 3.07312 11.755 3.06177 11.8126 3.06177C11.8701 3.06177 11.9271 3.07312 11.9802 3.09518C12.0334 3.11723 12.0817 3.14956 12.1223 3.1903Z"></path>
                                                            </svg>
                                                            Fragmented Customer Journey
</li>
                                                        <li>
                                                            <svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 14 14">
                                                                <path d="M12.1223 3.1903C12.1631 3.23094 12.1954 3.27922 12.2174 3.33237C12.2395 3.38552 12.2508 3.4425 12.2508 3.50005C12.2508 3.5576 12.2395 3.61458 12.2174 3.66773C12.1954 3.72088 12.1631 3.76916 12.1223 3.8098L5.99731 9.9348C5.95667 9.97554 5.9084 10.0079 5.85524 10.0299C5.80209 10.052 5.74511 10.0633 5.68756 10.0633C5.63002 10.0633 5.57304 10.052 5.51988 10.0299C5.46673 10.0079 5.41845 9.97554 5.37781 9.9348L2.31531 6.8723C2.23316 6.79015 2.18701 6.67873 2.18701 6.56255C2.18701 6.44637 2.23316 6.33495 2.31531 6.2528C2.39747 6.17065 2.50889 6.1245 2.62506 6.1245C2.74124 6.1245 2.85266 6.17065 2.93481 6.2528L5.68756 9.00642L11.5028 3.1903C11.5435 3.14956 11.5917 3.11723 11.6449 3.09518C11.698 3.07312 11.755 3.06177 11.8126 3.06177C11.8701 3.06177 11.9271 3.07312 11.9802 3.09518C12.0334 3.11723 12.0817 3.14956 12.1223 3.1903Z"></path>
                                                            </svg>
                                                            Customer Expectations
</li>
                                                        <li>
                                                            <svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 14 14">
                                                                <path d="M12.1223 3.1903C12.1631 3.23094 12.1954 3.27922 12.2174 3.33237C12.2395 3.38552 12.2508 3.4425 12.2508 3.50005C12.2508 3.5576 12.2395 3.61458 12.2174 3.66773C12.1954 3.72088 12.1631 3.76916 12.1223 3.8098L5.99731 9.9348C5.95667 9.97554 5.9084 10.0079 5.85524 10.0299C5.80209 10.052 5.74511 10.0633 5.68756 10.0633C5.63002 10.0633 5.57304 10.052 5.51988 10.0299C5.46673 10.0079 5.41845 9.97554 5.37781 9.9348L2.31531 6.8723C2.23316 6.79015 2.18701 6.67873 2.18701 6.56255C2.18701 6.44637 2.23316 6.33495 2.31531 6.2528C2.39747 6.17065 2.50889 6.1245 2.62506 6.1245C2.74124 6.1245 2.85266 6.17065 2.93481 6.2528L5.68756 9.00642L11.5028 3.1903C11.5435 3.14956 11.5917 3.11723 11.6449 3.09518C11.698 3.07312 11.755 3.06177 11.8126 3.06177C11.8701 3.06177 11.9271 3.07312 11.9802 3.09518C12.0334 3.11723 12.0817 3.14956 12.1223 3.1903Z"></path>
                                                            </svg>
                                                            Data Security and Privacy
</li>
                                                    </ul>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-4">
                                            <div class="advantage-img">
                                                <img src="image/case/1.png" alt="">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="case-study-approach">
                                    <div class="row g-lg-4 gy-5">
                                        <div class="col-lg-3">
                                            <div class="approach-img">
                                                <img src="image/case/2.png" alt="">
                                            </div>
                                        </div>
                                        <div class="col-lg-9">
                                            <div class="approach-content">
                                                <div class="details-section-title mb-40">
                                                    <svg xmlns="http://www.w3.org/2000/svg" width="10" height="14" viewBox="0 0 10 14">
                                                        <path d="M0 14V0L10 7L0 14Z"></path>
                                                    </svg>
                                                    <h4>Our Approach</h4>
                                                </div>
                                                <p>The solution approach will involve a phased implementation plan, strategic partnerships with fintech providers, technology infrastructure upgrades, and a strong focus on customer-centric design principles."This problem statement sets the stage for the digital banking transformation, outlining the challenges, objectives, scope, and desired outcomes of the initiative. It also highlights the importance of embracing digital technologies to stay competitive and meet the evolving needs of customers in the digital age.</p>
                                                <ul>
                                                    <li>Information Gathering and Analysis.</li>
                                                    <li>Stakeholder Collaboration.</li>
                                                    <li>Strategy Development.</li>
                                                    <li>Solution Design &amp; Sketching.</li>
                                                    <li>Implementation Planning.</li>
                                                    <li>Implementation Planning.</li>
                                                    <li>Change Management.</li>
                                                    <li>Quality Assurance.</li>
                                                    <li>Sustainability and Long-Term Planning.</li>
                                                    <li>Closure and Transition.</li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <div class="implementation-section mb-130">
            <div class="container-fluid one pl--95">
                <h2>Implementation &amp; Details</h2>
                <div class="row g-4">
                    <div class="col-lg-6">
                        <div class="single-implementation mb-30">
                            <div class="title">
                                <h6>1. Technology Upgrades</h6>
                            </div>
                            <ul>
                                <li>
                                    <svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 14 14">
                                        <path d="M12.1223 3.1903C12.1631 3.23094 12.1954 3.27922 12.2174 3.33237C12.2395 3.38552 12.2508 3.4425 12.2508 3.50005C12.2508 3.5576 12.2395 3.61458 12.2174 3.66773C12.1954 3.72088 12.1631 3.76916 12.1223 3.8098L5.99731 9.9348C5.95667 9.97554 5.9084 10.0079 5.85524 10.0299C5.80209 10.052 5.74511 10.0633 5.68756 10.0633C5.63002 10.0633 5.57304 10.052 5.51988 10.0299C5.46673 10.0079 5.41845 9.97554 5.37781 9.9348L2.31531 6.8723C2.23316 6.79015 2.18701 6.67873 2.18701 6.56255C2.18701 6.44637 2.23316 6.33495 2.31531 6.2528C2.39747 6.17065 2.50889 6.1245 2.62506 6.1245C2.74124 6.1245 2.85266 6.17065 2.93481 6.2528L5.68756 9.00642L11.5028 3.1903C11.5435 3.14956 11.5917 3.11723 11.6449 3.09518C11.698 3.07312 11.755 3.06177 11.8126 3.06177C11.8701 3.06177 11.9271 3.07312 11.9802 3.09518C12.0334 3.11723 12.0817 3.14956 12.1223 3.1903Z"></path>
                                    </svg>
                                    Invest in modernizing the bank's technology stack, including core banking systems, data management platforms, and cybersecurity solutions.
</li>
                                <li>
                                    <svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 14 14">
                                        <path d="M12.1223 3.1903C12.1631 3.23094 12.1954 3.27922 12.2174 3.33237C12.2395 3.38552 12.2508 3.4425 12.2508 3.50005C12.2508 3.5576 12.2395 3.61458 12.2174 3.66773C12.1954 3.72088 12.1631 3.76916 12.1223 3.8098L5.99731 9.9348C5.95667 9.97554 5.9084 10.0079 5.85524 10.0299C5.80209 10.052 5.74511 10.0633 5.68756 10.0633C5.63002 10.0633 5.57304 10.052 5.51988 10.0299C5.46673 10.0079 5.41845 9.97554 5.37781 9.9348L2.31531 6.8723C2.23316 6.79015 2.18701 6.67873 2.18701 6.56255C2.18701 6.44637 2.23316 6.33495 2.31531 6.2528C2.39747 6.17065 2.50889 6.1245 2.62506 6.1245C2.74124 6.1245 2.85266 6.17065 2.93481 6.2528L5.68756 9.00642L11.5028 3.1903C11.5435 3.14956 11.5917 3.11723 11.6449 3.09518C11.698 3.07312 11.755 3.06177 11.8126 3.06177C11.8701 3.06177 11.9271 3.07312 11.9802 3.09518C12.0334 3.11723 12.0817 3.14956 12.1223 3.1903Z"></path>
                                    </svg>
                                    Explore cloud-based solutions for scalability and cost-efficiency.
</li>
                            </ul>
                        </div>
                        <div class="single-implementation">
                            <div class="title">
                                <h6>2. Digital Banking Platforms</h6>
                            </div>
                            <ul>
                                <li>
                                    <svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 14 14">
                                        <path d="M12.1223 3.1903C12.1631 3.23094 12.1954 3.27922 12.2174 3.33237C12.2395 3.38552 12.2508 3.4425 12.2508 3.50005C12.2508 3.5576 12.2395 3.61458 12.2174 3.66773C12.1954 3.72088 12.1631 3.76916 12.1223 3.8098L5.99731 9.9348C5.95667 9.97554 5.9084 10.0079 5.85524 10.0299C5.80209 10.052 5.74511 10.0633 5.68756 10.0633C5.63002 10.0633 5.57304 10.052 5.51988 10.0299C5.46673 10.0079 5.41845 9.97554 5.37781 9.9348L2.31531 6.8723C2.23316 6.79015 2.18701 6.67873 2.18701 6.56255C2.18701 6.44637 2.23316 6.33495 2.31531 6.2528C2.39747 6.17065 2.50889 6.1245 2.62506 6.1245C2.74124 6.1245 2.85266 6.17065 2.93481 6.2528L5.68756 9.00642L11.5028 3.1903C11.5435 3.14956 11.5917 3.11723 11.6449 3.09518C11.698 3.07312 11.755 3.06177 11.8126 3.06177C11.8701 3.06177 11.9271 3.07312 11.9802 3.09518C12.0334 3.11723 12.0817 3.14956 12.1223 3.1903Z"></path>
                                    </svg>
                                    Develop or adopt user-friendly mobile and online banking platforms with intuitive interfaces, allowing customers to access accounts, perform transactions, and receive personalized financial insights.
</li>
                                <li>
                                    <svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 14 14">
                                        <path d="M12.1223 3.1903C12.1631 3.23094 12.1954 3.27922 12.2174 3.33237C12.2395 3.38552 12.2508 3.4425 12.2508 3.50005C12.2508 3.5576 12.2395 3.61458 12.2174 3.66773C12.1954 3.72088 12.1631 3.76916 12.1223 3.8098L5.99731 9.9348C5.95667 9.97554 5.9084 10.0079 5.85524 10.0299C5.80209 10.052 5.74511 10.0633 5.68756 10.0633C5.63002 10.0633 5.57304 10.052 5.51988 10.0299C5.46673 10.0079 5.41845 9.97554 5.37781 9.9348L2.31531 6.8723C2.23316 6.79015 2.18701 6.67873 2.18701 6.56255C2.18701 6.44637 2.23316 6.33495 2.31531 6.2528C2.39747 6.17065 2.50889 6.1245 2.62506 6.1245C2.74124 6.1245 2.85266 6.17065 2.93481 6.2528L5.68756 9.00642L11.5028 3.1903C11.5435 3.14956 11.5917 3.11723 11.6449 3.09518C11.698 3.07312 11.755 3.06177 11.8126 3.06177C11.8701 3.06177 11.9271 3.07312 11.9802 3.09518C12.0334 3.11723 12.0817 3.14956 12.1223 3.1903Z"></path>
                                    </svg>
                                    Implement features like mobile check deposit, digital wallets, and AI-powered chatbots for enhanced customer experiences.
</li>
                            </ul>
                        </div>
                    </div>
                    <div class="col-lg-6 pl--95">
                        <div class="single-implementation">
                            <div class="title">
                                <h6>3. Cybersecurity Enhancement</h6>
                            </div>
                            <ul>
                                <li>
                                    <svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 14 14">
                                        <path d="M12.1223 3.1903C12.1631 3.23094 12.1954 3.27922 12.2174 3.33237C12.2395 3.38552 12.2508 3.4425 12.2508 3.50005C12.2508 3.5576 12.2395 3.61458 12.2174 3.66773C12.1954 3.72088 12.1631 3.76916 12.1223 3.8098L5.99731 9.9348C5.95667 9.97554 5.9084 10.0079 5.85524 10.0299C5.80209 10.052 5.74511 10.0633 5.68756 10.0633C5.63002 10.0633 5.57304 10.052 5.51988 10.0299C5.46673 10.0079 5.41845 9.97554 5.37781 9.9348L2.31531 6.8723C2.23316 6.79015 2.18701 6.67873 2.18701 6.56255C2.18701 6.44637 2.23316 6.33495 2.31531 6.2528C2.39747 6.17065 2.50889 6.1245 2.62506 6.1245C2.74124 6.1245 2.85266 6.17065 2.93481 6.2528L5.68756 9.00642L11.5028 3.1903C11.5435 3.14956 11.5917 3.11723 11.6449 3.09518C11.698 3.07312 11.755 3.06177 11.8126 3.06177C11.8701 3.06177 11.9271 3.07312 11.9802 3.09518C12.0334 3.11723 12.0817 3.14956 12.1223 3.1903Z"></path>
                                    </svg>
                                    Strengthen cybersecurity measures to protect customer data and financial transactions. Implement multi-factor authentication, encryption, and continuous monitoring.
</li>
                                <li>
                                    <svg xmlns="http://www.w3.org/2000/svg" width="14" height="14" viewBox="0 0 14 14">
                                        <path d="M12.1223 3.1903C12.1631 3.23094 12.1954 3.27922 12.2174 3.33237C12.2395 3.38552 12.2508 3.4425 12.2508 3.50005C12.2508 3.5576 12.2395 3.61458 12.2174 3.66773C12.1954 3.72088 12.1631 3.76916 12.1223 3.8098L5.99731 9.9348C5.95667 9.97554 5.9084 10.0079 5.85524 10.0299C5.80209 10.052 5.74511 10.0633 5.68756 10.0633C5.63002 10.0633 5.57304 10.052 5.51988 10.0299C5.46673 10.0079 5.41845 9.97554 5.37781 9.9348L2.31531 6.8723C2.23316 6.79015 2.18701 6.67873 2.18701 6.56255C2.18701 6.44637 2.23316 6.33495 2.31531 6.2528C2.39747 6.17065 2.50889 6.1245 2.62506 6.1245C2.74124 6.1245 2.85266 6.17065 2.93481 6.2528L5.68756 9.00642L11.5028 3.1903C11.5435 3.14956 11.5917 3.11723 11.6449 3.09518C11.698 3.07312 11.755 3.06177 11.8126 3.06177C11.8701 3.06177 11.9271 3.07312 11.9802 3.09518C12.0334 3.11723 12.0817 3.14956 12.1223 3.1903Z"></path>
                                    </svg>
                                    Real estate investment trusts (REITs) provide a way for investors to access real estate assets through publicly traded securities.
</li>
                            </ul>
                        </div>

                    </div>
                </div>
            </div>
        </div>
        <div class="case-study-navigation-section mb-130">
            <div class="container ">
                <div class="row">
                    <div class="col-lg-12">
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
        </div>
    </main>
</asp:Content>

