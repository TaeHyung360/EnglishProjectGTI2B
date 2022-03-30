<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="demo.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="main_content_login">

        <h2 class="h2_login">Login Page</h2>

        <div>

            <input id="txtUserName" class="inputTxt" placeholder="  User" type="text" runat="server">

            <br />

        </div>

        <div>

            <input id="txtUserPass" class="inputTxt" placeholder="  Password" type="password" runat="server">
            
        </div>

         <asp:Label ID="Warninglogin" runat="server" Text=""></asp:Label>

        <br />

        <asp:Label class="logLogin" ID="log_login" runat="server" Text=""></asp:Label>

        <asp:Button class="btn" ID="Button1" Text="Login" OnClick="button_Click_Login" runat="server"/>

    </section>

</asp:Content>
