<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="view-product.aspx.cs" Inherits="Admin_view_product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        .pageLenght {
            width: 80px;
            padding: 5px;
            margin: 5px;
            height: 30px;
        }

        .fs-option:hover {
            background-color: #426cb4 !important;
            color: white !important;
        }

        .fs-wrap.multiple .fs-option {
            background: White;
            color: #000;
        }

        .fs-option.selected {
            background-color: #426cb4 !important;
            color: white !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="page-content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-12">
                    <div class="page-title-box d-sm-flex align-items-center justify-content-between">
                        <h4 class="mb-sm-0">View Product</h4>
                        <div class="page-title-right">
                            <ol class="breadcrumb m-0">
                                <li class="breadcrumb-item"><a href="/Admin/">Dashboard</a></li>
                                <li class="breadcrumb-item"><a href="javascript: void(0);">Product</a></li>
                                <li class="breadcrumb-item active">View Product</li>
                            </ol>
                        </div>

                    </div>
                </div>
            </div>
        </div>
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header align-items-center d-flex justify-content-between">
                            <h4 class="card-title mb-0 flex-grow-1">Filters</h4>
                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col-lg-3 mb-3">
                                    <label class="">Product Name<sup class="text-danger"></sup></label>
                                    <%--<asp:TextBox runat="server" MaxLength="100" class="form-control mb-3 " placeholder="Search by Product name" ID="txtSearch" />--%>
                                    <input id="txtSearch" class="form-control mb-3" placeholder="Search by Product name">
                                </div>
                                <div class="col-lg-3 mb-3">
                                    <label class="">Capability<sup class="text-danger"></sup></label>
                                    <%-- <asp:DropDownList runat="server" ID="ddlCapabilityType" CssClass="form-select" ></asp:DropDownList>--%>

                                    <select id="ddlCapabilityType" class="form-select"></select>
                                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlCapabilityType" InitialValue="0" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>--%>
                                </div>
                                <div class="col-lg-3 mb-3">
                                    <label class="">Industry<sup class="text-danger"></sup></label>
                                    <select id="ddlindustry" class="form-select"></select>
                                    <%--<asp:DropDownList runat="server" ID="ddlindustry" CssClass="form-select" AutoPostBack="true"></asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlindustry" InitialValue="0" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>--%>
                                </div>
                                <div class="col-lg-3 mb-3">
                                    <div class="col-lg-1">
                                        <%--<asp:Button runat="server" name="btnSearch" Text="Search" ID="btnSearch" class="btn btn-success waves-effect waves-light m-t-25  btnSearch" />--%>
                                       <a id="btnSearch" class="btn btn-primary m-t-25 btnSearch" href="javascript:void(0);">Search</a>
                                        

                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg-12">
                <div class="card">
                    <div class="card-body">
                        <div class="row mt-2 mb-2">
                            <div class="col-lg-6 d-flex">
                                <label style="margin-top: 10px;">Show </label>
                                <select name="pageLenght" class="form-select form-select-sm pageLenght">
                                    <option value="10">10</option>
                                    <option value="25">25</option>
                                    <option value="50">50</option>
                                    <option value="100">100</option>
                                </select>
                                <label style="margin-top: 10px;">entries</label>
                            </div>
                        </div>
                        <div class="">

                            <table id="alternative-pagination" class="table align-middle table-striped table-bordered" data-page-length='25' style="width: 100%">
                                <thead>
                                    <tr>
                                        <th>#</th>
                                        <th>Thumb Image</th>
                                        <th>Broucher PDF</th>
                                        <th>Product Name</th>
                                        <th>Manage Capabilities</th>
                                        <th>Specification</th>
                                        <th>Datasheet Gallery</th>
                                        <th>Product Galleries</th>
                                        <th>Capability</th>
                                        <th>SubCapability</th>
                                        <th>Industry</th>
                                        <th>Added On</th>
                                        <th class="text-center">Action</th>
                                    </tr>
                                </thead>
                                <tbody class="strTable">
                                </tbody>
                            </table>
                        </div>
                        <nav aria-label="Page navigation" class="mt-2">
                            <ul class="mppagination pagination justify-content-center">
                            </ul>
                        </nav>
                    </div>
                </div>

            </div>
        </div>
    </div>
    <script src="assets/js/jquery-3.6.0.min.js"></script>
    <script src="assets/js/pages/view-product.js"></script>
</asp:Content>

