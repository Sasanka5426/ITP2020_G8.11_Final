<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="addCustomer.aspx.cs" Inherits="ITP2020_G8._11.addCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="row-border">
            <div col-md-12>
                <center>
                    <h1><b> Customer Details</b></h1></center>
            </div>
        <div class="row">
            <div class="col-md-5">
 
                <div class="card">
                    <div class="card-body">
 
                        <div class="row">
                            <div class="col">
                                <center>
                                        <h4>Add Customer</h4>
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
                                <label>Customer ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="ID"></asp:TextBox>
                                        <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Go" OnClick="Button1_Click"    />
                                    </div>
                                </div>
                            </div>
 
                            <div class="col-md-8">
                                <label>Customer Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Customer Name" ></asp:TextBox>
 
                                </div>
                            </div>
                        
                            </div>
                        <div class="col-10">
                                <label>Customer Number</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" id="TextBox3" runat="server" placeholder="Customer Number" ></asp:TextBox>
 
                                </div>
                        </div>
                        
                    
                    
                            <div class="col-md-10">
                                <lable>Address</lable>
                                <div class="form-group">
                                   <asp:textbox CssClass="form-control"  id="txtBodymsg" runat="server"  placeholder="Address"></asp:textbox>
 
                                </div>

                            </div>
                            <div class="col-md-10">
                                <lable>E-mail</lable>
                                <div class="form-group">
                                   <asp:textbox CssClass="form-control" id="Textbox5" runat="server"  placeholder="Email"></asp:textbox>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="Invalied Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red"></asp:RegularExpressionValidator>
                                </div>

                            </div>

                  
                    
                    <div class="col-10">
                                <label>Location</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" id="TextBox6" runat="server" placeholder="location" ></asp:TextBox>
 
                                </div>
                    </div>
                    
                    

                    <div class="col-10">
                                <label>Land Size</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" id="TextBox8" runat="server" placeholder="land size" ></asp:TextBox>
 
                                </div>
                    </div>
                    <div class="col-10">
                                <label>Price</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" id="TextBox7" runat="server" placeholder="price" ></asp:TextBox>
 
                                </div>
                    </div>
                        
                            <div class="col-md-10">
                                <lable>Date</lable>
                                <div class="form-group">
                                   <asp:textbox CssClass="form-control" id="Textbox9" runat="server"  placeholder="date"></asp:textbox>
 
                                </div>

                            </div>

                   

                            <div class="row">
                            <div class="col-3">
                                <asp:Button ID="Button2" class="btn btn-lg btn-block btn-success" runat="server" Text="Add" OnClick="Button2_Click"  />
                            </div>
                            <div class="col-3">
                                <asp:Button ID="Button3" class="btn btn-lg btn-block btn-warning" runat="server" Text="Update" OnClick="Button3_Click"   />
                            </div>
                            <div class="col-3">
                                <asp:Button ID="Button4" class="btn btn-lg btn-block btn-danger" runat="server" Text="Delete" OnClick="Button4_Click"    />
                            </div> 
                            <div class="col-3">
                                <asp:Button ID="Button5" class="btn btn-lg btn-block btn-primary" runat="server" Text="Report" OnClick="Button5_Click"  />
                            </div> 
                            
                            
                        </div>
                         <br />

                 
 
 
                    </div>
                </div>
               
                <br>
            </div>
        
            <div class="col-md-7">
            
                <div class="card">
                    <div class="card-body">
 
 
 
                        <div class="row">
                            <div class="col">
                                <center>
                                        <h4>Customer Details List</h4>
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
                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:IsuruProperty_ITPConnectionString %>" SelectCommand="SELECT * FROM [add_customer]"></asp:SqlDataSource>
                                <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="C_id" DataSourceID="SqlDataSource2">
                                    <Columns>
                                        <asp:BoundField DataField="C_id" HeaderText="C_id" ReadOnly="True" SortExpression="C_id" InsertVisible="False" />
                                        <asp:BoundField DataField="cus_name" HeaderText="cus_name" SortExpression="cus_name" />
                                        <asp:BoundField DataField="cus_num" HeaderText="cus_num" SortExpression="cus_num" />
                                        <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                                        <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                                        <asp:BoundField DataField="location" HeaderText="location" SortExpression="location"/>
                                        <asp:BoundField DataField="land_size" HeaderText="land_size" SortExpression="land_size" />
                                        <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                                        <asp:BoundField DataField="date" HeaderText="date" SortExpression="date" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
 
 
                    </div>
                 </div>
             </div>
          </div>
        </div>
     </div>


</asp:Content>
