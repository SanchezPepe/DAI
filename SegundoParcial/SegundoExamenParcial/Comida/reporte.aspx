﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="reporte.aspx.cs" Inherits="reporte" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Asistentes:<br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    
        <br />
    
        <br />
        <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Regresar" />
        <br />
    
    </div>
    </form>
</body>
</html>
