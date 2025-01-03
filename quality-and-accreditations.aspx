<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="quality-and-accreditations.aspx.cs" Inherits="quality_and_accreditations" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/breadcrums.css" rel="stylesheet" />
    <style>
        .certificate-img {
            border: 8px solid #79010c;
        }
        .sec-title {
    position: relative;
    display: block;
    margin-bottom: 49px;
    text-align:center;
}
            .sec-title .sub-title {
                position: relative;
                display: inline-block;
                font-size: 14px;
                line-height: 24px;
                color: #827e7d;
                font-weight: 700;
                padding-bottom: 9px;
                margin-bottom: 18px;
                text-transform: uppercase;
            }
            .sec-title h2 {
    position: relative;
    display: block;
    font-size: 42px;
    line-height: 50px;
    font-weight: 700;
    margin: 0px;
}
            .sec-title .sub-title:before {
    position: absolute;
    content: '';
    width: 100%;
    height: 1px;
    left: 0px;
    bottom: 0px;
}
.sec-title .sub-title:before {
    background: #e4492e;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
          <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(image/blog/braadcrumb-bg3.jpg);">
      <div class="container-fluid one pl--95">
          <div class="row">
              <div class="col-lg-12">
                  <div class="banner-content">
                      <h1>Quality And Accreditations</h1>
                      <ul class="breadcrumb-list">
                          <li><a href="Default.aspx">Home</a></li>
                          <li>Quality And Accreditations</li>
                      </ul>
                  </div>
              </div>
          </div>
      </div>
  </div>
    <section class="section-padding ">
        <div class="container">
            <div class="sec-title centred">
                <span class="sub-title">Certification</span>
                <h2>Quality And Accreditations</h2>
            </div>
            <div class="row">
                <div class="col-lg-4">
                    <div class="certificate-img">
                        <img src="image/certificate/Appreciation-letter-from-BDL-for-Telemetry-Ground-System-1-216x300.jpg" class="img-fluid w-100" />
                    </div>

                </div>
                <div class="col-lg-4">
                    <div class="certificate-img">
                        <img src="image/certificate/pcc-astra-letter--215x300.jpg" class="img-fluid w-100" />
                    </div>

                </div>
                <div class="col-lg-4">
                    <div class="certificate-img">
                        <img src="image/certificate/Appreciation-letter-from-BDL-for-Telemetry-Ground-System-1-216x300.jpg" class="img-fluid w-100" />
                    </div>

                </div>
            </div>
        </div>
    </section>
</asp:Content>

