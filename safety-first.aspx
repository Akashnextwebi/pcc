<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="safety-first.aspx.cs" Inherits="safety_first" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/breadcrums.css" rel="stylesheet" />
    <style>
        .career-page .section-title1 h2 {
            padding-top: 0;
        }

        .section-title1.two h2 {
            margin-top: 0;
            padding-top: 10px;
        }

        .section-title1 h2 {
            color: #000;
            font-size: 42px;
            font-weight: 400;
            margin-bottom: 0;
            margin-top: -10px;
        }

        .pr--95 {
            padding-right: 70px;
        }

        .our-approach {
        }

        .item-box {
            background-color: #FFF;
            border-radius: 5px;
            overflow: hidden;
            height: 100%;
            position: relative;
        }

            .item-box i {
                float: left;
                line-height: 1.3;
                font-size: 45px;
                color: #F57009;
                position: relative;
            }



            .item-box .content-box h4 {
                font-size: 22px;
                font-weight: 600;
                line-height: 1.3;
                margin-bottom: 15px;
                text-transform: capitalize;
                position: relative;
            }

            .item-box .content-box p {
                margin-bottom: 0;
                position: relative;
            }

        .item-box, .item-box {
            position: relative;
            padding: 50px 35px;
        }
        .mb-30{
            margin-bottom:30px !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(image/safety.png);">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="banner-content">
                        <h1>Safety First – A Commitment to Excellence</h1>
                        <ul class="breadcrumb-list">
                            <li><a href="Default.aspx">Home</a></li>
                            <li>Safety First</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="career-page pt-100 pb-100">
        <div class="container">
            <div class="row align-items-center">

                <div class="col-lg-6">
                    <div class="section-title1 two">
                        <h2 class="mb-30">Safety First – A Commitment to Excellence






                        </h2>
                    </div>
                    <p>
                        At Park Controls and Communications Private Limited (PCC), safety is at the core of everything we do. From designing mission-critical systems for defense and aerospace to ensuring robust quality standards in industrial applications, we prioritize safety, reliability, and compliance at every stage.






                    </p>
                    <p>
                        Our products undergo rigorous testing to meet global safety and sustainability standards, ensuring flawless performance in extreme environments. By integrating cutting-edge safety protocols in our design, manufacturing, and operational processes, we protect not only our workforce but also the end-users who rely on our technology.
                    </p>
                    <p><strong>At PCC, safety isn’t just a priority—it’s a responsibility.</strong></p>
                </div>
                <div class="col-lg-6">
                    <div class="new-image">
                        <img src="image/s1.png" />
                    </div>
                </div>

            </div>
        </div>
    </div>
  
    <section class="section-padding bg-light">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-lg-12">
                    <div class=" our-approach ">
                        <h2 class="mb-30">PCC Safety First: Committed to Protecting Lives, Promoting Workplace Safety.</h2>
                        <p>
                            PCC Safety First is our unwavering commitment to fostering a safe and secure environment across all operations. We prioritize the well-being of our employees, partners, and stakeholders by adhering to the highest safety standards. By proactively identifying and mitigating risks, we ensure a workplace free from hazards. Safety is not just a policy but a shared responsibility embedded in our culture. Our goal is to protect lives, preserve resources, and maintain operational excellence. Every team member plays a vital role in upholding our safety values. We believe that a safe workplace is the foundation for success. At PCC, safety always comes first because it is essential for achieving our mission and sustaining growth. Together, we build a future where safety drives performance and innovation.                       
                        </p>
                    </div>

                </div>
            </div>

        </div>
    </section>
</asp:Content>

