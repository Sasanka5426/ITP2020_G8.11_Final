<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FAQ_Customer.aspx.cs" Inherits="ITP2020_G8._11.FAQ_Customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-md-9 mx-auto">
            <div class="card">
                <div class="card-body">
                    
                    <div class="row">
                        <div class="col-12">
                            <center><b><h4>Frequently Asked Questions</h4></b></center>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-12">
                            <hr />
                        </div>
                    </div>
                    <br />

                    <div class="row">
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IsuruProperty_ITPConnectionString %>" SelectCommand="SELECT * FROM [admin_FAQ_tbl]"></asp:SqlDataSource>
                        <div class="col">
                            <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Qid" DataSourceID="SqlDataSource1">
                                <Columns>
                                    



                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <div class="container-fluid">
                                                <div class="row">
                                                    <div class="col-lg-12">
                                                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Question") %>' Font-Bold="True" Font-Size="Larger"></asp:Label><asp:Label ID="Label2" runat="server" Text="?" Font-Size="Larger" Font-Bold="True"></asp:Label>
                                                    </div>
                                                </div>
                                                <div class="row">
                                                    <div class="col-lg-12">
                                                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("Answer") %>' Font-Size="Larger"></asp:Label>
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

</asp:Content>
