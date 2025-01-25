<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="manage-feature.aspx.cs" Inherits="Admin_manage_feature" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="page-content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-12">
                    <div class="page-title-box d-sm-flex align-items-center justify-content-between">
                        <h4 class="mb-sm-0">Manage Feature</h4>
                        <div class="page-title-right">
                            <ol class="breadcrumb auto m-0">
                                <li class="breadcrumb-item"><a href="/vs-adm/">Dashboard</a></li>
                                <li class="breadcrumb-item"><a href="javascript: void(0);">Feature</a></li>
                                <li class="breadcrumb-item active">Manage Feature</li>
                            </ol>
                        </div>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <h4 class="mb-sm-0 card-title"><%=Request.QueryString["id"] ==null?"Add New":"Update"%> Manage Feature</h4>
                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col-lg-6 mb-3">
                                    <label class="form-label">Feature Image <sup class="text-danger">*</sup></label>
                                    <asp:FileUpload runat="server" CssClass="form-control mb-2 mr-sm-2" ID="updImg"></asp:FileUpload>
                                    <small class="text-danger fw-bold">Image format .png, .jpeg, .jpg, .webp with 128px w X 128px h is recommended.</small><br />
                                    <%=StrThumbImage %>
                                </div>
                                <div class="row mb-2">
                                    <div class="col-lg-12 mb-3">
                                        <label class="">Feature Heading<sup>*</sup></label>
                                        <asp:TextBox runat="server" MaxLength="100" class="form-control mb-2 mr-sm-2 txtheading onlyAlpha" ID="txtheading" placeholder="Enter Desc Heading" />
                                        <asp:RequiredFieldValidator ID="rfv14" runat="server" ControlToValidate="txtheading" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                    </div>

                                    <div class="col-lg-12">
                                        <label class="">Full Description <sup>*</sup></label>
                                        <asp:TextBox runat="server" TextMode="MultiLine" class="form-control mb-2  summernote" ID="txtfulldesc" Placeholder="Enter Full Description ....." />
                                    </div>
                                </div>
                                <div class="col-lg-4 mb-3">
                                    <asp:Button ID="btnSave" runat="server" Text="Save" ValidationGroup="Save" CssClass="btn btn btn-success waves-effect waves-light" Style="margin-top: 28px" OnClick="btnSave_Click" />
                                    <asp:Button ID="btnNew" runat="server" Text="Add New Image" CssClass="btn btn btn-success waves-effect waves-light" Style="margin-top: 28px" OnClick="btnNew_Click" Visible="false" />
                                    <asp:Label runat="server" ID="lblThumb" Visible="false"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="card">
                        <div class="card-header">
                            <h4 class="mb-sm-0 card-title">View Feature</h4>
                        </div>
                        <div class="card-body table-responsive">
                            <table id="alternative-pagination" class="table nowrap align-middle dt-responsive table-hover" style="width: 100%">
                                <thead>
                                    <tr>
                                        <th>#</th>
                                        <th>Feature Image</th>
                                        <th>Feature Heading</th>
                                        <th>Added On</th>
                                        <th class="text-center">Action</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <%=strFeature %>
                                </tbody>
                                <tfoot>
                                    <tr>
                                        <th>#</th>
                                        <th>Feature Image</th>
                                        <th>Feature Heading</th>
                                        <th>Added On</th>
                                        <th class="text-center">Action</th>
                                    </tr>
                                </tfoot>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <script src="assets/js/jquery-3.6.0.min.js"></script>
        <script src="assets/js/pages/manage-feature.js"></script>
</asp:Content>

