<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="white-paper.aspx.cs" Inherits="white_paper" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <link href="css/about.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wptb-page-heading" style="position: relative; background-image: url('image/about/2.png');">
    <!-- Overlay -->
    <div class="overlay" style="position: absolute; top: 0; left: 0; width: 100%; height: 100%; background-color: rgba(0, 0, 0, 0.5); z-index: 1;"></div>

    <div class="container" style="position: relative; z-index: 2;">
        <div class="wptb-item--inner">
            <h2 class="wptb-item--title text-white mb-2">Blogs</h2>
            <div class="wptb-breadcrumb-wrap">
                <ul class="wptb-breadcrumb">
                    <li><a href="#">Home</a></li>
                    <li><span>Blogs</span></li>
                </ul>
            </div>
        </div>
    </div>
</div>
    <main >
        <section class="section-padding">
            <div class="container">
                <div class="row">

                </div>
            </div>
        </section>
    </main>
</asp:Content>

