<%@ Page Language="C#"  CodeBehind="EmployeesUI.aspx.cs" Inherits="FarmCentral.EmployeesUI" %>


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

                            <div class="panel-body">

                                <div class="row">
                                    <div class="col-md-4 col-md-offset-1">
                                        <h3 id="aspnetTitle" style="text-align: center">FARM-CENTRAL EMPLOYEES</h3>
                                        <p>&nbsp;</p>
                                        <p style="text-align: center"><a href="https://localhost:44369/AddFarmer" class="btn btn-primary btn-md">Add New Farmer &raquo;</a></p>
                                        <p style="text-align: center"><a href="https://localhost:44369/DisplayProducts" class="btn btn-primary btn-md">Display Products &raquo;</a></p>
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














