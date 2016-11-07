<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="wfAgregarIncidente.aspx.cs" Inherits="UI.wfAgregarIncidente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 271px;
            height: 44px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        Agrega un nuevo incidente</p>
    <p>
        &nbsp;</p>
    <p>
        Tipo:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </p>
    <p>
        <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server">
        </asp:ScriptManagerProxy>
    </p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
<br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
    <p>
&nbsp;Descripción:
        <textarea id="Descripcion>" class="auto-style1"></textarea>
   
    </p>
    <p>
    </p>
</asp:Content>
