<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="LetUsCallYouAdmin2.aspx.cs" Inherits="ITP2020_G8._11.LetUsCallYouAdmin2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center>
        <h3>Manage Let Us Call You</h3><br />

    </center>
     <div class="container">
        
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IsuruProperty_ITPConnectionString %>" SelectCommand="SELECT * FROM [Let_us_call_you]"></asp:SqlDataSource>
            <asp:GridView class="table table-striped table-bordered" ID="GridView4" runat="server" AutoGenerateColumns="False" DataKeyNames="Detail_id" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView4_SelectedIndexChanged" >
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Detail_id" HeaderText="Detail Id" InsertVisible="False" ReadOnly="True" SortExpression="Detail_id" />
                    <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" />
                    <asp:BoundField DataField="phone" HeaderText="Phone" SortExpression="phone" />
                    <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
                    <asp:BoundField DataField="message" HeaderText="Message" SortExpression="message" />
                    <asp:CommandField ShowSelectButton="True" />
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
    

   <br /><br />
         <h4>Delete Details</h4><hr />
         <div class="col-md-4">
                                <label>Details ID</label>
             <br />
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="ID"></asp:TextBox>
                                        <asp:Button class="btn btn-lg btn-block btn-danger" ID="Button1" runat="server" Text="Detete" OnClick="Button1_Click" />
                                    </div>
                                </div>
                            </div>
         <hr />
         <br /><br />
         <a href="LetUsCallYouAdminPdf.aspx"><h4><b><u><i>Get Report>></i></u></b></h4></a><br>
    </div>

</asp:Content>
