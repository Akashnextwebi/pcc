<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="manage-product-galleries.aspx.cs" Inherits="Admin_manage_product_galleries" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
           <div class="page-content">
    <div class="container-fluid">
        <div class="row">
            <div class="col-lg-12">
                <div class="page-title-box d-sm-flex align-items-center justify-content-between">
                    <h4 class="mb-sm-0">Manage Product Gallery</h4>
                    <div class="page-title-right">
                        <ol class="breadcrumb auto m-0">
                            <li class="breadcrumb-item"><a href="/vs-adm/">Dashboard</a></li>
                            <li class="breadcrumb-item"><a href="javascript: void(0);">Product</a></li>
                            <li class="breadcrumb-item active">Manage Product Gallery</li>
                        </ol>
                    </div>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-lg-12">
                <div class="card">
                    <div class="card-header">
                        <h4 class="mb-sm-0 card-title"><%=Request.QueryString["id"] ==null?"Add New":"Update"%> Product Gallery-<%=StrProductname%></h4>
                    </div>
                    <div class="card-body">
                        <div class="row">
                            <div class="col-lg-4 mb-3">
                                <label class="form-label">Product Image<sup class="text-danger">*</sup></label>
                                <asp:FileUpload runat="server" CssClass="form-control mb-2 mr-sm-2" ID="updImg"></asp:FileUpload>
                                <small class="text-danger fw-bold">Image format .png, .jpeg, .jpg, .webp with 414 w X 414 h is recommended.</small><br />
                                <%=StrThumbImage %>
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
                        <h4 class="mb-sm-0 card-title">View Product Images</h4>
                    </div>
                    <div class="card-body table-responsive">
                        <table id="alternative-pagination" class="table nowrap align-middle dt-responsive table-hover" style="width: 100%">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Product Image</th>
                                    <th>Added On</th>
                                    <th class="text-center">Action</th>
                                </tr>
                            </thead>
                            <tbody>
                                <%=strImage %>
                            </tbody>
                            <tfoot>
                                <tr>
                                    <th>#</th>
                                    <th>Product Image</th>
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
</div>
     <script src="assets/js/jquery-3.6.0.min.js"></script>
    <script src="assets/js/pages/product-gallery.js"></script>
</asp:Content>

