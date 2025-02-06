<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="quality-and-accreditations.aspx.cs" Inherits="quality_and_accreditations" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
 <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/lightbox2/2.11.5/css/lightbox.css" integrity="sha512-DKdRaC0QGJ/kjx0U0TtJNCamKnN4l+wsMdION3GG0WVK6hIoJ1UPHRHeXNiGsXdrmq19JJxgIubb/Z7Og2qJww==" crossorigin="anonymous" referrerpolicy="no-referrer" />

    <link href="css/breadcrums.css" rel="stylesheet" />
    <style>
        .certificate-img {
            border: 8px solid #79010c;
        }

        .sec-title {
            position: relative;
            display: block;
            margin-bottom: 49px;
            text-align: center;
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
            .cc1 h4{
                background:#f1f1f1;
                padding:10px 0px;
                font-size:18px !important;
              text-align:center;    


            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(image/blog/braadcrumb-bg3.jpg);">
        <div class="container-fluid one pl--95">
            <div class="row">
                <div class="col-lg-12">
                    <div class="banner-content">
                        <h1>Quality and Accreditations</h1>
                        <ul class="breadcrumb-list">
                            <li><a href="Default.aspx">Home</a></li>
                            <li>Quality and Accreditations</li>
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
                <h2>Quality and Accreditations</h2>
            </div>
            <div class="row justify-content-center">
                <div class="col-lg-3">
                    <div class="cc1">
                        <div class="certificate-img">
                            <a href="image/c1.jpg" data-lightbox="image-1" data-title="AS9100 Rev D Certificate 2024">
                                <img src="image/c1.jpg" class="img-fluid w-100" /></a>
                        </div>
                        <h4>AS9100 Rev D Certificate 2024</h4>
                    </div>

                </div>
                <div class="col-lg-3">
                     <div class="cc1">
                    <div class="certificate-img">
                       
                            <a href="image/c2.jpg" data-lightbox="image-1" data-title="NSIC Certificate">

                                <img src="image/c2.jpg" class="img-fluid w-100" /></a>
                        </div>
                        <h4>NSIC Certificate</h4>
                    </div>

                </div>
                <div class="col-lg-3">
                    <div class="cc1">
                        <div class="certificate-img">
                            <a href="image/c3.jpg" data-lightbox="image-1" data-title="NSIC Certificate">

                                <img src="image/c3.jpg" class="img-fluid w-100" /></a>
                        </div>
                        <h4>NSIC Certificate</h4>

                    </div>

                </div>
            </div>
        </div>
    </section>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>

  <script src="https://cdnjs.cloudflare.com/ajax/libs/lightbox2/2.11.5/js/lightbox.js" integrity="sha512-wvPoH20loGkctRFnd9QMpyFzw/HyHVg8iBEvvXZgtbOk88UPEjvavqp2DEldr/Nwj8w1uCzLZDig+BzhbrXgJg==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
    <script>
    lightbox.option({
      'resizeDuration': 200,
      'wrapAround': true
    })
    </script>
</asp:Content>

