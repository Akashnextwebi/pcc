<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="add-product-catalogue.aspx.cs" Inherits="Admin_add_product_catalogue" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="page-content">
        <div class="container-fluid">
            <!-- start page title -->
            <div class="row">
                <div class="col-12">
                    <div class="page-title-box d-sm-flex align-items-center justify-content-between">
                        <h4 class="mb-sm-0"> Add Product Catalogue</h4>

                        <div class="page-title-right">
                            <ol class="breadcrumb m-0">
                                <li class="breadcrumb-item"><a href="javascript: void(0);">Dashboard</a></li>
                                <li class="breadcrumb-item"><a href="javascript: void(0);">Product Catalogue</a></li>
                                <li class="breadcrumb-item active"><%=Request.QueryString["id"] == null ? "Add" : "Update" %> Add Product Catalogue</li>
                            </ol>
                        </div>
                    </div>
                </div>
            </div>
            <!-- end page title -->
            <div class="row">
                <div class="col-lg-12 mb-2">
                    <div class="card">
                        <div class="card-header">
                            <h5 class="card-title mb-0">Add Product Catalogue</h5>
                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col-lg-6 mb-3">
                                    <label>Catalogue Name<sup style="color: red;">*</sup></label>
                                    <asp:TextBox runat="server" class="form-control mb-2 mr-sm-2" ID="txtcatalogue" placeholder="Enter Catalogue Name" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtcatalogue" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-6 mb-3">
                                    <label>PDF Link<sup style="color: red;">*</sup></label>
                                    <asp:TextBox runat="server" class="form-control mb-2 mr-sm-2" ID="txtlink" placeholder="Enter PDF Link " />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtlink" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-6 mb-2">
                                    <label class="">Thumb Image <sup class="text-danger">*</sup></label>
                                    <asp:FileUpload runat="server" ID="ThumbImage" CssClass="form-control" />
                                    <small class="text-danger fw-bold">Image format .png, .jpeg, .jpg, .webp with 650px w X 430px h is recommended.</small><br />
                                    <%=strThumbImage %>
                                </div>
                            </div>
                            <div class="col-lg-12 mb-2">
                                <div>
                                    <asp:Button ID="btnSave" runat="server" Text="Save" ValidationGroup="Save" CssClass="btn btn-success waves-effect waves-light " OnClientClick="tinyMCE.triggerSave(false,true);" OnClick="btnSave_Click" />
                                    <asp:Button ID="btnNew" runat="server" Text="Clear" Visible="false" CssClass="btn btn-outline-success waves-effect waves-light" OnClick="btnNew_Click" />
                                    <asp:Label ID="lblThumb" runat="server" Visible="false"></asp:Label>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

