<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ContactUsAdmin8.aspx.cs" Inherits="ITP2020_G8._11.ContactUsAdmin8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <center>
        <h3><b>Manage Contact Us</b></h3><br />
    </center>
    <div class="container">
        <div class="row">
            <div class="col-md-7">
                <div class="cart">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Phone Details</h4>
                                </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <hr >
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <label>Phone ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="ID"></asp:TextBox>
                                        <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Go" OnClick="Button1_Click"  />
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-8">
                                <label>Phone Number</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Phone Number"></asp:TextBox>
                                </div>
                            </div>

                        </div>
                        <div class="row">
                            <div class="col-4">
                                <asp:Button ID="Button2" class="btn btn-lg btn-block btn-success" runat="server" Text="Add" OnClick="Button2_Click"  />
                            </div>
                            <div class="col-4">
                                <asp:Button ID="Button3" class="btn btn-lg btn-block btn-warning" runat="server" Text="Update" OnClick="Button3_Click"  />
                            </div>
                            <div class="col-4">
                                <asp:Button ID="Button4" class="btn btn-lg btn-block btn-danger" runat="server" Text="Delete" OnClick="Button4_Click"  />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr >
                            </div>
                        </div>
                    </div>
                </div>
            </div>
      
        <div class="col-md-5">
            <div class="card">
                <div class="card-body">
                    <div class="row">
                        <div class="col">
                            <center>
                                <h4>Phone Details List</h4>
                            </center>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col">
                            <hr >
                        </div>
                    </div>
                    <div class="row">
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IsuruProperty_ITPConnectionString %>" SelectCommand="SELECT * FROM [Company_phone]"></asp:SqlDataSource>
                        <div class="col">
                            <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server"  AutoGenerateColumns="False" DataKeyNames="phone_id" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="phone_id" HeaderText="phone_id" ReadOnly="True" SortExpression="phone_id" />
                                    <asp:BoundField DataField="phone_No" HeaderText="phone_No" SortExpression="phone_No" />
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
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</div>
    <br /><br />
        <div class="container">
        <div class="row">
            <div class="col-md-7">
                <div class="cart">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Email Details</h4>
                                </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <hr >
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <label>Email ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="ID"></asp:TextBox>
                                        <asp:Button class="btn btn-primary" ID="Button5" runat="server" Text="Go" OnClick="Button5_Click"  />
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-8">
                                <label>Email</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Email"></asp:TextBox>
                                </div>
                            </div>

                        </div>
                        <div class="row">
                            <div class="col-4">
                                <asp:Button ID="Button6" class="btn btn-lg btn-block btn-success" runat="server" Text="Add" OnClick="Button6_Click"  />
                            </div>
                            <div class="col-4">
                                <asp:Button ID="Button7" class="btn btn-lg btn-block btn-warning" runat="server" Text="Update" OnClick="Button7_Click"  />
                            </div>
                            <div class="col-4">
                                <asp:Button ID="Button8" class="btn btn-lg btn-block btn-danger" runat="server" Text="Delete" OnClick="Button8_Click"  />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr >
                            </div>
                        </div>
                    </div>
                </div>
            </div>
      
        <div class="col-md-5">
            <div class="card">
                <div class="card-body">
                    <div class="row">
                        <div class="col">
                            <center>
                                <h4>Email Details List</h4>
                            </center>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col">
                            <hr >
                        </div>
                    </div>
                    <div class="row">
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:IsuruProperty_ITPConnectionString %>" SelectCommand="SELECT * FROM [Company_Email]"></asp:SqlDataSource>
                        <div class="col">
                            <asp:GridView class="table table-striped table-bordered" ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="Email_id" DataSourceID="SqlDataSource2" CellPadding="4" ForeColor="#333333" GridLines="None" >
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="Email_id" HeaderText="Email_id" ReadOnly="True" SortExpression="Email_id" />
                                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
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
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</div>
    <br /><br />
        <div class="container">
        <div class="row">
            <div class="col-md-7">
                <div class="cart">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Address Details</h4>
                                </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <hr >
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <label>Address ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="ID"></asp:TextBox>
                                        <asp:Button class="btn btn-primary" ID="Button9" runat="server" Text="Go" OnClick="Button9_Click"  />
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-8">
                                <label>Address</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="Address"></asp:TextBox>
                                </div>
                            </div>

                        </div>
                        <div class="row">
                            <div class="col-4">
                                <asp:Button ID="Button10" class="btn btn-lg btn-block btn-success" runat="server" Text="Add" OnClick="Button10_Click"  />
                            </div>
                            <div class="col-4">
                                <asp:Button ID="Button11" class="btn btn-lg btn-block btn-warning" runat="server" Text="Update" OnClick="Button11_Click"  />
                            </div>
                            <div class="col-4">
                                <asp:Button ID="Button12" class="btn btn-lg btn-block btn-danger" runat="server" Text="Delete" OnClick="Button12_Click"  />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr >
                            </div>
                        </div>
                    </div>
                </div>
            </div>
      
        <div class="col-md-5">
            <div class="card">
                <div class="card-body">
                    <div class="row">
                        <div class="col">
                            <center>
                                <h4>Address Details List</h4>
                            </center>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col">
                            <hr >
                        </div>
                    </div>
                    <div class="row">
                        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:IsuruProperty_ITPConnectionString %>" SelectCommand="SELECT * FROM [Company_Address]"></asp:SqlDataSource>
                        <div class="col">
                            <asp:GridView class="table table-striped table-bordered" ID="GridView3" runat="server" AutoGenerateColumns="False" DataKeyNames="Add_id" DataSourceID="SqlDataSource3" CellPadding="4" ForeColor="#333333" GridLines="None">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="Add_id" HeaderText="Add_id" ReadOnly="True" SortExpression="Add_id" />
                                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
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
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</div>
    <br /><br />
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <h4>Working Hours</h4><br />
                <h5>8 A.M to 5 P.M</h5>
            </div>
            <div class="col-md-6">
                <h4>Company Links</h4>
                <a href="facebook.com">Facebook</a><br />

                <a href="whatsapp.com">Whatsapp</a>

            </div>

        </div>
    </div>
    <br /><br />

<div class="container">
    <a href="LetUsCallYouAdmin2.aspx"><h4><b><u><i>Manage Let Us Call You>></i></u></b></h4></a><br>
                
</div>
    <br /><br />


</asp:Content>
