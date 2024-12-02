<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Blogs.aspx.cs" Inherits="Blogs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/about.css" rel="stylesheet" />
    <style>
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

        .pagination {
            margin-top: 50px;
            margin-bottom: 0px;
            list-style-type: none;
            align-items: center;
        }

            .pagination li {
                margin: 0px 5px;
            }

                .pagination li .page-number.disabled {
                    cursor: auto;
                    opacity: 0.5;
                }

                .pagination li .page-number {
                    background: #f1f1f1 !important;
                    color: #000;
                }

                .pagination li .page-number {
                    font-size: 16px;
                    font-weight: 500;
                    text-align: center;
                    width: 44px;
                    height: 44px;
                    display: flex;
                    align-items: center;
                    justify-content: center;
                    background-color: rgba(var(--color-white-rgb), 0.30);
                    color: var(--color-white);
                    border: 1px solid transparent;
                    border-radius: 0px;
                    transition: var(--transition-base);
                }

                .pagination li .page-number {
                    background: #f1f1f1 !important;
                    color: #000;
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
                    <h2 class="wptb-item--title text-white mb-2">Blogs</h2>
                    <div class="wptb-breadcrumb-wrap">
                        <ul class="wptb-breadcrumb">
                            <li><a href="#">Home</a></li>
                            <li><span>Blogs</span></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <section id="blog" class="blog-area p-relative fix pt-100 pb-100" style="background: #f3f3f3">
            <div class="container">

                <div class="row">
                    <div class="col-12 col-md-4">
                        <a class="blog-card" href="#">
                            <div class="image">
                                <div class="tag">Defence</div>
                                <img src="image/blog-1.jpg" alt="">
                            </div>
                            <div class="content">
                                <h3>The Future of Defense Technology</h3>
                                <div class="posted-date">
                                    <span>October 19, 2024</span>
                                    <div class="read-more">
                                        Read More <i class="fal fa-long-arrow-right"></i>
                                    </div>
                                </div>
                            </div>
                        </a>
                    </div>
                    <div class="col-12 col-md-4">
                        <a class="blog-card" href="#">
                            <div class="image">
                                <div class="tag">Industry</div>
                                <img src="image/blog-2.jpg" alt="">
                            </div>
                            <div class="content">
                                <h3>Top Trends in Aerospace Testing and Calibration for 2024
                                </h3>
                                <div class="posted-date">
                                    <span>October 19, 2024</span>
                                    <div class="read-more">
                                        Read More <i class="fal fa-long-arrow-right"></i>
                                    </div>
                                </div>
                            </div>
                        </a>
                    </div>
                    <div class="col-12 col-md-4">
                        <a class="blog-card" href="#">
                            <div class="image">
                                <div class="tag">Aerospace</div>
                                <img src="image/blog-3.jpg" alt="">
                            </div>
                            <div class="content">
                                <h3>Ensuring Safety and Compliance in High-Stakes Industries
                                </h3>
                                <div class="posted-date">
                                    <span>October 19, 2024</span>
                                    <div class="read-more">
                                        Read More <i class="fal fa-long-arrow-right"></i>
                                    </div>
                                </div>
                            </div>
                        </a>
                    </div>
                    <siv class="col-lg-12">
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
                    </siv>
                </div>
            </div>
        </section>
    </main>
</asp:Content>

