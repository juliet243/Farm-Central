<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="FarmCentral.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

       <section id="main-content" style="height: 563px">
        <section id="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            <div class="col-md-4 col-md-offset-4">
                                <h1>Register </h1>
                            </div>
                        </header>
                        <div class="panel-body">
                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="Name" runat="server" />
                                        <br />
                                        <asp:TextBox runat="server" Enabled="true" required="required" CssClass="form-control input-sm" placeholder="Name" ID="txtName" Height="27px" />
                                    </div>
                                </div>
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label Text="Surname" runat="server" />
                                        <asp:TextBox runat="server" Enabled="true" required="required" CssClass="form-control input-sm" placeholder="Surname" ID="txtSurname" />
                                    </div>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group" style="height: 86px">
                                        <asp:Label Text="Email" runat="server" />
                                        <asp:TextBox runat="server" Enabled="true" required="required" TextMode="Email" CssClass="form-control input-sm" placeholder="Email" ID="txtEmail" Width="202px" />
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Invalid Email Address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                    </div>
                                </div>
                            </div>


                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <asp:Label Text="Role" runat="server" />
                                    <asp:DropDownList runat="server" required="required" CssClass="form-control input-sm" ID="drpDwnRole">
                                        <asp:ListItem Text="Farmer" Value="FarmerRole" />
                                        <asp:ListItem Text="Farm Central Employee" Value="EmployeeRole" />
                                   </asp:DropDownList>
                                </div>
                            </div>


                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <asp:Label Text="Password" runat="server" />
                                    <asp:TextBox runat="server" Enabled="true" required="required" TextMode="Password" CssClass="form-control input-sm" placeholder="Enter Password" ID="txtPassword" />
                                    <asp:Label Text="Confirm Password" runat="server" />
                                    <asp:TextBox runat="server" Enabled="true" required="required" TextMode="Password" CssClass="form-control input-sm" placeholder="Confirm Password" ID="txtConfirmPassword" />
                                </div>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" ErrorMessage="Passwords Do Not Match"></asp:CompareValidator>
                                <br />

                                <div class="col-md-8 col-md-offset-2">
                                    <asp:Button Text="Submit" ID="btnRegister" CssClass="btn btn-primary" Width="170px" runat="server" OnClick="btnRegister_Click"  />

                                </div>
                            </div>


                        </div>
                    </section>
                </div>

            </div>
        </section>

    </section>

</asp:Content>
