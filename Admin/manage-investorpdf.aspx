﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="manage-investorpdf.aspx.cs" Inherits="Admin_manage_investorpdf" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="page-content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-12">
                    <div class="page-title-box d-sm-flex align-items-center justify-content-between">
                        <h4 class="mb-sm-0">Manage InvestorPDF</h4>
                        <div class="page-title-right">
                            <ol class="breadcrumb m-0">
                                <li class="breadcrumb-item"><a href="/Admin/">Dashboard</a></li>
                                <li class="breadcrumb-item"><a href="javascript: void(0);">InvestorPDF</a></li>
                                <li class="breadcrumb-item active">Manage InvestorPDF</li>
                            </ol>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <div class="card">
                    <div class="card-header">
                        <h4 class="mb-sm-0 card-title"><%=Request.QueryString["id"] ==null?"Add New":"Update"%> InvestorPDF</h4>
                    </div>
                    <div class="card-body">
                        <div class="row">
                            <div class="col-lg-4 mb-3">
                                <label class="">Investor<sup class="text-danger">*</sup></label>
                                <asp:DropDownList runat="server" ID="ddlinvestor" CssClass="form-select"></asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlinvestor" InitialValue="0" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                            </div>

                            <div class="col-lg-4">
                                <label class="">PDF Title<sup class="text-danger">*</sup></label>
                                <asp:TextBox runat="server" class="form-control mb-2 mr-sm-2 " ID="txttitle" placeholder="PDF Title" />
                                <asp:RequiredFieldValidator ID="req1" runat="server" ControlToValidate="txttitle" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-lg-4 mb-3">

                                <label class="">Investor (PDF) <sup>*</sup></label>
                                <asp:FileUpload ID="UploadPDF" runat="server" ToolTip="Maxmimum 1 MB file size" CssClass="form-control"></asp:FileUpload>
                                <small class="text-danger">.pdf, .doc, .docx, .png, .jpg .jpeg formats are required</small><br />
                                <%=strPDF %>
                                <%--     <asp:RequiredFieldValidator ID="RequiredFieldValidatorFile" runat="server" ControlToValidate="ItineraryPath" InitialValue="" ErrorMessage="Please upload a file." ForeColor="Red" ValidationGroup="Save" Display="Dynamic"></asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="RegularExpressionValidatorFile" runat="server" ControlToValidate="ItineraryPath" ErrorMessage="Invalid file type. Only .pdf, .doc, .docx, .png, .jpg, .jpeg files are allowed." ForeColor="Red" ValidationGroup="Save" Display="Dynamic" ValidationExpression="^.*\.(pdf|doc|docx|png|jpg|jpeg)$"></asp:RegularExpressionValidator>
                                --%>
                            </div>

                            <div class="col-lg-4 mb-3">
                                <asp:Button ID="btnSave" runat="server" Text="Save" ValidationGroup="Save" CssClass="btn btn-success waves-effect waves-light" Style="margin-top: 28px" OnClick="btnSave_Click" />
                                <asp:Button ID="btnNew" runat="server" Text="Clear" CssClass="btn btn-outline-success waves-effect waves-light" Style="margin-top: 28px" OnClick="btnNew_Click" Visible="false" />
                                <asp:Label ID="lblPdf" runat="server" Visible="false"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="container-fluid">
                    <div class="card">
                        <div class="card-header">
                            <h5 class="card-title">View InvestorPDF</h5>
                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col-lg-12">
                                    <table id="alternative-pagination" class="table nowrap align-middle table-striped table-bordered myTable" style="width: 100%">
                                        <thead>
                                            <tr>
                                                <th>#</th>
                                                <th>Investor PDF</th>
                                                <th>Investor </th>
                                                <th>PDF Title</th>
                                                <th>Added On</th>
                                                <th class="text-center">Action</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <%=strInvestorPdf%> 
                                        </tbody>
                                        <tfoot>
                                            <tr>
                                                <th>#</th>
                                                <th>Investor PDF</th>
                                                <th>Investor </th>
                                                <th>PDF Title</th>
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
        </div>
    </div>
    <script src="assets/js/jquery-3.6.0.min.js"></script>
    <script>
        //Delete Function
        $(document.body).on("click", ".deleteItem", function () {
            var elem = $(this);
            var id = $(this).attr('data-id');
            swal.fire({
                html:
                    '<div class="mt-3"><lord-icon src="https://cdn.lordicon.com/gsqxdxog.json" trigger="loop" colors="primary:#f7b84b,secondary:#f06548" style="width:100px;height:100px"></lord-icon><div class="mt-4 pt-2 fs-15 mx-5"><h4>Are You Sure You Want To Delete ?</h4><p class="text-muted mx-4 mb-0">You won`t be able to revert this !</p></div></div>',
                showCancelButton: !0,
                confirmButtonClass: "btn btn-primary w-xs me-2 mb-1",
                confirmButtonText: "Yes, Delete It!",
                cancelButtonClass: "btn btn-danger w-xs mb-1",
                buttonsStyling: !1,
                showCloseButton: !0,
            }).then(function (result) {
                if (result.value) {
                    $.ajax({
                        type: 'POST',
                        url: "manage-investorpdf.aspx/Delete",
                        contentType: 'application/json; charset=utf-8',
                        dataType: "json",
                        data: "{id: '" + id + "'}",
                        success: function (data2) {
                            if (data2.d.toString() == "Success") {
                                Swal.fire({
                                    html:
                                        '<div class="mt-3"><lord-icon src="https://cdn.lordicon.com/kfzfxczd.json" trigger="loop" colors="primary:#0ab39c,secondary:#405189" style="width:120px;height:120px"></lord-icon><div class="mt-4 pt-2 fs-15"><h4 style="color:red">Deleted!</h4><p class="text-muted mx-4 mb-0">Deleted Successfully</p></div></div>',
                                    showCancelButton: !0,
                                    showConfirmButton: !1,
                                    cancelButtonClass: "btn btn-primary w-xs mb-1 back",
                                    cancelButtonText: "Back",
                                    buttonsStyling: !1,
                                    showCloseButton: !0,
                                });
                                $(".back").on("click", () => window.location.href = "#");
                                elem.parent().parent().remove();
                            }
                            else if (data2.d.toString() == "Permission") {
                                Swal.fire({
                                    html:
                                        '<div class="mt-3"><lord-icon src="https://cdn.lordicon.com/tdrtiskw.json" trigger="loop" colors="primary:#f06548,secondary:#f7b84b" style="width:120px;height:120px"></lord-icon><div class="mt-4 pt-2 fs-15"><h4>Oops...! Something went Wrong !</h4><p class="text-muted mx-4 mb-0">Permission denied. Please contact to your administrator</p></div></div>',
                                    showCancelButton: !0,
                                    showConfirmButton: !1,
                                    cancelButtonClass: "btn btn-primary w-xs mb-1",
                                    cancelButtonText: "Dismiss",
                                    buttonsStyling: !1,
                                    showCloseButton: !0,
                                });
                            }
                            else {
                                Swal.fire({
                                    html:
                                        '<div class="mt-3"><lord-icon src="https://cdn.lordicon.com/tdrtiskw.json" trigger="loop" colors="primary:#f06548,secondary:#f7b84b" style="width:120px;height:120px"></lord-icon><div class="mt-4 pt-2 fs-15"><h4>Oops...! There is some problem now !</h4><p class="text-muted mx-4 mb-0">Please try again later</p></div></div>',
                                    showCancelButton: !0,
                                    showConfirmButton: !1,
                                    cancelButtonClass: "btn btn-primary w-xs mb-1",
                                    cancelButtonText: "Dismiss",
                                    buttonsStyling: !1,
                                    showCloseButton: !0,
                                });
                            }
                        }
                    });
                }
            })
        });
    </script>
</asp:Content>

