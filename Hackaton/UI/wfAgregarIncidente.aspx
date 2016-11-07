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
            Tipo:
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" class="form-control" Height="26px" Width="933px"></asp:TextBox>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
      <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
<br __designer:mapid="8d" />
            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
    <p>
        &nbsp;</p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <br />
            <asp:Label ID="lblTipoIncidente" runat="server" class="form-control"></asp:Label>
        </ContentTemplate>
    </asp:UpdatePanel>
    <p>
&nbsp;Descripción:
           
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
