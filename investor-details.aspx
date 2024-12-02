<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="investor-details.aspx.cs" Inherits="investor_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        .breadcrumb-section {
            background-size: cover;
            background-repeat: no-repeat;
            background-position: right;
            padding: 305px 0 200px;
            position: relative;
        }

        .section-padding {
            padding: 60px 0px;
        }

        .container-fluid.one {
            max-width: 1746px;
        }

        .pl--95 {
            padding-left: 70px;
        }

        .breadcrumb-list {
            display: inline-flex;
            align-items: center;
            gap: 10px;
            border: 1px solid rgba(255, 255, 255, 0.2);
            padding: 10px 20px;
            flex-wrap: wrap;
        }

        .breadcrumb-section .banner-content h1 {
            color: #fff;
            font-size: 75px;
            font-weight: 400;
        }

        .breadcrumb-section .banner-content .breadcrumb-list li:first-child {
            padding-left: 0;
        }

        .breadcrumb-section .banner-content .breadcrumb-list li {
            line-height: 1;
            color: #fff;
            font-size: 16px;
            font-weight: 500;
            padding-left: 16px;
            position: relative;
        }

            .breadcrumb-section .banner-content .breadcrumb-list li a {
                color: #fff;
                transition: 0.35s;
            }

        .banner-content .breadcrumb-list li {
            line-height: 1;
            color: #fff;
            font-size: 16px;
            font-weight: 500;
            padding-left: 16px;
            position: relative;
        }

        .breadcrumb-section .banner-content .breadcrumb-list li::before {
            content: "";
            width: 6px;
            height: 6px;
            border-radius: 50%;
            background-color: #cacaca;
            position: absolute;
            left: 0;
            top: 50%;
            transform: translateY(-50%);
        }.bg-invest table {
    box-shadow: 0 0.3125rem 1.25rem rgba(24, 63, 101, 0.1);
}
        .table-primary {
            --bs-table-color: #000;
            --bs-table-bg: #dce4df;
            --bs-table-border-color: #c6cdc9;
            --bs-table-striped-bg: #d1d9d4;
            --bs-table-striped-color: #000;
            --bs-table-active-bg: #c6cdc9;
            --bs-table-active-color: #000;
            --bs-table-hover-bg: #ccd3ce;
            --bs-table-hover-color: #000;
            color: var(--bs-table-color);
            border-color: var(--bs-table-border-color);
        }
        .bg-invest tbody tr:nth-child(n+1) {
            background: #F9FAFF !important;
        }
        .section-padding{
            padding:60px 0px;
        }
   .btn{
          padding:10px 26px 10px 26px !important;
          background:#4e7661;
          color:#fff;
        }
        .bg-invest tbody tr td {
            font-weight: 600;
            text-transform: uppercase;
        } .table th, .table td{
padding:0.5rem 2.5rem;
         }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <main>
<section class="section-padding mt-100  bg-invest" style="background: url('image/case/bg3.png');background-attachment:fixed" data-animated-id="1">
            <div class="container">
                <div class="text-center">
                     <h2 class="mb-3">QUARTERLY RESULTS
 </h2>
                </div>
               
                <div class="row justify-content-center">
                    <div class="col-lg-10">
                        <table class="table table-bordered table-striped">
                            <thead class="table-primary">
                                <tr>
                                    <th style="width: 80%" class="py-2 px-10 fs-5">QUARTERLY RESULTS</th>
                                    <th class="py-2 fs-5 text-center">Download</th>
                                </tr>
                            </thead>
                            <tbody>

                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result 30-June-2024   </td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result 31-Mar-2024 </td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result 31-Dec-2023 </td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result 30-Sep-2023 </td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result 30-June-2023</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result 31-MAR-2023 </td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result 31-DEC-2022 </td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result 30-SEP-2022 </td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result 30-JUNE-2022 </td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result 31-MAR-2022</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result 31-DEC-2021</td>
                                    <td class="">
                                        <a href="../blocks/heros/home-11.html" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result 30-SEP-2021</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result 30-June-2021</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result 31-Mar-2021</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result 31-Dec-2020 </td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result 30-Sept-2020 </td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result Sept-2018</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result June-2018</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>

                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result MAR-2018</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>


                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result DEC-2017</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>


                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result SEP-2017</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>


                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result JUN-2017</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>


                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result MAR-2017</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>


                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result DEC-2016</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>


                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result SEP-2016</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>

                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result JUN-2016</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>


                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result MAR-2016</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>



                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result DEC-2015</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>


                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result SEP-2015</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>



                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result JUN-2015</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>


                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result MAR-2015</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>


                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result DEC-2014</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>

                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result SEP-2014</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result JUN-2014</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result MAR-2014</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result DEC-2013</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result SEP-2013</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result JUN-2013</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result MAR-2013</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result DEC-2012</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result SEP-2012</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result JUN-2012</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result MAR-2012</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result DEC-2011</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result SEP-2011</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result JUN-2011</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result MAR-2011</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>

                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result DEC-2010</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>

                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result SEP-2010</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>


                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result JUN-2010</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>


                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result MAR-2010</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>

                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result DEC-2009</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>

                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result SEP-2009</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>

                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result JUN-2009</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>

                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result MAR-2009</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="align-middle px-10 text-body-emphasis">Quarter Result SEP-2008</td>
                                    <td class="">
                                        <a href="#" class="btn btn-dark w-100 btn-hover-bg-primary btn-hover-border-primary btn-sm py-4" target="_blank" contenteditable="false" style="cursor: pointer;">
                                            Download PDF
                                        </a>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>

        </section>
    </main>
</asp:Content>

