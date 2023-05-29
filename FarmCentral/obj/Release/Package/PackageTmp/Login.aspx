<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FarmCentral.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section id="main-content">
        <section id="wrapper">
            <div class="col-lg-12">
                <section class="panel">
                    <header class ="panel-heading">
                        <div class ="col-md-4 col-md-offset-5">
                            <h1> Login</h1>
                        </div>
                    </header>
                     <br />
                     <br />

                    <div class="panel-body">
                       
                        <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <asp:Label Text="Select User Role" runat="server" />
                                    <asp:DropDownList runat="server" required="required" CssClass="form-control input-sm" ID="drpDwnRoleLogin">
                                        <asp:ListItem Text="Farmer" Value="FarmerRole" />
                                        <asp:ListItem Text="Farm Central Employee" Value="EmployeeRole" />
                                    </asp:DropDownList>

                                </div>

                            </div>

                        <div class ="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class ="form-group">
                                        <asp:Label Text="Email" runat="server" />
                                        <asp:TextBox runat="server" Enabled="true" required="required" TextMode="Email" CssClass ="form-control input-sm" placeholder="Email" ID="txtEmailLogin" />
                                    </div>
                                </div>

                            </div>

                         <div class ="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class ="form-group">
                                        <asp:Label Text="Password" runat="server" />
                                        <asp:TextBox runat="server" Enabled="true" required="required" TextMode="Password" CssClass ="form-control input-sm" placeholder="Enter Password" ID="txtPasswrdLogin" />
                                    </div>
                                </div>

                            </div>

                         <div class="row">
                                  <div class="col-md-8 col-md-offset-2">
                                        <asp:Button Text="Login" ID="btnLogin" CssClass="btn btn-primary" Width="170px" runat="server" OnClick="btnLogin_Click" />        
                                </div>
                             
                            </div>

                    </div>
                </section>
            </div>

        </section>

    </section>


</asp:Content>
