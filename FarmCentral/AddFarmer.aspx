<%@ Page Language="C#" CodeBehind="AddFarmer.aspx.cs" Inherits="FarmCentral.AddFarmer" %>

<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title><%: Page.Title %> - My ASP.NET Application</title>

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>

    <webopt:BundleReference runat="server" Path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />

</head>
<body>
    <form runat="server">
        <div style="background-image: url(Images/farming.jpg); height: 653px">
            <asp:ScriptManager runat="server">
                <Scripts>
                    <%--To learn more about bundling scripts in ScriptManager see https://go.microsoft.com/fwlink/?LinkID=301884 --%>
                    <%--Framework Scripts--%>
                    <asp:ScriptReference Name="MsAjaxBundle" />
                    <asp:ScriptReference Name="jquery" />
                    <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
                    <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
                    <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
                    <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
                    <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
                    <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
                    <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
                    <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
                    <asp:ScriptReference Name="WebFormsBundle" />
                    <%--Site Scripts--%>
                </Scripts>
            </asp:ScriptManager>



            <nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark">
                <div class="container">
                    <ul class="navbar-nav flex-grow-1">
                        <li class="nav-item"><a class="nav-link" runat="server" href="~/EmployeesUI" style="font-family: 'Arial Rounded MT Bold'">Farm Central</a></li>

                    </ul>
                    <button type="button" class="navbar-toggler" data-bs-toggle="collapse" data-bs-target=".navbar-collapse" title="Toggle navigation" aria-controls="navbarSupportedContent"
                        aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>
                    <div class="collapse navbar-collapse d-sm-inline-flex justify-content-between">
                        <ul class="navbar-nav flex-grow-1" dir="rtl">
                            <li class="nav-item"><a class="nav-link" runat="server" href="~/Default" style="font-family: 'Arial Rounded MT Bold'">Sign Out</a></li>

                        </ul>
                    </div>
                </div>
            </nav>

            <section id="main-content">
                <section id="wrapper">
                    <div class="col-lg-12">
                        <section class="panel">

                            <br />
                            <br />

                            <div class="panel-body">

                                <div class="row">
                                    <div class="col-md-4 col-md-offset-1">
                                        <div class="form-group">
                                            <asp:Label Text="Farmer Name" runat="server" />
                                            <asp:TextBox runat="server" Enabled="true" required="required" CssClass="form-control input-sm" placeholder="Name" ID="txtFarmrNameAdded" />
                                            <asp:Label Text="Farmer Surname" runat="server" />
                                            <asp:TextBox runat="server" Enabled="true" required="required" CssClass="form-control input-sm" placeholder="Surname" ID="txtFarmerSurnameAdded" />
                                            <asp:Label Text="Email" runat="server" />
                                            <asp:TextBox runat="server" Enabled="true" required="required" TextMode="Email" CssClass="form-control input-sm" placeholder="Email" ID="txtFarmerEmalAdded" Width="1311px" />
                                            <asp:Label Text="Password" runat="server" />
                                            <asp:TextBox runat="server" Enabled="true" required="required" TextMode="Password" CssClass="form-control input-sm" placeholder="Enter Password" ID="txtPasswrd" />
                                            <asp:Label Text="Confirm Password" runat="server" />
                                            <asp:TextBox runat="server" Enabled="true" required="required" TextMode="Password" CssClass="form-control input-sm" placeholder="Confirm Password" ID="txtConfirmPassword" />
                                            <br />
                                            <asp:Button Text="SAVE" ID="btnSave" CssClass="btn btn-primary" Width="170px" runat="server" OnClick="btnSaveFarmer_Click" />
                                        </div>
                                    </div>

                                </div>

                            </div>
                        </section>
                    </div>

                </section>

            </section>


        </div>
    </form>
    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/Scripts/bootstrap.js") %>
    </asp:PlaceHolder>
</body>
</html>


