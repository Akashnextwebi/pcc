<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="air.aspx.cs" Inherits="air" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="/css/breadcrums.css" rel="stylesheet" />
    <link href="/css/industries.css" rel="stylesheet" />
    <style>
        .breadcrumb-section{
            background-position:top !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(/<%=strBannerImage%>);">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="banner-content">
                        <h1 class="mb-3"><%=strIndustryName %></h1>
                        <ul class="breadcrumb-list">
                            <li><a href="/Default.aspx">Home</a></li>
                            <li><%=strIndustryName %></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="section-padding">
        <div class="container">
            <div class="row">
                <div class="col-lg-10">
                    <h2 class="mb-3"><%=strDescHeading %>


                    </h2>
                    <%=strfullDesc %>
                    
                </div>
            </div>

            <div class="">
                <%=strFeature %>
            </div>
        </div>
    </div>



    <div class="solution-section section-padding pb-50 bg-light" id="divpro" runat="server">
        <div class="container">
            <div class="row g-4">
                <div class="col-lg-12 ">
                    <div class="sub-title  text-start" >
                        <h2>Spotlight on <%=strIndustryName %> Capabilities
                        </h2>
                    </div>

                </div>
                

                        <%=strProduct %>

                        
                    </div>


               
        </div>
    </div> 
    <div class="horizontal-scrolling-section d-none ">
        <div class="single-scroll-container" style="background-image: linear-gradient(180deg, rgb(0 0 0 / 58%) 0%, rgb(0 0 0 / 20%) 100%), url(/<%=strbannerimg2%>)">
            <div class="container">
                <div class="horizontal-scrolling-content">
                    <div class="section-title1 two">
                        <span><%=strIndustryName %></span>
                        <h2><%=strDescHeading2 %>

                        </h2>
                    </div>
                    <p><%=strFullDesc2 %></p>
                  
                </div>
            </div>
        </div>
    </div>



    <script src="js/vendor/jquery-3.6.0.min.js"></script>


</asp:Content>

