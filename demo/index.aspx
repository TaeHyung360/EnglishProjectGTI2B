<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="demo.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <span>Here goes the content of the INDEX PAGE !!!!!!!!!!!</span>
    <asp:TextBox ID="txtBox" runat="server" CssClass="txtboxok"></asp:TextBox>
    <asp:Button ID="button" runat="server" Text="OK" CssClass="buttonok" OnClick="button_Click"/>
</asp:Content>
