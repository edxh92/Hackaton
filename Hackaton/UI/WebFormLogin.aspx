<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormLogin.aspx.cs" Inherits="UI.WebFormLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    Ingresa tus datos para iniciar sesión<br />
    Nombre de Usuario:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" CausesValidation="True"></asp:TextBox>
    <br />
    <br />
    Contraseña:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server" TextMode="Password" CausesValidation="True" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
    &nbsp;&nbsp;
    <br />
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Iniciar Sesión" />
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
    </asp:GridView>
&nbsp;
</asp:Content>
