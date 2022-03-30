<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="client.aspx.cs" Inherits="demo.client.client" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="main_content_client">

        <h2 class="h2_client">Wellcome Client</h2>

        <asp:GridView class="client_table" ID="GridView1" runat="server" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">

        </asp:GridView>

    </section>

</asp:Content>
