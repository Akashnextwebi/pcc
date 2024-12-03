<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="product-lisitng.aspx.cs" Inherits="product_lisitng" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/about.css" rel="stylesheet" />
    <link href="css/shop.css" rel="stylesheet" />
    <link href="css/globel.css" rel="stylesheet" />
    <link href="css/light.css" rel="stylesheet" />
    <style>
        .product_col_1, .product_col_2, .product_col_3, .product_col_4 {
            display: flex;
            flex-wrap: wrap;
            margin-right: -10px;
            margin-left: -10px;
        }
        .products .product .product-inner:hover {
    box-shadow: -1px 5px 14px 6px rgba(0, 0, 0, 0.2);
    top: -5px;
}
        .section-padding {
            padding: 60px 0px !important;
            background: #fff;
        }

        .product_col_3 .product_item {
            flex: 0 0 20%;
            max-width: 20%;
        }

        .product_col_1 .product_item, .product_col_2 .product_item, .product_col_3 .product_item, .product_col_4 .product_item {
            position: relative;
            width: 100%;
            min-height: 1px;
            -webkit-box-flex: 0;
            padding-right: 10px;
            padding-left: 10px;
            box-sizing: border-box;
        }

        .product_item {
            position: relative;
            overflow: hidden;
        }

        .product_thumb .product_item_inner {
            padding: 10px 10px;
        }

        .product_thumb {
            position: relative;
            overflow: unset;
            box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;
            width: 100%;
            margin-bottom: 55px;
        }

        .theme-style--light .product_thumb .product_imagebox {
            background: rgba(#dddddd4d, 0.30);
            border-color: #D9D9D9;
        }

        .product_thumb .product_imagebox {
            position: relative;
            background-color: rgba(#dddddd4d, 0.30);
            border: 1px solid #3d3d3d;
            overflow: hidden;
            transition: all 0.5s ease-in-out;
        }

            .product_thumb .product_imagebox::before {
                content: '';
                position: absolute;
                left: 0;
                top: 0;
                right: 0;
                bottom: 0;
                background: var(--heading-color);
                opacity: 0;
                z-index: 1;
                transition: all 0.5s ease-in-out;
            }

        .product_thumb .primary_img {
            transition: all 0.5s ease-in-out;
        }

        .product_thumb .cart_button {
            position: relative;
            width: 100%;
            text-align: center;
            bottom: -29px;
            transition: var(--transition-base);
            z-index: 1;
        }

            .product_thumb .cart_button .btn {
                min-width: auto;
                height: auto;
                font-size: 12px;
                padding: 5px 15px;
            }

        .product_thumb .product_item_inner {
            transition: all 0.5s ease-in-out;
        }

        .product_thumb .label_text {
            padding: 0px 0px 0px 0px;
            transition: all 0.5s ease-in-out;
        }

            .product_thumb .label_text .product_item_name {
                position: relative;
                font-size: 18px;
                font-style: normal;
                font-weight: 600;
                line-height: 26px;
                text-align: left;
                color: #000;
                margin-bottom: 10px;
            }

        .product_thumb .product_item_rating {
            margin-bottom: 5px;
        }

        .shop_filtering_method {
            justify-content: space-between;
            margin-bottom: 30px;
        }

            .shop_filtering_method .view_type_wrapper {
                min-width: 300px;
            }

                .shop_filtering_method .view_type_wrapper .showing_results {
                    font-size: 14px;
                    font-weight: 400;
                    color: #9a9a9a;
                    margin-left: 15px;
                }

        select {
            display: block;
            width: 100%;
            height: 55px;
            padding: 15px 20px;
            font-size: 16px;
            font-weight: 500;
            line-height: normal;
            background-color: rgba(#2727274d, 0.30);
            color: #fff;
            background-clip: padding-box;
            border: 1px solid #000;
            -webkit-border-radius: 0px;
            -moz-border-radius: 0px;
            border-radius: 0px;
            transition: all .25s cubic-bezier(.645, .045, .355, 1);
            backface-visibility: hidden;
            box-sizing: border-box;
            outline: none;
            appearance: none;
            -webkit-appearance: none;
            outline-offset: 0;
        }

        .product_thumb .label_text .product_item_name a {
            color: #000;
        }

        .product_thumb .product_item_price {
            color: #000;
        }

        .pagination li {
            margin: 0px 5px;
        }

        .pagination {
            display: flex;
            justify-content: center;
        }

            .pagination li .page-number {
                background: #f1f1f1 !important;
                color: #000;
            }

        .product_col_3 .product_item:hover .btn {
            border: 1px solid red;
            background: #fff;
            color: #000;
        }.wptb-breadcrumb li a:after {
    content: "\f054";
    position: absolute;
    font-family: "Font Awesome 6 Pro";
    color: inherit;
    font-size: 14px;
    font-weight: 400;
    position: absolute;
    bottom: 0px;
    right: -7px;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <main class="wrapper">

        <div class="wptb-page-heading" style="position: relative; background-image: url('image/about/2.png');">
            <!-- Overlay -->
            <div class="overlay" style="position: absolute; top: 0; left: 0; width: 100%; height: 100%; background-color: rgba(0, 0, 0, 0.5); z-index: 1;"></div>

            <div class="container" style="position: relative; z-index: 2;">
                <div class="wptb-item--inner">
                    <h2 class="wptb-item--title text-white mb-2">Sub Category 1</h2>
                    <div class="wptb-breadcrumb-wrap">
                        <ul class="wptb-breadcrumb">
                            <li><a href="#">Home</a></li>
                            <li><a href="#">Advanced Data Solution</a></li>
                            <li><a href="#">Category</a></li>

                            <li><span>Sub Category 1</span></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <section class="wptb-shop section-padding">
            <div class="container">
                <div class="row">

                    <div class="col-lg-12 col-md-8 pe-md-5">


                        <div class="product_view_grid product_col_3">
                            <div class="product_item">
                                <div class="product_thumb">

                                    <div class="product_imagebox">
                                        <img class="primary_img" src="image/shop/1.jpg" alt="img">
                                    </div>
                                    <div class="product_item_inner">
                                        <div class="label_text">
                                            <h2 class="product_item_name"><a href="shop-product.html">Flight Test Telemetry</a></h2>

                                        </div>
                                        <div class="cart_button">
                                            <a href="product-details.aspx" class="btn">View Product
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="product_item">
                                <div class="product_thumb">
                                    <div class="product_imagebox">
                                        <img class="primary_img" src="image/shop/2.jpg" alt="img">
                                    </div>
                                    <div class="product_item_inner">
                                        <div class="label_text">
                                            <h2 class="product_item_name"><a href="shop-product.html">Flight Test Instrumentation</a></h2>

                                        </div>
                                        <div class="cart_button">
                                            <a href="#" class="btn">View Product
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="product_item">
                                <div class="product_thumb">
                                    <div class="product_imagebox">
                                        <img class="primary_img" src="image/shop/3.jpg" alt="img">
                                    </div>
                                    <div class="product_item_inner">
                                        <div class="label_text">
                                            <h2 class="product_item_name"><a href="shop-product.html">Telemetry Power Dividers
                                            </a></h2>

                                        </div>
                                        <div class="cart_button">
                                            <a href="#" class="btn">View Product
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="product_item">
                                <div class="product_thumb">
                                    <div class="product_imagebox">
                                        <img class="primary_img" src="image/shop/4.jpg" alt="img">
                                    </div>
                                    <div class="product_item_inner">
                                        <div class="label_text">
                                            <h2 class="product_item_name"><a href="shop-product.html">Telemetry Power Amplifiers</a></h2>

                                        </div>
                                        <div class="cart_button">
                                            <a href="#" class="btn">View Product
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="product_item">
                                <div class="product_thumb">
                                    <span class="badge-new">New</span>
                                    <div class="product_imagebox">
                                        <img class="primary_img" src="image/shop/5.jpg" alt="img">
                                    </div>
                                    <div class="product_item_inner">
                                        <div class="label_text">
                                            <h2 class="product_item_name"><a href="shop-product.html">Telemetry Transmitters</a></h2>

                                        </div>
                                        <div class="cart_button">
                                            <a href="#" class="btn">View Product
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>





                        </div>
                    </div>
                    <div class="col-lg-12">
                        <div class="wptb-pagination-wrap text-center">
                            <ul class="pagination">
                                <li><a class="disabled page-number previous" href="#"><i class="fa-solid fa-chevron-left"></i></a></li>
                                <li><span class="page-number current">1</span></li>
                                <li><a class="page-number" href="#">2</a></li>
                                <li><a class="page-number" href="#">3</a></li>
                                <li><a class="page-number" href="#">9</a></li>
                                <li><a class="page-number next" href="#"><i class="fa-solid fa-chevron-right"></i></a></li>
                            </ul>
                        </div>
                    </div>




                    <!-- Sidebar  -->

                </div>

            </div>
        </section>
    </main>
</asp:Content>

