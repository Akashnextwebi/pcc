<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="add-related-products.aspx.cs" Inherits="Admin_add_related_products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="page-content">
    <div class="container-fluid">
        <div class="row">
            <div class="col-lg-12">
                <div class="page-title-box d-sm-flex align-items-center justify-content-between">
                    <h4 class="mb-sm-0">Manage Related Products</h4>
                    <div class="page-title-right">
                        <ol class="breadcrumb m-0">
                            <li class="breadcrumb-item"><a href="/Admin/">Dashboard</a></li>
                            <li class="breadcrumb-item"><a href="javascript: void(0);">Products</a></li>
                            <li class="breadcrumb-item"><a href="javascript: void(0);">Manage Related Products</a></li>
                        </ol>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col-lg-4 mb-3">
                                <label>Select Cpability <sup>*</sup> </label>
                                <asp:DropDownList runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true" class="form-control mb-2 mr-sm-2 basic fSelect" ID="DropDownList1">
                                    <asp:ListItem Value="0">- Select Capability -</asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" InitialValue="0" ControlToValidate="DropDownList1" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-lg-4 mb-3">
                                <label>Select Related Products <sup>*</sup> </label>
                                <asp:DropDownList runat="server" OnSelectedIndexChanged="ddlProduct_SelectedIndexChanged" AutoPostBack="true" class="form-control mb-2 mr-sm-2 mr-sm-2 basic fSelect" ID="ddlProduct">
                                    <asp:ListItem Value="0">- Select Product -</asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" InitialValue="0" ControlToValidate="ddlProduct" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-lg-4 mb-3">
                                <label>Map Products <sup>*</sup></label>
                                <asp:ListBox ID="chkMapProducts" runat="server" CssClass="lstChks form-control fSelect" SelectionMode="Multiple"></asp:ListBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" InitialValue="0" ControlToValidate="chkMapProducts" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-lg-12">
                                <asp:Button runat="server" ID="btnSave" CssClass="btn btn-success waves-effect waves-light" Text="Save" ValidationGroup="Save" OnClick="btnSave_Click" Style="margin-top: 15px;" />
                                <asp:Button runat="server" ID="btnNew" CssClass="btn btn-success waves-effect waves-light" Text="Add New PinCode" Visible="false" OnClick="btnNew_Click" Style="margin-top: 15px;" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
</asp:Content>

