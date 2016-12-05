<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Informacion.aspx.cs" Inherits="Informacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <asp:Button ID="btMensaje" runat="server" OnClick="btMensaje_Click" Text="Enviar mensaje" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btBusqueda" runat="server" OnClick="btBusqueda_Click" Text="Busqueda Avanzada" />
    
    </div>
    </form>
</body>
</html>
