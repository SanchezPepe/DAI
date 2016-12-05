<%@ Page Language="C#" AutoEventWireup="true" CodeFile="reporte2.aspx.cs" Inherits="reporte2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Asistentes otros/externos<br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <br />
        Total recaudado: $
        <asp:Label ID="lbtotal" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Regresar" />
    </form>
</body>
</html>
