    <%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="product-details.aspx.cs" Inherits="product_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="/css/shop.css" rel="stylesheet" />
    <link href="/css/about.css" rel="stylesheet" />
    <link href="/css/light.css" rel="stylesheet" />
    <link href="/snackbar/snackbar.min.css" rel="stylesheet" />
    <link href="/css/industries.css" rel="stylesheet" />

    <link
        rel="stylesheet"
        href="https://cdn.jsdelivr.net/npm/swiper@11/swiper-bundle.min.css" />
    <link href="/css/globel.css" rel="stylesheet" />
    <style>
        section.product_view {
            background: #fff;
        }

        .campus-slider .swiper-button-prev {
            color: #fff;
            background: #0000005c;
            z-index: 10;
            padding: 20px;
            border-radius: 50%;
        }

      

           .contact-btn {
       position: fixed;
       right: -20px;
       top: 250px;
       rotate: -90deg;
       z-index: 1;
       transform: translateY(26px);
       text-transform: uppercase;
       z-index: 9;
   }
   .wptb-accordion1 .wptb--item .wptb-item--content{
       color:#000 !important;
   }
            .contact-btn button {
                padding: 15px;
                background: #c72329;
                font-size: 18px;
                line-height: 20px;
                border: 0;
                color: #fff;
            }
            .product_details_tab .nav li a.active {
    background: unset !important;
    color: #000  !important;
    font-size: 32px;
    font-weight:600;
    position: relative;
}

            .product_details_tab .nav li a.active::after{
                content:none;
                border-color:unset !important;
                background:unset !important;
                border-style:unset !important;
            }
        textarea.form-control {
            background: #fff;
            color: #000;
        }

            textarea.form-control:focus {
                background: #fff;
                color: #000;
            }

        .campus-slider .swiper-button-next {
            color: #fff;
            background: #000;
            z-index: 10;
            padding: 20px;
            border-radius: 50%;
        }

        .campus-slider .swiper-button-prev:after {
            font-size: 18px;
            content: 'prev';
        }


        .campus-slider .swiper-button-next:after {
            content: 'next';
            font-size: 18px;
        }

        .pcc-header .header-mid {
            padding: 10px 40px;
            border-bottom: 1px solid #000;
        }

        .product_right .product_price {
            color: #000;
        }

        .swiper-button-next,
        .swiper-button-prev {
            color: #000; /* Make sure the arrows are visible */
            z-index: 10; /* Ensure the buttons are above the slides */
        }

        .new-color {
            color: #f00;
            font-size: 18px;
            margin-bottom: 20px;
        }

        .product_details_tab .nav {
            justify-content: center;
        }

        li.nav-item a {
            padding: 10px 20px;
            border: 1px solid #ff1717;
        }

        .product_details_tab .nav li a.active {
            background: #d70006;
            color: #fff;
            position: relative;
        }

            .product_details_tab .nav li a.active::after {
                content: '';
                position: absolute;
                top: 100%;
                left: 50%;
                transform: translateX(-50%);
                width: 0px;
                height: 0px;
                border-width: 8px;
                border-style: solid;
                border-color: #d70006 transparent transparent transparent;
                opacity: 1;
                transition: all 0.5s ease-in-out;
            }

        .btn-three:hover {
            border: 1px solid #d70006;
        }

        .people-card2 .people-content .name-deg {
            border: 1px solid #eee;
            padding: 22px 20px;
        }

            .people-card2 .people-content .name-deg h5 {
                margin-bottom: 0;
            }

            .people-card2 .people-content .name-deg span {
                color: #000;
                font-size: 14px;
                font-weight: 500;
            }

        .people-card2 .people-content .contact-area {
            border-bottom: 1px solid #eee;
            border-right: 1px solid #eee;
            display: flex;
            align-items: center;
            justify-content: space-between;
        }

            .people-card2 .people-content .contact-area .contact-number {
                display: flex;
                align-items: center;
            }

                .people-card2 .people-content .contact-area .contact-number .icon {
                    width: 50px;
                    height: 45px;
                    display: flex;
                    color: #000;
                    align-items: center;
                    justify-content: center;
                    background-color: #e8f1fb;
                    transition: 0.35s;
                }

                .people-card2 .people-content .contact-area .contact-number .content {
                    line-height: 1;
                    padding-left: 15px;
                    padding-right: 15px;
                }

        .people-card2 .people-content .contact-area {
            border-bottom: 1px solid #eee;
            border-right: 1px solid #eee;
            display: flex;
            align-items: center;
            justify-content: space-between;
        }

        .btn i {
            margin-left: 10px;
            font-size: 16px;
            position: absolute;
            left: -10px;
            background: var(--pcc-primary-theme);
            top: 1px;
        }

        .people-card2 .people-content .contact-area .social-icon {
            display: flex;
            align-items: center;
        }

            .people-card2 .people-content .contact-area .social-icon li {
                line-height: 1;
                border-left: 1px solid #eee;
            }

        .people-card2 .people-content .contact-area .contact-number .icon {
            width: max-content;
            height: 45px;
            padding-right: 24px;
            display: flex;
            align-items: center;
            justify-content: center;
            background-color: #e8f1fb;
            transition: 0.35s;
            padding-left: 20px;
        }

        .people-card2 .people-content .contact-area .social-icon li {
            line-height: 1;
            border-left: 1px solid #eee;
        }

            .people-card2 .people-content .contact-area .social-icon li a {
                height: 45px;
                width: 45px;
                display: flex;
                align-items: center;
                justify-content: center;
                transition: 0.35s;
            }

        .contact-area li {
            display: inline-block;
            margin: 0px 0px 0px 0 !important;
        }

        .people-card2 .people-content .contact-area .social-icon {
            display: flex;
            align-items: center;
            background: #fff;
        }

        .wptb-icon-box2 .wptb-item--title {
            font-size: 20px !important;
            line-height: 30px !important;
            margin-bottom: 15px !important;
        }

        .product_details_tab .tab-content p {
            font-size: 16px !important;
            line-height: 26px !important;
        }

        .people-card2 .people-content .contact-area {
            border-bottom: 1px solid #eee;
            border-right: 1px solid #eee;
            display: flex;
            background: #e8f1fb;
            align-items: center;
            justify-content: space-between;
        }.wptb-accordion1 .wptb-item-title .wptb-item--number{
             margin-right:0px !important;
         }

        input[type="text"] {
            background-color: #fff !important;
            color: #000 !important;
        }

        .btn i {
            margin-left: 10px;
            font-size: 16px;
            position: absolute;
            left: -10px;
            background: var(--pcc-primary-theme);
            top: 2px;
            color: #fff;
            width: 50px;
            height: 100%;
            line-height: 57px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <main class="wrapper">


        <section class="product_view section-padding mt-100">
            <div class="container">
                <div class="row">
                    <div class="col-lg-7 pe-lg-5">
                        <div class="product_left">
                            <div class="product_zoom">
                                <ul class="product_zoom_button_group">
                                    <%=StrGallery %>
                                   
                                </ul>

                                <div class="product_zoom_container">
                                    <%=strMainImg %>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-5 ps-lg-0 pe-lg-5">
                        <div class="product_right">
                            <div class="product_info">
                                <h2 class="product_title"><%=strName %></h2>
                                <h4 class="new-color"><%=strSKU %></h4>

                                <div class="product_description">
                                    <%=strdesc %>
                                </div>


                                <div class="cart_button">
                                    <%=strpdf%>
                                </div>


                            </div>
                        </div>
                    </div>
                </div>
        </section>

        <div class="product_details_section section-padding bg-light" id="divspeccon" runat="server">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="product_details_tab">
                            <ul class="nav">
                                <li class="nav-item" id="divcap" runat="server">
                                    <a data-bs-toggle="tab" href="#Capabilities">Capabilities</a>
                                </li>
                                <li class="nav-item" id="divspe" runat="server">
                                    <a class="active"  data-bs-toggle="tab" href="#Specifications">Specifications</a>
                                </li>

                            </ul>
                            <div class="tab-content">

                                <div class="tab-pane fade" id="Capabilities" runat="server" tabindex="0">
                                    <div class="row justify-content-center gy-4">
                                        <%=strCapabilities %>
                                    </div>
                                </div>
                                <div class="tab-pane fade show active" id="Specifications" runat="server" tabindex="0">
                                    <div class="row justify-content-center">
                                        <div class="col-lg-8 p-0">
                                            <div class="wptb-accordion wptb-accordion1">
                                                <%=strSpecification %>
                                            </div>
                                        </div>


                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                    
                </div>

            </div>
        </div>
        <section class="section-padding " id="divsheet" runat="server">
            <div class="container">
                <div class="row justify-content-center">

                    <div class="col-lg-4">
                        <a href="javascript:void(0);" class="btn-three w-100 hidenId" data-id="<%=strId %>" data-bs-toggle="modal" data-bs-target="#exampleModal">
                            <div class="btn-wrap">
                                <span class="text-first"><i class="fa-solid fa-cloud-arrow-down me-2"></i>
                                    Download Datasheet</span>
                                <span class="text-second"><i class="fa-solid fa-cloud-arrow-down me-2 "></i>Download <b></b>Datasheet</span>
                            </div>
                        </a>
                    </div>
                </div>
            </div>

        </section>

        <section class="section-padding bg-light" id="divpro" runat="server">
            <div class="container">
                <div class="">
                    <h2 class="mb-30">Related Products
                    </h2>
                </div>
                <div class="row">
                    <%=strRelatedProducts %>
                </div>
            </div>

        </section>


        <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered modal-lg	">
                <div class="modal-content">
                    <div class="modal-header">
                        <h1 class="modal-title fs-5" id="exampleModalLabel">Download PDF
                        </h1>
                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>
                    <div class="modal-body bg-light">
                        <div class="row">
                            <div class="col-lg-12 ">
                                <div class="wptb-form" method="post">
                                    <div class="wptb-form--inner">
                                        <div class="row gy-3">
                                            <div class="col-lg-12 col-md-12">
                                                <div class="form-group">
                                                    <asp:TextBox ID="textFname" runat="server" class="form-control textFname" MaxLength="100" placeholder="Enter Your Name"></asp:TextBox>
                                                    <span class="spnfname text-danger"></span>
                                                </div>
                                            </div>
                                            <div class="col-lg-12 col-md-12">
                                                <div class="form-group">
                                                    <asp:TextBox ID="txtContact" class="form-control txtContact" runat="server" MaxLength="15" placeholder="Mobile Number"></asp:TextBox>
                                                    <span class="spncontact text-danger"></span>
                                                </div>
                                            </div>
                                            <div class="col-lg-12 col-md-12">
                                                <div class="form-group">
                                                    <asp:TextBox ID="txtemailAdress" class="form-control txtemailAdress" runat="server" MaxLength="100" placeholder="Corporate E-mail ID"></asp:TextBox>
                                                    <span class="spnemail text-danger"></span>
                                                </div>
                                            </div>

                                            <div class="col-md-12 col-lg-12 ">

                                                <div class="slider-btn">
                                                    <asp:LinkButton runat="server" ID="BtnSubmit" CssClass="btn ss-btn BtnSubmit" ValidationGroup="Save">Download<i class="fa-solid fa-cloud-arrow-down"></i></asp:LinkButton>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
        <div class="modal fade" id="exampleModal1" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered modal-lg	">
                <div class="modal-content">
                    <div class="modal-header">
                        <h1 class="modal-title fs-5" id="exampleModalLabel1">Enquiry Now
                        </h1>
                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>
                    <div class="modal-body bg-light">
                        <div class="row">
                            <div class="col-lg-12  gy-3">
                                <div class="wptb-form" method="post">
                                    <div class="wptb-form--inner">
                                        <div class="row">
                                            <div class="col-lg-12 col-md-12">
                                                <div class="form-group">
                                                    <input type="text" name="name" class="form-control" id="txtname" placeholder="Enter Your Name" required>
                                                    <span class="spnname text-danger"></span>
                                                </div>
                                            </div>
                                            <div class="col-lg-12 col-md-12">
                                                <div class="form-group">
                                                    <input type="text" name="password" class="form-control" id="txtcontact" placeholder="Mobile Number">
                                                    <span class="spncontact text-danger"></span>
                                                </div>
                                            </div>
                                            <div class="col-lg-12 col-md-12">
                                                <div class="form-group">
                                                    <input type="text" name="password" class="form-control" id="txtemail" placeholder="Email" />
                                                    <span class="spnemail text-danger"></span>
                                                </div>
                                            </div>
                                            <div class="col-lg-12 col-md-12">
                                                <div class="form-group">
                                                    <textarea type="text" name="message" class="form-control" id="txtmessage" placeholder="Message"></textarea>
                                                    <span class="spnmessage text-danger"></span>
                                                </div>
                                            </div>

                                            <div class="col-md-12 col-lg-12">
                                                <div class="slider-btn">
                                                    <%-- <a
                                                href="#"
                                                class="btn ss-btn mr-15"
                                                data-animation="fadeInLeft"
                                                data-delay=".4s">Submit<i class="fal fa-long-arrow-right"></i></a>--%>
                                                    <%--<input type="button" value="Submit" class="btn ss-btn mr-15" data-animation="fadeInLeft" data-delay=".4s" onclick="submitFunction()"><i class="fal fa-long-arrow-right"></i>--%>
                                                    <button class="btn ss-btn mr-15 btnsubmit" data-animation="fadeInLeft" data-delay=".4s">
                                                        Submit<i class="fal fa-long-arrow-right"></i>
                                                    </button>

                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>

        <div class="contact-btn">
            <button type="button" data-bs-toggle="modal" data-bs-target="#exampleModal1">
                Enquiry Now
     
            </button>
        </div>
    </main>

    <script src="https://cdn.jsdelivr.net/npm/swiper@11/swiper-bundle.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.7.1/jquery.min.js" integrity="sha512-v2CJ7UaYy4JwqLDIrZUI/4hqeoQieOmAZNXBeQyjo21dadnwR+8ZaIJVT8EE2iyI61OV8e6M8PP2/4hpQINQ/g==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
    <script src="/snackbar/snackbar.min.js"></script>
    <script>
        var swiper = new Swiper(".campus-slider", {
            slidesPerView: 1,
            spaceBetween: 30,
            pagination: false,
            navigation: true,
            keyboard: false,
            navigation: {
                nextEl: ".swiper-button-next",
                prevEl: ".swiper-button-prev",
            },
            breakpoints: {
                0: {
                    slidesPerView: 1.1,
                },
                480: {
                    slidesPerView: 1.1,
                },
                787: {
                    slidesPerView: 2,
                },
                991: {
                    slidesPerView: 5,
                },
                1200: {
                    slidesPerView: 1.5,
                },
            },
        });
    </script>
    <script src="/js/vendor/jquery-3.6.0.min.js"></script>
    <script src="/js/pages/brochure-enguiry.js"></script>

</asp:Content>

