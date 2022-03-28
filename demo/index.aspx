<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="demo.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="mainContent">

        <h2>The jewel of Tenerife and one of Europe's best-kept secrets</h2>

    <br />

    <p>
        Abama Resort Tenerife is an exclusive 400-acre vacation and residential destination offering Michelin-star dining and world-class service to those who prefer tranquillity over fanfare. 
        And with the majority of our terrain dedicated to our luxury properties, this is an ideal place to live or visit. Our undisturbed beach, sumptuous spa and year-round springtime climate provide 
        a welcome retreat just a few travel hours from most major European cities.
    </p>
    <br />


        <asp:Button ID="btn_reservation_page" runat="server" Text="Book Now" OnClick="button_Click_reservation"/>
    </div>
</asp:Content>
