<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MostrarInfo.aspx.cs" Inherits="MostrarInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Fecha inicio:
        <asp:TextBox ID="tbInicio" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Fecha fin:&nbsp;
        <asp:TextBox ID="tbFin" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Reporte" runat="server" OnClick="Reporte_Click" Text="Mostrar Reporte" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btRegresar" runat="server" OnClick="btRegresar_Click" Text="Regresar" />
        <br />
        <br />
    
        Mensajes Enviados:<br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <br />
        <asp:Label ID="lbNoticias" runat="server" Text=" "></asp:Label>
    </div>
    </form>
</body>
</html>
