<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="safety-first.aspx.cs" Inherits="safety_first" %>

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
            font-size: 40px;
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
            height:100%;
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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(image/blog/braadcrumb-bg3.jpg);">
        <div class="container-fluid one pl--95">
            <div class="row">
                <div class="col-lg-12">
                    <div class="banner-content">
                        <h1>Safety First</h1>
                        <ul class="breadcrumb-list">
                            <li><a href="Default.aspx">Home</a></li>
                            <li>Safety First</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="career-page pt-130 mb-130">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="row g-lg-4 gy-5 mb-70">
                        <div class="col-lg-12 ">
                            <div class="section-title1 two">
                                <h2>PCC Safety First: Committed to Protecting Lives, Promoting Workplace Safety.






</h2>
                            </div>
                        </div>
                        <div class="col-lg-12">
                            <p>
                                PCC Safety First is our unwavering commitment to fostering a safe and secure environment across all operations. We prioritize the well-being of our employees, partners, and stakeholders by adhering to the highest safety standards. By proactively identifying and mitigating risks, we ensure a workplace free from hazards. Safety is not just a policy but a shared responsibility embedded in our culture. Through rigorous training programs, regular audits, and innovative safety practices, we strive to prevent accidents and incidents. Our goal is to protect lives, preserve resources, and maintain operational excellence. Every team member plays a vital role in upholding our safety values. We believe that a safe workplace is the foundation for success. At PCC, safety always comes first because it is essential for achieving our mission and sustaining growth. Together, we build a future where safety drives performance and innovation.






                            </p>
                        </div>

                    </div>
                    <div class="new-image">
                        <img src="image/safe.jpg" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <section class="section-padding bg-light">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-lg-8">
                    <div class="text-center our-approach">
                        <h2>Our Approach to Safety</h2>
                        <p>
                            At PCC,We operate a number of industrial sites and our manufacturing activities present a range of risks. These include work in confined spaces, machinery operation, working at height, and slips, trips and falls among others. Our 2022 safety performance showed a small improvement in recordable and major injuries from 2021. We monitor and aim to eliminate, mitigate and manage workplace safety risks. Our approach to identifying and assessing safety risks is embedded within our approach to risk management.
                        </p>
                    </div>

                </div>
            </div>
            <div class="row">
                <div class="col-lg-4">
                    <div class="item-box">
                        <img src="image/checked.png"  width="48" class="mb-3"/>
                        <div class="content-box">
                            <h4>Prevention</h4>
                            <p>We focus on identifying potential risks before they become issues. Through rigorous safety assessments, hazard analysis, and continuous monitoring, we take preventive actions to ensure that all operations are safe and compliant with industry standards.</p>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4">
                    <div class="item-box">
                        <img src="image/checked.png" width="48" class="mb-3" />

                        <div class="content-box">
                            <h4>Training and Empowerment</h4>
                            <p>Our employees receive continuous safety training, equipping them with the knowledge and skills needed to recognize and address safety concerns. We empower our teams to make safety a priority at all levels, fostering a culture where every individual takes ownership of their safety and the safety of others.</p>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4">
                    <div class="item-box">
                        <img src="image/checked.png" width="48" class="mb-3" />

                        <i class="ar-icons-tank"></i>
                        <div class="content-box">
                            <h4>Continuous Improvement</h4>
                            <p>We are committed to constantly improving our safety practices. By reviewing safety data, learning from incidents, and staying updated on best practices, we strive to enhance our safety performance and create a work environment that is always evolving towards greater safety standards.</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

