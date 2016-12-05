<%@ Page Language="C#" AutoEventWireup="true" CodeFile="menu.aspx.cs" Inherits="menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Menu de inicio<br />
        <br />
        <asp:Button ID="btAlta" runat="server" OnClick="btAlta_Click" Text="Alta" />
        <br />
        <br />
        <asp:Button ID="btBaja" runat="server" OnClick="btBaja_Click" Text="Baja" />
        <br />
        <br />
        <asp:Button ID="btModificaciones" runat="server" OnClick="btModificaciones_Click" Text="Modificaciones" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <asp:Label ID="lbNoticias" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
