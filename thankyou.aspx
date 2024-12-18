<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="thankyou.aspx.cs" Inherits="thankyou" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
  <style>
    .error-img{
        height:250px;
        width:250px;
    }
     .get-quote-btn{
    display:none;
}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
              <section class="error-area">
    <div class="container">
        <div class="row justify-content-center">
            <div class="col-lg-8">
                <div class="error-wrap text-center">
                    <div class="error-img">
                        <img src="/assets/images/sucess.png" />
                    </div>
                    <div class="error-content">
                        <h1 class="title mb-2">Thank You </h1>
                        <h4 class="mb-4">Thank you for contacting us. our team will get back to you soon.</h4>
                        <div class="tg-button-wrap">
                            <a href="/" class="btn arrow-btn btn-four ">Go To Home Page <img src="assets/images/right_arrow.svg" alt="img" class="injectable"></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
</asp:Content>

