<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="receptionist.aspx.cs" Inherits="demo.receptionist.receptionist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="main_content_recptionist">

        <h2 class="h2_receptionist">Wellcome Receptionist</h2>

        <div class="content_recption">

                <div class="content_txt_btn">

                    <div>

                        <asp:ListBox class="listbox" ID="ListBoxReservations" runat="server"></asp:ListBox>

                    </div>

                    <div class="content_txt_box_reception">

                        <div class="content_txt_left">

                        <p>Id client: </p>
                        <asp:TextBox class="inputTxt_reception" ID="ResIdClient" runat="server"></asp:TextBox>
                        <p>Id room: </p>
                        <asp:TextBox class="inputTxt_reception" ID="ResRoom" runat="server"></asp:TextBox>
                        <p>Id book name: </p>
                        <asp:TextBox class="inputTxt_reception" ID="ResName" runat="server"></asp:TextBox>

                        </div>

                    <div class="content_txt_rigth">

                        <p>Arrival date: </p>
                        <asp:TextBox class="inputTxt_reception" ID="ResArrivalDate" runat="server"></asp:TextBox>
                        <p>Nights: </p>
                        <asp:TextBox class="inputTxt_reception" ID="ResNights" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label class="out_text" ID="stateInfo" runat="server"></asp:Label>
                    </div>

                </div>

                     <div class="btn_container">

                        <asp:Button class="btn_select" ID="ButtonSelect" runat="server" OnClick="ButtonSelect_Click" Text="Select" />
                        <asp:Button class="btn_add" ID="ButtonAdd" runat="server" Text="Add" OnClick="ButtonAdd_Click"/>
                        <asp:Button class="btn_update" ID="ButtonUpdate" runat="server" Text="Update book" OnClick="ButtonUpdate_Click" />  
                        <asp:Button class="btn_delete" ID="ButtonDelete" runat="server" OnClick="ButtonDelete_Click" Text="Delete" />

                    </div>

          </div>
                
          </div>

    </section>
    
</asp:Content>
