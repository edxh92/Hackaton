<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="UI.login" %>

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
    <div>
        <div id="cuerpo">
		
				
			<div id="fomulario">
		
					
						
						<h1>Login</h1>
						<div class="Entradas">
							<i class="icon-user"></i>
							<!--<input class="text" type="text" name="usuario" placeholder="Usuario" autocomplete="off" required>-->
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="text" placeholder="Usuario"></asp:TextBox>
                            <br>
						</div>
						
						<div class="Entradas">
							<i class="icon-key"></i>
							<!--<input class="text" type="password" name="pass" placeholder="Contraseña" required>-->
                            <asp:TextBox ID="TextBox2" runat="server" CssClass="text" placeholder="Contraseña"></asp:TextBox>
                            <br>
						</div>
						<asp:Button ID="Button1" runat="server" CssClass="button" Text="Iniciar Sesión" OnClick="Button1_Click" />
&nbsp;<div id="registrate">
					 <a href="Registro.aspx">Regístrate ahora!!</a>
				</div>
			</div>
		
		
		
	</div>
    </div>
    </form>
</body>
</html>
