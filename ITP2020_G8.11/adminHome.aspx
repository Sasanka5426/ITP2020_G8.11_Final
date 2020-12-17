<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminHome.aspx.cs" Inherits="ITP2020_G8._11.adminHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        
        <div class="row">
            
            <div class="col-md-3">
                <center>
                <a href="manageLandsAdmin.aspx"><div class="card" style="width: 20rem;">
                    <img src="images/landSaleImage.png" class="card-img-top" />
                    <%--<img src="images/landSaleImage" class="card-img-top" alt="...">--%>
                    <div class="card-body">
                        <h5 class="card-title" style="text-decoration:none !important; color:#179400;" >Manage Land Details</h5>
                        
                        <%--<a href="#" class="btn btn-outline-success">View</a>--%>
                    </div>
                </div><a>
                </center>
            </div>

            
            
            <div class="col-md-3">
                <center>
                <a href="manageInquiryAdmin.aspx"><div class="card" style="width: 20rem;">
                    <img src="images/inquiryImage.png" class="card-img-top" />
                    <div class="card-body">
                        <h5 class="card-title" style="text-decoration:none !important; color:#179400;">Manage Customer Inquiries</h5>
                        
                       <%-- <a href="manageInquiryAdmin.aspx" class="btn btn-outline-success">View</a>--%>
                    </div>
                </div></a>
                </center>

            </div>

           

            <div class="col-md-3">
                <center>
                <a href="Manage_Proposal_Admin.aspx"><div class="card" style="width: 20rem;">
                    <img src="images/sellImage.jpg" class="card-img-top" />
                    <div class="card-body">
                        <h5 class="card-title" style="text-decoration:none !important; color:#179400;">Manage Selling Proposals</h5>
                        
                        <%--<a href="#" class="btn btn-outline-success">View</a>--%>
                    </div>
                </div></a>
                </center>

            </div>

            <div class="col-md-3">
                <center>
                <a href="FAQ_admin.aspx"><div class="card" style="width: 20rem;">
                    <img src="images/FAQImage.jpg" class="card-img-top" />
                    <div class="card-body">
                        <h5 class="card-title" style="text-decoration:none !important; color:#179400;">Manage FAQ Section</h5>
                        
                        <%--<a href="#" class="btn btn-outline-success">View</a>--%>
                    </div>
                </div></a>
                </center>

            </div>

            




        </div>

        <%---------------------------------------------------------------------------------------------------------------------------------------------%>
        <br /><br />

        <div class="row">
            
            <div class="col-md-3">
                <center>
                <a href="ContactUsAdmin8.aspx"><div class="card" style="width: 20rem;">
                    <img src="images/contactUsImage.jpg" class="card-img-top" />
                    <div class="card-body">
                        <h5 class="card-title" style="text-decoration:none !important; color:#179400;">Manage Contact Us</h5>
                        
                        <%--<a href="#" class="btn btn-outline-success">View</a>--%>
                    </div>
                </div></a>
                </center>
            </div>

            
            
            <div class="col-md-3">
                <center>
                <a href="aboutUsAdmin.aspx"><div class="card" style="width: 20rem;">
                    <img src="images/aboutUsImage.jpg" class="card-img-top" />
                    
                    <div class="card-body">
                        <h5 class="card-title" style="text-decoration:none !important; color:#179400;">Manage About Us</h5>
                        
                        <%--<a href="#" class="btn btn-outline-success">View</a>--%>
                    </div>
                </div></a>
                </center>

            </div>

           

            <div class="col-md-3">
                <center>
                <a href="addCustomer.aspx"><div class="card" style="width: 20rem;">
                    <img src="images/cutomerRecordsImage.jpg" class="card-img-top"/>
                    <div class="card-body">
                        <h5 class="card-title" style="text-decoration:none !important; color:#179400;">Customer Records</h5>
                        
                        <%--<a href="#" class="btn btn-outline-success">View</a>--%>
                    </div>
                </div><//a>
                </center>

            </div>

            <div class="col-md-3">
                <center>
                <a href="adminProfile.aspx"><div class="card" style="width: 20rem;">
                    <img src="images/AdminProfileImage.png" class="card-img-top" />
                    <div class="card-body">
                        <h5 class="card-title" style="text-decoration:none !important; color:#179400;">Admin Profile</h5>
                        
                        <%--<a href="#" class="btn btn-outline-success">View</a>--%>
                    </div>
                </div></a>
                </center>

            </div>

            




        </div>

        
            
        
    </div>

    
</asp:Content>
