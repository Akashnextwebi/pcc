<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="view-seminar.aspx.cs" Inherits="Admin_view_seminar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="page-content">
        <div class="container-fluid">
            <!-- start page title -->
            <div class="row">
                <div class="col-12">
                    <div class="page-title-box d-sm-flex align-items-center justify-content-between">
                        <h4 class="mb-sm-0">Manage Seminar</h4>

                        <div class="page-title-right">
                            <ol class="breadcrumb m-0">
                                <li class="breadcrumb-item"><a href="/Admin/">Dashboard</a></li>
                                <li class="breadcrumb-item"><a href="javascript: void(0);">Seminar</a></li>
                                <li class="breadcrumb-item active">Manage Seminar</li>
                            </ol>
                        </div>

                    </div>
                </div>
            </div>
            <!-- end page title -->
            <div class="container-fluid">
                <div class="card">
                    <div class="card-header">
                        <h5 class="card-title">View Seminars</h5>
                    </div>
                    <div class="card-body">
                        <div class="row">
                            <div class="col-lg-12">
                                <table id="alternative-pagination" class="table nowrap align-middle table-striped table-bordered myTable" style="width: 100%">
                                    <thead>
                                        <tr>
                                            <th>#</th>
                                            <th>Thumb Image</th>
                                            <th>Seminar Title</th>
                                            <th>Tag</th>
                                            <th>Added On</th>
                                            <th class="text-center">Action</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <%=strSeminars%>
                                    </tbody>
                                    <tfoot>
                                        <tr>
                                            <th>#</th>
                                            <th>Thumb Image</th>
                                            <th>SeminarTitle</th>
                                            <th>Tag</th>
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
    <script src="assets/js/jquery-3.6.0.min.js"></script>
    <script>
        $(document).ready(function () {
            $(document.body).on('click', '.deleteItem', function () {
                var elem = $(this);
                var id = elem.attr('data-id');
                Swal.fire({
                    title: "Are you sure?",
                    text: "You won't be able to revert this!",
                    icon: "warning",
                    showCancelButton: !0,
                    confirmButtonClass: "btn btn-primary w-xs me-2 mt-2",
                    cancelButtonClass: "btn btn-danger w-xs mt-2",
                    confirmButtonText: "Yes, delete it!",
                    buttonsStyling: !1,
                    showCloseButton: !0,
                }).then(function (result) {
                    if (result.value) {
                        $.ajax({
                            type: 'POST',
                            url: "view-seminar.aspx/Delete",
                            data: "{id: '" + id + "'}",
                            contentType: 'application/json; charset=utf-8',
                            dataType: "json",
                            async: false,
                            success: function (data2) {
                                if (data2.d.toString() == "Success") {
                                    Swal.fire({ title: "Deleted!", text: "Your file has been deleted.", icon: "success", confirmButtonClass: "btn btn-primary w-xs mt-2", buttonsStyling: false })
                                    elem.parent().parent().remove();
                                }
                                else if (data2.d.toString() == "Permission") {

                                    Swal.fire({ title: "Oops...", text: "Permission denied! Please contact to your administrator.", icon: "error", confirmButtonClass: "btn btn-primary w-xs mt-2", buttonsStyling: !1, footer: '', showCloseButton: !0 });
                                }
                                else {
                                    Swal.fire({ title: "Oops...", text: "Something went wrong!", icon: "error", confirmButtonClass: "btn btn-primary w-xs mt-2", buttonsStyling: !1, footer: '', showCloseButton: !0 });
                                }
                            }
                        });

                    }
                })
            });


        });
    </script>
</asp:Content>

