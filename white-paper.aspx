<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="white-paper.aspx.cs" Inherits="white_paper" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/about.css" rel="stylesheet" />
    <link href="css/breadcrums.css" rel="stylesheet" />
    <style>
        .eg-card3.four {
            position: relative;
            padding: 0;
            transition: 0.5s;
        }
             .eg-card3.four:hover{
                 box-shadow: rgba(0, 0, 0, 0.2) 0px 18px 50px -10px;
             }
           .eg-card3.four .card-content {
    position: absolute;
    /* left: 20px; */
    top: 68px;
    width: 100%;
    height: 100%;
    transform: unset;
box-shadow: rgba(67, 71, 85, 0.27) 0px 0px 0.25em, rgba(90, 125, 188, 0.05) 0px 0.25em 1em;    /* padding: 50px 40px 20px 0; */
    display: flex
;
    justify-content: end;
    flex-direction: column;
    transition: 0.5s;
}

                .eg-card3.four .card-content .catgory-and-title {
                    transform: unset;
                    background-color: #fff;
                    padding: 25px 20px;
                    transition: 0.5s;
                }

                    .eg-card3.four .card-content .catgory-and-title > a {
                        border-radius: 16px;
                        border: 1px solid #000;
                        background: 0 0;
                        display: inline-block;
                        color: #000;
                        text-align: center;
                        font-size: 12px;
                        font-weight: 500;
                        padding: 2px 17px;
                        margin-bottom: 13px;
                    }

                    .eg-card3.four .card-content .catgory-and-title h5 {
                        margin-bottom: 0;
                    }

                        .eg-card3.four .card-content .catgory-and-title h5 a {
                            font-size: 18px;
                            color: #000;
                            transition: 0.5s;
                        }


        .eg-card3 .card-img img {
            transition: transform 0.3s ease; /* Smooth scaling transition */
            width: 100%;
            height: auto;
        }

    
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(image/blog/braadcrumb-bg3.jpg);">
        <div class="container-fluid one pl--95">
            <div class="row">
                <div class="col-lg-12">
                    <div class="banner-content">
                        <h1>White Paper</h1>
                        <ul class="breadcrumb-list">
                            <li><a href="index.html">Home</a></li>
                            <li>White Paper</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <main>
        <section class="section-padding">
            <div class="container">
                <div class="row g-lg-4 gy-5 mb-70">
                    <div class="col-lg-4 col-md-6">
                        <div class="eg-card3 four">
                            <div class="card-img">
                                <img src="image/whitepaper/portfolio-three-column-img1.jpg" alt="">
                            </div>
                            <div class="card-content">
                                <div class="catgory-and-title">
                                    <a href="whitepaper-details.aspx">Technology</a>
                                    <h5><a href="whitepaper-details.aspx">Information Technology (IT)</a></h5>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-6">
                        <div class="eg-card3 four">
                            <div class="card-img">
                                <img src="image/whitepaper/portfolio-three-column-img2.jpg" alt="">
                            </div>
                            <div class="card-content">
                                <div class="catgory-and-title">
                                    <a href="whitepaper-details.aspx">Managemnet</a>
                                    <h5><a href="whitepaper-details.aspx">To Change Management</a></h5>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-6">
                        <div class="eg-card3 four">
                            <div class="card-img">
                                <img src="image/whitepaper/portfolio-three-column-img3.jpg" alt="">
                            </div>
                            <div class="card-content">
                                <div class="catgory-and-title">
                                    <a href="whitepaper-details.aspx">Marketing</a>
                                    <h5><a href="whitepaper-details.aspx">Marketing and Sales Consulting</a></h5>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </section>
    </main>
</asp:Content>

