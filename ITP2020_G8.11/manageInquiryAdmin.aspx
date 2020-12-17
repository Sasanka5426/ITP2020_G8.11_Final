<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="manageInquiryAdmin.aspx.cs" Inherits="ITP2020_G8._11.manageInquiryAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br><br>
  

    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">
                <center><h4><b>Customer Inquiries</b></h4></center>
            </div>
        </div>
        <div class="row">
            <div class="col-md-5">
 
                <div class="card">
                    <div class="card-body">
 
                        <div class="row">
                            <div class="col">
                                <center>
                                        <h4>Inquiry Details</h4>
                                    </center>
                            </div>
                        </div>
 
                        <%--<div class="row">
                            <div class="col">
                                <center>
                                        <img width="100px" src="imgs/writer.png" />
                                       
                                    </center>
                            </div>
                        </div>--%>
 
                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>
 
                        <div class="row">
                            <div class="col-md-4">
                                <label>Inquiry ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" id="TextBox1" runat="server" placeholder="ID"></asp:TextBox>
                                        <asp:Button class="btn btn-primary" id="Button1" runat="server" Text="Go" OnClick="Button1_Click" />
                                    </div>
                                </div>
                            </div>
 
                            <div class="col-md-8">
                                <label>Customer Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" id="TextBox2" runat="server" placeholder="Customer Name" ReadOnly="true"></asp:TextBox>
 
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-10">
                                <lable>Customer Email</lable>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" id="TextBox3" runat="server" placeholder="Customer Email" ReadOnly="true"></asp:TextBox>
 
                                </div>

                            </div>

                        </div>
                        <div class="row">
                            <div class="col-md-7">
                                <lable>Customer phone</lable>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" id="TextBox4" runat="server" placeholder="Customer Phone" ReadOnly="true"></asp:TextBox>
 
                                </div>

                            </div>

                        </div>
                        <div class="row">
                            <div class="col-md-5">
                                <lable>Land ID</lable>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" id="TextBox5" runat="server" placeholder="Land ID" ReadOnly="true"></asp:TextBox>
 
                                </div>

                            </div>

                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <lable>Message</lable>
                                <div class="form-group">
                                   <asp:textbox id="txtBodymsg" runat="server" Width="440px" height="100px" Wrap="true" TextMode="MultiLine" ReadOnly="true"></asp:textbox>
 
                                </div>

                            </div>

                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <lable>Reply</lable>
                                <div class="form-group">
                                   <asp:textbox id="TextBodyRep" runat="server" Width="440px" height="100px" Wrap="true" TextMode="MultiLine" placeholder="Reply" ></asp:textbox>
 
                                </div>

                            </div>

                        </div>
                        <div class="row">
                            <div class="col-md-6">
                                <asp:Button ID="Button5" class="btn btn-lg btn-block btn-success" runat="server" Text="Add to pending" Width="170px" OnClick="Button5_Click" />
                            </div>
                            <div class="col-md-6">
                                <asp:Button ID="Button6" class="btn btn-lg btn-block btn-warning" runat="server" Text="Send Reply" Width="150px" OnClick="Button6_Click" />
                        </div>
                            <br><br>
                           
                            <br>
                        <div class="row">
                             <div class="col-12">
                                 <asp:Button ID="Button7" class="btn btn-lg btn-block btn-danger" runat="server" Text="Remove from pending"  OnClick="Button7_Click" />
                             </div>
                           
                        </div>
                             


                            <br><br><br>

                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <lable>Note</lable>
                                <div class="form-group">
                                   <asp:textbox id="TextBodyNote" runat="server" Width="440px" height="100px" Wrap="true" TextMode="MultiLine" placeholder="Note"></asp:textbox>
 
                                </div>

                            </div>

                        </div>


 
                        <div class="row">
                            <div class="col-6">
                                <asp:Button ID="Button2" class="btn btn-lg btn-block btn-success" runat="server" Text="Add Note" Width="150px" OnClick="Button2_Click" />
                            </div>
                            
                        </div>
                        
                        <br />
                        <div class="row">
                            <div class="col-6">
                                <asp:Button ID="Button9" class="btn btn-lg btn-block btn-primary" runat="server" Text="Download PDF" Width="170px" OnClick="Button9_Click" /> 
                            </div>
                        </div>
                       <br />

                        <div class="row">
                            <div class="col-12">
                                <asp:Button ID="Button4" class="btn btn-lg btn-block btn-danger" runat="server" Text="Delete Inquiry" OnClick="Button4_Click" />
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
                                        <h4>Inquiries</h4>
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
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IsuruProperty_ITPConnectionString %>" SelectCommand="SELECT * FROM [Inquiry_t2]"></asp:SqlDataSource>
                                <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="I_id" DataSourceID="SqlDataSource1">
                                    <Columns>
                                        <asp:BoundField DataField="I_id" HeaderText="ID" ReadOnly="True" SortExpression="I_id" InsertVisible="False"  />
                                        


                                        <%--<asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                                        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                                        <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                                        <asp:BoundField DataField="land_id" HeaderText="land_id" SortExpression="land_id" />
                                        <asp:BoundField DataField="Message" HeaderText="Message" SortExpression="Message" />
                                        <asp:BoundField DataField="Reply" HeaderText="Reply" SortExpression="Reply" />
                                        <asp:BoundField DataField="Note" HeaderText="Note" SortExpression="Note" />--%>


                                        <asp:TemplateField>
                                            <ItemTemplate> 
                                                <div class="container-fluid">
                                                    <div class="row">
                                                        <div class="col-12">
                                                            

                                                            <div class="row">
                                                                <div class="col-6">
                                                                    <asp:Label ID="Label2" runat="server" Text="Customer Name :"></asp:Label> <asp:Label ID="Label1" runat="server" Text='<%# Eval("Name") %>' Font-Bold="True" Font-Size="Large"></asp:Label>
                                                                </div>
                                                                <div class="col-6">
                                                                    <asp:Label ID="Label3" runat="server" Text="Email :"></asp:Label> <asp:Label ID="Label4" runat="server" Text='<%# Eval("Email") %>'></asp:Label>
                                                                </div>
                                                            </div>
                                                            
                                                            <div class="row">
                                                                <div class="col-6">
                                                                    <asp:Label ID="Label5" runat="server" Text="Phone :"></asp:Label> <asp:Label ID="Label6" runat="server" Text='<%# Eval("Phone") %>'></asp:Label>
                                                                </div>
                                                                <div class="col-6">
                                                                    <asp:Label ID="Label7" runat="server" Text="Land ID :"></asp:Label> <asp:Label ID="Label8" runat="server" Text='<%# Eval("land_id") %>'></asp:Label>
                                                                </div>
                                                                
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-12">
                                                                    <asp:Label ID="Label9" runat="server" Text="Message :"></asp:Label> <asp:Label ID="Label10" runat="server" Text='<%# Eval("Message") %>'></asp:Label>
                                                                </div>
                                                                
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-12">
                                                                    <asp:Label ID="Label11" runat="server" Text="Reply :"></asp:Label> <asp:Label ID="Label12" runat="server" Text='<%# Eval("Reply") %>'></asp:Label>
                                                                </div>
                                                            </div>

                                                            <div class="row">
                                                                <div class="col-12">
                                                                    <asp:Label ID="Label13" runat="server" Text="Note :"></asp:Label> <asp:Label ID="Label14" runat="server" Text='<%# Eval("Note") %>'></asp:Label>
                                                                </div>
                                                            </div> 

                                                            

                                                            

                                                            

                                                        </div>
                                                    </div>
                                                </div>
                                                
                                              
                                            </ItemTemplate>
                                        </asp:TemplateField>




                                           
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                        <br><br><br>
                        <div class="row">
                            <div class="col">
                                <center>
                                        <h4>Pending to reply</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:IsuruProperty_ITPConnectionString %>" SelectCommand="SELECT * FROM [Inquiry_pending]"></asp:SqlDataSource>
                                <asp:GridView class="table-striped table-bordered" ID="GridView2" runat="server" DataSourceID="SqlDataSource2" Width="765px" AutoGenerateColumns="False" DataKeyNames="I_id">
                                    <Columns>
                                        <asp:BoundField DataField="I_id" HeaderText="I_id" ReadOnly="True" SortExpression="I_id" />
                                        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
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
