<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="job-details.aspx.cs" Inherits="job_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        .job-detail-section {
            position: relative;
        }

            .job-detail-section .upper-box {
                position: relative;
                background-image: url(image/bg-4.png);
                background-repeat: no-repeat;
                background-position: center;
                background-size: cover;
                background-size: cover;
                padding: 80px 0 70px;
            }

        .auto-container {
            position: static;
            max-width: 1310px;
            padding: 0px 15px;
            margin: 0 auto;
            width: 100%;
        }

        .job-block-seven {
            position: relative;
        }

            .job-block-seven .inner-box {
                position: relative;
                display: flex;
                align-items: center;
                justify-content: space-between;
                box-sizing: border-box;
            }

            .job-block-seven .content {
                position: relative;
                padding-left: 120px;
                min-height: 51px;
            }

            .job-block-seven .company-logo {
                position: absolute;
                left: 0;
                top: 0;
                width: 100px;
                transition: all 300ms ease;
            }

                .job-block-seven .company-logo img {
                    display: block;
                    width: 100%;
                }

            .job-block-seven h4 {
                position: relative;
                font-weight: 500;
                font-size: 26px;
                line-height: 1.3em;
                color: #202124;
                top: -3px;
                margin-bottom: 10px;
            }

            .job-block-seven .job-info {
                position: relative;
                display: flex;
                flex-wrap: wrap;
                margin-bottom: 10px;
            }

                .job-block-seven .job-info li {
                    position: relative;
                    font-size: 14px;
                    line-height: 22px;
                    color: #696969;
                    font-weight: 400;
                    padding-left: 25px;
                    margin-right: 20px;
                    margin-bottom: 3px;
                }

                    .job-block-seven .job-info li .icon {
                        position: absolute;
                        left: 0;
                        top: 0;
                        font-size: 18px;
                        line-height: 22px;
                        color: #696969;
                    }

            .job-block-seven .job-other-info {
                position: relative;
                display: flex;
                flex-wrap: wrap;
            }

        .job-other-info li.time {
            background: rgba(25, 103, 210, 0.15);
            color: #1967D2;
        }

        .job-other-info li, .job-other-info.at-jsv6 li, .job-other-info.at-jsv7 li {
            position: relative;
            font-size: 13px;
            line-height: 15px;
            margin-right: 15px;
            padding: 5px 20px;
            border-radius: 50px;
            margin-bottom: 10px;
        }

        .job-block-seven .btn-box {
            position: relative;
            display: flex;
            align-items: center;
        }

        .job-detail-outer {
            position: relative;
            padding: 50px 0;
        }

        .job-detail {
            position: relative;
            padding-right: 30px;
        }

            .job-overview-two h4, .job-detail h3 {
                position: relative;
                font-weight: 500;
                font-size: 24px;
                line-height: 24px;
                color: #202124;
                margin-bottom: 20px;
            }

            .job-detail p {
                position: relative;
                font-size: 18px;
                line-height: 30px;
                color: #696969;
                margin-bottom: 26px;
            }

        .list-style-three {
            position: relative;
            margin-bottom: 50px;
        }

            .list-style-three li {
                position: relative;
                font-size: 18px;
                line-height: 30px;
                color: #696969;
                padding-left: 20px;
                margin-bottom: 25px;
            }

                .list-style-three li:before {
                    position: absolute;
                    left: 0;
                    top: 12px;
                    height: 4px;
                    width: 4px;
                    background: #202124;
                    content: "";
                }

        .job-detail-section .other-options {
            position: relative;
            margin-bottom: 50px;
            margin-top: 50px;
        }

        .job-detail-section .social-share {
            display: flex;
            align-items: center;
        }

        .social-share h5 {
            font-weight: 500;
            font-size: 16px;
            line-height: 22px;
            color: #202124;
            margin-right: 20px;
        }

        .social-share a.facebook {
            background: #3B5998;
        }

        .social-share a {
            padding: 10px 25px;
            font-size: 14px;
            line-height: 20px;
            color: #FFFFFF;
            background: #222222;
            border-radius: 8px;
            transition: all 300ms ease;
            margin: 5px 0;
            margin-right: 10px;
        }

            .social-share a.twitter {
                background: #55ACEE;
            }

            .social-share a.google {
                background: #dd4b39;
            }

        .header-three {
            margin-bottom: 0px;
            z-index: 2;
            position: relative;
        }

        .apply-now-sec {
            border: 1px solid #ebf0f6;
            box-shadow: 0 0 10px 7px rgb(0 0 0 / 3%);
            padding: 30px 20px;
            border-radius: 5px;
            position: sticky;
            top: 150px;
            display: block;
        }

        .contact-one__input-box {
            position: relative;
            display: block;
            margin-bottom: 20px;
        }

            .contact-one__input-box input[type="text"], .contact-one__input-box input[type="number"], .contact-one__input-box input[type="email"], .contact-one__input-box input, .contact-one__input-box select {
                width: 100%;
                border: none;
                background-color: #F5F5F5;
                border: none;
                border-radius: 0;
                padding: 15px 24px;
                outline: none;
                font-size: 16px;
                color: var(--knodtec-gray);
                display: block;
                font-weight: 400;
            }

        .social-share a i {
            margin-right: 5px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="job-detail-section">
        <!-- Upper Box -->
        <div class="upper-box">
            <div class="auto-container">
                <!-- Job Block -->
                <div class="job-block-seven">
                    <div class="inner-box">
                        <div class="content">
                            <span class="company-logo">
                                <img src="/image/media_37.png" alt=""></span>
                            <h4><a href="#" contenteditable="false" style="cursor: pointer;"><%=strJobTitle %></a></h4>
                            <ul class="job-info">
                                <li><i class="fa-solid fa-briefcase icon "></i><%=strEducation %></li>
                                <li><i class="fa-solid fa-location-dot icon "></i><%=strJobLocation %></li>
                                <li><i class="fa-regular fa-clock icon "></i><%--11 hours ago--%> <%=strtime %></li>
                            </ul>
                            <ul class="job-other-info">
                                <li class="time"><%=strEmploymentType %></li>

                            </ul>
                        </div>


                    </div>
                </div>
            </div>
        </div>

        <div class="job-detail-outer">
            <div class="auto-container">
                <div class="row">
                    <div class="content-column col-lg-8 col-md-12 col-sm-12">
                        <div class="job-detail">
                            <h3>Job Description</h3>
                            <p><%=strJobDescription %></p>
                            <h3>Key Responsibilities</h3>
                            <ul class="list-style-three">
                                <%=strKeyResponsibilities %>
                            </ul>
                            <h3>Skill &amp; Experience</h3>
                            <ul class="list-style-three">
                                <%=strSkills %>
                            </ul>
                        </div>

                        <!-- Other Options -->
                        <div class="other-options">
                            <div class="social-share">
                                <h5>Share this job</h5>
                                <a href="#" class="facebook" contenteditable="false" style="cursor: pointer;"><i class="fab fa-facebook-f"></i>Facebook</a>
                                <a href="#" class="twitter" contenteditable="false" style="cursor: pointer;"><i class="fab fa-twitter"></i>Twitter</a>
                                <a href="#" class="google" contenteditable="false" style="cursor: pointer;"><i class="fab fa-google"></i>Google+</a>
                            </div>
                        </div>

                        <!-- Related Jobs -->

                    </div>

                    <div class="sidebar-column col-lg-4 col-md-12 col-sm-12">
                        <div class="apply-now-sec">
                            <h4 class="mb-30 font-bold text-center">Apply For This Job</h4>
                            <div class="apply-form">
                                <asp:Label ID="lblStatus" runat="server"></asp:Label>

                                <div class="contact-one__input-box">
                                    <%--<input name="txtFullName" type="text" maxlength="100" placeholder="Full Name">--%>
                                    <asp:TextBox ID="txtname" runat="server" placeholder="Full Name"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfv1" runat="server" ControlToValidate="txtname" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="contact-one__input-box">
                                    <%-- <input name="txtEmailId" type="email" maxlength="100" placeholder="Email Id">--%>
                                    <asp:TextBox ID="txtemail" runat="server" placeholder="Email Id"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtemail" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator runat="server" ControlToValidate="txtemail" ErrorMessage="Please Enter valid EmailId" ForeColor="Red" ValidationGroup="Save" SetFocusOnError="True" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                </div>
                                <div class="contact-one__input-box">
                                    <%--<input name="txtContactNumber" type="text" maxlength="15" placeholder="Contact Number">--%>
                                    <asp:TextBox ID="txtcontact" runat="server" placeholder="Contact Number"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtcontact" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator runat="server" ControlToValidate="txtcontact" ErrorMessage="Please Enter valid contact number" ForeColor="Red" ValidationGroup="Save" SetFocusOnError="True" Display="Dynamic" ValidationExpression="^([0-9\(\)\/\+ \-]*)$"></asp:RegularExpressionValidator>
                                </div>
                                <div class="contact-one__input-box">
                                    <%-- <input name="txtExperience" type="text" maxlength="100" placeholder="Experience">--%>
                                    <asp:TextBox ID="txtexperience" runat="server" placeholder="Experience"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtexperience" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="contact-one__input-box">
                                    <%-- <input name="txtLocation" type="text" maxlength="100" placeholder="Location">--%>
                                    <asp:TextBox ID="txtlocation" runat="server" placeholder="Location"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtlocation" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="contact-one__input-box">
                                    <%-- <input name="txtCurrentCompany" type="text" maxlength="100" placeholder="Current Company">--%>
                                    <asp:TextBox ID="txtcompany" runat="server" placeholder="Current Company"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtcompany" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Field can't be empty"></asp:RequiredFieldValidator>
                                </div>
                                <div class="contact-one__input-box">
                                    <%-- <select name="ddlNoticePeriod">
                                        <option value="">Notice Period</option>
                                        <option value="Immediate Joiner">Immediate Joiner</option>
                                        <option value="0-15 days">0-15 days</option>
                                        <option value="1 month">1 month</option>
                                        <option value="2 months">2 months</option>
                                        <option value="3 months">3 months</option>
                                    </select>--%>
                                    <asp:DropDownList ID="ddlNoticePeriod" runat="server">
                                        <asp:ListItem Text="Notice Period" Value="" />
                                        <asp:ListItem Text="Immediate Joiner" Value="Immediate Joiner" />
                                        <asp:ListItem Text="0-15 days" Value="0-15 days" />
                                        <asp:ListItem Text="1 month" Value="1 month" />
                                        <asp:ListItem Text="2 months" Value="2 months" />
                                        <asp:ListItem Text="3 months" Value="3 months" />
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="ddlNoticePeriod" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationGroup="Save" ErrorMessage="Please select Notice Period"></asp:RequiredFieldValidator>
                                </div>
                                <div class="contact-one__input-box">
                                    <label>Resume <sup>*</sup></label>
                                    <%--<input type="file" name="fuResumePath" title="Maximum 1 MB file size">--%>
                                   <asp:FileUpload ID="UploadResume" runat="server" ToolTip="Maxmimum 1 MB file size"></asp:FileUpload><br />
                                    <small class="text-danger">.pdf, .doc, .docx, .png, .jpg, .jpeg formats are required</small>
                                </div>
                                <div class="contact-one__input-box">
                                    <%-- <input name="txtWriteYourMessage" type="text" maxlength="250" placeholder="Write Your Message">--%>
                                    <asp:TextBox ID="txtWriteYourMessage" runat="server" MaxLength="250" Placeholder="Write Your Message"></asp:TextBox>

                                </div>
                                <div class="contact-one__input-box">
                                    <%--  <input type="submit" name="btnSubmit" value="Submit" class="btn ss-btn">--%>
                                     <a><asp:LinkButton  class="btn ss-btn" ID="btnsubmit" runat="server" Text="Apply Now" OnClick="btnsubmit_Click" ValidationGroup="Save">Submit<i class="fal fa-arrow-right-long"></i></asp:LinkButton></a>
                                    <asp:Label ID="lblResume" runat="server" Visible="false"></asp:Label>
                                    <asp:HiddenField ID="txtJobId" runat="server" />
                                    <asp:HiddenField ID="txtJobTitle" runat="server" />
                                </div>

                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

