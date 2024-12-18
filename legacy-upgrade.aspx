<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="legacy-upgrade.aspx.cs" Inherits="legacy_upgrade" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/breadcrums.css" rel="stylesheet" />
    <style>
        .mb-130 {
    margin-bottom: 130px;
}

.pt-130 {
    padding-top: 130px;
}
        .mb-70 {
            margin-bottom: 70px;
        }
        .details-page-content h2 {
    color:#000;
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
        .service-details-wrapper .service-details-solution-area .solution-img {
            height: 100%;
        }
            .service-details-wrapper .service-details-solution-area .solution-img img {
                height: 100%;
                -o-object-fit: cover;
                object-fit: cover;
                -o-object-position: left;
                object-position: left;
            }
.details-section-title {
    display: flex
;
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
}.service-details-wrapper .service-details-solution-area .solution-content ul {
    list-style: decimal;
    padding-left: 20px;
    -moz-columns: 2;
    columns: 2;
    -moz-column-gap: 30px;
    column-gap: 30px;
    max-width: 740px;
    width: 100%;
    margin-bottom: 30px;
}
 .service-details-wrapper .service-details-solution-area .solution-content ul li {
    color: #566064;
    font-size: 16px;
    font-weight: 500;
    line-height: 1.5;
    margin-bottom: 15px;
}

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(image/blog/braadcrumb-bg3.jpg);">
        <div class="container-fluid one pl--95">
            <div class="row">
                <div class="col-lg-12">
                    <div class="banner-content">
                        <h1>Legacy Upgrade</h1>
                        <ul class="breadcrumb-list">
                            <li><a href="Default.aspx">Home</a></li>
                            <li>Legacy Upgrade</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="service-details-wrapper pt-130 mb-130">
        <div class="container-fluid one pl--95">
            <div class="details-page-content mb-70">
                <h2>Health &amp; Care Consulting</h2>
                <div class="row g-lg-4 gy-2">
                    <div class="col-lg-6">
                        <p class="first-para">H ealth and care consulting refers to a specialized field of consulting that focuses on providing advisory and support services to organizations and individuals within the healthcare and healthcare-related industries. This can encompass a wide range of services and expertise aimed at improving the delivery, efficiency, quality, and outcomes of healthcare services and patient.Health and care consultants bring specialized knowledge and expertise in healthcare management, policy, technology, and clinical practice. They stay up-to-date with industry trends and best practices, providing valuable insights and solutions.</p>
                    </div>
                    <div class="col-lg-6">
                        <p>In a rapidly evolving and complex healthcare landscape, health and care consulting serves as a valuable resource for healthcare organizations looking to navigate challenges, improve patient care, and remain competitive. The advantages of consulting services are often realized through improved outcomes, increased patient satisfaction, and better overall healthcare delivery.</p>
                    </div>
                </div>
            </div>
            <div class="service-details-solution-area mb-70">
                <div class="row g-md-4 gy-5">
                    <div class="col-lg-3 col-md-4">
                        <div class="solution-img">
                            <img src="image/update/1.png" alt="">
                        </div>
                    </div>
                    <div class="col-lg-9 col-md-8">
                        <div class="solution-content">
                            <div class="details-section-title mb-40">
                                <svg xmlns="http://www.w3.org/2000/svg" width="10" height="14" viewBox="0 0 10 14">
                                    <path d="M0 14V0L10 7L0 14Z"></path>
                                </svg>
                                <h4>Solution Approach</h4>
                            </div>
                            <ul>
                                <li>1. Information Gathering and Analysis.</li>
                                <li>2. Stakeholder Collaboration.</li>
                                <li>3. Strategy Development.</li>
                                <li>4. Solution Design &amp; Sketching.</li>
                                <li>5. Implementation Planning.</li>
                                <li>6. Implementation Planning.</li>
                                <li>7. Change Management.</li>
                                <li>8. Quality Assurance.</li>
                                <li>9. Sustainability and Long-Term Planning.</li>
                                <li>10. Closure and Transition.</li>
                            </ul>
                           
                        </div>
                    </div>
                </div>
            </div>
            
        </div>
    </div>
    <div class="section-padding">
        <div class="container">
            <div class="row">
                <div class="col-lg-3">

                </div>
            </div>
        </div>
    </div>
</asp:Content>

