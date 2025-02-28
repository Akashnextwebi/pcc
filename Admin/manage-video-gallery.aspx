﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="manage-video-gallery.aspx.cs" Inherits="Admin_manage_video_gallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="page-content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-12">
                    <div class="page-title-box d-sm-flex align-items-center justify-content-between">
                        <h4 class="mb-sm-0">Manage Videos</h4>
                        <div class="page-title-right">
                            <ol class="breadcrumb m-0">
                                <li class="breadcrumb-item"><a href="/Admin/">Dashboard</a></li>
                                <li class="breadcrumb-item"><a href="javascript: void(0);">Video</a></li>
                                <li class="breadcrumb-item active">Manage Videos</li>
                            </ol>
                        </div>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <h4 class="mb-sm-0 card-title"><%=Request.QueryString["id"] ==null?"Add New":"Update"%> Video</h4>
                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col-lg-6 mb-2">
                                    <label class="">Video Link <sup class="text-danger">*</sup></label>
                                    <asp:TextBox runat="server" ID="txtlink" CssClass=" form-control" MaxLength="100" placeholder="Video Link"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="req1" runat="server" ControlToValidate="txtlink" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-6 mb-2">
                                    <label class="">Thumb Image <sup class="text-danger">*</sup></label>
                                    <asp:FileUpload runat="server" ID="ThumbImage" CssClass="form-control" />
                                   <small class="text-danger">.png, .jpeg, .jpg, .gif formats are required, Image Size Should be 800 × 548 px</small><br />
                                    <%=strThumbImage %>
                                </div>
                                <div class="col-lg-4 mb-3">
                                    <asp:Button ID="btnSave" runat="server" Text="Save" ValidationGroup="Save" CssClass="btn btn-success waves-effect waves-light" Style="margin-top: 28px" OnClick="btnSave_Click" />
                                    <asp:Button ID="btnNew" runat="server" Text="Clear" CssClass="btn btn-outline-success waves-effect waves-light" Style="margin-top: 28px" OnClick="btnNew_Click" Visible="false" />
                                    <asp:Label runat="server" ID="lblThumb" Visible="false"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="container-fluid">
                        <div class="card">
                            <div class="card-header">
                                <h5 class="card-title">View Videos</h5>
                            </div>
                            <div class="card-body">
                                <div class="row">
                                    <div class="col-lg-12">
                                        <table id="alternative-pagination" class="table nowrap align-middle table-striped table-bordered myTable" style="width: 100%">
                                            <thead>
                                                <tr>
                                                    <th>#</th>
                                                    <th>Image</th>
                                                    <th>Video Link </th>
                                                    <th>Added On</th>
                                                    <th class="text-center">Action</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <%=strVideos%>
                                            </tbody>
                                            <tfoot>
                                                <tr>
                                                    <th>#</th>
                                                    <th>Image</th>
                                                    <th>Video Link </th>
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
                        url: "manage-video-gallery.aspx/Delete",
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

