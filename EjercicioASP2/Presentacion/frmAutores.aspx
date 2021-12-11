<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmAutores.aspx.cs" Inherits="EjercicioASP2.Presentacion.frmAutores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <style type="text/css">
        #form1 
        {
            height: 853px;
            width: 1513px;
        }
    </style>

    <script type="text/javascript">

        function btnAplicaFechaFall()
        {
            document.getElementById("dateFechaFallAutor").disabled = false;
        }

    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Autores</h1>
            <div>
                <asp:Label for="IdAutor" ID="Label1" runat="server">ID </asp:Label>
                <asp:TextBox ID="txtIdAutor" runat="server" name="IdAutor"></asp:TextBox>
            </div>
            &nbsp;&nbsp;&nbsp;
            <div>
                <asp:Label for="NombreAutor" ID="Label2" runat="server">Nombre </asp:Label>
                <asp:TextBox ID="txtNombreAutor" runat="server" name="NombreAutor"></asp:TextBox>
            </div>
            &nbsp;&nbsp;&nbsp;
            <div>
                <asp:Label for="ApellidoAutor" ID="Label3" runat="server">Apellido </asp:Label>
                <asp:TextBox ID="txtApellidoAutor" runat="server" name="ApellidoAutor"></asp:TextBox>
            </div>
            &nbsp;&nbsp;&nbsp;
            <div>
                <asp:Label for="FechaNacAutor" ID="Label4" runat="server">Fecha de Nacimiento </asp:Label>
                <asp:Calendar name="FechaNacAutor" ID="dateFechaNacAutor2" runat="server"></asp:Calendar>
            </div>
            &nbsp;&nbsp;&nbsp;
            <div>
                <asp:Label for="FechaFallAutor" ID="Label5" runat="server">Fecha de Fallecimiento </asp:Label>
                <asp:Calendar for="FechaFallAutor" ID="dateFechaFallAutor" runat="server" disabled="disabled"></asp:Calendar>
                <asp:Button text="Aplica" OnClick="btnAplicaFechaFall()" runat="server" ></asp:Button>
            </div>
            &nbsp;&nbsp;&nbsp;
            <div>
                <asp:Label for="NacionalidadAutor" ID="Label6" runat="server">Nacionalidad </asp:Label>
                <asp:TextBox ID="txtNacionalidadAutor" runat="server" name="NacionalidadAutor"></asp:TextBox>
            </div>
            &nbsp;&nbsp;&nbsp;
            <div>
                <asp:ListBox ID="lstAutores" runat="server" style="width:100%; height: 50%"></asp:ListBox>
            </div>
            <div>
                <asp:Button Text="Alta" OnClick="btnAltaAutor_Click" style="width:100px; height:30px" runat="server"></asp:Button>
                &nbsp;&nbsp;&nbsp;
                <asp:Button Text="Baja" OnClick="btnBajaAutor_Click" style="width:100px; height:30px" runat="server"></asp:Button>
                &nbsp;&nbsp;&nbsp;
                <asp:Button Text="Modificar" OnClick="btnModificarAutor_Click" style="width:100px; height:30px" runat="server"></asp:Button>
                &nbsp;&nbsp;&nbsp;
                <asp:Button Text="Limpiar" OnClick="btnLimpiarAutor_Click" style="width:100px; height:30px" runat="server"></asp:Button>
                &nbsp;&nbsp;&nbsp;
                <asp:Label Text="  " ID="lblMensajeAutor" runat="server"></asp:Label>
            </div> 
        </div>
    </form>
</body>
</html>
