<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="investors.aspx.cs" Inherits="investors" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/about.css" rel="stylesheet" />
    <style>
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

        .bd-callout {
            padding: 1.25rem;
            margin-top: 1.25rem;
            margin-bottom: 1.25rem;
            color: #151615;
            background-color: #fff;
            border: 1px solid #efeded;
            box-shadow: 0 0 4px rgba(0, 0, 0, 0.2);
            justify-content: center;
            border-left: 2px solid #79010c;
            text-align: center;
        }

        .bd-callout-info {
            --bd-callout-color: var(--bs-info-text-emphasis);
            --bd-callout-bg: #f7f0ec;
            --bd-callout-border: #4e7661;
            font-weight: bold;
            text-transform: uppercase;
            min-height: 100px;
            align-items: center;
            display: flex;
        }

        .bd-callout:hover {
            background: #f8f8f8;
            cursor: pointer;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(image/blog/braadcrumb-bg3.jpg);">
        <div class="container-fluid one pl--95">
            <div class="row">
                <div class="col-lg-12">
                    <div class="banner-content">
                        <h1>Investor</h1>
                        <ul class="breadcrumb-list">
                            <li><a href="Default.aspx">Home</a></li>
                            <li>Investor</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <main>
        <section class="section-padding">
            <div class="container">
                <div class="row">
                    <%=strInvestors %>
                    <%--<div class="col-xl-3 col-lg-4 col-md-6">
                        <a href="investor-details.aspx" contenteditable="false" style="cursor: pointer;">
                            <div class="bd-callout bd-callout-info">
                                Annual report
                            </div>
                        </a>
                    </div>
                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <a href="investor-details.aspx" contenteditable="false" style="cursor: pointer;">
                            <div class="bd-callout bd-callout-info">
                                QUARTERLY RESULTS
                           
                            </div>
                        </a>
                    </div>

                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <a href="investor-details.aspx" contenteditable="false" style="cursor: pointer;">
                            <div class="bd-callout bd-callout-info">
                                INVESTOR CONTACT
                           
                            </div>
                        </a>
                    </div>

                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            CORPORATE GOVERNANCE
                       
                        </div>
                    </div>

                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            UNPAID DIVIDEND
                       
                        </div>
                    </div>

                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            CODE OF CONDUCT
                       
                        </div>
                    </div>
                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            CODE OF CONDUCT FOR EMPLOYEES
                       
                        </div>
                    </div>

                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            WHISTLE BLOWER POLICY
                       
                        </div>
                    </div>

                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            CORPORATE SOCIAL RESPONSIBILITY POLICY
                       
                        </div>
                    </div>
                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            RISK MANAGEMENT POLICY
                       
                        </div>
                    </div>

                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            NOMINATION AND REMUNERATION POLICY
                       
                        </div>
                    </div>

                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            ANNUAL GENERAL MEETING REPORTS
                       
                        </div>
                    </div>
                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            APPOINTMENT OF DIRECTORS
                       
                        </div>
                    </div>
                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            AGM 2015
                       
                        </div>
                    </div>
                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            AGM 2016
                       
                        </div>
                    </div>
                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            DISCLOSURE UNDER CLAUSE 53
                       
                        </div>
                    </div>
                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            INSIDER TRADING REGULATION
                       
                        </div>
                    </div>
                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            POSTAL BALLOT 2017
                       
                        </div>
                    </div>
                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            BOARD OF DIRECTORS
                       
                        </div>
                    </div>
                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            CORPORATE ANNOUNCEMENTS
                       
                        </div>
                    </div>
                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            FAMILIARIZATION PROGRAMME FOR INDEPENDENT DIRECTORS
                       
                        </div>
                    </div>
                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            PARTY TRANSCATIONS POLICY
                       
                        </div>
                    </div>
                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            POLICY ON DETERMINATION
                       
                        </div>
                    </div>
                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            AGM 2017
                       
                        </div>
                    </div>
                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            COMMITTEE
                       
                        </div>
                    </div>
                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            DEMERGER
                       
                        </div>
                    </div>
                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            AGM-2020
                       
                        </div>
                    </div>
                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            EGM 2021
                       
                        </div>
                    </div>
                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            AGM-2021 &amp; 2022
                       
                        </div>
                    </div>
                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            CONTACT DETAILS
                       
                        </div>
                    </div>
                    <div class="col-xl-3 col-lg-4 col-md-6">
                        <div class="bd-callout bd-callout-info">
                            ANNUAL RETURN 2021
                       
                        </div>
                    </div>--%>
                </div>
            </div>
        </section>
    </main>
</asp:Content>

