<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="demo.contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="main_content_contact">

        <h2 class="h2_contact">Contact us</h2>

        <p>Contact our sales team for more information and enquiries into the exciting opportunities of the Abama resort.</p>

        <p>+34 922 849 157</p>

        <asp:Image class="imagePc" ID="Image1" runat="server" src="Images/image_contact.png" Height="650px" Width="1000px"/>

        <asp:Image class="imageTablet" ID="Image2" runat="server" src="Images/image_contact.png" Height="300px" Width="400px"/>

    </section>

</asp:Content>

