<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="job-listing.aspx.cs" Inherits="job_listing" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/about.css" rel="stylesheet" />
    <link href="css/breadcrums.css" rel="stylesheet" />
    <style>
        .job-list-three {
            background: #fff;
            border: 1px solid #EBEBEB;
            border-radius: 10px;
            padding: 28px 40px 30px;
            transition: all .2s ease-in-out 0s;
        }

            .job-list-three .main-wrapper {
                position: relative;
                display: flex;
                flex-direction: column;
            }

                .job-list-three .main-wrapper .list-header {
                    border-bottom: 1px solid #EAEAEA;
                    padding-bottom: 30px;
                    margin-bottom: 25px;
                }

                .job-list-three .main-wrapper .logo {
                    width: 50px;
                }

                .job-list-three .main-wrapper .info-wrapper {
                    width: calc(100% - 50px);
                    padding-left: 22px;
                    padding-right: 37px;
                }

                .job-list-three .main-wrapper .title {
                    font-size: 18px;
                    color: #000;
                    margin-bottom: 7px;
                }

        .style-none {
            list-style: none;
            padding-left: 0;
            margin-bottom: 0;
        }

        .job-list-three .main-wrapper .info-data li {
            font-size: 14px;
            font-weight: 500;
            color: #244034b3;
            position: relative;
            margin-right: 20px;
        }

            .job-list-three .main-wrapper .info-data li:before {
                content: ".";
                position: absolute;
                right: -10px;
                top: 0;
            }

        .job-list-three .main-wrapper p {
            font-size: 14px;
            line-height: 28px;
            margin-bottom: 25px;
        }

        .job-list-three .main-wrapper .job-duration {
            display: inline-block;
            font-size: .875rem;
            font-weight: 500;
            color: #000;
            border-radius: 0px;
            padding: 5px 21px;
            background: #f3e8c1;
        }


        .job-list-three .main-wrapper .apply-btn {
            width: 80px;
            line-height: 30px;
            font-weight: 500;
            font-size: 12px;
            letter-spacing: 1px;
            color: #fff;
            text-transform: uppercase;
            border-radius: 17px;
            background: #31795a;
        }

        .career-image {
            border: 1px solid #eee;
            box-shadow: rgba(0, 0, 0, 0.05) 0px 0px 0px 1px;
            padding: 4px;
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
                            <h1>Career</h1>
                            <ul class="breadcrumb-list">
                                <li><a href="/">Home</a></li>
                                <li>Career</li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <section class="section-padding">
            <div class="container">
                <div class="row justify-content-center">
                    <div class="col-lg-6">
                        <div class="text-start ">
                            <h2 class="mb-40 ">About Career at PCC</h2>
                            <p>
                                Park Controls and Communications Private Limited, (PCC) is a company of three and half decades standing within the Defence and Aerospace Industry.  The company holds a monopoly status for the supply of products to the many Aircraft, Missiles, Unmanned Air Vehicles, Bombs and Satellite programs of the Government of India and Private suppliers to Defence and Aerospace.

                            </p>
                            <p>
                                PCC is on a fast track growth trajectory and is aiming to be the top player within the Industry and therefore, is continuously on the lookout for young and efficient problem solvers and go-getters, who have the ability to deliver from the first day of joining the organization. The positions are high pressure in nature with expectations that are very high and top notch.
                            </p>
                            <p>
                                Rewards and compensation are the best in the Industry. 
                            </p>
                            <p>
                                <strong>Come! Join us!! We are making a new high-tech world.

                                </strong>
                            </p>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="career-image">
                            <img src="image/career/c1.jpg" />
                        </div>
                    </div>
                </div>

            </div>
        </section>
        <section class="section-padding ">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="text-center mb-50">
                            <h2 class="">Current Job Opening</h2>
                        </div>


                    </div>
                </div>
                <div class="row gy-4">
                    <%=strJobs %>
                </div>
            </div>
        </section>
    </main>
</asp:Content>

