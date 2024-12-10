<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="add-new-job.aspx.cs" Inherits="Admin_add_new_job" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="page-content">
        <div class="container-fluid">
            <div class="row">
                <div class="col-12">
                    <div class="page-title-box d-sm-flex align-items-center justify-content-between">
                        <h4 class="mb-sm-0"><%=Request.QueryString["id"] !=null?"Update":"Add" %> Job</h4>
                        <div class="page-title-right">
                            <ol class="breadcrumb m-0">
                                <li class="breadcrumb-item"><a href="javascript: void(0);">Dashboards</a></li>
                                <li class="breadcrumb-item active"><%=Request.QueryString["id"] !=null?"Update":"Add" %> Job</li>
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
                            <h5 class="card-title"><%=Request.QueryString["id"] !=null?"Update":"Add" %> Job Detail</h5>
                        </div>
                        <div class="card-body">
                            <div class="row mb-2">
                                <div class="col-lg-6">
                                    <label class="">Job Title <sup>*</sup></label>
                                    <asp:TextBox runat="server" MaxLength="100" class="form-control gap-2 mr-sm-2 txtName " ID="txtName" placeholder="Enter Job Title" />
                                    <asp:RequiredFieldValidator ID="rfv1" runat="server" ControlToValidate="txtName" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>

                                <div class="col-lg-6">
                                    <label class="">Job URL <sup>*</sup></label>
                                    <asp:TextBox runat="server" MaxLength="100" class="form-control gap-2 mr-sm-2 txtUrl" ID="txtUrl" placeholder="Auto-Generated" />
                                    <asp:RequiredFieldValidator ID="rfv2" runat="server" ControlToValidate="txtUrl" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>

                                <div class="col-lg-4">
                                    <label class="">Posted On <sup>*</sup></label>
                                    <asp:TextBox runat="server" MaxLength="100" class="form-control gap-2 mr-sm-2 datepicker" ID="txtPostedOn" placeholder="Select Posted On Date" />
                                    <asp:RequiredFieldValidator ID="rfv3" runat="server" ControlToValidate="txtPostedOn" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-4">
                                    <label class="">Employment Type<sup>*</sup></label>
                                    <asp:TextBox runat="server" MaxLength="100" class="form-control gap-2 mr-sm-2 onlyAlpha" ID="txtEmpType" placeholder="Enter Employment Type" />
                                    <asp:RequiredFieldValidator ID="rfv4" runat="server" ControlToValidate="txtEmpType" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-4">
                                    <label class="">Job Location<sup>*</sup></label>
                                    <asp:TextBox runat="server" MaxLength="100" class="form-control gap-2 mr-sm-2 onlyAlpha" ID="txtLocation" placeholder="Job Location" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLocation" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-4">
                                    <label class="">Salary (In LPA) <sup>*</sup></label>
                                    <asp:TextBox runat="server" class="form-control gap-2 mr-sm-2" MaxLength="100" ID="txtSalary" placeholder="Enter Salary (In LPA)" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtSalary" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>

                                </div>
                                <div class="col-lg-4 mb-2">
                                    <label class="">Education<sup>*</sup></label>
                                    <asp:TextBox runat="server" MaxLength="100" class="form-control gap-2 mr-sm-2" ID="txtEducation" placeholder="Enter Education" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtEducation" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-lg-4 mb-2">
                                    <label class="">Company Image <sup class="text-danger">*</sup></label>
                                    <asp:FileUpload runat="server" ID="companyimage" CssClass="form-control" />
                                    <small class="text-danger fw-bold">Image format .png, .jpeg, .jpg, .webp with 60px w X 60px h is recommended.</small><br />
                                    <%=strCompanyImage %>
                                </div>

                            </div>
                            <div class="row mb-2">
                                <div class="col-lg-12">
                                    <label class="">Job Description<sup class="text-danger"></sup></label>
                                    <asp:TextBox runat="server" TextMode="MultiLine" class="form-control mb-2 mr-sm-2 summernote" ID="txtDesc" Placeholder="Full Description ....." />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtDesc" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="row mb-2">
                                <div class="col-lg-12">
                                    <label class="">Key Responsibilities<sup class="text-danger"></sup></label>
                                    <asp:TextBox runat="server" TextMode="MultiLine" class="form-control mb-2 mr-sm-2 summernote" ID="txtkey" Placeholder="Full Description ....." />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtkey" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="row mb-2">
                                <div class="col-lg-12">
                                    <label class="">Skills & Experience<sup class="text-danger"></sup></label>
                                    <asp:TextBox runat="server" TextMode="MultiLine" class="form-control mb-2 mr-sm-2 summernote" ID="txtskills" Placeholder="Full Description ....." />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtskills" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
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
                </div>
                <div class="col-lg-12 mb-3">
                    <asp:Button runat="server" ID="btnSave" CssClass="btn btn-secondary" Text="Save" OnClick="btnSave_Click" OnClientClick="tinyMCE.triggerSave(false,true);" ValidationGroup="Save" />
                    <asp:Button runat="server" ID="btnNew" CssClass="btn btn-info" Visible="false" Text="Add New Job" OnClick="btnNew_Click" />
                    <asp:Label ID="lblThumb" runat="server" Visible="false"></asp:Label>                 
                </div>
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

