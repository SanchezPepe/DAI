<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Baja.aspx.cs" Inherits="Baja" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Forma para dar de baja un usuario<br />
        <br />
        Usuario:
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btBaja" runat="server" OnClick="btBaja_Click" Text="Baja" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btRegresar" runat="server" OnClick="btRegresar_Click" Text="Regresar" />
        <br />
        <br />
        <asp:Label ID="lbNoticias" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
