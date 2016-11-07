<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="wfAgregarIncidente.aspx.cs" Inherits="UI.wfAgregarIncidente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="form-group">
      <p>
        <br />
        Agrega un nuevo incidente</p>
    <p>
        &nbsp;</p>
            Tipo:<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Height="19px" Width="323px">
      </asp:DropDownList>
      Nivel<asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True">
          <asp:ListItem>Positivo</asp:ListItem>
          <asp:ListItem>Negativo</asp:ListItem>
      </asp:DropDownList>
&nbsp;<asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
      <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
<br __designer:mapid="8d" />
    <p>
        &nbsp;</p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <br />
            <asp:Label ID="lblTipoIncidente" runat="server" class="form-control"></asp:Label>
        </ContentTemplate>
    </asp:UpdatePanel>
    <p>
&nbsp;</p>
      <p>
          &nbsp;</p>
      <p>
          Descripción:
           
    </p>
      <p>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo Requerido" class="text-danger" ControlToValidate="TextBox2">Campo obligatorio</asp:RequiredFieldValidator>
   
    </p>
      <p>
          &nbsp;<asp:TextBox ID="TextBox2" TextMode="MultiLine" runat="server" Height="63px" Rows="5" Width="1020px" class="form-control"></asp:TextBox>
          &nbsp;</p>
      <p>
        <asp:Button ID="Button1" runat="server" Text="Enviar"  class="btn btn-default" OnClick="Button1_Click"/>
    </p>
      </div>
    <p>
    </p>
    
</asp:Content>
