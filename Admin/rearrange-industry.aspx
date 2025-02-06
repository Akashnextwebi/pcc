<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="rearrange-industry.aspx.cs" Inherits="Admin_rearrange_industry" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="assets/libs/jquery-ui/jquery-ui.min.css" rel="stylesheet" />

    <style>
        .sortablev {
            list-style-type: none;
            margin: 0;
            float: left;
            margin-right: 10px;
            background-color: #efefef;
            border: 1px solid #ccc;
            padding: 5px;
            width: 100%;
            min-height: unset;
            border-radius: 5px;
        }

            .sortablev li .maindiv {
                margin: 5px;
                /*   padding: 5px;*/
                font-size: 1.2em;
                width: 100% !important;
                cursor: pointer;
                background: #fff;
                color: #fff;
                border-radius: 5px;
                box-shadow: 5px 10px 8px #888888;
            }

                .sortablev li .maindiv span {
                    color: #000 !important;
                }


                .sortablev li .maindiv div {
                    width: 100% !important;
                    text-align: center;
                    padding: 8px 0px;
                }

                .sortablev li .maindiv img {
                    width: 100% !important;
                    padding: 15px 15px 0px 15px;
                    border-radius: 0px;
                    /*                    height: 150px !important;
*/ border: none;
                }


        .ui-state-default, .ui-widget-content .ui-state-default, .ui-widget-header .ui-state-default, .ui-button, html .ui-button.ui-state-disabled:hover, html .ui-button.ui-state-disabled:active {
            border: none;
            background: none;
            padding: 5px;
        }

        @media only screen and (max-width: 767px) {
            .sortablev li .maindiv {
                height: auto !important;
            }

                .sortablev li .maindiv img {
                    height: auto !important;
                }
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="page-content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <h5 class="card-title">Re-Arrange Industry Display Order</h5>
                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col-lg-12">
                                    <asp:Label ID="lblStatus" runat="server" Visible="false" Width="100%"></asp:Label>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-12">
                                    <ul id='left-defaults' class='dragula sortablev row'>
                                    </ul>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-12">
                                    <input type="button" style="margin-top: 10px;" value="Update Order" id="Update" class="btn btn-primary" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script src="assets/js/jquery-3.6.0.min.js"></script>
    <script src="assets/js/pages/rearrange-industry.js"></script>
</asp:Content>

