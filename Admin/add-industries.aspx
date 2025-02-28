﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="add-industries.aspx.cs" Inherits="Admin_manage_industries" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="page-content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-12">
                    <div class="page-title-box d-sm-flex align-items-center justify-content-between">
                        <h4 class="mb-sm-0"><%=Request.QueryString["id"] !=null?"Update":"Add" %> Industry</h4>
                        <div class="page-title-right">
                            <ol class="breadcrumb m-0">
                                <li class="breadcrumb-item"><a href="javascript: void(0);">Dashboards</a></li>
                                <li class="breadcrumb-item"><a href="javascript: void(0);">Industry</a></li>
                                <li class="breadcrumb-item active"><%=Request.QueryString["id"] !=null?"Update":"Add" %> Industry</li>
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
                        <div class="card-header">
                            <h5 class="card-title"><%=Request.QueryString["id"] !=null?"Update":"Add" %> Industry</h5>
                        </div>
                        <div class="card-body">
                            <div class="row mb-2">
                                <div class="col-lg-3">
                                    <label class="">Industry Name<sup class="text-danger">*</sup></label>
                                    <asp:TextBox runat="server" class="form-control mb-2 mr-sm-2 txtname" ID="txtname" placeholder="Industry Name" />
                                    <asp:RequiredFieldValidator ID="req1" runat="server" ControlToValidate="txtname" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-3">
                                    <label class="">Industry URL<sup class="text-danger">*</sup></label>
                                    <asp:TextBox runat="server" class="form-control mb-2 mr-sm-2 txtUrl" ID="txtUrl" placeholder="Auto-Generate" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUrl" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-3">
                                    <label class="">Page Title</label>
                                    <asp:TextBox runat="server" MaxLength="100" class="form-control mb-2 mr-sm-2" ID="txtPageTitle" placeholder="Page Title" />
                                </div>
                                <div class="col-lg-3">
                                    <label class="">Meta Keys</label>
                                    <asp:TextBox ID="txtMetaKey" class="form-control mb-2 mr-sm-2" runat="server" placeholder="Meta Keys"></asp:TextBox>
                                </div>
                                <div class="col-lg-3">
                                    <label class="">Meta Description</label>
                                    <asp:TextBox ID="txtMetaDesc" TextMode="MultiLine" class="form-control mb-2 mr-sm-2" Rows="3" runat="server" placeholder="Meta Description"></asp:TextBox>
                                </div>
                                <div class="col-lg-3 mb-2">
                                    <label class="">Banner Image1 <sup class="text-danger">*</sup></label>
                                    <asp:FileUpload runat="server" ID="ThumbImage" CssClass="form-control" />
                                    <small class="text-danger">.png, .jpeg, .jpg, .gif formats are required, Image Size Should be 1080 × 720 px</small><br />
                                    <%=strThumbImage %>
                                </div>
                                <div class="col-lg-3 mb-2">
                                    <label class="">Banner Image2 <sup class="text-danger">*</sup></label>
                                    <asp:FileUpload runat="server" ID="BannerImage" CssClass="form-control" />
                                    <small class="text-danger">.png, .jpeg, .jpg, .gif formats are required, Image Size Should be 1080 × 720 px</small><br />
                                    <%=strbanner %>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-6">
                                    <div class="">
                                        <div class="col-lg-12 mb-3">
                                            <label class="">Desc Heading<sup>*</sup></label>
                                            <asp:TextBox runat="server" MaxLength="100" class="form-control mb-2 mr-sm-2 txtheading onlyAlpha" ID="txtheading" placeholder="Enter Desc Heading" />
                                            <asp:RequiredFieldValidator ID="rfv14" runat="server" ControlToValidate="txtheading" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                        </div>

                                        <div class="col-lg-12">
                                            <label class="">Full Description <sup></sup></label>
                                            <asp:TextBox runat="server" TextMode="MultiLine" class="form-control mb-2  summernote" ID="txtfulldesc" Placeholder="Enter Full Description ....." />
                                            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtfulldesc" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>--%>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-6">
                                    <div class="">
                                        <div class="col-lg-12 mb-3">
                                            <label class="">Desc Heading2<sup></sup></label>
                                            <asp:TextBox runat="server" MaxLength="100" class="form-control mb-2 mr-sm-2 txtheading2 onlyAlpha" ID="txtheading2" placeholder="Enter Desc Heading" />
                                            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtheading2" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>--%>
                                        </div>

                                        <div class="col-lg-12">
                                            <label class="">Full Description2 <sup></sup></label>
                                            <asp:TextBox runat="server" TextMode="MultiLine" class="form-control mb-2  summernote" ID="txtfdesc2" Placeholder="Enter Full Description ....." />
                                            <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtfdesc2" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>--%>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-4 mb-3">
                                    <asp:Button ID="btnSave" runat="server" Text="Save" ValidationGroup="Save" CssClass="btn btn-success waves-effect waves-light" Style="margin-top: 28px" OnClick="btnSave_Click" />
                                    <asp:Button ID="btnNew" runat="server" Text="Clear" CssClass="btn btn-outline-success " Style="margin-top: 28px" OnClick="btnNew_Click" Visible="false" />
                                    <asp:Label runat="server" ID="lblThumb" Visible="false"></asp:Label>
                                    <asp:Label runat="server" ID="lblbanner" Visible="false"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>

    </div>

</asp:Content>

