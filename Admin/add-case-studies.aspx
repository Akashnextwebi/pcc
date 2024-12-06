<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="add-case-studies.aspx.cs" Inherits="Admin_add_case_studies" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="page-content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-12">
                    <div class="page-title-box d-sm-flex align-items-center justify-content-between">
                        <h4 class="mb-sm-0"><%=Request.QueryString["id"] !=null?"Update":"Add New" %>Case Study</h4>
                        <div class="page-title-right">
                            <ol class="breadcrumb m-0">
                                <li class="breadcrumb-item"><a href="javascript: void(0);">Dashboard</a></li>
                                <li class="breadcrumb-item"><a href="javascript: void(0);">Case Studies</a></li>
                                <li class="breadcrumb-item active"><%=Request.QueryString["id"] !=null?"Update":"Add New" %> Case Study</li>
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
                            <h5 class="card-title"><%=Request.QueryString["id"] !=null?"Update":"" %> General Information</h5>
                        </div>
                        <div class="card-body">
                            <div class="row mb-2">
                                <div class="col-lg-6">
                                    <label class="">Case Study Name<sup>*</sup></label>
                                    <asp:TextBox runat="server" MaxLength="100" class="form-control mb-2 mr-sm-2 txtName onlyAlpha" ID="txtCasestudyName" placeholder="Enter Case Study Name" />
                                    <asp:RequiredFieldValidator ID="rfv1" runat="server" ControlToValidate="txtCasestudyName" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-6">
                                    <label class="">Case Studie URL <sup>*</sup></label>
                                    <asp:TextBox runat="server" MaxLength="100" class="form-control mb-2 mr-sm-2 txtUrl" ID="txtUrl" placeholder="Auto-Generated" />
                                    <asp:RequiredFieldValidator ID="rfv2" runat="server" ControlToValidate="txtUrl" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="row mb-2">
                                <div class="col-lg-3">
                                    <label class="">Category <sup>*</sup></label>
                                    <asp:TextBox runat="server" MaxLength="100" class="form-control mb-2 mr-sm-2 onlyAlpha" ID="txtCategory" placeholder="Enter Category" />
                                    <asp:RequiredFieldValidator ID="rfv4" runat="server" ControlToValidate="txtCategory" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-3">
                                    <label class="">Posted On <sup>*</sup></label>
                                    <asp:TextBox runat="server" MaxLength="100" class="form-control mb-2 mr-sm-2 datepicker" ID="txtPostedOn" placeholder="Select Posted On Date" />
                                    <asp:RequiredFieldValidator ID="rfv3" runat="server" ControlToValidate="txtPostedOn" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-3">
                                    <label class="">Location <sup>*</sup></label>
                                    <asp:TextBox runat="server" MaxLength="100" class="form-control mb-2 mr-sm-2 onlyAlpha" ID="txtLocation" placeholder="Enter Your Location" />
                                    <asp:RequiredFieldValidator ID="rfv7" runat="server" ControlToValidate="txtLocation" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>

                                <div class="col-lg-3">
                                    <label class="">Client <sup>*</sup></label>
                                    <asp:TextBox runat="server" MaxLength="100" class="form-control mb-2 mr-sm-2 onlyAlpha" ID="txtClient" placeholder="Enter Client Name" />
                                    <asp:RequiredFieldValidator ID="rfv8" runat="server" ControlToValidate="txtClient" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <%--<div class="row mb-2">
                                <div class="col-lg-12">
                                    <label class="">Full Description <sup>*</sup></label>
                                    <asp:TextBox runat="server" TextMode="MultiLine" class="form-control mb-2 mr-sm-2 summernote" ID="txtDesc" Placeholder="Enter Full Description ....." />
                                    <asp:RequiredFieldValidator ID="rfv6" runat="server" ControlToValidate="txtDesc" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                            </div>--%>
                            <div class="row mb-2">
                                <div class="col-lg-5">
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class="card">
                        <div class="card-header">
                            <h5 class="card-title"><%=Request.QueryString["id"] !=null?"Update":"" %> Overview Details</h5>
                        </div>
                        <div class="card-body">
                            <div class="row mb-2">
                                <div class="col-lg-12 mb-3">
                                    <label class="">OV Title<sup>*</sup></label>
                                    <asp:TextBox runat="server" MaxLength="100" class="form-control mb-2 mr-sm-2 txtName onlyAlpha" ID="txtOverview" placeholder="Enter Overview Title" />
                                    <asp:RequiredFieldValidator ID="rfv14" runat="server" ControlToValidate="txtOverview" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>

                                <div class="col-lg-12">
                                    <label class="">OV Full Description <sup>*</sup></label>
                                    <asp:TextBox runat="server" TextMode="MultiLine" class="form-control mb-2 mr-sm-2 summernote" ID="OverviewDesc" Placeholder="Enter Full Description ....." />
                                    <asp:RequiredFieldValidator ID="rfv6" runat="server" ControlToValidate="OverviewDesc" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="row mb-2">
                                <div class="col-lg-5">
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="card">
                        <div class="card-header">
                            <h5 class="card-title"><%=Request.QueryString["id"] !=null?"Update":"" %> Problem Statement Details</h5>
                        </div>
                        <div class="card-body">
                            <div class="row mb-2">
                                <div class="col-lg-12 mb-3">
                                    <label class="">PS Title<sup>*</sup></label>
                                    <asp:TextBox runat="server" MaxLength="100" class="form-control mb-2 mr-sm-2 txtName onlyAlpha" ID="txtPStitle" placeholder="Enter Problem Statement Title" />
                                    <asp:RequiredFieldValidator ID="rfv9" runat="server" ControlToValidate="txtPStitle" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>

                                <div class="col-lg-12 mb-3">
                                    <label class="">PS Full Description <sup>*</sup></label>
                                    <asp:TextBox runat="server" TextMode="MultiLine" class="form-control mb-2 mr-sm-2 summernote" ID="txtPSDesc" Placeholder="Enter Full Description ....." />
                                    <asp:RequiredFieldValidator ID="rfv10" runat="server" ControlToValidate="txtPSDesc" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>

                                <div class="col-lg-6 mb-3">
                                    <label class=""> PS Upload Image<sup>*</sup></label>
                                    <asp:FileUpload ID="ImgPS" runat="server" ToolTip="Maxmimum 1 MB file size" CssClass="form-control"></asp:FileUpload>
                                    <small class="text-danger">.png, .jpeg, .jpg, .gif formats are required, Image Size Should be 463 × 306 px</small><br />

                                    <div class="col-lg-3 mt-3">
                                        <%=strImgPS %>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class="card">
                        <div class="card-header">
                            <h5 class="card-title"><%=Request.QueryString["id"] !=null?"Update":"" %> Our Approach Details</h5>
                        </div>
                        <div class="card-body">
                            <div class="row mb-2">
                                <div class="col-lg-12">
                                    <label class="">OA Title<sup>*</sup></label>
                                    <asp:TextBox runat="server" MaxLength="100" class="form-control mb-2 mr-sm-2 txtName onlyAlpha" ID="txtApproach" placeholder="Enter Approach Title" />
                                    <asp:RequiredFieldValidator ID="rfv11" runat="server" ControlToValidate="txtApproach" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="col-lg-12">
                                <label class="">OA Full Description About Approach<sup>*</sup></label>
                                <asp:TextBox runat="server" TextMode="MultiLine" class="form-control mb-2 mr-sm-2 summernote" ID="txtDescApproach" Placeholder="Enter Full Description ....." />
                                <asp:RequiredFieldValidator ID="rev12" runat="server" ControlToValidate="txtDescApproach" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-lg-6">
                                <label class="">OA Upload Image<sup>*</sup></label>
                                <asp:FileUpload ID="ImgApproach" runat="server" ToolTip="Maxmimum 1 MB file size" CssClass="form-control"></asp:FileUpload>
                                <small class="text-danger">.png, .jpeg, .jpg, .gif formats are required, Image Size Should be 463 × 306 px</small><br />
                            </div>

                            <div class="col-lg-3 mt-3">
                                <%=strImgApproach %>
                            </div>
                            <div class="row mb-2">
                                <div class="col-lg-5">
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="card">
                        <div class="card-header">
                            <h5 class="card-title"><%=Request.QueryString["id"] !=null?"Update":"" %> Implementation & Details</h5>
                        </div>
                        <div class="card-body">
                            <div class="row mb-2">
                                <div class="col-lg-12 mb-3">
                                    <label class="">TU Title<sup>*</sup></label>
                                    <asp:TextBox runat="server" MaxLength="100" class="form-control mb-2 mr-sm-2 txtName onlyAlpha" ID="txttutitle" placeholder="Enter Implementation Title" />
                                    <asp:RequiredFieldValidator ID="rfv15" runat="server" ControlToValidate="txttutitle" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-12">
                                    <label class="">TU Full Description  <sup>*</sup></label>
                                    <asp:TextBox runat="server" TextMode="MultiLine" class="form-control mb-2 mr-sm-2 summernote" ID="txttudesc" Placeholder="Enter Full Description ....." />
                                    <asp:RequiredFieldValidator ID="rfv13" runat="server" ControlToValidate="txttudesc" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-12 mb-3">
                                    <label class="">CE Title<sup>*</sup></label>
                                    <asp:TextBox runat="server" MaxLength="100" class="form-control mb-2 mr-sm-2 txtName onlyAlpha" ID="txtcetitle" placeholder="Enter Implementation Title" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtcetitle" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-12">
                                    <label class="">CE Full Description  <sup>*</sup></label>
                                    <asp:TextBox runat="server" TextMode="MultiLine" class="form-control mb-2 mr-sm-2 summernote" ID="txtcedesc" Placeholder="Enter Full Description ....." />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtcedesc" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-12 mb-3">
                                    <label class="">DBP Title<sup>*</sup></label>
                                    <asp:TextBox runat="server" MaxLength="100" class="form-control mb-2 mr-sm-2 txtName onlyAlpha" ID="txtdbptitle" placeholder="Enter Implementation Title" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtdbptitle" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-12">
                                    <label class="">DBP Full Description  <sup>*</sup></label>
                                    <asp:TextBox runat="server" TextMode="MultiLine" class="form-control mb-2 mr-sm-2 summernote" ID="txtdbpdesc" Placeholder="Enter Full Description ....." />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtdbpdesc" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="row mb-2">
                                <div class="col-lg-5">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4">
                    <div class="card">
                        <div class="card-header">
                            <h5 class="card-title"><%=Request.QueryString["id"] !=null?"Update":"Add" %> Other Details</h5>
                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col-lg-12 mb-3">
                                    <label class="">Thumb Image <sup>*</sup></label>
                                    <asp:FileUpload ID="CSthumbimg" runat="server" ToolTip="Maxmimum 1 MB file size" CssClass="form-control"></asp:FileUpload>
                                    <small class="text-danger">.png, .jpeg, .jpg, .gif formats are required, Image Size Should be 650 × 430 px</small><br />
                                </div>
                                <div class="col-lg-12 mb-3">
                                    <label class="">Detail Image <sup>*</sup></label>
                                    <asp:FileUpload ID="CSDetailImage" runat="server" ToolTip="Maxmimum 1 MB file size" CssClass="form-control"></asp:FileUpload>
                                    <small class="text-danger">.png, .jpeg, .jpg, .gif formats are required, Image Size Should be 1600 × 600 px</small><br />
                                </div>
                                <div class="col-lg-12 mb-3">
                                    <label class="">Upload PDF <sup>*</sup></label>
                                    <asp:FileUpload ID="UploadPDF" runat="server" CssClass="form-control"></asp:FileUpload>
                                    <small class="text-danger">.pdf, .doc, formats are required.</small><br />
                                </div>
                                <div runat="server" id="divimg" class="col-lg-12 d-flex justify-content-around" visible="false">
                                    <div class="col-lg-3 text-center">
                                        <%=strThumbImage %>
                                        <h6 class=" mt-1">Thumb Image</h6>
                                    </div>
                                    <div class="col-lg-3 text-center">
                                        <%=strDetailImage %>
                                        <h6 class=" mt-1">Detail Image </h6>
                                    </div>


                                    <a href="/<%=strUploadPDF %>" class="col-lg-3 text-center" target="_blank">
                                        <img src="assets/images/pdf.png" alt="" width="60" height="60"><br />
                                        Check PDF
                                        
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="card">
                        <div class="card-header">
                            <h5 class=" card-title"><%=Request.QueryString["id"] !=null?"Update":"Add" %> SEO Details</h5>
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
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <div class="mb-3">
                            <asp:Button runat="server" ID="btnSave" CssClass="btn btn-primary" Text="Save" OnClick="btnSave_Click" OnClientClick="tinyMCE.triggerSave(false,true);" ValidationGroup="Save" Style="margin-top: 10px;" />
                            <asp:Button runat="server" ID="btnNew" CssClass="btn btn-info" Visible="false" Text="Add New Case Study" OnClick="btnNew_Click" Style="margin-top: 10px;" />
                            <asp:Label ID="lblThumb" runat="server" Visible="false"></asp:Label>
                            <asp:Label ID="lblDetailImg" runat="server" Visible="false"></asp:Label>
                            <asp:Label ID="lblPDF" runat="server" Visible="false"></asp:Label>
                            <asp:Label ID="lblPSImg" runat="server" Visible="false"></asp:Label>
                            <asp:Label ID="lblApproachImg" runat="server" Visible="false"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script src="assets/js/jquery-3.6.0.min.js"></script>

    <script>
        $(document).ready(function () {
            $(".txtName").change(function () {
                $(".txtUrl").val($(".txtName").val().toLowerCase().replace(/\./g, '').replace(/\//g, '').replace(/\\/g, '').replace(/\*/g, '').replace(/\?/g, '').replace(/\~/g, '').replace(/\ /g, '-'));
            });
        });
    </script>
</asp:Content>

