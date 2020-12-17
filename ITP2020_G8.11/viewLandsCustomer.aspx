<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="viewLandsCustomer.aspx.cs" Inherits="ITP2020_G8._11.viewLandsCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

   <script type="text/javascript">
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
   </script>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-md-11 mx-auto">

            <div class="card">
                <div class="card-body">

                    <div class="row">
                        <div class="col">
                            <hr>
                        </div>
                    </div>

                    <div class="row">
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IsuruProperty_ITPConnectionString %>" SelectCommand="SELECT * FROM [Lands]"></asp:SqlDataSource>
                        <div class="col">
                            
                            <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" Width="1340px" AutoGenerateColumns="False" DataKeyNames="Land_id" DataSourceID="SqlDataSource1">
                                <Columns>

                                    <asp:TemplateField>
                                        <ItemTemplate>
                                             <div class="container-fluid">
                                                 <div class="row">
                                                     <div class="col-lg-3">
                                                         <div class="row">
                                                             <div class="col-12">
                                                                 <asp:Label ID="Label17" runat="server" Text="ID : " Font-Bold="True" Font-Size="Medium"></asp:Label><asp:Label ID="Label18" runat="server" Text='<%# Eval("Land_id") %>' Font-Size="Medium"></asp:Label>
                                                             </div>
                                                         </div>
                                                         <div class="row">
                                                             <div class="col-12">
                                                                <asp:Image class="image-fluid p-2" ID="Image1" runat="server" ImageUrl='<%# Eval("Image_file") %>' />
                                                             </div>
                                                         </div>                       
                                                     </div>
                                                     <div class="col-lg-9">
                                                         <div class="row">
                                                             <div class="col-12">
                                                                 <asp:Label ID="Label1" runat="server" Text='<%# Eval("Located_area") %>' Font-Bold="True" Font-Size="X-Large"></asp:Label> <b>(</b><asp:Label ID="Label2" runat="server" Text='<%# Eval("Location") %>' Font-Bold="True" Font-Size="Larger"></asp:Label><b>)</b>
                                                             </div>
                                                         </div>
                                                         <div class="row">
                                                             <div class="col-6">
                                                                 <asp:Label ID="Label3" runat="server" Text="Size(perches) : " Font-Bold="True" Font-Size="Medium"></asp:Label><asp:Label ID="Label5" runat="server" Text='<%# Eval("Land_size") %>' Font-Size="Medium"></asp:Label>
                                                             </div>
                                                             <div class="col-6">
                                                                 <asp:Label ID="Label4" runat="server" Text="Price(/perch) : LKR" Font-Bold="True" Font-Size="Medium"></asp:Label><asp:Label ID="Label6" runat="server" Text='<%# Eval("Land_price") %>' Font-Size="Medium"></asp:Label>
                                                             </div>
                                                         </div>
                                                         <div class="row">
                                                             <div class="col-12">
                                                                 <asp:Label ID="Label7" runat="server" Text="Details : " Font-Bold="True" Font-Size="Medium" ></asp:Label><asp:Label ID="Label8" runat="server" Text='<%# Eval("Land_details") %>' Font-Size="Medium"></asp:Label>
                                                             </div>
                                                         </div>
                                                         <div class="row">
                                                             <div class="col-12">
                                                                 <asp:Label ID="Label9" runat="server" Text="Payment Plan : " Font-Bold="True" Font-Size="Medium"></asp:Label><asp:Label ID="Label10" runat="server" Text='<%# Eval("Payment_plan") %>' Font-Size="Medium"></asp:Label>
                                                             </div>
                                                         </div>
                                                         <div class="row">
                                                             <div class="col-12">
                                                                 <asp:Label ID="Label15" runat="server" Text="Facilities : " Font-Bold="True" Font-Size="Medium"></asp:Label><asp:Label ID="Label16" runat="server" Text='<%# Eval("Facilities") %>' Font-Size="Medium"></asp:Label>
                                                             </div>
                                                         </div>
                                                         <div class="row">
                                                             <div class="col-6">
                                                                 <asp:Label ID="Label11" runat="server" Text="Agent Name : " Font-Bold="True" Font-Size="Medium"></asp:Label><asp:Label ID="Label12" runat="server" Text='<%# Eval("Agent_name") %>' Font-Size="Medium"></asp:Label>
                                                             </div>
                                                             <div class="col-6">
                                                                 <asp:Label ID="Label13" runat="server" Text="Agent Contact No : " Font-Bold="True" Font-Size="Medium"></asp:Label><asp:Label ID="Label14" runat="server" Text='<%# Eval("Agent_contact_number") %>' Font-Size="Medium"></asp:Label>
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



                </div>
            </div>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-md-5 mx-auto">
            <div class="card">
                <div class="card-body">
                    <div class="row">
                        <div class="col-12">
                            <center><h4>SEND US AN INQUIRE</h4></center>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Name" required="true"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Email" required="true"></asp:TextBox><br>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Invalied Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red"></asp:RegularExpressionValidator>
                            </div>
                            
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-6">
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Phone" required="true"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-6">
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Land ID" required="true"></asp:TextBox>
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
