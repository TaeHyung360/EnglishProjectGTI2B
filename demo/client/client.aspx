<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="client.aspx.cs" Inherits="demo.client.client" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Hello Client!!!"></asp:Label>
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
