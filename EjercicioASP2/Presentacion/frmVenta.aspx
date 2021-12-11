<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmVenta.aspx.cs" Inherits="EjercicioASP2.Presentacion.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div style="height: 634px">
            <div>
                <h1>Ventas</h1>
            </div>
            <div>
                <label for="IdVenta">ID Venta</label>
                <asp.TextBox id="txtIdVenta" name="IdVenta" runat="server" type="text" />
            </div>
            &nbsp;&nbsp;&nbsp;
            <div>
                <label for="FechaVenta">Fecha de venta</label>
                <asp.TextBox id="txtFechaVenta" name="Fechaventa" runat="server" type="date" />
            </div>
            &nbsp;&nbsp;&nbsp;
            <div>
                <label for="TituloLibro">Titulo del libro</label>
                <asp.select name="TituloLibro" id="cmbTituloLibroVenta" runat="server" style="width:200px">

            </div>
            &nbsp;&nbsp;&nbsp;
            <div>
                <label for="AutorLibro">Autor</label>
                <asp.elect id="cmbAutorVenta" name="AutorLibro" runat="server" style="width:200px">

                </asp.elect>
            </div>
            &nbsp;&nbsp;&nbsp;
            <div>
                <label for="LectorLibro">Lector</label>
                <asp.Select id="cmbLectorLibro" name="LectorLibro" runat="server" style="width:200px">

                </asp.Select>
            </div>
            &nbsp;&nbsp;&nbsp;
            <div>
                <label for="PrecioLibro">Precio</label>
                <asp:TextBox type="number" name="PrecioLibro" id="txtPrecioVenta" runat="server"/>
            </div>
            &nbsp;&nbsp;&nbsp;
            <div>
                <asp.select id="lstVentas" onclick="clickLstVentas()" style="width:100%; height: 33%"></asp.select>
            </div>
            <div style="height: 40px; width: 1510px">
                <asp.TextBox type="button" value="Vender" onclick="btnVentaLibro" style="width:100px; height:30px" />
                &nbsp;&nbsp;&nbsp;
                <asp.TextBox type="button" value="Devolucion" onclick="btnDevLibro" style="width:100px; height:30px" />
            </div> 
        </div>
    </form>
</body>
</html>
