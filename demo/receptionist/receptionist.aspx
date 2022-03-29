<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="receptionist.aspx.cs" Inherits="demo.receptionist.receptionist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListBox ID="ListBoxReservations" runat="server" Height="153px" Width="221px" ></asp:ListBox>
    <asp:Button ID="ButtonSelect" runat="server" OnClick="ButtonSelect_Click" Text="Select" />
    <asp:Button ID="ButtonAdd" runat="server" Text="Add" OnClick="ButtonAdd_Click"/>
    <asp:Button ID="ButtonUpdate" runat="server" Text="Update book" OnClick="ButtonUpdate_Click" />  
    <asp:Button ID="ButtonDelete" runat="server" OnClick="ButtonDelete_Click" Text="Delete" />
    <asp:TextBox ID="ResIdClient" runat="server"></asp:TextBox>
    <asp:TextBox ID="ResRoom" runat="server"></asp:TextBox>
    <asp:TextBox ID="ResName" runat="server"></asp:TextBox>
    <asp:TextBox ID="ResArrivalDate" runat="server"></asp:TextBox>
    <asp:TextBox ID="ResNights" runat="server"></asp:TextBox>
    <asp:Label ID="stateInfo" runat="server"></asp:Label>
</asp:Content>
