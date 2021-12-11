<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLectores.aspx.cs" Inherits="EjercicioASP2.Presentacion.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 621px">
    <form id="form1" runat="server">
        <div>
            <h1>Lectores</h1>
            <div>
                <asp:Label for="IdLector" ID="Label1" runat="server">ID Lector</asp:Label>
                <asp:TextBox ID="txtIdLector" name="IdLector" runat="server"></asp:TextBox>
            </div>
            &nbsp;&nbsp;&nbsp;
            <div>
                <asp:Label for="NombreLector" ID="Label2" runat="server">Nombre</asp:Label>
                <asp:TextBox ID="txtNombreLector" name="NombreLector" runat="server"></asp:TextBox>
            </div>
            &nbsp;&nbsp;&nbsp;
            <div>
                <asp:Label for="ApellidoLector" ID="Label3" runat="server">Apellido</asp:Label>
                <asp:TextBox ID="txtApellidoLector" name="ApellidoLector" runat="server"></asp:TextBox>
            </div>
            &nbsp;&nbsp;&nbsp;
            <div>
                <asp:ListBox id="lstLectores" runat="server" style="width:100%; height: 50%"></asp:ListBox>
            </div>
            <div>
                <asp:Button Text="Alta" OnClick="btnAltaLector_Click_1" style="width:100px; height:30px" runat="server"></asp:Button>
                &nbsp;&nbsp;&nbsp;
                <asp:Button Text="Baja" OnClick="btnBajaLector_Click_1" style="width:100px; height:30px" runat="server"></asp:Button>
                &nbsp;&nbsp;&nbsp;
                <asp:Button Text="Modificar" OnClick="btnModificarLector_Click_1" style="width:100px; height:30px" runat="server"></asp:Button>
                &nbsp;&nbsp;&nbsp;
                <asp:Button Text="Limpiar" OnClick="btnLimpiarLector_Click" style="width:100px; height:30px" runat="server"></asp:Button>
                &nbsp;&nbsp;&nbsp;
                <asp:Label Text="  " ID="lblMensajeLectores" runat="server"></asp:Label>
            </div> 
        </div>
    </form>
</body>
</html>
