<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Mensajes.aspx.cs" Inherits="Mensajes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Nuevo Mensaje<br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Contactos"></asp:Label>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Height="20px" Width="143px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Asunto: "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbAsunto" runat="server" Height="20px" Width="199px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Mensaje: "></asp:Label>
        <br />
        <asp:TextBox ID="tbMensaje" runat="server" Height="137px" Width="294px"></asp:TextBox>
    
        <br />
        <br />
        <asp:Button ID="btEnviar" runat="server" Text="Enviar" OnClick="btEnviar_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Cancelar" OnClick="Button2_Click" />
    
        <br />
        <br />
        <asp:Label ID="lbNoticias" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
