<%@ Page Language="C#" CodeBehind="DisplayProducts.aspx.cs" Inherits="FarmCentral.DisplayProducts" %>


<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title><%: Page.Title %>- My ASP.NET Application</title>

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>

    <webopt:BundleReference runat="server" Path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />

</head>
<body>
    <form runat="server">
        <div style="background-image: url(Images/farming.jpg); height: 653px">

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
                            <header class="panel-heading">
                                <div class="col-md-4 col-md-offset-5">
                                    <h1>Display Products</h1>
                                </div>
                            </header>
                            <br />
                            <br />

                            <div class="panel-body">

                                <div class="row">
                                    <div class="col-md-4 col-md-offset-1">
                                        <div class="form-group">
                                            <asp:Label Text="Name" runat="server" />
                                            <br />
                                            <asp:TextBox runat="server" Enabled="true" required="required" TextMode="Email" CssClass="form-control input-sm" placeholder="Enter Farmer Email" ID="txtEmail" Height="27px" />
                                        </div>
                                    </div>
                             
                                </div>
                                <div class="row">
                                    <div class="col-md-4 col-md-offset-1">
                                        <asp:Label Text="Select Category To Display" runat="server" />
                                        <asp:DropDownList runat="server" required="required" CssClass="form-control input-sm" ID="drpDwnProductCategory">
                                            <asp:ListItem Text="DisplayAll" Value="DisplayAll" />
                                            <asp:ListItem Text="Fruits" Value="DisplayFruits" />
                                            <asp:ListItem Text="Vegetables" Value="DisplayVegetables" />
                                            <asp:ListItem Text="Dairy" Value="DisplayDairy" />
                                            <asp:ListItem Text="Meat" Value="DisplayMeat" />
                                        </asp:DropDownList>
                                    </div>
                                </div>

                                <div class="col-md-8 col-md-offset-2">
                                    <asp:Button Text="Display Products" ID="btnDsplyProd" CssClass="btn btn-primary" Width="170px" runat="server" OnClick="btnDsplyProd_Click" />
                                    <td>
                                        <asp:GridView ID="gVDisplay" runat="server" Height="282px" Width="525px" CellPadding="3" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px">
                                            <AlternatingRowStyle BackColor="#CCCCCC" />
                                            <FooterStyle BackColor="#CCCCCC" />
                                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                            <SortedAscendingHeaderStyle BackColor="#808080" />
                                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                            <SortedDescendingHeaderStyle BackColor="#383838" />
                                        </asp:GridView>
                                    </td>

                                </div>


                            </div>
                        </section>
                    </div>

                </section>

            </section>
        </div>
    </form>
</body>
</html>
