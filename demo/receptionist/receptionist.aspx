<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="receptionist.aspx.cs" Inherits="demo.receptionist.receptionist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Hello Receptionist!!!"></asp:Label>
    <asp:ListBox ID="ListBoxReservations" runat="server"></asp:ListBox>
    <asp:Button ID="Button1" runat="server" Text="Add book" />
    <asp:Button ID="Button2" runat="server" Text="Update book" />
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
