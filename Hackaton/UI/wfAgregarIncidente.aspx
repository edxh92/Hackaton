<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="wfAgregarIncidente.aspx.cs" Inherits="UI.wfAgregarIncidente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            display: block;
            width: 78%;
            height: 38px;
            padding: 6px 12px;
            font-size: 14px;
            line-height: 1.42857143;
            color: #555;
            background-color: #fff;
            background-image: none;
            border: 1px solid #ccc;
            border-radius: 4px;
            -webkit-box-shadow: inset 0 1px 1px rgba(0,0,0,.075);
            box-shadow: inset 0 1px 1px rgba(0,0,0,.075);
            -webkit-transition: border-color ease-in-out .15s,-webkit-box-shadow ease-in-out .15s;
            -o-transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
            transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="form-group">
      <p>
        <br />
        Agrega un nuevo incidente</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server">
        </asp:ScriptManagerProxy>
    </p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            Tipo:
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" class="form-control" Height="26px" Width="933px"></asp:TextBox>
<br />
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
            <br />
            <asp:Label ID="lblTipoIncidente" runat="server" class="form-control"></asp:Label>
        </ContentTemplate>
    </asp:UpdatePanel>
    <p>
&nbsp;Descripción:
           
    </p>
      <p>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo Requerido" class="text-danger">Campo obligatorio</asp:RequiredFieldValidator>
   
    </p>
      <p>
          &nbsp;<textarea id="Descripcion>"  class="auto-style1"></textarea>
   
    </p>
      <p>
        <asp:Button ID="Button1" runat="server" Text="Enviar"  class="btn btn-default"/>
    </p>
      </div>
    <p>
    </p>
    
</asp:Content>
