<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="add-testimonial.aspx.cs" Inherits="Admin_add_testimonial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="page-content">
        <div class="container-fluid">
            <!-- start page title -->
            <div class="row">
                <div class="col-12">
                    <div class="page-title-box d-sm-flex align-items-center justify-content-between">
                        <h4 class="mb-sm-0">Testimonials</h4>

                        <div class="page-title-right">
                            <ol class="breadcrumb m-0">
                                <li class="breadcrumb-item"><a href="javascript: void(0);">Dashboard</a></li>
                                <li class="breadcrumb-item"><a href="javascript: void(0);">Testimonial</a></li>
                                <li class="breadcrumb-item active"><%=Request.QueryString["id"] == null ? "Add" : "Update" %> Testimonial</li>
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
                            <h5 class="card-title mb-0">Testimonial</h5>
                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col-lg-6 mb-3">
                                    <label>Name <sup style="color: red;">*</sup></label>
                                    <asp:TextBox runat="server" class="form-control mb-2 mr-sm-2" ID="txtPName" placeholder="Enter Name" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPName" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-6 mb-3">
                                    <label class="text-muted">Select Rating <sup class="text-danger">*</sup></label>
                                    <div class="custom-textbox">

                                        <asp:DropDownList ID="ddlrating" runat="server" CssClass="dropdown-inside-textbox form-select">
                                            <asp:ListItem Value="">Please Select</asp:ListItem>
                                            <asp:ListItem>1</asp:ListItem>
                                            <asp:ListItem>2</asp:ListItem>
                                             <asp:ListItem>3</asp:ListItem>
                                             <asp:ListItem>4</asp:ListItem>
                                             <asp:ListItem>5</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>

                            <div class="col-lg-12 mb-3">
                                <label>Testimonial Description<sup style="color: red">*</sup></label>
                                <asp:TextBox runat="server" TextMode="MultiLine" class="form-control mb-2 mr-sm-2 summernote" ID="TxtTdesc" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TxtTdesc" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                            </div>

                            <div class="col-lg-12 mb-2">
                                <div>
                                    <asp:Button ID="btnSave" runat="server" Text="Save" ValidationGroup="Save" CssClass="btn btn-secondary waves-effect waves-light " OnClientClick="tinyMCE.triggerSave(false,true);" OnClick="btnSave_Click" />
                                    <asp:Button ID="btnNew" runat="server" Text="Add New Testimonial" Visible="false" CssClass="btn btn-info waves-effect waves-light" OnClick="btnNew_Click" />
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

