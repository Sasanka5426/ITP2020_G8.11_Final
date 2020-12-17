<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FAQ_admin.aspx.cs" Inherits="ITP2020_G8._11.FAQ_admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {

            //$(document).ready(function () {
                //$('.table').DataTable();
            //});

            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
            //$('.table1').DataTable();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <br>
        <center><h2><b>Frequantly Asked Questions</b></h2></center>
        <br />
        <div class="row">
            <div class="col-md-5">

                <div class="card">
                    <div class ="card body">
                        
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>FAQ Details</h4>
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
                                <label>Question ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Qid"></asp:TextBox>
                                        <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Search" OnClick="Button1_Click"   />
                                    </div>
                                </div>
                            </div>
 
                            <div class="col-md-8">
                                <label>Question</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Question"></asp:TextBox>
 
                                </div>
                            </div>

                            <div class="col-md-12">
                                <label>Answer</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Answer"></asp:TextBox>
 
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

                    </div>

                </div>


            </div>
        
            <div class="col-md-7">
 
                <div class="card">
                    <div class="card-body">
 
 
 
                        <div class="row">
                            <div class="col">
                                <center>
                                        <h4>FAQ List</h4>
                                    </center>
                            </div>
                        </div>
 
                       
 
                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>
 
                        <div class="row">

                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IsuruProperty_ITPConnectionString %>" SelectCommand="SELECT * FROM [admin_FAQ_tbl]"></asp:SqlDataSource>
                            <div class="col">
                                <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Qid" DataSourceID="SqlDataSource1">
                                    <Columns>
                                        <asp:BoundField DataField="Qid" HeaderText="Qid" ReadOnly="True" SortExpression="Qid" />
                                        <asp:BoundField DataField="Question" HeaderText="Question" SortExpression="Question" />
                                        <asp:BoundField DataField="Answer" HeaderText="Answer" SortExpression="Answer" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
 
                    </div>
                </div>  
           
                <br />
               
           </div>
               
           <div class="col-md-2">
                <asp:Button ID="Button5" class="btn btn-lg btn-block btn-danger" runat="server" Text="Print PDF" OnClick="Button5_Click" />
                <br />

           </div>
            
        </div>

  </div>

</asp:Content>
