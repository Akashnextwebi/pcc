<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="product-lisitng.aspx.cs" Inherits="product_lisitng" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <link href="/css/breadcrums.css" rel="stylesheet" />
    <link href="/css/industries.css" rel="stylesheet" />
    <link href="/css/pro-list.css" rel="stylesheet" />
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <main class="wrapper">
        <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(/<%=strBanner%>);">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="banner-content">
                            <h1><%=strBannertitle %></h1>
                            <ul class="breadcrumb-list">
                                <li><a href="/Default.aspx">Home</a></li>
                                <li><%=strBannertitle %></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <section class="section-padding">
            <div class="container">
                <div class="row">
                    <div class="col-lg-10">
                        <h2><%=strDesctitle %>

                        </h2>
                        <p><%=strDesc %></p>
                    </div>
                </div>
            </div>
        </section>
        <section class="wptb-shop section-padding" id="divpro" runat="server">
            <div class="container">
                <div class="row gy-4">
                    <%=strProduct %>
                </div>

            </div>
        </section>
    </main>
</asp:Content>

