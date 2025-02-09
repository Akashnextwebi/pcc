<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="add-capability.aspx.cs" Inherits="Admin_add_capability" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="page-content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-12">
                    <div class="page-title-box d-sm-flex align-items-center justify-content-between">
                        <h4 class="mb-sm-0"><%=Request.QueryString["id"] !=null?"Update":"Add" %> Competencies</h4>
                        <div class="page-title-right">
                            <ol class="breadcrumb m-0">
                                <li class="breadcrumb-item"><a href="javascript: void(0);">Dashboards</a></li>
                                  <li class="breadcrumb-item"><a href="javascript: void(0);">Cpability</a></li>
                                <li class="breadcrumb-item active"><%=Request.QueryString["id"] !=null?"Update":"Add" %> Competencies</li>
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
                            <h5 class="card-title"><%=Request.QueryString["id"] !=null?"Update":"Add" %> Competencies <%=StrProductname %></h5>
                        </div>
                        <div class="card-body">
                            <div class="row mb-2">
                                <div class="col-lg-6">
                                    <label class="">Competencies Name<sup class="text-danger">*</sup></label>
                                    <asp:TextBox runat="server" class="form-control mb-2 mr-sm-2 txtcapability" ID="txtcapability" placeholder="Competencies Name" />
                                    <asp:RequiredFieldValidator ID="req1" runat="server" ControlToValidate="txtcapability" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-6">
                                    <label class="">Competencies URL<sup class="text-danger">*</sup></label>
                                    <asp:TextBox runat="server" class="form-control mb-2 mr-sm-2 txtUrl" ID="txtUrl" placeholder="Auto-Generate" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUrl" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty" Enabled="false"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-6">
                                    <label class="">Banner Title<sup class="text-danger">*</sup></label>
                                    <asp:TextBox runat="server" class="form-control mb-2 mr-sm-2 " ID="txtbtitle" placeholder="Banner Title" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtbtitle" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-6 mb-2">
                                    <label class="">Banner Image <sup class="text-danger">*</sup></label>
                                    <asp:FileUpload runat="server" ID="ThumbImage" CssClass="form-control" />
                                   <small class="text-danger">.png, .jpeg, .jpg, .gif formats are required, Image Size Should be 1920 × 650 px</small><br />
                                    <%=strThumbImage %>
                                </div>
                                <div class="row mb-2">
                                    <div class="col-lg-12 mb-3">
                                        <label class="">Desc Heading<sup>*</sup></label>
                                        <asp:TextBox runat="server" MaxLength="100" class="form-control mb-2 mr-sm-2 txtheading onlyAlpha" ID="txtheading" placeholder="Enter Desc Heading" />
                                        <asp:RequiredFieldValidator ID="rfv14" runat="server" ControlToValidate="txtheading" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                    </div>

                                    <div class="col-lg-12">
                                        <label class="">Full Description <sup>*</sup></label>
                                        <asp:TextBox runat="server" TextMode="MultiLine" class="form-control mb-2  summernote" ID="txtfulldesc" Placeholder="Enter Full Description ....." />
                                        <asp:RequiredFieldValidator ID="rfv6" runat="server" ControlToValidate="txtfulldesc" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-12 mb-3">
                                <asp:Button runat="server" ID="btnSave" CssClass="btn btn-success" Text="Save" OnClick="btnSave_Click" OnClientClick="tinyMCE.triggerSave(false,true);" ValidationGroup="Save" />
                                <asp:Button runat="server" ID="btnNew" CssClass="btn btn-outline-success" Visible="false" Text="Clear" OnClick="btnNew_Click" />
                                <asp:Label runat="server" ID="lblThumb" Visible="false"></asp:Label>
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
            $(".txtcapability").change(function () {
                $(".txtUrl").val($(".txtcapability").val().toLowerCase().replace(/\./g, '').replace(/\//g, '').replace(/\&/g, 'and').replace(/\\/g, '').replace(/\*/g, '').replace(/\?/g, '').replace(/\~/g, '').replace(/\ /g, '-'));
            });
        });
    </script>
</asp:Content>

