<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="contact-us.aspx.cs" Inherits="contact_us" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/breadcrums.css" rel="stylesheet" />
    <link href="css/about.css" rel="stylesheet" />
    <style>
        .pd-bottom-300 {
            padding-bottom: 300px;
        }

        .mr-bottom-90 {
            margin-bottom: 90px;
        }

        .theme-style--light .widget {
            border-color: #d9d9d9;
        }

        .wptb-office-address .widget {
            padding-left: 40px ;
            padding-right: 15px;
            margin-right: -1px;
            height: 100%;
        }

        .widget {
            background: transparent;
            padding: 0px 30px 30px 30px;
            margin-bottom: -1px;
            box-shadow: none;
            border: 1px solid #3d3d3d;
            overflow: hidden;
        }

        .wptb-office-address .widget .widget-title {
            font-size: 24px;
            font-style: normal;
            font-weight: 600;
            line-height: 36px;
            letter-spacing: -0.24px;
            text-transform: capitalize;
            padding: 20px 0px;
        }



        .widget .widget-title::after {
            background-color: #d9d9d9;
        }

        .widget .widget-title {
            position: relative;
            margin-bottom: 30px ;
        }

            .widget .widget-title::after {
                content: '';
                position: absolute;
                left: -50%;
                bottom: 0px;
                width: 200%;
                height: 1px;
            }

        .wptb-office .wptb-item--inner .wptb-item--subtitle {
            color: #000;
            font-size: 16px;
            font-style: normal;
            font-weight: 700;
            line-height: 26px;
            text-transform: uppercase;
        }

        .wptb-office .wptb-item--inner .wptb-item--title {
            color: #000;
            font-style: normal;
            font-weight: 600;
            letter-spacing: -0.2px;
            word-break: break-word;
            font-size: 16px ;
            margin-bottom: 10px ;
            line-height: 30px ;
        }

        .wptb-heading {
            position: relative;
            margin-bottom: 50px;
        }

            .wptb-heading .wptb-item--title {
                position: relative;
                z-index: 1;
                color: var(--color-white);
                font-size: var(--fs-48);
                font-weight: var(--fw-semibold);
                line-height: var(--fs-56);
                letter-spacing: -1.06px;
                margin-top: 10px;
                margin-bottom: 15px;
                transition: var(--transition-base);
            }

        .form-control {
            background-color: rgba(255, 255, 255, 0.50);
            border-color: #D9D9D9;
            color: #000000;
            display: block;
            width: 100%;
            height: 55px;
            padding: 15px 20px;
            font-size: 14px;
            font-weight: 500;
            line-height: normal;
            background-clip: padding-box;
            -webkit-border-radius: 0px;
            -moz-border-radius: 0px;
            border-radius: 0px;
            backface-visibility: hidden;
            box-sizing: border-box;
            outline: none;
            appearance: none;
            -webkit-appearance: none;
            outline-offset: 0;
        }

        .btn-two {
            position: relative;
            width: auto;
            min-width: 230px;
            height: 60px;
            padding: 0px 60px 0px 0px;
            display: inline-flex;
            align-items: center;
            justify-content: center;
            gap: 10px;
            font-size: 16px;
            font-weight: 600;
            line-height: 28px;
            text-transform: uppercase;
            color: #fff;
            background: #d70006;
            border-width: 0px;
            -webkit-border-radius: 0px;
            -moz-border-radius: 0px;
            -ms-border-radius: 0px;
            -o-border-radius: 0px;
            border-radius: 0px;
            letter-spacing: 0.8px;
            cursor: pointer;
            overflow: hidden;
            -webkit-transition: var(--transition-base);
            transition: var(--transition-base);
        }

  h2.wptb-item--title1 {
            font-size: 42px ;
            margin-bottom: 30px ;
            line-height: 48px ;
            font-weight: 800;
        }

        textarea, textarea.form-control {
            height: 200px;
            -webkit-border-radius: 0px;
            -moz-border-radius: 0px;
            border-radius: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <main class="wrapper">
        <!-- Page Header -->
        <div class="breadcrumb-section" style="background-image: linear-gradient(270deg, rgba(0, 0, 0, .55), rgba(0, 0, 0, 0.55) 101.02%), url(image/bg1/contact%20us.png);">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="banner-content">
                            <h1>Contact Us</h1>
                            <ul class="breadcrumb-list">
                                <li><a href="Default.aspx">Home</a></li>
                                <li>Contact Us</li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Contact Us -->
        <section class="pd-bottom-300 section-padding">
            <div class="container">
                <div class="wptb-office-address mr-bottom-90">
                    <div class="row gy-lg-0 gy-4">
                        <div class="col-md-4 pe-md-0">
                            <div class="widget">
                                <h2 class="widget-title">Phone No</h2>

                                <div class="wptb-office">
                                    <div class="wptb-item--inner">

                                        <h5 class="wptb-item--title"><a href="tel:+91-80-2529 2513">+91-80-2529 2513/2529 7199/ 2529 3482</a></h5>

                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="col-md-4 p-md-0">
                            <div class="widget">
                                <h2 class="widget-title">Email</h2>

                                <div class="wptb-office">
                                    <div class="wptb-item--inner">

                                        <h5 class="wptb-item--title"><a href="mailto:info@parkcontrols.com

">info@parkcontrols.com

                                        </a></h5>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4 p-md-0">
                            <div class="widget">
                                <h2 class="widget-title">Fax</h2>

                                <div class="wptb-office">
                                    <div class="wptb-item--inner">

                                        <h5 class="wptb-item--title"><a href="tel:+91-80-2528 1716">+91-80-2528 1716 / 4091 0252</a></h5>

                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-6 pe-md-0">
                            <div class="widget">
                                <h2 class="widget-title">Address</h2>

                                <div class="wptb-office">
                                    <div class="wptb-item--inner">
                                        <div class="wptb-item--subtitle">
                                            Park Controls and Communications Private Limited


                                        </div>
                                        <h5 class="wptb-item--title"><a href="#">2716, Suranjan Das Rd, Rd, HAL 3rd Stage, Bhoomi Reddy Colony, New Tippasandra, Bengaluru, Karnataka 560075</a></h5>
                                    </div>
                                </div>
                            </div>
                        </div>


                        <div class="col-md-6 p-md-0">
                            <div class="widget">
                                <h2 class="widget-title">Business Hours:

                                </h2>

                                <div class="wptb-office">
                                    <div class="wptb-item--inner">

                                        <h5 class="wptb-item--title"><a href="mailto:info@parkcontrols.com

">9:00 AM – 6:00 PM Monday – Friday
                                            <br />
                                           Non-Working Day – Saturday<br />
                                           Day Off – Sunday





                                        </a></h5>
                                    </div>
                                </div>
                            </div>
                        </div>

                        
                    </div>
                </div>

              


            </div>
        </section>
        <section class="bg-light">
            <div class="container">
                <div class="wptb-contact-form-two mr-top-100  section-padding">
                    <div class="wptb-form--wrapper">
                        <div class="row">
                            <div class="col-lg-5 col-md-12">
                                <div class="wptb-heading">
                                    <div class="wptb-item--inner">
                                        <h6 class="wptb-item--subtitle">SEND US MAIL
                                        </h6>
                                        <h2 class="wptb-item--title1">Get in Touch</h2>
                                        <div class="wptb-item--divider"></div>
                                        <div class="wptb-item--description">
Have questions or need assistance? Reach out to us, and our team will be happy to help!                                        </div>
                                    </div>
                                </div>

                            </div>

                            <div class="col-lg-7 col-md-12">
                                <div class="wptb-form--inner">
                                    <asp:Label ID="lblStatus" runat="server" Width="100%" Visible="false"></asp:Label>
                                    <div class="row">
                                        <div class="col-lg-6 col-md-6 mb-4">
                                            <div class="form-group">
                                                <%-- <input type="text" name="name" class="form-control" placeholder="Name*" required>--%>
                                                <asp:TextBox ID="txtname" class="form-control" runat="server" placeholder="Enter Your Name*"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="req1" runat="server" ControlToValidate="txtname" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>

                                        <div class="col-lg-6 col-md-6 mb-4">
                                            <div class="form-group">
                                                <%-- <input type="email" name="email" class="form-control" placeholder="E-mail*" required>--%>
                                                <asp:TextBox ID="txtemail" class="form-control" runat="server" placeholder="Enter Your E-mail*"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="rfv2" runat="server" ControlToValidate="txtemail" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                                <asp:RegularExpressionValidator runat="server" ControlToValidate="txtemail" ErrorMessage="Please Enter Valid Email Id" ForeColor="Red" ValidationGroup="Save" SetFocusOnError="True" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                            </div>
                                        </div>

                                        <div class="col-lg-12 col-md-12 mb-4">
                                            <div class="form-group">
                                                <%--<input type="text    name="subject" class="form-control" placeholder="Subject">--%>
                                                <asp:TextBox ID="txtsubject" runat="server" class="form-control" placeholder="Enter Subject*"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="rfv3" runat="server" ControlToValidate="txtsubject" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>

                                        <div class="col-md-12 col-lg-12 mb-4">
                                            <div class="form-group">
                                                <%-- <textarea name="message" class="form-control" placeholder="Text"></textarea>--%>
                                                <asp:TextBox ID="txtmsg" runat="server" TextMode="MultiLine" Rows="6" class="form-control" placeholder="Enter Message*"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="rfv4" runat="server" ControlToValidate="txtmsg" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>

                                        <div class="col-md-12 col-lg-12">
                                            <div class="wptb-item--button">
                                                <%--  <asp:LinkButton ID="lnkSendMail" runat="server" CssClass="btn-two white" OnClick="SendMail_Click" CausesValidation="true" ValidationGroup="Save">
                                <div class="btn-wrap">
                          <span class="text-first">Send Mail</span>
                                  </div>
                              </asp:LinkButton>--%>
                                                <asp:LinkButton ID="lnkSendMail" runat="server" CssClass="btn2 mt-35" OnClick="SendMail_Click" ValidationGroup="Save">Send Mail<i class="fal fa-long-arrow-right"></i></asp:LinkButton>
                                                <%--                                                <asp:Button runat="server" ID="BtnSave" OnClick="BtnSave_Click" OnClientClick="false" ValidationGroup="Save" CssClass="btn-two white" Text="Submit" />--%>
                                                <%--<button class="btn-two white" type="submit">
                                        <div class="btn-wrap">
                                            <span class="text-first">Send Mail </span>
                                        </div>
                                    </button>--%>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <section class="section-padding">
            <div class="container">
                  <div class="gmapbox wow fadeInUp">
      <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d242.99987728533415!2d77.65786535202425!3d12.971977128157983!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3bae16aa33b27567%3A0x8f953033d4356f!2sPark%20Controls%20%26%20Communications%20Private%20Limited!5e0!3m2!1sen!2sin!4v1732866597618!5m2!1sen!2sin" width="600" height="450" style="border: 0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
  </div>

            </div>
        </section>
    </main>
</asp:Content>

