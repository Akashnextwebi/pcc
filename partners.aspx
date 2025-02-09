<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="partners.aspx.cs" Inherits="partners" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/breadcrums.css" rel="stylesheet" />
    <style>
        .pl--95 {
            padding-left: 70px;
        }

        .section-title1 {
            display: flex;
            align-items: flex-start;
            justify-content: space-between;
            max-width: 1066px;
            width: 100%;
            gap: 25px;
        }

            .section-title1.w-890 h2 {
                max-width: 890px;
            }

            .section-title1 h2 {
                color: #000;
                font-size: 40px;
                font-weight: 400;
                margin-bottom: 0;
                max-width: 740px;
                margin-top: -10px;
            }

        .mission-content-top p {
            font-size: 24px;
            font-weight: 400;
            line-height: normal;
            margin-bottom: 30px;
            padding-top: 25px;
        }

        .mission-img {
            height:100%;
            padding: 20px;
            background: #fff;
            border:1px solid #eee;
            transition:.3s ease-in;
        }
        .mission-img:hover{
                        box-shadow: rgba(50, 50, 93, 0.25) 0px 6px 12px -2px, rgba(0, 0, 0, 0.3) 0px 3px 7px -3px;

        }
          .mission-img  h4{
              margin-top:10px;
          }
             .mission-img img {
                 width:150px;
                 height:150px;
                 object-fit:contain;
                 

             }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(image/blog/braadcrumb-bg3.jpg);">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="banner-content">
                        <h1>Partners</h1>
                        <ul class="breadcrumb-list">
                            <li><a href="Default.aspx">Home</a></li>
                            <li>Partners</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="section-padding">
        <div class="container">
            <div class="row justify-content-center  gy-4 align-items-center">
                <div class="col-lg-4 col-md-4">
                    <div class="mission-img">
                        <img src="image/partners/bhe.jpg" alt="">
                        <h4>Bonn Hungary 
Electronics
                        </h4>
                      
                    </div>
                </div>
                <div class="col-lg-4 col-md-4">
                    <div class="mission-img">
                        <img src="image/partners/gdp.jpg" alt="">
                        <h4>GDP Space Systems

                        </h4>
                      
                    </div>
                </div>
                <div class="col-lg-4 col-md-4">
                    <div class="mission-img">
                        <img src="image/partners/systel.png" alt="">
                        <h4>AA Systel, France

                        </h4>
                       
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

