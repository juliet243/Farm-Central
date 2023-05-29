<%@ Page Language="C#" CodeBehind="AddNewProduct.aspx.cs" Inherits="FarmCentral.AddNewProduct" %>


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
                        <li class="nav-item"><a class="nav-link" runat="server" href="~/FarmersUI" style="font-family: 'Arial Rounded MT Bold'">Farm Central</a></li>

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

                            <div>

                                <div class="row">
                                    <div class="col-md-4 col-md-offset-1">
                                        <asp:Label Text="Select Category " runat="server" />
                                        <asp:DropDownList runat="server" required="required" CssClass="form-control input-sm" ID="drpDwnProductCtgry">
                                            <asp:ListItem Text="All" Value="prdctAll" />
                                            <asp:ListItem Text="Fruits" Value="FruitsCategory" />
                                            <asp:ListItem Text="Vegetables" Value="VegetablesCategory" />
                                            <asp:ListItem Text="Dairy" Value="DairyCategory" />
                                            <asp:ListItem Text="Meat" Value="MeatCategory" />
                                        </asp:DropDownList>
                                    </div>
                                </div>

                                <div class="row">
                                    <div class="col-md-4 col-md-offset-1">
                                        <div class="form-group">
                                            <asp:Label Text="Item Name" runat="server" />
                                            <asp:TextBox runat="server" Enabled="true" required="required" CssClass="form-control input-sm" placeholder="Write Item Name e.g Apples" ID="txtItemNameAdded" />
                                            <br />
                                            <asp:Label Text="Item Quantity" runat="server" />
                                            <asp:TextBox runat="server" Enabled="true" required="required" CssClass="form-control" TextMode="Number" placeholder="Write Item Quantity e.g 50" ID="txtItemQtyAdded" />
                                            <br />
                                             <asp:Button Text="Submit" ID="btnAddNewPrdct" CssClass="btn btn-primary" Width="170px" runat="server" OnClick="btnAddNewPrdct_Click"/>
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
</body>
</html>
