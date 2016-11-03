<%@ Page Language="C#" AutoEventWireup="true" CodeFile="inicio.aspx.cs" Inherits="inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Comida Ingenierias<br />
        <br />
        Carrera:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="192px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lbnoticias" runat="server" Text=" "></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Siguiente" OnClick="Button1_Click" />
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Por universidad" />
            
    </div>
    </form>
</body>
</html>