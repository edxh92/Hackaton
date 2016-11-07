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
     <IMG height="30" alt="" src=BuildCaptcha.aspx width="80">
    <form id="form1" runat="server">
        <asp:textbox runat="Server" ID="txtCaptcha"/>
         <asp:Button runat="Server" ID="btnSubmit" OnClick="btnSubmit_Click" Text="Submit" />
    </form>
    <div>
            
    </div>
</body>
</html>
