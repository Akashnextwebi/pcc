<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="manage-specification.aspx.cs" Inherits="Admin_manage_specification" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="page-content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-12">
                    <div class="page-title-box d-sm-flex align-items-center justify-content-between">
                        <h4 class="mb-sm-0">Manage Specification </h4>
                        <div class="page-title-right">
                            <ol class="breadcrumb m-0">
                                <li class="breadcrumb-item"><a href="/Admin/">Dashboard</a></li>
                                <li class="breadcrumb-item"><a href="javascript: void(0);">Specification</a></li>
                                <li class="breadcrumb-item active">Add Specification</li>
                            </ol>
                        </div>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <h4 class="mb-sm-0 card-title"><%=Request.QueryString["id"] ==null?"Add New":"Update"%> Specification - <%=StrProductname %></h4>
                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col-lg-6 mb-2">
                                    <label class="text-muted">Specification Title <sup class="text-danger">*</sup></label>
                                    <asp:TextBox runat="server" ID="txttitle" CssClass=" form-control" MaxLength="100" placeholder=" Title"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="req1" runat="server" ControlToValidate="txttitle" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>

                                </div>
                                <div class="col-lg-12">
                                    <label class="text-muted">Full Desc<sup class="text-danger">*</sup></label>
                                    <asp:TextBox runat="server" TextMode="MultiLine" class="form-control mb-2 mr-sm-2 summernote" ID="txtDesc" Placeholder="Full Desc ....." />
                                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtanswer" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>--%>
                                </div>
                                <div class="col-lg-4 mb-3">
                                    <asp:Button ID="btnSave" runat="server" Text="Save" ValidationGroup="Save" CssClass="btn btn-success waves-effect waves-light" Style="margin-top: 28px" OnClick="btnSave_Click" />
                                    <asp:Button ID="btnNew" runat="server" Text="Clear" CssClass="btn btn-outline-success waves-effect waves-light" Style="margin-top: 28px" OnClick="btnNew_Click" Visible="false" />
                                    
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
                                        <th>Specification Title</th>
                                        <th>Full Desc</th>
                                        <th>Added On</th>
                                        <th class="text-center">Action</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <%=strSpecification %>
                                </tbody>                              
                            </table>
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
                           url: "manage-specification.aspx/Delete",
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

