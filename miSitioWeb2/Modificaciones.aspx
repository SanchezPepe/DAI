<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Modificaciones.aspx.cs" Inherits="Modificaciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Modificar contraseña<br />
        <br />
        Usuario:
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        Contraseña anterior:<asp:TextBox ID="tbAnterior" runat="server"></asp:TextBox>
        <br />
        <br />
        Contraseña nueva:<asp:TextBox ID="tbNueva" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btModificar" runat="server" OnClick="btModificar_Click" Text="Modificar" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btRegresar" runat="server" OnClick="btRegresar_Click" Text="Regresar" />
        <br />
        <br />
        <asp:Label ID="lbNoticias" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
