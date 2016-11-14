<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wf_Ingreso.aspx.cs" Inherits="SysMec.Seguridad.wf_Ingreso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:#b4ce9c;">
    <form id="form1" runat="server">
    <div>
    </div>
        <center>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Usuario:  "></asp:Label>
            <asp:TextBox ID="txtUsuario" runat="server" style="margin-left: 20px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Contraseña:  "></asp:Label>
            <asp:TextBox ID="txtClave" runat="server" style="margin-left: 0px"></asp:TextBox>
        </p>
        <p>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Iniciar sesión" Height="42px" Width="197px" />
    
        </p>
        </center>
    </form>
</body>
</html>
