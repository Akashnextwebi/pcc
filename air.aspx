<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="air.aspx.cs" Inherits="air" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="/css/breadcrums.css" rel="stylesheet" />
    <link href="/css/industries.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(/<%=strBannerImage%>);">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="banner-content">
                        <h1 class="mb-3"><%=strIndustryName %></h1>
                        <ul class="breadcrumb-list">
                            <li><a href="/Default.aspx">Home</a></li>
                            <li><%=strIndustryName %></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="section-padding">
        <div class="container">
            <div class="row">
                <div class="col-lg-10">
                    <h2 class="mb-3"><%=strDescHeading %>


                    </h2>
                    <%=strfullDesc %>
                    <%--<p>
                        In modern aerospace technology, the integration of advanced communication systems is critical for efficient park control and communication (PCC). These systems ensure seamless interaction between drones, operators, and air traffic control, enhancing safety and operational efficiency. By leveraging cutting-edge communication protocols, PCC solutions allow precise navigation, situational awareness, and control within designated airspaces. As the demand for unmanned aerial systems grows, robust PCC systems will play a pivotal role in shaping the future of drone operations in both urban and remote environments.
                    </p>
                    <p class="mb-0">
                        With decades of experience in aerospace manufacturing, we specialize in creating solutions that meet the highest standards of performance and durability. Our parts are engineered to integrate seamlessly into sophisticated systems, ensuring unmatched operational excellence. When seconds count, you need components you can trust—crafted for resilience and precision.

                    </p>--%>
                </div>
            </div>

            <div class="row mt-5">
                <%=strFeature %>
               <%-- <div class="col-lg-4">
                    <div class="content-card">
                        <img src="/image/liv/jet.png" width="48" class="content-img" />
                        <h4>The Ultimate Solution for Precision Air Compression
                        </h4>
                        <p>Revolutionize your workflow with the Air PCC—a lightweight, high-performance portable compressed air system designed for maximum efficiency and reliability. Whether on-site or in the workshop, it's built to meet the highest aerospace and industrial standards.</p>
                    </div>
                </div>
                <div class="col-lg-4">
                    <div class="content-card">
                        <img src="/image/liv/jet.png" width="48" class="content-img" />

                        <h4>Why Choose Air PCC?
                        </h4>
                        <p>The Air PCC is a game-changer in portable air compression, offering ultra-compact and lightweight design for effortless transportation and ideal performance in mobile operations. It combines high output with low noise.</p>
                    </div>
                </div>
                <div class="col-lg-4">
                    <div class="content-card">
                        <img src="/image/liv/jet.png" width="48" class="content-img" />

                        <h4>Built for Excellence, Trusted by Industry Leaders
                        </h4>
                        <p>The Air PCC stands out with its unmatched durability, energy efficiency, and precision engineering. Designed specifically for demanding applications, it delivers reliability you can trust in aerospace manufacturing, drone maintenance, and other critical operations.</p>
                    </div>
                </div>--%>
            </div>
        </div>
    </div>



    <div class="solution-section section-padding pb-50 bg-light">
        <div class="container">
            <div class="row g-4">
                <div class="col-lg-12 ">
                    <div class="sub-title  text-start" id="divpro" runat="server">
                        <h2>Spotlight on <%=strIndustryName %> Capabilities
                        </h2>
                    </div>

                </div>
                <div class="col-lg-12">
                    <div class="row gy-4">

                        <%=strProduct %>

                        <%--<div class="col-lg-4">
                            <div class="card1">
                                <a href="/product-details.aspx" contenteditable="false" style="cursor: pointer;">
                                    <img src="/image/air/1.png" class="img1">
                                    <div class="intro1">
                                        <h4 class="text-h1">PCAMi - 1000

            </h4>

                                        <p class="text-p">
                                            Flight Test Telemetry & Instrumentation for Defense Aircrafts, Commercial Flight trials, UAV, Missiles, Helicopters, Launch Vehicles : Onboard           
                                        </p>
                                    </div>
                                </a>

                            </div>
                        </div>
                        <div class="col-lg-4">
                            <div class="card1">
                                <a href="product-details.aspx" contenteditable="false" style="cursor: pointer;">
                                    <img src="/image/air/2.png" class="img1">
                                    <div class="intro1">
                                        <h4 class="text-h1">PCAMi - 1000

</h4>

                                        <p class="text-p">
                                            Flight Test Telemetry & Instrumentation for Defense Aircrafts, Commercial Flight trials, UAV, Missiles, Helicopters, Launch Vehicles : Onboard           
                                        </p>
                                    </div>
                                </a>

                            </div>
                        </div>
                        <div class="col-lg-4">
                            <div class="card1">
                                <a href="product-details.aspx" contenteditable="false" style="cursor: pointer;">
                                    <img src="/image/air/3.png" class="img1">
                                    <div class="intro1">
                                        <h4 class="text-h1">PCAMi - 1000

</h4>

                                        <p class="text-p">
                                            Flight Test Telemetry & Instrumentation for Defense Aircrafts, Commercial Flight trials, UAV, Missiles, Helicopters, Launch Vehicles : Onboard           
                                        </p>
                                    </div>
                                </a>

                            </div>
                        </div>
                        <div class="col-lg-4">
                            <div class="card1">
                                <a href="/product-details.aspx" contenteditable="false" style="cursor: pointer;">
                                    <img src="/image/air/4.png" class="img1">
                                    <div class="intro1">
                                        <h4 class="text-h1">PCAMi - 1000

</h4>

                                        <p class="text-p">
                                            Flight Test Telemetry & Instrumentation for Defense Aircrafts, Commercial Flight trials, UAV, Missiles, Helicopters, Launch Vehicles : Onboard           
                                        </p>
                                    </div>
                                </a>

                            </div>
                        </div>
                        <div class="col-lg-4">
                            <div class="card1">
                                <a href="/product-details.aspx" contenteditable="false" style="cursor: pointer;">
                                    <img src="/image/air/2.png" class="img1">
                                    <div class="intro1">
                                        <h4 class="text-h1">PCAMi - 1000

</h4>

                                        <p class="text-p">
                                            Flight Test Telemetry & Instrumentation for Defense Aircrafts, Commercial Flight trials, UAV, Missiles, Helicopters, Launch Vehicles : Onboard           
                                        </p>
                                    </div>
                                </a>

                            </div>
                        </div>
                        <div class="col-lg-4">
                            <div class="card1">
                                <a href="product-details.aspx" contenteditable="false" style="cursor: pointer;">
                                    <img src="/image/air/2.png" class="img1">
                                    <div class="intro1">
                                        <h4 class="text-h1">PCAMi - 1000

</h4>

                                        <p class="text-p">
                                            Flight Test Telemetry & Instrumentation for Defense Aircrafts, Commercial Flight trials, UAV, Missiles, Helicopters, Launch Vehicles : Onboard           
                                        </p>
                                    </div>
                                </a>

                            </div>
                        </div>--%>

                        <!-- Sidebar  -->

                    </div>


                </div>
               
            </div>
        </div>
    </div>
    <%--<section class="cta ">

    <div class="cta__row">
        <div class="cta__col">
            <h2>Unlock Innovative, Customized Solutions for Defence, Aerospace,
        and Industrial Applications
      </h2>
        </div>
        <div class="cta__col">
            <a href="#" class="custom-btn" contenteditable="false" style="cursor: pointer;">Let's Connect</a>
        </div>
    </div>

</section>--%>
    <div class="horizontal-scrolling-section ">
        <div class="single-scroll-container" style="background-image: linear-gradient(180deg, rgb(0 0 0 / 58%) 0%, rgb(0 0 0 / 20%) 100%), url(/<%=strbannerimg2%>)">
            <div class="container-fluid one pl--95">
                <div class="horizontal-scrolling-content">
                    <div class="section-title1 two">
                        <span><%=strIndustryName %></span>
                        <h2><%=strDescHeading2 %>

                        </h2>
                    </div>
                    <p><%=strFullDesc2 %></p>
                    <div class="slider-btn ">
                        <a href="#" class="btn ss-btn mr-15" data-animation="fadeInLeft" data-delay=".4s" tabindex="0" style="animation-delay: 0.4s;"><i class="fal fa-long-arrow-right"></i>Read more</a>
                    </div>
                </div>
            </div>
        </div>
    </div>



    <script src="js/vendor/jquery-3.6.0.min.js"></script>


</asp:Content>

