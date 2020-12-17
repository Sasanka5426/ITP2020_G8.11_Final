<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ShowDetails.aspx.cs" Inherits="ITP2020_G8._11.ShowDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 58%;
            height: 324px;
            margin-left: 0px;
            background-color: #3399FF;
        }
        .auto-style4 {
            width: 213px;
        }
        .auto-style5 {
            width: 300px;
        }
        .auto-style6 {
            background-color: #FFFFCC;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">

    <center>
        <h3>Show Customer Details</h3>
        </center>
            <br />

        <table class="auto-style1">
            <tr>
                <td class="auto-style4">Detail_ID</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style6" Width="776px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Name</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style6" Width="776px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Phone Number</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style6" Width="776px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Email</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style6" Width="776px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Message</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox5" runat="server" CssClass="auto-style6" Width="776px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />

    

    <br />
    <hr />
    <div class="container">
    <a href="LetUsCallYouAdmin2.aspx"><h4><b><u><i>Go Back</i></u></b></h4></a><br>
                
</div>
    <hr />

    </div>


</asp:Content>
