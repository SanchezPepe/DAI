<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Alta.aspx.cs" Inherits="Alta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Bienvenido!<br />
        <br />
        Alta de usuario<br />
        <br />
        Correo:&nbsp;
        <asp:TextBox ID="tbCorreo" runat="server"></asp:TextBox>
        <br />
        <br />
        Contraseña:
        <asp:TextBox ID="tbCont" runat="server"></asp:TextBox>
        <br />
        <br />
        Nombre:
        <asp:TextBox ID="tbNombre" runat="server"></asp:TextBox>
        <br />
        <br />
        Sexo:
        <asp:TextBox ID="tbSexo" runat="server"></asp:TextBox>
        <br />
        <br />
        Edad:
        <asp:TextBox ID="tbEdad" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btAgregar" runat="server" OnClick="btAgregar_Click" Text="Agregar" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btRegresar" runat="server" OnClick="btRegresar_Click" Text="Regresar" />
        <br />
        <br />
        <asp:Label ID="lbNoticias" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
