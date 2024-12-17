<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="principals.aspx.cs" Inherits="principals" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/breadcrums.css" rel="stylesheet" />
    <style>
        .pl--95 {
            padding-left: 70px;
        }

        .section-title1 {
            display: flex;
            align-items: flex-start;
            justify-content: space-between;
            max-width: 1066px;
            width: 100%;
            gap: 25px;
        }

            .section-title1.w-890 h2 {
                max-width: 890px;
            }

            .section-title1 h2 {
                color: #000;
                font-size: 40px;
                font-weight: 400;
                margin-bottom: 0;
                max-width: 740px;
                margin-top: -10px;
            }

        .mission-content-top p {
            font-size: 24px;
            font-weight: 400;
            line-height: normal;
            margin-bottom: 30px;
            padding-top: 25px;
        }

        .title h6 {
            font-size: 28px;
        }

        .step-card1 {
            width: 100%;
        }

            .step-card1 span {
                border: 1px solid #fff;
                background: #79010c;
                color: #fff;
            }

            .step-card1 span {
                border-radius: 14px;
                font-size: 14px;
                font-weight: 600;
                display: inline-block;
                line-height: 1;
                padding: 6px 17px;
                margin-bottom: 20px;
            }

            .step-card1 h3 {
                color: #000;
                font-size: 28px;
                font-weight: 400;
                margin-bottom: 20px;
            }

            .step-card1 ul li {
                color: #000;
                font-size: 16px;
                font-weight: 500;
                padding-left: 18px;
                position: relative;
                margin-bottom: 10px;
            }

                .step-card1 ul li::after {
                    content: "";
                    height: 8px;
                    width: 8px;
                    border-radius: 50%;
                    border: 1px solid #566064;
                    position: absolute;
                    left: 0;
                    top: 25%;
                    transform: translateY(-50%);
                }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(image/blog/braadcrumb-bg3.jpg);">
        <div class="container-fluid one pl--95">
            <div class="row">
                <div class="col-lg-12">
                    <div class="banner-content">
                        <h1>Principals</h1>
                        <ul class="breadcrumb-list">
                            <li><a href="Default.aspx">Home</a></li>
                            <li>Principals</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="section-padding">
        <div class="container-fluid one pl--95">
            <div class="row align-items-center">
                <div class="col-lg-4">
                    <div class="mission-img">
                        <img src="image/priciple/1.png" alt="">
                    </div>
                </div>
                <div class="col-lg-8 pl--95">
                    <div class="mission-content-wrap">
                        <div class="mission-content-top">
                            <div class="section-title1 w-890">
                                <h2>Principles of PCC (Park Controls and Communications)</h2>
                            </div>
                            <p>
                                The Principles of PCC focus on managing and coordinating various systems within controlled environments such as parks, industrial facilities, and urban infrastructure. While the specific application can vary depending on the context, here are the core principles typically applicable in Park Controls and Communications systems:

                            </p>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="section-padding">
        <div class="container-fluid one pl--95">

            <div class="row g-xl-4 gy-5 justify-content-center">
                <div class="col-xl-6 col-lg-6 col-sm-6">
                    <div class="step-card1">
                        <span>01 </span>
                        <h3>Centralized Control
</h3>
                        <ul>
                            <li>Establish a single point of control to monitor and manage all park or system operations.
</li>
                            <li>Use supervisory systems like SCADA (Supervisory Control and Data Acquisition) for oversight and automation.
</li>
                        </ul>
                    </div>
                </div>
                <div class="col-xl-6 col-lg-6 col-sm-6">
                    <div class="step-card1">
                        <span>02 </span>
                        <h3>Automation and System Integration</h3>
                        <ul>
                            <li>Integrate multiple subsystems such as lighting, irrigation, surveillance, and energy management for seamless operation.
</li>
                            <li>Automation ensures real-time adjustments, improving efficiency and resource utilization.
</li>
                        </ul>
                    </div>
                </div>
                <div class="col-xl-6 col-lg-6 col-sm-6">
                    <div class="step-card1">
                        <span>03 </span>
                        <h3>Communication Networks</h3>
                        <ul>
                            <li>Ensure reliable communication protocols for data transmission between devices, sensors, and the control center.
</li>
                            <li>Utilize technologies such as IoT (Internet of Things), wired/wireless connections, and cloud-based solutions.
</li>
                        </ul>
                    </div>
                </div>
                <div class="col-xl-6 col-lg-6 col-sm-6">
                    <div class="step-card1">
                        <span>04 </span>
                        <h3>Real-Time Monitoring and Feedback
</h3>
                        <ul>
                            <li>Implement sensors and control devices to monitor environmental conditions (e.g., water levels, temperature, occupancy).
</li>
                            <li>Allow for real-time feedback to respond dynamically to changes<br /> or disruptions.
</li>
                        </ul>
                    </div>
                </div>
                <div class="col-xl-6 col-lg-6 col-sm-6">
                    <div class="step-card1">
                        <span>05 </span>
                        <h3>Energy Efficiency and Sustainability</h3>
                        <ul>
                            <li>Optimize systems to minimize energy consumption (e.g., smart lighting, water conservation via automated irrigation).
</li>
                            <li>Adopt renewable energy sources, where possible, for powering<br /> systems.
</li>
                        </ul>
                    </div>
                </div>
                <div class="col-xl-6 col-lg-6 col-sm-6">
                    <div class="step-card1">
                        <span>06 </span>
                        <h3>Safety and Security</h3>
                        <ul>
                            <li>Integrate surveillance systems (e.g., cameras, alarms) for safety and control in public spaces.

</li>
                            <li>Implement access control and emergency communication systems to maintain order and security.

</li>
                        </ul>
                    </div>
                </div>
                <div class="col-xl-6 col-lg-6 col-sm-6">
                    <div class="step-card1">
                        <span>07 </span>
                        <h3>User-Friendly Interfaces</h3>
                        <ul>
                            <li>Provide user interfaces (like dashboards or mobile applications) to visualize data and simplify controls for park administrators.


</li>
                            <li>Ensure intuitive design for effective decision-making and user <br />management.


</li>
                        </ul>
                    </div>
                </div>
                <div class="col-xl-6 col-lg-6 col-sm-6">
                    <div class="step-card1">
                        <span>08 </span>
                        <h3>Scalability and Flexibility</h3>
                        <ul>
                            <li>Design systems that can scale to accommodate new technologies or expanded<br /> areas.



</li>
                            <li>Adopt flexible infrastructure to allow for upgrades or integrations without disrupting operations.



</li>
                        </ul>
                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>

