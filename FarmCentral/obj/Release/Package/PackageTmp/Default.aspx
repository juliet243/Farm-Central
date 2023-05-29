<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FarmCentral._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 style="text-align: center; color: #FFFFFF; background-color: #000000;" id="aspnetTitle" style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; text-decoration: blink">FARM CENTRAL</h1>
            <h3 style="text-align: center">Welcome To Our Farming Stock Management Web Application!</h3>
            <h5 style="text-align: center">Our application is designed to simplify and streamline the management of your farming stock.</h5>
            <h5 style="text-align: center">Whether you have a small family farm or a large-scale agricultural operation, our platform provides you with the tools and features to effectively monitor and track your inventory.</h5>
            <h3 style="text-align: center; font-family: 'Arial Rounded MT Bold'; background-color: #808080;">Please Register or Login To Access Full Website</h3>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:Button Text="Login" ID="btnLogin" CssClass="btn btn-primary" Width="170px" runat="server" OnClick="btnLogin_Click"   />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button Text="Register" ID="Button1" CssClass="btn btn-primary" Width="170px" runat="server" OnClick="Button1_Click"  />
            
        </section>
     

    </main>

</asp:Content>
