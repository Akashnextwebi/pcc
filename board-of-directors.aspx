<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="board-of-directors.aspx.cs" Inherits="board_of_directors" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/breadcrums.css" rel="stylesheet" />
    <style>
        .magnetic-wrap {
    position: relative;

}
        .people-card3 .people-content {
    padding: 25px 30px;
    border: 1px solid #eee;
    border-top: none;
    display: flex
;
    align-items: center;
    justify-content: space-between;
    gap: 10px;
}
            .people-card3 .people-content .name-degi {
                line-height: 1;
            }.people-card3 .people-content .name-degi h5 {
    margin-bottom: 5px;
}
             .people-card3 .people-content .name-degi span {
    color: #566064;
    font-size: 14px;
    font-weight: 500;
}.people-card3 .people-content .social-icon {
    display: flex
;
    align-items: center;
    justify-content: center;
    width: 120px;
    border: 1px solid #eee;
    border-radius: 20px;
    padding: 7px;
}
 .people-card3 .people-content .social-icon li a {
    width: 24px;
    height: 24px;
    border-radius: 50%;
    background-color: #dfebf7;
    display: flex
;
    align-items: center;
    justify-content: center;
    transition: 0.35s;
}
 .people-card3 .people-content .social-icon li a i {
    font-size: 15px;
    color: #0094ff;
    transition: 0.35s;
}
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(image/blog/braadcrumb-bg3.jpg);">
        <div class="container-fluid one pl--95">
            <div class="row">
                <div class="col-lg-12">
                    <div class="banner-content">
                        <h1>Board Of Directors</h1>
                        <ul class="breadcrumb-list">
                            <li><a href="Default.aspx">Home</a></li>
                            <li>Board Of Directors</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="section-padding">
        <div class="container">
            <div class="row g-4">
                <div class="col-md-6">
                    <div class="magnetic-wrap">
                        <div class="people-card3 magnetic-item" style="">
                            <div class="people-img">
                                <img src="image/team/1.png" alt="">
                            </div>
                            <div class="people-content">
                                <div class="name-degi">
                                    <h5><a href="#">Mr. Harbard Mack</a></h5>
                                    <span>Senior Consultant</span>
                                </div>
                               <div class="social-icon">
View Profile
  </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="magnetic-wrap">
                        <div class="people-card3 magnetic-item">
                            <div class="people-img">
                                <img src="image/team/1.png" alt="">
                            </div>
                            <div class="people-content">
                                <div class="name-degi">
                                    <h5><a href="#">Mr. DF Daniel Scoot</a></h5>
                                    <span>Senior Consultant</span>
                                </div>
                              <div class="social-icon">
View Profile
  </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="magnetic-wrap">
                        <div class="people-card3 magnetic-item" style="">
                            <div class="people-img">
                                <img src="image/team/1.png" alt="">
                            </div>
                            <div class="people-content">
                                <div class="name-degi">
                                    <h5><a href="#">Mrs. Hanrry Ghust</a></h5>
                                    <span>Senior Consultant</span>
                                </div>
                                <div class="social-icon">
View Profile
  </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="magnetic-wrap">
                        <div class="people-card3 magnetic-item">
                            <div class="people-img">
                                <img src="image/team/1.png" alt="">
                            </div>
                            <div class="people-content">
                                <div class="name-degi">
                                    <h5><a href="#">Mr. Dr Richard Joseph</a></h5>
                                    <span>Senior Consultant</span>
                                </div>
                                <div class="social-icon">
                              View Profile
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

