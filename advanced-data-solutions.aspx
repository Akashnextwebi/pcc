<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="advanced-data-solutions.aspx.cs" Inherits="advanced_data_solutions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="/css/breadcrums.css" rel="stylesheet" />

    <link href="/css/advance.css" rel="stylesheet" />
    <link href="/css/industries.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <main class="wrapper">
        <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(/<%=strBanner%>);">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="banner-content">
                            <h1><%=strBannertitle %></h1>
                            <div>
                                <ul class="breadcrumb-list">
                                    <li><a href="/">Home</a></li>
                                    <li><%=strBannertitle %></li>
                                </ul>
                            </div>
                           
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <section class="section-padding pb-0">
            <div class="container">
                <div class="row">
                    <div class="col-lg-10">
                        <h2><%=strDesctitle %></h2>
                        <p><%=strDesc %></p>
                    </div>
                </div>
            </div>
        </section>
        <section class="section-padding" id="divCap" runat="server">
            <div class="container">
                <div class="row gy-4"><%=strsubcapability %></div>
            </div>
        </section>
    </main>
</asp:Content>

