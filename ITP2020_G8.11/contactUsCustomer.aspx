<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="contactUsCustomer.aspx.cs" Inherits="ITP2020_G8._11.contactUsCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br /><br />
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-9 mx-auto">

                <div class="card-group">
  <div class="card border-success">
    
    <div class="card-body">
      <center><h5 class="card-title">Phone</h5>
        <asp:Label ID="phone1" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="phone2" runat="server" Text=""></asp:Label>
      </center>  
      
    </div>
  </div>
  <div class="card border-success">
    
    <div class="card-body">
      <center><h5 class="card-title">Email</h5>
        <asp:Label ID="email1" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="email2" runat="server" Text=""></asp:Label>
      </center>
    </div>
  </div>
  <div class="card border-success">
    
    <div class="card-body">
      <center><h5 class="card-title">Address</h5>
        <asp:Label ID="add1" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="add2" runat="server" Text=""></asp:Label>
      </center>
    </div>
  </div>
</div>


            </div>
        
        
            
        </div>
    </div>

    <br /><br /><br />

    <div class="row">
        <div class="col-md-5 mx-auto">
            <div class="card border-success">
                <div class="card-body">
                    <div class="row">
                        <div class="col-12">
                            <center><h4>LET US CALL YOU</h4></center>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Name" required="true"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Email" required="true"></asp:TextBox>
                            </div>
                            
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-6">
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Phone" required="true"></asp:TextBox>
                            </div>
                        </div>
                        
                    </div>
                    <div class="row">
                        <div class="col">
                            <asp:textbox CssClass="form-control" id="TextBox5" runat="server" Width="575px" height="100px" Wrap="true" TextMode="MultiLine" placeholder="Message" required="true"></asp:textbox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="form-group">
                                <asp:Button ID="Button1" CssClass="btn btn-success btn-block" runat="server" Text="Send" OnClick="Button1_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>




</asp:Content>
