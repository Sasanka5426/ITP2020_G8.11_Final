<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="aboutUsAdmin.aspx.cs" Inherits="ITP2020_G8._11.aboutUsAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
body {
  background-image: url('images/bc.png');
}
    .auto-style1 {
        display: block;
        font-size: 1rem;
        font-weight: 400;
        line-height: 1.5;
        color: #495057;
        background-clip: padding-box;
        border-radius: .25rem;
        transition: none;
        border: 1px solid #ced4da;
        background-color: #fff;
    }
</style>
    <div class="container">
          <center>
               <h3>About Us</h3>
          </center>

           <div class="row">
                     <div class="col">
                        <label>Company Description</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="auto-style1" ID="TextBox1" runat="server" placeholder="Company Description"  Height="33px" Width="100%"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter Company Description" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div></div></div>
                 
                  
                        <label>Vision</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="auto-style1" ID="TextBox2" runat="server" placeholder="Vision" Height="33px" Width="100%" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter Vision" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>

                          <label>Mission</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="auto-style1" ID="TextBox3" runat="server" placeholder="Mission" Height="33px" Width="100%" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox3" ErrorMessage="Enter Mission" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>

                          <label>Company History</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="auto-style1" ID="TextBox4" runat="server" placeholder="Company History" Height="33px" Width="100%" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox4" ErrorMessage="Enter Company History" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>

                          <label>Quality Policy</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="auto-style1" ID="TextBox5" runat="server" placeholder="Quality Policy" Height="33px" Width="100%" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox5" ErrorMessage="Enter Quality Policy" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>

                              <label>Latest News</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="auto-style1" ID="TextBox6" runat="server" placeholder="Latest News" Height="31px" Width="100%" ></asp:TextBox>
                           
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter Latest News" ForeColor="Red"></asp:RequiredFieldValidator>
                           
                        </div>



                               
                            <div class="form-group">
                           <asp:Button class="btn btn-warning btn-block btn-lg" ID="Button40" runat="server" Text="Update" OnClick="Button40_Click"  />
                        </div>
                        </div>

                            

    
                        


</asp:Content>

