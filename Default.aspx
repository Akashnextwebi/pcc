﻿<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <main>
        <!-- slider-area -->
        <section class="slider-area p-relative">
            <div class="slider-active" style="background: #101010">
                <div
                    class="single-slider slider-bg d-flex align-items-center"
                    style="background-image: url(image/bg1/bb1-min.webp); background-size: cover;">
                    <div class="container">
                        <div class="row justify-content-start align-items-start">
                            <div class="col-lg-9 col-md-8">
                                <div class="slider-content s-slider-content mt-200 pt-50">
                                    <h2 data-animation="fadeInUp" data-delay=".4s">Driving Data Acquisition while Powering Precision
                                    </h2>
                                    <p data-animation="fadeInUp" data-delay=".6s">
                                        The Health & Utility Management Systems (HUMS) Data Acquisition Unit is a future-ready solution to monitor and assess the health and performance of critical flight instruments and systems. 
                                    </p>
                                    <div class="slider-btn mt-30 mb-105">
                                        <a
                                            href="#"
                                            class="btn ss-btn mr-15"
                                            data-animation="fadeInLeft"
                                            data-delay=".4s" data-bs-toggle="modal" data-bs-target="#exampleModal"><i class="fal fa-long-arrow-right"></i>Read more</a>
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-6 col-md-4 p-relative"></div>
                        </div>

                    </div>
                </div>
                <div
                    class="single-slider slider-bg d-flex align-items-center"
                    style="background-image: url(image/bg1/bb2-min.webp); background-size: cover;">
                    <div class="container">
                        <div class="row justify-content-start align-items-start">
                            <div class="col-lg-9 col-md-8">
                                <div class="slider-content s-slider-content mt-100 pt-50">
                                    <h2 data-animation="fadeInUp" data-delay=".4s">Control Refined. Performance Redefined.
                                    </h2>
                                    <p data-animation="fadeInUp" data-delay=".6s">
                                        The <strong>Full Authority Digital Engine Control (FADEC)</strong> is one of the leading Power Control Systems that enables simpler and more efficient management of the flight engine and its components.
                                    </p>
                                    <div class="slider-btn mt-30">
                                        <a
                                            href="#"
                                            class="btn ss-btn mr-15"
                                            data-animation="fadeInLeft"
                                            data-delay=".4s" data-bs-toggle="modal" data-bs-target="#exampleModal2"><i class="fal fa-long-arrow-right" ></i>Read more</a>
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-7 col-md-7 p-relative">
                            </div>
                        </div>
                    </div>
                </div>
                <div
                    class="single-slider slider-bg d-flex align-items-center"
                    style="background-image: url(image/bg1/bb3-min.webp); background-size: cover;">
                    <div class="container">
                        <div class="row justify-content-start align-items-start">
                            <div class="col-lg-9 col-md-8">
                                <div class="slider-content s-slider-content mt-100 pt-50">
                                    <h2 data-animation="fadeInUp" data-delay=".4s">Raising the Standard for Seamless Synchronization  
                                    </h2>
                                    <p data-animation="fadeInUp" data-delay=".6s">
                                        These systems provide highly accurate timekeeping modes that are vital for aviation, telecommunications, and defence data centres. It keeps the time consistent across multiple airborne instruments and ground locations         
                                    </p>
                                    <div class="slider-btn mt-30">
                                        <a
                                            href="#"
                                            class="btn ss-btn mr-15"
                                            data-animation="fadeInLeft"
                                            data-delay=".4s" data-bs-toggle="modal" data-bs-target="#exampleModal3"><i class="fal fa-long-arrow-right"></i>Read more</a>
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-7 col-md-7 p-relative">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="badge">
                <img src="image/makein-india.png" alt="" class="make-in-india" />
                <img src="image/element-1.png" alt="feature" class="spin-animation" />
            </div>
        </section>
        <!-- slider-area-end -->
        <!-- about-area -->
        <section class="about-area about-p pt-120 pb-120 p-relative fix">
            <div class="scroll-btn">
                <a href="#top">
                    <img src="image/scroll-top-line.png" alt="img" />
                    Scroll Down</a>
            </div>
            <ul class="nav nav-tabs">
                <li>
                    <span
                        class="active"
                        id="home-tab"
                        data-bs-toggle="tab"
                        data-bs-target="#voverview"
                        role="tab">About Us</span>
                </li>
            </ul>
            <div class="tab-content" id="myTabContent">
                <div class="tab-pane fade show active" id="voverview" role="tabpanel">
                    <div class="container">
                        <div class="row justify-content-center align-items-center">
                            <div class="col-lg-6 col-md-12 col-sm-12">
                                <div
                                    class="s-about-img p-relative new-about wow fadeInLeft animated"
                                    data-animation="fadeInLeft"
                                    data-delay=".4s">
                                    <img src="image/habo/3.png" alt="img" />
                                </div>
                            </div>

                            <div class="col-lg-6 col-md-12 col-sm-12">
                                <div
                                    class="about-content s-about-content wow fadeInRight animated"
                                    data-animation="fadeInRight"
                                    data-delay=".4s">
                                    <div class="about-title second-title pb-25">
                                        <div class="mb-30">
                                            <img src="image/icon-2.png" alt="img" />
                                        </div>
                                        <h2>Empowered Vision.
                                            <br class="d-lg-block d-md-none d-none "/>
                                            Embedded Values</h2>
                                    </div>
                                    <p>
                                        <strong>Park Controls and Communications Private Limited (PCC)</strong>, with over 3 decades of experience, is an agile and innovative leader in standard, customized and COTS (Commercial Off The Shelf) solutions for Defence, Aerospace, Space, and Industrial applications. Our commitment to innovation and precision enables us to serve clients across India and beyond. PCC delivers precise, tailored products meeting rigorous AS9100D, ISO 9001:2015 , and CEMILAC standards.
                                    </p>
                                    <p>
                                      The company was awarded with the Government of India recognition as an R & D unit a decade ago. PCC is registered with the National Small Industries Corporation and licensed to produce Defence LRUs, ensuring reliability and compliance with the most stringent requirements.
                                    </p>
                                    <a
                                        href="about-us.aspx"
                                        class="btn2 mt-35"
                                        data-animation="fadeInLeft"
                                        data-delay=".4s">Read More <i class="fal fa-long-arrow-right"></i></a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- about-area-end -->
        <!-- services-area -->
        <section
            id="services"
            class="services-area services-bg pt-120 pb-120 p-relative fix"
            style="background: #f3f3f3">
            <div class="container">
                <div class="row">
                    <div class="col-12">
                        <div
                            class="d-flex new-flex justify-content-between align-items-center mb-50">
                            <div class="pcc-section-heading mb-0">
                                <span>Our Core Competence</span>
                                <h2>Delivering Excellence in
                                   <br class="d-lg-block d-md-none d-none "/>
                                    Defence & Aerospace</h2>
                            </div>
                            <%--<div class="service-btn d-lg-block d-none">
                                <a href="#" class="btn2">Read More<i class="fal fa-long-arrow-right"></i></a>
                            </div>--%>
                        </div>
                    </div>
                    <div class="services-slider-pcc">
                        <div class="col-lg-4 col-md-6">
                            <div class="service-card">
                                <div class="card-inner">
                                    <div class="title">
                                        <h3>Advanced Avionics<br /> Solutions</h3>
                                        <p>
                                            Creating Smarter, Safer, and Highly Efficient Systems for On-board & Ground Operations. 
                                        </p>
                                    </div>
                                    <div class="image">
                                        <div class="icon">
                                            <img src="image/icons/data.png" alt="" />
                                        </div>
                                        <img src="image/data-solution.jpg" alt="" />
                                    </div>
                                    <div class="product-link">
                                        <a href="/competencies/advanced-avionics-solutions" class="custom-btn">View Products</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 col-md-6">
                            <div class="service-card">
                                <div class="card-inner">
                                    <div class="title">
                                        <h3>Precise Time & Frequency solutions</h3>
                                        <p>
                                            Delivering Perfection where every Second
                                            Matters.
                                        </p>
                                    </div>
                                    <div class="image">
                                        <div class="icon">
                                            <img src="image/icons/time.png" alt="" />
                                        </div>
                                        <img src="Img/cc/pt.png" alt="" />
                                    </div>
                                    <div class="product-link">
                                        <a href="/competencies/precise--time-and-frequency-solution" class="custom-btn">View Products</a>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="col-lg-4 col-md-6">
                            <div class="service-card">
                                <div class="card-inner">
                                    <div class="title">
                                        <h3>Control
                                            <br />
                                            Solutions</h3>
                                        <p>
                                            Ensuring Consistent Performance for
                                          
                                            Mission-Critical Applications
                                        </p>
                                    </div>
                                    <div class="image">
                                        <div class="icon">
                                            <img src="image/icons/power-generation.png" alt="" />
                                        </div>
                                        <img src="Img/cc/Control.png" alt="" />
                                    </div>
                                    <div class="product-link">
                                        <a href="/competencies/control-solution" class="custom-btn">View Products</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 col-md-6">
                            <div class="service-card">
                                <div class="card-inner">
                                    <div class="title">
                                        <h3>Select Custom
                                            <br />
                                            Solutions</h3>
                                        <p>
                                            Redefining complex requirements with
                                       
                                            adaptable innovations. 
                                        </p>
                                    </div>
                                    <div class="image">
                                        <div class="icon">
                                            <img src="image/icons/customization.png" alt="" />
                                        </div>
                                        <img src="image/indigenization.jpg" alt="" />
                                    </div>
                                    <div class="product-link">
                                        <a href="/competencies/select-custom-solution" class="custom-btn">View Products</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="scrollbox2 fix">
                <div class="scrollbox scrollbox--secondary scrollbox--reverse">
                    <div class="scrollbox__item">
                        <div class="section-t">
                            <h2>INDUSTRIAL SOLUTIONS</h2>
                        </div>
                    </div>
                    <div class="scrollbox__item">
                        <div class="section-t">
                            <h2>DEFENCE & AEROSPACE</h2>
                        </div>
                    </div>
                    <div class="scrollbox__item">
                        <div class="section-t">
                            <h2>INDUSTRIAL AUTOMATION</h2>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- services-area-end -->

        <section class="wptb-funfacts-one has-before-bg py-0">
            <div class="container">
                <div class="wptb-funfacts--inner">
                    <div class="row">
                        <div class="col-lg-4 col-md-4 mb-4 mb-md-0 mb-lg-0">
                            <div class="wptb-counter1 style1 wow skewIn">
                                <div class="wptb-item--inner">
                                    <div class="wptb-item--icon">
                                        <img src="image/icons/supply-chain.png" alt="" />
                                    </div>
                                    <div class="wptb-item--holder">
                                        <div class="wptb-item--text">Products Introduced</div>
                                        <div class="wptb-item--value">
                                            <span class="odometer"></span><span class="suffix">300+</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="col-lg-4 col-md-4 mb-4 mb-md-0 mb-lg-0">
                            <div class="wptb-counter1 style1 wow skewIn">
                                <div class="wptb-item--inner">
                                    <div class="wptb-item--icon">
                                        <img src="image/icons/client.png" alt="" />
                                    </div>
                                    <div class="wptb-item--holder">
                                        <div class="wptb-item--text">Engineering Partners</div>
                                        <div class="wptb-item--value">
                                            <span class="odometer"></span><span class="suffix">275+</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="col-lg-4 col-md-4 mb-4 mb-md-0 mb-lg-0">
                            <div class="wptb-counter1 style1 wow skewIn">
                                <div class="wptb-item--inner">
                                    <div class="wptb-item--icon">
                                        <img src="image/icons/experience.png" alt="" />
                                    </div>
                                    <div class="wptb-item--holder">
                                        <div class="wptb-item--text">Years of Experties</div>
                                        <div class="wptb-item--value">
                                            <span class="odometer"></span><span class="suffix">35+</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <section class="industry-we-serve pt-80 pb-120 p-relative">
            <div class="container">
                <div class="row">
                    <div class="col-12">
                        <div class="pcc-section-heading">
                            <h2>Industry We Serve</h2>
                        </div>
                    </div>
                </div>
                <div class="row gy-4">
                    <div class="col-6 col-sm-6 col-md-3">
                        <div class="industry-card">
                             <a href="/industries/air"><div class="image">
                                <a href="/industries/air"><img src="image/air-industry.jpg" alt="" /></a>
                            </div></a>
                            <a href="/industries/air"><div class="image-caption">Air</div></a>
                        </div>
                    </div>
                    <div class="col-6 col-sm-6 col-md-3">
                        <div class="industry-card">
                            <div class="image">
                                <img src="image/land-industry.jpg" alt="" />
                            </div>
                            <a href="/industries/land"><div class="image-caption">Land</div></a>
                        </div>
                    </div>
                    <div class="col-6 col-sm-6 col-md-3">
                        <div class="industry-card">
                            <div class="image">
                                <img src="image/sea-industry.jpg" alt="" />
                            </div>
                            <a href="/industries/sea"><div class="image-caption">Sea</div></a>
                        </div>
                    </div>
                    <div class="col-6 col-sm-6 col-md-3">
                        <div class="industry-card">
                            <div class="image">
                                <img src="image/space-industry.jpg" alt="" />
                            </div>
                            <a href="/industries/space"><div class="image-caption">Space</div></a>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <section class="clientele">
            <div class="container-fluid px-0">
                <div class="client-logo-wrap">
                    <div class="client-card">
                        <img src="image/clients/indian-air-force.png" alt="" />
                    </div>
                    <div class="client-card">
                        <img src="image/clients/isro-logo.png" alt="" />
                    </div>
                    <div class="client-card">
                        <img src="image/clients/csir-csio.jpg" alt="" />
                    </div>
                    <div class="client-card">
                        <img src="image/clients/defence.jpg" alt="" />
                    </div>
                    <div class="client-card">
                        <img src="image/clients/bhartiya.png" alt="" />
                    </div>
                    <div class="client-card">
                        <img src="image/clients/ada.jpg" alt="" />
                    </div>
                </div>
            </div>
        </section>
        <!-- service-area -->
        <!-- skill-area -->
        <section
            id="skill"
            class="skill-area p-relative fix pt-120 pb-120 why-choose-us">
            <div class="container">
                <div class="row justify-content-center align-items-center">
                    <div class="col-lg-6 col-md-12 col-sm-12 pr-30">
                        <div
                            class="skills-img wow fadeInLeft animated"
                            data-animation="fadeInLeft"
                            data-delay=".4s">
                          <%--  <a
                                href="https://www.youtube.com/shorts/Sb21UWXblcA"
                                class="video-i popup-video">
                                <span class="play-icon">
                                    <i class="fa-solid fa-play"></i>
                                    <span class="playvideo_animation"></span>
                                    <span
                                        class="playvideo_animation"
                                        style="animation-delay: 0.4s"></span>
                                    <span
                                        class="playvideo_animation"
                                        style="animation-delay: 0.6s"></span>
                                </span></a>--%>
                                <img src="image/why4.png" alt="img" class="img" />
                            
                        </div>
                    </div>
                    <div class="col-lg-6 col-md-12 col-sm-12">
                        <div
                            class="skills-content s-about-content wow fadeInRight animated"
                            data-animation="fadeInRight"
                            data-delay=".4s">
                            <div class="pcc-section-heading">
                                <span class="text-white">#1 in Customer Satisfaction</span>
                                <h2 class="text-white">Why Choose Us</h2>
                            </div>
                            <p class="text-white">
                                Trusted by leading organizations, our technology-driven approach ensures superior functionality in the most demanding environments. We specialize in advanced telemetry solutions, control systems, and data acquisition units designed for mission-critical applications. Irrespective of the application used for aerospace, defense or industrial sectors.
                            </p>
                            <div class="mt-20">
                                <div
                                    class="skills pt-50 pb-50"
                                    style="background-image: url(image/skills-img.png); background-repeat: repeat-y;">
                                    <div class="skill mb-30">
                                        <div class="skill-name">CONSTANT INNOVATION</div>
                                        <div class="skill-bar">
                                            <div class="skill-per" id="80"></div>
                                        </div>
                                    </div>
                                    <div class="skill mb-30">
                                        <div class="skill-name">IN-HOUSE EXPERTISEs</div>
                                        <div class="skill-bar">
                                            <div class="skill-per" id="90"></div>
                                        </div>
                                    </div>
                                    <div class="skill">
                                        <div class="skill-name">ENGINEERING REVOLUTION</div>
                                        <div class="skill-bar">
                                            <div class="skill-per" id="100"></div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- skill-area-end -->
        <section
            class="service pb-120 p-relative fix"
            style="background: #f3f3f3">
            <div class="scrollbox2">
                <div class="scrollbox scrollbox--secondary scrollbox--reverse">
                    <div class="scrollbox__item">
                        <div class="section-t">
                            <h2>Our Products</h2>
                        </div>
                    </div>
                    <div class="scrollbox__item">
                        <div class="section-t">
                            <h2>Our Products</h2>
                        </div>
                    </div>
                    <div class="scrollbox__item">
                        <div class="section-t">
                            <h2>Our Products</h2>
                        </div>
                    </div>
                </div>
            </div>
            <div class="container">
                <div class="row">
                    <div class="col-lg-12 col-md-12 col-sm-12">
                        <ul class="services-active">
                            <li>
                                <div class="service-box-slider">
                                    <div class="text">
                                       <%-- <span>Land</span>--%>
                                        <h3 class="fw-bold">Land</h3>
                                        <p>
PCC prides in the supply of many products that are used for surface applications; Range Systems that include Telemetry Ground Stations, Time Synchronization Systems, Automated Test Equipment, Digital Engine Control Unit, Heavy Vehicle Dashboard Display, etc.
                                        </p>
                                        <a
                                            href="/industries/land"
                                            class="btn2 mt-35"
                                            data-animation="fadeInLeft"
                                            data-delay=".4s">Read More <i class="fal fa-long-arrow-right"></i></a>
                                    </div>
                                    <div class="img">
                                        <div class="product-card-img">
                                            <img src="image/hpro/l1.png" alt="img" />
                                        </div>
                                    </div>
                                </div>
                            </li>
                            <li>
                                <div class="service-box-slider">
                                    <div class="text">
                                        <h3 class="fw-bold">Air</h3>
                                        <p>
Airborne products that are technology intense and unique is the hallmark of the PCC portfolio; Data Acquisition Unit for Flight Test Instrumentation and Health & Usage Monitoring Systems, Full Authority Digital Engine Control, Control & Guidance Electronics, Fuel Flow Meter Unit, etc.
                                        </p>
                                        <a
                                            href="/industries/air"
                                            class="btn2 mt-35"
                                            data-animation="fadeInLeft"
                                            data-delay=".4s">Read More <i class="fal fa-long-arrow-right"></i></a>
                                    </div>
                                    <div class="img">
                                        <div class="product-card-img">
                                            <img src="image/hpro/l2.png" alt="img" />
                                        </div>
                                    </div>
                                </div>
                            </li>
                            <li>
                                <div class="service-box-slider">
                                    <div class="text">
                                        <h3 class="fw-bold">Sea </h3>
                                        <p>
PCC works closely with Naval vessels in supplying products and solutions for Torpedoes, Fire Control Systems, Ship based landing and takeoff, etc.
                                        </p>
                                        <a
                                            href="/industries/sea"
                                            class="btn2 mt-35"
                                            data-animation="fadeInLeft"
                                            data-delay=".4s">Read More <i class="fal fa-long-arrow-right"></i></a>
                                    </div>
                                    <div class="img">
                                        <div class="product-card-img">
                                            <img src="image/hpro/l3.png" alt="img" />
                                        </div>
                                    </div>
                                </div>
                            </li>
                                                        <li>
                                <div class="service-box-slider">
                                    <div class="text">
                                        <h3 class="fw-bold">Space </h3>
                                        <p>
The Satellite launches by the Indian Space Research Organization have been supported by PCC to a great extent with their Telemetry Solutions, Timing Solutions, etc.
                                        </p>
                                        <a
                                            href="/industries/space"
                                            class="btn2 mt-35"
                                            data-animation="fadeInLeft"
                                            data-delay=".4s">Read More <i class="fal fa-long-arrow-right"></i></a>
                                    </div>
                                    <div class="img">
                                        <div class="product-card-img">
                                            <img src="image/hpro/l4.png" alt="img" />
                                        </div>
                                    </div>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </section>
        <!-- service-details2-area-end -->

        <!-- testimonial-area -->
        <section
            id="testimonial"
            class="testimonial-area pt-100 pb-100 p-relative fix">
            <div class="container">
                <div class="client-logos">
                    <div class="client-image">
                        <img src="image/clients/ada.jpg" alt="" />
                    </div>
                    <div class="client-image">
                        <img src="image/clients/bhartiya.png" alt="" />
                    </div>
                    <div class="client-image">
                        <img src="image/clients/csir-csio.jpg" alt="" />
                    </div>
                    <div class="client-image">
                        <img src="image/clients/defence.jpg" alt="" />
                    </div>
                    <div class="client-image">
                        <img src="image/clients/indian-air-force.png" alt="" />
                    </div>
                    <div class="client-image">
                        <img src="image/clients/isro-logo.png" alt="" />
                    </div>
                    <div class="client-image">
                        <img src="image/clients/nal.jpg" alt="" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-12">
                        <div
                            class="pcc-section-heading wow fadeInDown animated"
                            data-animation="fadeInDown"
                            data-delay=".4s">
                            <span>Testimonials</span>
                            <h2>What Our Client's Say</h2>
                        </div>
                    </div>
                    <div class="col-lg-12">
                        <div
                            class="testimonial-active wow fadeInUp animated"
                            data-animation="fadeInUp"
                            data-delay=".4s">
                            <%=strtestimonial %>
                           <%-- <div class="testimonial-box">
                                <div class="single-testimonial">
                                    <div class="review-icon">
                                        <img src="image/icons/review-icon.png" alt="img" />
                                    </div>
                                    <p>
                                        “Park Controls & Communications (P) Ltd., Bangalore has
                  been supplying PCM Decommutation Systems for last fifteen
                  years. The products supplied by the company are presently
                  in use with us for Flight Trials and testing”
                                    </p>
                                    <div class="testi-author">
                                        <div class="ta-info">
                                            <h6>Mr. S. Venugopal <span>/PD, ASTRA Project</span>
                                            </h6>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="testimonial-box">
                                <div class="single-testimonial">
                                    <div class="review-icon">
                                        <img src="image/icons/review-icon.png" alt="img" />
                                    </div>
                                    <p>
                                        Park Controls & Communications (P) Ltd., Bangalore has
                  been supplying Telemetry equipments for last fifteen
                  years. The products supplied by the company are presently
                  in use with us for LCA Flight trials and testing.
                                    </p>
                                    <div class="testi-author">
                                        <div class="ta-info">
                                            <h6>Mr. B. Umashankar <span>/ NFTC / ADA</span></h6>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="testimonial-box">
                                <div class="single-testimonial">
                                    <div class="review-icon">
                                        <img src="image/icons/review-icon.png" alt="img" />
                                    </div>
                                    <p>
                                        Park Controls and Communications supplied the Telemetry
                  Receiving station for Brahmos Aerospace Pvt Ltd. The
                  system is robust, rich in feature and user friendly. The
                  performance of the system is excellent and meets our
                  requirement.
                                    </p>
                                    <div class="testi-author">
                                        <div class="ta-info">
                                            <h6>S Masood Ahmed <span>/Addl General manager</span>
                                            </h6>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="testimonial-box">
                                <div class="single-testimonial">
                                    <div class="review-icon">
                                        <img src="image/icons/review-icon.png" alt="img" />
                                    </div>
                                    <p>
                                        Park Controls & Communications (P) Ltd., Bangalore has
                  been supplying Telemetry equipments for last fifteen
                  years. The products supplied by the company are presently
                  in use with us for LCA Flight trials and testing.
                                    </p>
                                    <div class="testi-author">
                                        <div class="ta-info">
                                            <h6>Mr. B. Umashankar <span>/ NFTC / ADA</span></h6>
                                        </div>
                                    </div>
                                </div>
                            </div>--%>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- testimonial-area-end -->
        <section class="cta pt-30 pb-100">
            <div class="container">
                <div class="cta__row">
                    <div class="cta__col">
                        <h2>Cutting-edge Technology Tailored to your Defence, Aerospace, and Industrial needs 
                        </h2>
                    </div>
                    <div class="cta__col">
                        <a href="contact-us.aspx" class="custom-btn">Let's Connect</a>
                    </div>
                </div>
            </div>
        </section>
        <!-- blog-area -->
        <section
            id="blog"
            class="blog-area d-none p-relative fix pt-100 pb-100"
            style="background: #f3f3f3">
            <div class="container">
                <div class="row align-items-center">
                    <div class="col-lg-12 col-md-12">
                        <div
                            class="text-center pcc-section-heading wow fadeInDown animated"
                            data-animation="fadeInDown"
                            data-delay=".4s">
                            <h2>Our Latest Blogs</h2>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-12 col-md-4">
                        <a class="blog-card" href="blogs-details.aspx">
                            <div class="image">
                                <div class="tag">Defence</div>
                                <img src="image/blog-1.jpg" alt="" />
                            </div>
                            <div class="content">
                                <h3>The Future of Defense Technology</h3>
                                <div class="posted-date">
                                    <span>October 19, 2024</span>
                                    <div class="read-more">
                                        Read More <i class="fal fa-long-arrow-right"></i>
                                    </div>
                                </div>
                            </div>
                        </a>
                    </div>
                    <div class="col-12 col-md-4">
                        <a class="blog-card" href="blogs-details.aspx">
                            <div class="image">
                                <div class="tag">Industry</div>
                                <img src="image/blog-2.jpg" alt="" />
                            </div>
                            <div class="content">
                                <h3>Top Trends in Aerospace Testing and Calibration for 2024
                                </h3>
                                <div class="posted-date">
                                    <span>October 19, 2024</span>
                                    <div class="read-more">
                                        Read More <i class="fal fa-long-arrow-right"></i>
                                    </div>
                                </div>
                            </div>
                        </a>
                    </div>
                    <div class="col-12 col-md-4">
                        <a class="blog-card" href="blogs-details.aspx">
                            <div class="image">
                                <div class="tag">Aerospace</div>
                                <img src="image/blog-3.jpg" alt="" />
                            </div>
                            <div class="content">
                                <h3>Ensuring Safety and Compliance in High-Stakes Industries
                                </h3>
                                <div class="posted-date">
                                    <span>October 19, 2024</span>
                                    <div class="read-more">
                                        Read More <i class="fal fa-long-arrow-right"></i>
                                    </div>
                                </div>
                            </div>
                        </a>
                    </div>
                </div>
            </div>
        </section>
        <!-- blog-area-end -->
        <section class="our-partners pt-50 pb-50">
            <div class="container">
                <div class="row align-items-center">
                    <div class="col-12 col-md-4">
                        <div
                            class="pcc-section-heading mb-0 wow fadeInDown animated"
                            data-animation="fadeInDown"
                            data-delay=".4s">
                            <h2 class="mb-0">Our Partners</h2>
                        </div>
                    </div>
                    <div class="col-12 col-md-8">
                        <div class="partner-slider">
                            <%--  <div class="partner-logo">
                                <img src="image/partners/anash.png" alt="" />
                            </div>--%>
                            <div class="partner-logo">
                                <img src="image/partners/bhe.jpg" alt="" />
                            </div>
                            <%--  <div class="partner-logo">
                                <img src="image/partners/envinode.png" alt="" />
                            </div>--%>
                            <div class="partner-logo">
                                <img src="image/partners/gdp.jpg" alt="" />
                            </div>
                            <%--  <div class="partner-logo">
                                <img src="image/partners/ontime.png" alt="" />
                            </div>
                            <div class="partner-logo">
                                <img src="image/partners/rockwell.jpg" alt="" />
                            </div>--%>
                            <div class="partner-logo">
                                <img src="image/partners/systel.png" alt="" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </main>

    <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
<div class="modal-dialog modal-dialog-centered">
            <div class="modal-content">
                <div class="modal-header">
                    <h1 class="modal-title" style="color:#79010c"  id="exampleModalLabel">Driving Data Acquisition while Powering Precision</h1>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <p>Tailored to meet the demands of dynamic flight conditions, the (on-board) Health and Utility Management Systems provide actionable insights into the performance and condition of critical flight components. From detecting potential faults to optimizing maintenance schedules, HUMS empowers operators to reduce downtime, enhance operational efficiency, and ensure regulatory compliance. By integrating advanced data acquisition and real-time monitoring technologies, these systems enable smarter decision-making through intuitive interfaces and robust connectivity.</p>
                </div>
              
            </div>
        </div>
    </div>
       <div class="modal fade" id="exampleModal2" tabindex="-1" aria-labelledby="exampleModalLabel2" aria-hidden="true">
<div class="modal-dialog modal-dialog-centered">
           <div class="modal-content">
               <div class="modal-header">
                   <h1 class="modal-title " style="color:#79010c"  id="exampleModalLabel2">Control Refined. Performance Redefined.</h1>
                   <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
               </div>
               <div class="modal-body">
                   <p>The Full Authority Digital Engine Control (FADEC) systems leverage sophisticated algorithms and digital precision to enable top-tier engine performance and consistency across a wide range of conditions. These systems continuously monitor and manage critical parameters like fuel flow, engine temperature, and thrust levels. They adapt in real time to changing flight conditions and deliver peak performance while reducing overall pilot workload. Designed for durability and seamless integration, FADEC represents the pinnacle of modern aerospace engineering, driving innovation in both commercial and military aviation.</p>
               </div>
            
           </div>
       </div>
   </div>
         <div class="modal fade" id="exampleModal3" tabindex="-1" aria-labelledby="exampleModalLabel3" aria-hidden="true">
<div class="modal-dialog modal-dialog-centered">
         <div class="modal-content">
             <div class="modal-header">
                 <h1 class="modal-title " style="color:#79010c" id="exampleModalLabel3">Raising the Standard for Seamless Synchronization  </h1>
                 <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
             </div>
             <div class="modal-body">
                 <p>Precision timing systems are the backbone of synchronized operations across aviation and aerospace industries. Engineered for reliability in extreme conditions, the Precision Timing Systems integrate advanced technologies such as atomic clocks and GPS synchronization to maintain stability. Whether managing flight trajectories or supporting mission-critical tasks, they provide the foundation for precision, efficiency, and safety in complex aviation environments.</p>
             </div>
           
         </div>
     </div>
 </div>
</asp:Content>