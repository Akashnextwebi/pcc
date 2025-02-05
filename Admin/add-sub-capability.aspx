<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="add-sub-capability.aspx.cs" Inherits="Admin_add_sub_capability" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="page-content">
        <div class="container-fluid">
            <!-- start page title -->
            <div class="row">
                <div class="col-12">
                    <div class="page-title-box d-sm-flex align-items-center justify-content-between">
                        <h4 class="mb-sm-0">Add Sub Capability</h4>

                        <div class="page-title-right">
                            <ol class="breadcrumb m-0">
                                <li class="breadcrumb-item"><a href="javascript: void(0);">Dashboard</a></li>
                                <li class="breadcrumb-item"><a href="javascript: void(0);">Sub Capability</a></li>
                                <li class="breadcrumb-item active"><%=Request.QueryString["id"] == null ? "Add" : "Update" %> Sub Capability</li>
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
                            <h5 class="card-title mb-0">Add Sub Capability</h5>
                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col-lg-4 mb-3">
                                    <label class="">Capability<sup class="text-danger">*</sup></label>
                                    <asp:DropDownList runat="server" ID="ddlCapability" CssClass="form-select" AutoPostBack="true"></asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlCapability" InitialValue="0" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-4">
                                    <label class="">Sub Capability Name<sup class="text-danger">*</sup></label>
                                    <asp:TextBox runat="server" class="form-control mb-2 mr-sm-2 txtsubcapability" ID="txtsubcapability" placeholder="Sub Capability Name" />
                                    <asp:RequiredFieldValidator ID="req1" runat="server" ControlToValidate="txtsubcapability" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-4">
                                    <label class="">Sub Capability URL<sup class="text-danger">*</sup></label>
                                    <asp:TextBox runat="server" class="form-control mb-2 mr-sm-2 txtUrl" ID="txtUrl" placeholder="Auto-Generate" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUrl" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-6">
                                    <label class="">Tag<sup class="text-danger">*</sup></label>
                                    <asp:TextBox runat="server" class="form-control mb-2 mr-sm-2 " ID="txttag" placeholder="Tag" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txttag" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-6 mb-2">
                                    <label class="">Thumb Image <sup class="text-danger">*</sup></label>
                                    <asp:FileUpload runat="server" ID="ThumbImage" CssClass="form-control" />
                                    <small class="text-danger">.png, .jpeg, .jpg, .gif formats are required, Image Size Should be 415 × 350 px</small><br />
                                    <%=strThumbImage %>
                                </div>
                                <div class="col-lg-6">
                                    <label class="">Banner Title<sup class="text-danger">*</sup></label>
                                    <asp:TextBox runat="server" class="form-control mb-2 mr-sm-2 " ID="txtbtitle" placeholder="Banner Title" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtbtitle" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-6 mb-2">
                                    <label class="">Banner Image <sup class="text-danger">*</sup></label>
                                    <asp:FileUpload runat="server" ID="BannerImage" CssClass="form-control" />
                                    <small class="text-danger">.png, .jpeg, .jpg, .gif formats are required, Image Size Should be 1080 × 720 px</small><br />
                                    <%=strBannerImage %>
                                </div>
                                <div class="row mb-2">
                                    <div class="col-lg-12 mb-3">
                                        <label class="">Desc Heading<sup>*</sup></label>
                                        <asp:TextBox runat="server" MaxLength="100" class="form-control mb-2 mr-sm-2 txtheading onlyAlpha" ID="txtheading" placeholder="Enter Desc Heading" />
                                        <asp:RequiredFieldValidator ID="rfv14" runat="server" ControlToValidate="txtheading" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                    </div>

                                    <div class="col-lg-12">
                                        <label class="">Full Description <sup>*</sup></label>
                                        <asp:TextBox runat="server" TextMode="MultiLine" class="form-control mb-2 mr-sm-2 summernote" ID="txtfulldesc" Placeholder="Enter Full Description ....." />
                                        <asp:RequiredFieldValidator ID="rfv6" runat="server" ControlToValidate="txtfulldesc" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                            </div>

                            <div class="col-lg-12 mb-2">
                                <div>
                                    <asp:Button ID="btnSave" runat="server" Text="Save" ValidationGroup="Save" CssClass="btn btn-success waves-effect waves-light " OnClientClick="tinyMCE.triggerSave(false,true);" OnClick="btnSave_Click" />
                                    <asp:Button ID="btnNew" runat="server" Text="Clear" Visible="false" CssClass="btn btn-outline-success waves-effect waves-light" OnClick="btnNew_Click" />
                                    <asp:Label ID="lblThumb" runat="server" Visible="false"></asp:Label>
                                     <asp:Label ID="lblBanner" runat="server" Visible="false"></asp:Label>

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
        $(document).ready(function () {
            $(".txtsubcapability").change(function () {
                $(".txtUrl").val($(".txtsubcapability").val().toLowerCase().replace(/\./g, '').replace(/\//g, '').replace(/\&/g, 'and').replace(/\\/g, '').replace(/\*/g, '').replace(/\?/g, '').replace(/\~/g, '').replace(/\ /g, '-'));
            });
        });
    </script>
</asp:Content>

