<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Autentificación:<br />
        <br />
        Clave única:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbClaveU" runat="server"></asp:TextBox>
        <br />
        <br />
        Contraseña:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbContraseña" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btEntrar" runat="server" OnClick="btEntrar_Click" Text="Entrar" />
    
    </div>
    </form>
</body>
</html>
