<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="manageLandsAdmin.aspx.cs" Inherits="ITP2020_G8._11.manageLandsAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
      <div class="row">
         <div class="col-md-5">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Manage Land Details</h4>
                        </center>
                     </div>
                  </div>


                  
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  
                  <div class="row">
                     <div class="col-md-3">
                        <label>Land ID</label><asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="  *Invalid ID*" ForeColor="#CC0000" ValidationExpression="\d{5}"></asp:RegularExpressionValidator>
                        <div class="form-group">

                           <div class="input-group">
                              <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Land ID"></asp:TextBox>
                                <asp:LinkButton class="btn btn-primary" ID="LinkButton4" runat="server"  Width="40px" OnClick="LinkButton4_Click"><i class="fas fa-check-circle"></i></asp:LinkButton>
                           </div>
                        </div>
                     </div>
                     <div class="col-md-9">
                        <label>Located Area </label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Located Area"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                    <div class="row">
                                <div class="col">
                                    
                                    <label>Add image :</label>
                                    
                                    <asp:FileUpload  CssClass="auto-style2" ID="FileUpload1" runat="server" />
                                </div>
                            </div> 
                   <div class="row">
                    <div class="col-md-6">
                        <label>Location </label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox8" runat="server" placeholder="Location"></asp:TextBox>
                        </div>
                     </div>

                       <div class="col-md-6">
                        <label>Land Size </label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox12" runat="server" placeholder="Land Size"></asp:TextBox>
                        </div>
                     </div>

                    </div>
                  
                  <div class="row">
                     <div class="col-md-4">
                        <label>Land Price</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox9" runat="server" placeholder="Land Price"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-8">
                        <label>Payment Plan</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox10" runat="server"   Height="100px" Wrap="true" TextMode="MultiLine" placeholder="Payment Plan"></asp:TextBox>
                        </div>
                     </div>
                    
                  </div>
                  <div class="row">
                     <div class="col-md-6">
                        <label>Agent Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Agent Name" ></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Agent Contact Number</label><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="  *Invalid Number*" ForeColor="#CC0000" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
&nbsp;<div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="Agent Contact Number"></asp:TextBox>
                        </div>
                     </div>
              
                  </div>
                  <div class="row">
                     <div class="col-6">
                        <label>Land Description</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" Width="100%" Height="100px" Wrap="true" placeholder="Land Description" TextMode="MultiLine" ></asp:TextBox>
                        </div>
                     </div>
                       <div class="col-6">
                        <label>Facilities</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" Width="100%" Height="100px" Wrap="true" placeholder="Facilities" TextMode="MultiLine" ></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-4">
                         <asp:Button ID="Button1" class="btn btn-lg btn-block btn-success" runat="server" Text="Add" OnClick="Button1_Click"  />
                     </div>
                     <div class="col-4">
                        <asp:Button ID="Button3" class="btn btn-lg btn-block btn-warning" runat="server" Text="Update" OnClick="Button3_Click"  />
                     </div>
                     <div class="col-4">
                        <asp:Button ID="Button2" class="btn btn-lg btn-block btn-danger" runat="server" Text="Delete" OnClick="Button2_Click"  />
                     </div>
                      </div>
                    <br />

                   <div class="row">
                      <div class="col-4">
                        <asp:Button ID="Button4" class="btn btn-lg btn-block btn-primary" runat="server" Text="Report" OnClick="Button4_Click"    />
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
                           <h4>Land List</h4>
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
                         <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:IsuruProperty_ITPConnectionString %>" SelectCommand="SELECT * FROM [Lands]"></asp:SqlDataSource>
                        <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
                            <Columns>
                                <asp:BoundField DataField="Land_id" HeaderText="Land ID" SortExpression="Land_id" />
                                
                                <asp:TemplateField>
                                    <ItemTemplate>
                                       <div class="container-fluid">
                                               <div class="row">
                                                   <div class="col-lg-10">
                                                       <div class="row">
                                                           <div class="col-lg-12">
                                                               Located Area-<asp:Label ID="Label1" runat="server" Text='<%# Eval("Located_area") %>' Font-Bold="True" Font-Size="X-Large"></asp:Label>
                                                               &nbsp;| Location-<asp:Label ID="Label2" runat="server" Font-Bold="True" Text='<%# Eval("Location") %>'></asp:Label>
                                                               &nbsp;| Price-<asp:Label ID="Label3" runat="server" Font-Bold="True" Text='<%# Eval("Land_price") %>'></asp:Label>
                                                               &nbsp;| Land Size-<asp:Label ID="Label4" runat="server" Font-Bold="True" Text='<%# Eval("Land_size") %>'></asp:Label>
                                                           </div>
                                                      </div>
                                                       <div class="row">
                                                           <div class="col-lg-12">

                                                               Land Details-<asp:Label ID="Label5" runat="server" Font-Bold="True" Text='<%# Eval("Land_details") %>'></asp:Label>

                                                           </div>
                                                      </div>
                                                       <div class="row">
                                                           <div class="col-lg-12">

                                                               Payment Plan-<asp:Label ID="Label6" runat="server" Font-Bold="True" Text='<%# Eval("Payment_plan") %>'></asp:Label>
                                                               &nbsp;| Facilities-<asp:Label ID="Label7" runat="server" Font-Bold="True" Text='<%# Eval("Facilities") %>'></asp:Label>

                                                           </div>
                                                      </div>
                                                       <div class="row">
                                                           <div class="col-lg-12">

                                                               &nbsp;Agent Name-<asp:Label ID="Label9" runat="server" Font-Bold="True" Text='<%# Eval("Agent_name") %>'></asp:Label>
                                                               &nbsp;| Agent Contact Number-<asp:Label ID="Label8" runat="server" Font-Bold="True" Text='<%# Eval("Agent_contact_number") %>'></asp:Label>

                                                           </div>
                                                      </div>

                                                   </div>
                                                   <div class="col-lg-2">
                                                       <asp:Image Class="img-fluid" ID="Image1" runat="server" ImageUrl='<%# Eval("Image_file") %>' />

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
   </div>

</asp:Content>
