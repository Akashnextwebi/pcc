<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="product-details.aspx.cs" Inherits="product_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="/css/shop.css" rel="stylesheet" />
    <link href="/css/about.css" rel="stylesheet" />
    <link href="/css/light.css" rel="stylesheet" />
    <link href="/snackbar/snackbar.min.css" rel="stylesheet" />
    <link href="/css/industries.css" rel="stylesheet" />
    <link href="/css/pro.css" rel="stylesheet" />
    <link
        rel="stylesheet"
        href="https://cdn.jsdelivr.net/npm/swiper@11/swiper-bundle.min.css" />
    <link href="/css/globel.css" rel="stylesheet" />
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <main class="wrapper">
        <div class="strip">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <ul class="breadcrumb-list">
                            <li><a href="/">Home</a></li>
                            <li><a href="javascript:void(0);">Products</a></li>
                            <li><a href="javascript:void(0);"><%=strName %></a></li>

                        </ul>
                    </div>
                </div>
            </div>
        </div>

        <section class="product_view section-padding mt-120">
            <div class="container">
                <div class="row">
                    <div class="col-lg-7 pe-lg-5">
                        <div class="product_left">
                            <div class="product_zoom">
                                <div class="new-arrow-parent">
    <button class="product_zoom_left_arrow " style="display: none;">&#10094;</button>

                                <ul class="product_zoom_button_group">
                                    <%=StrGallery %>
                                </ul>
    <button class="product_zoom_right_arrow" style="display: none;">&#10095;</button>
                                    </div>

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
                                    <a class="active" data-bs-toggle="tab" href="#Specifications">Specifications</a>
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
                                        <div class="col-lg-8 p-0 p-md-3">
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
                      
                                <div class="wptb-form" method="post">
                                    <div class="wptb-form--inner">
                                        <div class="row gy-3">
                                            <div class="col-lg-12 col-md-12 p-0 p-lg-2">
                                                <div class="form-group">
                                                    <asp:TextBox ID="textFname" runat="server" class="form-control textFname" MaxLength="100" placeholder="Enter Your Name"></asp:TextBox>
                                                    <span class="spnfname text-danger"></span>
                                                </div>
                                            </div>
                                            <div class="col-lg-12 col-md-12 p-0 p-lg-2">
                                                <div class="form-group">
                                                    <asp:TextBox ID="txtContact" class="form-control txtContact" runat="server" MaxLength="15" placeholder="Mobile Number"></asp:TextBox>
                                                    <span class="spncontact text-danger"></span>
                                                </div>
                                            </div>
                                            <div class="col-lg-12 col-md-12 p-0 p-lg-2">
                                                <div class="form-group">
                                                    <asp:TextBox ID="txtemailAdress" class="form-control txtemailAdress" runat="server" MaxLength="100" placeholder="Corporate E-mail ID"></asp:TextBox>
                                                    <span class="spnemail text-danger"></span>
                                                </div>
                                            </div>

                                            <div class="col-md-12 col-lg-12  p-0 p-lg-2">

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
        <div class="modal fade" id="exampleModal1" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered modal-lg	">
                <div class="modal-content">
                    <div class="modal-header">
                        <h1 class="modal-title fs-5" id="exampleModalLabel1">Enquiry Now
                        </h1>
                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>
                    <div class="modal-body bg-light">
                       
                                <div class="wptb-form" method="post">
                                    <div class="wptb-form--inner">
                                        <div class="row gy-3">
                                            <div class="col-lg-12 col-md-12 p-0 p-lg-2">
                                                <div class="form-group">
                                                    <input type="text" name="name" class="form-control" id="txtname" placeholder="Enter Your Name" required>
                                                    <span class="spnname text-danger"></span>
                                                </div>
                                            </div>
                                            <div class="col-lg-12 col-md-12 p-0 p-lg-2">
                                                <div class="form-group">
                                                    <input type="text" name="password" class="form-control" id="txtcontact" placeholder="Mobile Number">
                                                    <span class="spncontact text-danger"></span>
                                                </div>
                                            </div>
                                            <div class="col-lg-12 col-md-12 p-0 p-lg-2">
                                                <div class="form-group">
                                                    <input type="text" name="password" class="form-control" id="txtemail" placeholder="Email" />
                                                    <span class="spnemail text-danger"></span>
                                                </div>
                                            </div>
                                            <div class="col-lg-12 col-md-12 p-0 p-lg-2">
                                                <div class="form-group">
                                                    <textarea type="text" name="message" class="form-control" id="txtmessage" placeholder="Message"></textarea>
                                                    <span class="spnmessage text-danger"></span>
                                                </div>
                                            </div>

                                            <div class="col-md-12 col-lg-12 p-0 p-lg-2">
                                                <div class="slider-btn">
                                                    <%-- <a
                                                href="#"
                                                class="btn ss-btn mr-15"
                                                data-animation="fadeInLeft"
                                                data-delay=".4s">Submit<i class="fal fa-long-arrow-right"></i></a>--%>
                                                    <%--<input type="button" value="Submit" class="btn ss-btn mr-15" data-animation="fadeInLeft" data-delay=".4s" onclick="submitFunction()"><i class="fal fa-long-arrow-right"></i>--%>
                                                    <button class="btn ss-btn  btnsubmit" data-animation="fadeInLeft" data-delay=".4s">
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
  
<script>
    document.addEventListener("DOMContentLoaded", function () {
        const leftArrow = document.querySelector(".product_zoom_left_arrow");
        const rightArrow = document.querySelector(".product_zoom_right_arrow");
        const productList = document.querySelector(".product_zoom_button_group");
        const productItems = document.querySelectorAll(".product_zoom_button");

        // Show arrows only if more than 5 images
        if (productItems.length > 5) {
            leftArrow.style.display = "block";
            rightArrow.style.display = "block";
        }

        leftArrow.addEventListener("click", function () {
            productList.scrollLeft -= 100;
        });

        rightArrow.addEventListener("click", function () {
            productList.scrollLeft += 100;
        });
    });
</script>
</asp:Content>

