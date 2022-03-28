<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="demo.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>

        <h2>Login Page</h2>

        <div>

            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>

            <input id="txtUserName" type="text" runat="server">

            <br />

        </div>

        <div>

            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>

            <input id="txtUserPass" type="password" runat="server">
            
        </div>

         <asp:Label ID="Warninglogin" runat="server" Text=""></asp:Label>

        <br />

        <asp:Button ID="Button1" Text="Login" OnClick="button_Click_Login" runat="server"/>

    </section>
</asp:Content>
