<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Manage_Proposal_Admin.aspx.cs" Inherits="ITP2020_G8._11.Manage_Proposal_Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="row-border">
            <div col-md-12>
                <center><h1><b>Manage Proposals</b></h1></center>
            </div>
        <div class="row">
            <div class="col-md-5">
 
                <div class="card">
                    <div class="card-body">
 
                        <div class="row">
                            <div class="col">
                                <center>
                                        <h4>Proposal Details</h4>
                                    </center>
                            </div>
                        </div>
 
                        
 
                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>
 
                        <div class="row">
                            <div class="col-md-4">
                                <label>P ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="ID"></asp:TextBox>
                                        <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Go" OnClick="Button1_Click" />
                                    </div>
                                </div>
                            </div>
 
                            <div class="col-md-8">
                                <label>Customer Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Customer Name" ReadOnly="true"></asp:TextBox>
 
                                </div>
                            </div>
                        </div>

                        <div class="col-10">
                                <label>Customer Email</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" id="TextBox3" runat="server" placeholder="Customer Email" ReadOnly="true"></asp:TextBox>
 
                                </div>
                        </div>
                        

                    <div class="col-10">
                                <label>Customer Phone</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" id="TextBox4" runat="server" placeholder="Customer Phone" ReadOnly="true"></asp:TextBox>
 
                                </div>
                    </div>

                    <div class="row">
                            <div class="col-md-4">
                                <lable>Address</lable>
                                <div class="form-group">
                                   <asp:textbox id="txtBodymsg" runat="server" Width="440px" height="100px" Wrap="true" TextMode="MultiLine" ReadOnly="true" placeholder="Address"></asp:textbox>
 
                                </div>

                            </div>

                    </div>

                    <div class="row">
                            <div class="col-md-4">
                                <lable>Description</lable>
                                <div class="form-group">
 
                                </div>

                            </div>

                    </div>
                    
                    <div class="col-10">
                                <label>City</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" id="TextBox6" runat="server" placeholder="City" ReadOnly="true"></asp:TextBox>
 
                                </div>
                    </div>
                    
                    

                    <div class="col-10">
                                <label>Extent</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" id="TextBox8" runat="server" placeholder="Extent" ></asp:TextBox>
 
                                </div>
                    </div>
                    <div class="col-10">
                                <label>Price</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" id="TextBox7" runat="server" placeholder="Price" ></asp:TextBox>
 
                                </div>
                    </div>
                        <div class="row">
                            <div class="col-md-4">
                                <lable>Reply</lable>
                                <div class="form-group">
                                   <asp:textbox id="Textbox9" runat="server" Width="440px" height="100px" Wrap="true" TextMode="MultiLine" placeholder="Reply"></asp:textbox>
 
                                </div>

                            </div>

                    </div> 
                        <div class="row">
                            <div class="col-3">
                                <asp:Button ID="Button2" class="btn btn-lg btn-block btn-success" runat="server" Text="Reply" OnClick="Button2_Click"   />
                            </div>
                            <div class="col-3">
                                <asp:Button ID="Button3" class="btn btn-lg btn-block btn-warning" runat="server" Text="Update" OnClick="Button3_Click"  />
                            </div>
                            <div class="col-3">
                                <asp:Button ID="Button4" class="btn btn-lg btn-block btn-danger" runat="server" Text="Delete" OnClick="Button4_Click"  />
                            </div>
                            <div class="col-3">
                                <asp:Button ID="Button5" class="btn btn-lg btn-block btn-primary" runat="server" Text="Report" OnClick="Button5_Click"  />
                            </div>
                        </div>
 
 
                    </div>
                </div>
 
               <%--<a href="homepage.aspx"><< Back to Home</a><br>--%>
                <br>
            </div>
 
            <div class="col-md-7">
 
                <div class="card">
                    <div class="card-body">
 
 
 
                        <div class="row">
                            <div class="col">
                                <center>
                                        <h4>Proposal List</h4>
                                    </center>
                            </div>
                        </div>
 
                       
 
                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>
 
                        <div class="row">
                            <div class="col">
                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:IsuruProperty_ITPConnectionString %>" SelectCommand="SELECT * FROM [sell_yourLand]"></asp:SqlDataSource>
                                <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="sell_id" DataSourceID="SqlDataSource2">
                                    <Columns>







                                        <asp:BoundField DataField="sell_id" HeaderText="ID" ReadOnly="True" SortExpression="sell_id" InsertVisible="False" />





                                        <asp:BoundField DataField="emil" HeaderText="emil" SortExpression="emil" />
                                        <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                                        <asp:BoundField DataField="mobile" HeaderText="mobile" SortExpression="mobile" />
                                        <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                                        <asp:BoundField DataField="city" HeaderText="city" SortExpression="city" />
                                        <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                                        <asp:BoundField DataField="extent" HeaderText="extent" SortExpression="extent" />
                                        <asp:BoundField DataField="land_img_link" HeaderText="land_img_link" SortExpression="land_img_link" />
                                        <asp:BoundField DataField="reply" HeaderText="reply" SortExpression="reply" />
                                        
                                        
                                        
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
 
 
                    </div>
                </div>
 
 
            </div>
 
        </div>
    </div>

</asp:Content>
