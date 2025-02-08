<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="add-product.aspx.cs" Inherits="Admin_add_product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="page-content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-12">
                    <div class="page-title-box d-sm-flex align-items-center justify-content-between">
                        <h4 class="mb-sm-0"><%=Request.QueryString["id"] !=null?"Update":"Add" %> Product</h4>
                        <div class="page-title-right">
                            <ol class="breadcrumb m-0">
                                <li class="breadcrumb-item"><a href="javascript: void(0);">Dashboards</a></li>
                                <li class="breadcrumb-item"><a href="javascript: void(0);">Product</a></li>
                                <li class="breadcrumb-item active"><%=Request.QueryString["id"] !=null?"Update":"Add" %> Product</li>
                            </ol>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-8">
                    <div class="card">
                        <div class="card-header">
                            <h5 class="card-title"><%=Request.QueryString["id"] !=null?"Update":"Add" %> Product</h5>
                        </div>
                        <div class="card-body">
                            <div class="row mb-2">
                                <div class="col-lg-6">
                                    <label class="">Product Name<sup>*</sup></label>
                                    <asp:TextBox runat="server" MaxLength="100" class="form-control mb-2 mr-sm-2 txtName " ID="txtproductName" placeholder="Enter Product Name" />
                                    <asp:RequiredFieldValidator ID="rfv1" runat="server" ControlToValidate="txtproductName" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-6">
                                    <label class="">Product URL <sup>*</sup></label>
                                    <asp:TextBox runat="server" MaxLength="100" class="form-control mb-2 mr-sm-2 txtUrl" ID="txtUrl" placeholder="Auto-Generated" />
                                    <asp:RequiredFieldValidator ID="rfv2" runat="server" ControlToValidate="txtUrl" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>

                                <div class="col-lg-4 mb-3">
                                    <label class="">Competencies<sup class="text-danger">*</sup></label>
                                    <asp:DropDownList runat="server" ID="ddlCapabilityType" CssClass="form-select" OnSelectedIndexChanged="ddlCapabilityType_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlCapabilityType" InitialValue="0" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-4 mb-3">
                                    <label>Sub Competencies</label>
                                    <asp:ListBox runat="server" SelectionMode="Single" ID="ddlSubcapability" CssClass="form-select fSelect"></asp:ListBox>
                                </div>
                                <div class="col-lg-4 mb-3">
                                    <label>Industry<sup class="text-danger">*</sup></label>
                                    <asp:ListBox runat="server" SelectionMode="Multiple" ID="ddlindustry" CssClass="form-control fSelect"></asp:ListBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="ddlindustry" InitialValue="0" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="row mb-2">
                                <div class="col-lg-4">
                                    <label class="">SKU Code</label>
                                    <asp:TextBox runat="server" MaxLength="100" class="form-control mb-2 mr-sm-2 " ID="txtcode" placeholder="Enter SKU Code" />
                                </div>
                                <div class="col-lg-3">
                                    <div class="form-group align-items-center m-t-25">
                                        <input class="form-check-input" type="checkbox" id="chkenquiry" runat="server">
                                        <label class="form-check-label ms-2" for="<%=chkenquiry.ClientID %>">
                                            Unable Enquiry ?
                                        </label>
                                    </div>

                                </div>
                            </div>

                            <div class="row mb-2">
                                <div class="col-lg-12">
                                    <label class="">Full Description <sup>*</sup></label>
                                    <asp:TextBox runat="server" TextMode="MultiLine" class="form-control mb-2 mr-sm-2 summernote" ID="txtDesc" Placeholder="Enter Full Description ....." />
                                    <asp:RequiredFieldValidator ID="rfv6" runat="server" ControlToValidate="txtDesc" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4">
                    <div class="card">
                        <div class="card-header">
                            <h5 class=" card-title">Add Seo Details</h5>
                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col-lg-12">
                                    <label class="">Page Title</label>
                                    <asp:TextBox runat="server" MaxLength="100" class="form-control mb-2 mr-sm-2" ID="txtPageTitle" placeholder="Page Title" />
                                </div>
                                <div class="col-lg-12">
                                    <label class="">Meta Keys</label>
                                    <asp:TextBox ID="txtMetaKey" class="form-control mb-2 mr-sm-2" runat="server" placeholder="Meta Keys"></asp:TextBox>
                                </div>
                                <div class="col-lg-12">
                                    <label class="">Meta Description</label>
                                    <asp:TextBox ID="txtMetaDesc" TextMode="MultiLine" class="form-control mb-2 mr-sm-2" Rows="3" runat="server" placeholder="Meta Description"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="card">
                        <div class="card-header">
                            <h5 class="card-title">Add Other Details</h5>
                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col-lg-12 mb-3">
                                    <label class="">Thumb Image <sup>*</sup></label>
                                    <asp:FileUpload ID="CSthumbimg" runat="server" ToolTip="Maxmimum 1 MB file size" CssClass="form-control"></asp:FileUpload>
                                    <small class="text-danger">.png, .jpeg, .jpg, .gif formats are required, Image Size Should be 500 × 334 px</small><br />
                                </div>
                                <div class="col-lg-12 mb-3">
                                    <label class="">Broucher PDF <sup>*</sup></label>
                                    <asp:FileUpload ID="UploadPDF" runat="server" CssClass="form-control"></asp:FileUpload>
                                    <small class="text-danger">.pdf, .doc, formats are required.</small><br />
                                </div>
                                <div class="col-lg-12 mb-3">
                                    <label class="">Datasheet PDF <sup>*</sup></label>
                                    <asp:FileUpload ID="IndustryPDF" runat="server" CssClass="form-control"></asp:FileUpload>
                                    <small class="text-danger">.pdf, .doc, formats are required.</small><br />
                                </div>

                                <div runat="server" id="divimg" class="col-lg-12 d-flex justify-content-around" visible="false">
                                    <div class="col-lg-3 text-center">
                                        <%=strThumbImage %>
                                        <h6 class=" mt-1">Thumb Image</h6>
                                    </div>
                                    <div>
                                        <%=strUploadPDF %><br />
                                        <h6 class=" mt-1">Check Broucher PDF</h6>
                                    </div>
                                    <div>
                                        <%=strIndustryPDF %><br />
                                        <h6 class=" mt-1">Check Datasheet PDF</h6>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="mb-3">
                <asp:Button runat="server" ID="btnSave" CssClass="btn btn-success" Text="Save" OnClick="btnSave_Click" OnClientClick="tinyMCE.triggerSave(false,true);" ValidationGroup="Save" Style="margin-top: 10px;" />
                <asp:Button runat="server" ID="btnNew" CssClass="btn btn-outline-success" Visible="false" Text="Clear" OnClick="btnNew_Click" Style="margin-top: 10px;" />
                <asp:Label ID="lblThumb" runat="server" Visible="false"></asp:Label>
                <asp:Label ID="lblPDF" runat="server" Visible="false"></asp:Label>
                <asp:Label ID="lblindustry" runat="server" Visible="false"></asp:Label>
            </div>
        </div>
    </div>

    <script src="assets/js/jquery-3.6.0.min.js"></script>

    <script>
        $(document).ready(function () {
            $(".txtName").change(function () {
                $(".txtUrl").val($(".txtName").val().toLowerCase().replace(/\./g, '').replace(/\//g, '').replace(/\&/g, 'and').replace(/\\/g, '').replace(/\*/g, '').replace(/\?/g, '').replace(/\~/g, '').replace(/\ /g, '-'));
            });
        });
    </script>
</asp:Content>



