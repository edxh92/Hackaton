<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="UI.Registro1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="https://file.myfontastic.com/JKmPkeXtC2xxzgs26Dcm4g/icons.css" rel="stylesheet"/>
    <link rel="stylesheet" type="text/css" href="css/stylesheet1.css"/>
</head>
<body>
     
    <form id="form1" runat="server">

        <div id="fomulario">
		
					
						
						<h1>Registro</h1>
						<div class="Entradas">
							<i class="icon-user"></i>
							<!--<input class="text" type="text" name="usuario" placeholder="Usuario" autocomplete="off" required>-->
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="text" placeholder="Usuario"></asp:TextBox>
                            <br>
						</div>
						<div class="Entradas">
							<i class="icon-user"></i>
							<!--<input class="text" type="text" name="usuario" placeholder="Usuario" autocomplete="off" required>-->
                            <asp:TextBox ID="TextBox3" runat="server" CssClass="text" placeholder="Correo"></asp:TextBox>
                            <br>
						</div>
						<div class="Entradas">
							<i class="icon-key"></i>
							<!--<input class="text" type="password" name="pass" placeholder="Contraseña" required>-->
                            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" CssClass="text" placeholder="Contraseña"></asp:TextBox>
                            <br>
						    
						</div>
                        <div class="Entradas">
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/images.png" />
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                            <br />
                         </div>
            <IMG height="30" alt="" src=BuildCaptcha.aspx width="80">
						<asp:textbox runat="Server" ID="txtCaptcha"/>
         <asp:Button runat="Server" ID="btnSubmit" OnClick="btnSubmit_Click" Text="Registrar" CssClass="button" EnableTheming="False" />
&nbsp;<div id="registrate">
					 <a href="Registro.aspx">Regístrate ahora!!</a>
				</div>
			</div>
		
		
	




        
    </form>
    <div>
            
    </div>
</body>
</html>
