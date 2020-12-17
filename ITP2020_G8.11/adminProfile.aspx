<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminProfile.aspx.cs" Inherits="ITP2020_G8._11.adminProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-md-7 mx-auto">
            <div class="card">
                <div class="card-body">
                    <div class="row">
                        <div class="col-12">
                            <center><h4>Admin Profile</h4></center>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col">
                            <hr />
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-6">
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="First Name"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-6">
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Last Name"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-6">
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Contact Number"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-6">
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Gender"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="Address"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-6">
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="Username"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-6">
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox7" runat="server" placeholder="Password"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <br /><br /><br />

                    <div class="row">
                        <div class="col">
                            <center>
                                <asp:Button ID="Button1" runat="server" Text="Add" class="btn btn-success btn-lg" OnClick="Button1_Click"></asp:Button> &nbsp&nbsp
                                <asp:Button ID="Button2" runat="server" Text="Update" class="btn btn-warning btn-lg" OnClick="Button2_Click"></asp:Button> &nbsp&nbsp
                                <asp:Button ID="Button3" runat="server" Text="Delete" class="btn btn-danger btn-lg" OnClick="Button3_Click"></asp:Button> &nbsp&nbsp
                                <asp:Button ID="Button4" runat="server" Text="Search" class="btn btn-primary btn-lg" OnClick="Button4_Click"></asp:Button> &nbsp&nbsp
                                <asp:Button ID="Button5" runat="server" Text="Clear" class="btn btn-dark btn-lg" OnClick="Button5_Click"></asp:Button> &nbsp&nbsp
                                <asp:Button ID="Button6" runat="server" Text="Download PDF" class="btn btn-light btn-l" OnClick="Button6_Click"></asp:Button> &nbsp&nbsp

                            </center>
                        </div>
                    </div>
                    

                </div>
            </div>
        </div>
    </div>


</asp:Content>
