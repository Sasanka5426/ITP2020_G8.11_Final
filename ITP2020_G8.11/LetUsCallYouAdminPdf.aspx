<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="LetUsCallYouAdminPdf.aspx.cs" Inherits="ITP2020_G8._11.LetUsCallYouAdminPdf" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <center>
        <h3><b>Get Report</b></h3><br />

    </center>
    <div class="container">
        <asp:GridView class="table table-striped table-bordered" ID="GridView5" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Detail_id"  ForeColor="#333333" GridLines="None" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Detail_id" HeaderText="Detail_id" InsertVisible="False" ReadOnly="True" SortExpression="Detail_id" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="phone" HeaderText="phone" SortExpression="phone" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:BoundField DataField="message" HeaderText="message" SortExpression="message" />
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />

        </asp:GridView>
        <br />
        <hr />
        <div class="col-md-2">
        <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Export to PDF" OnClick="Button1_Click"  />
            </div>
        <hr />
    </div>
    <br />

</asp:Content>
