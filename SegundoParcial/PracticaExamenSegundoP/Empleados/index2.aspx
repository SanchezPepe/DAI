﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index2.aspx.cs" Inherits="index2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Reporte final de sueldos<br />
        <br />
    
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <br />
        <asp:Label ID="lbNoticias" runat="server" Text=" "></asp:Label>
    
        <asp:Button ID="Button1" runat="server" Text="Regresar" OnClick="Button1_Click" />
    
    </div>
    </form>
</body>
</html>
