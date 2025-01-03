<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="investing-on-people.aspx.cs" Inherits="investing_on_people" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/breadcrums.css" rel="stylesheet" />
    <style>
        .new-invest {
            padding-right: 40px;
        }

            .new-invest h2 {
                margin-bottom: 30px;
            }

        .inveast-card {
            padding-right: 40px;
        }

            .inveast-card h2 {
                margin-bottom: 30px;
            }

        .people-card {
            padding: 20px 40px 20px 20px;
        }

        .people-card img {
          width:150px;
          margin-bottom:30px;
            mix-blend-mode: darken;

        }
         .people-card h4{
             font-size:28px;
             margin-bottom:30px;

         }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(image/bg1/2.png);">
        <div class="container-fluid one pl--95">
            <div class="row">
                <div class="col-lg-12">
                    <div class="banner-content">
                        <h1>Investing on People</h1>
                        <ul class="breadcrumb-list">
                            <li><a href="Default.aspx">Home</a></li>
                            <li>Investing on People</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="section-padding ">
        <div class="container">
            <div class="row">
                <div class="col-lg-6">
                    <div class="new-invest">
                        <h2>Employees’ expectations about where, when and how they work have changed
                        </h2>
                        <p>
                            We know our people can thrive when their daily experience matches what they value and makes them happy — meaningful relationships, a varied workload, support for flexibility, and a sense of purpose and belonging. Our brand-defining people experience is designed to fundamentally rethink the work experience in our profession to attract, retain and develop leading talent so that we can serve our clients, fuel our growth and set a new standard for the business community. Just as we are relentlessly client focused, we are unwavering in our ongoing investment in our people. That’s why we’ve announced My+.

                        </p>
                    </div>
                </div>
                <div class="col-lg-6">
                    <img src="image/jcr_content.jpeg" />
                </div>
            </div>
        </div>
    </div>
    <section class="bg-light section-padding">
        <div class="container">
            <div class="row">

                <div class="col-lg-6">
                    <div class="inveast-card">
                        <h2>How we support our people
                        </h2>
                        <p>
                            As part of our New Equation strategy, My+ is our approach to change the way we work – focused on using technology to help personalize careers at PCC, all while keeping our clients’ needs at the center. Our people are the heartbeat of our firm, and we’ve taken the necessary time to listen and ask them questions to better understand their evolving wants and needs.

                        </p>
                        <p>
                            Through My+, we want to give our people personalization within their career. The future state will have increased emphasis on growth and development, rewards and benefits customized, well-being further stitched into our daily experiences, and the flexibility to support our people as their lives and needs shift over time.

                        </p>
                    </div>

                </div>
                <div class="col-lg-6">

                    <img src="image/pcc.png">
                </div>

            </div>
            <div class="row mt-5">
                <div class="col-lg-6">
                    <div class="people-card">
                        <img src="image/My-plus-Icon_Alumni2.jpg">
                        <h4>Well-being
                        </h4>
                        <p>
                            Our people will be supported by different career paths, development curricula and pay, including longer-term incentives, and protected time off to recharge between workload or career sprints.

                        </p>
                    </div>
                </div>
                <div class="col-lg-6">
                    <div class="people-card">
                        <img src="image/My-plus-Icon_Development2.jpg">
                        <h4>Development
                        </h4>
                        <p>
                            Our people will have greater opportunities to grow, to practice new skills, and to then work on different teams and new assignments of interest. We will elevate leadership and coaching skills for everyone at all levels.


                        </p>
                    </div>
                </div>
                <div class="col-lg-6">
                    <div class="people-card">
                        <img src="image/My-plus-Icon_Total%20Rewards2.jpg">
                        <h4>Rewards
                        </h4>
                        <p>
                            Our people easily access and choose from a menu of benefits and perks, with options for every stage of their life and career, that support their physical and mental health, financial, social, spiritual and emotional well-being.


                        </p>
                    </div>
                </div>
                <div class="col-lg-6">
                    <div class="people-card">
                        <img src="image/My-plus-Icon_Well-being2.jpg">
                        <h4>Always a PCC

                        </h4>
                        <p>
                            Our people can pursue professional paths that excite them — whether that’s inside or outside our firm, and we will invest in the incredible community of individuals who have worked at PCC.


                        </p>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

