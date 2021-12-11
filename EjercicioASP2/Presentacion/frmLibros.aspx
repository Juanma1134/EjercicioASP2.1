<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLibros.aspx.cs" Inherits="EjercicioASP2.Presentacion.frmLibros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 294px">
    <form id="form1" runat="server">
        <div style="height: 634px">
            <div>
                <h1>Libros</h1>
            </div>
            <div>
                <asp:Label for="IdLibro" ID="Label1" runat="server">ID Libro</asp:Label>
                <asp:TextBox ID="txtIdLibro" name="IdLibro" runat="server"></asp:TextBox>
            </div>
            &nbsp;&nbsp;&nbsp;
            <div>
                <asp:Label for="TituloLibro" ID="Label2" runat="server">Titulo</asp:Label>
                <asp:TextBox ID="txtTituloLibro" name="TituloLibro" runat="server"></asp:TextBox>
            </div>
            &nbsp;&nbsp;&nbsp;
            <div>
                <asp:Label for="GeneroLibro" ID="Label3" runat="server">Genero</asp:Label>
                <asp:DropDownList ID="drpGenero" runat="server"> 
                    <asp:ListItem >            -               </asp:ListItem>
                    <asp:ListItem >Accion                      </asp:ListItem>
                    <asp:ListItem >Aventura                    </asp:ListItem>
                    <asp:ListItem >Ciencia Ficcion             </asp:ListItem>
                    <asp:ListItem >Historia                    </asp:ListItem>
                    <asp:ListItem >Economia/Finanzas           </asp:ListItem>
                    <asp:ListItem >Infantiles                  </asp:ListItem>
                    <asp:ListItem >Otros                       </asp:ListItem>
                </asp:DropDownList>
            </div>
            &nbsp;&nbsp;&nbsp;
            <div>
                <asp:Label for="AñoLibro" ID="Label4" runat="server">Año Libro</asp:Label>
                <asp:TextBox ID="dateAñoLibro" name="AñoLibro" runat="server" type="date"></asp:TextBox>
            </div>
            &nbsp;&nbsp;&nbsp;
            <div>
                <asp:Label for="AutorLibro" ID="Label5" runat="server">Autor del Libro</asp:Label>
                <asp:DropDownList ID="cmbAutordeLibro" runat="server" name="AutorLibro">

                </asp:DropDownList>
            </div>
            &nbsp;&nbsp;&nbsp;
            <div>
                <asp:Label for="PrecioLibro" ID="Label6" runat="server">Precio del Libro</asp:Label>
                <asp:TextBox ID="txtPrecioLibro" name="PrecioLibro" runat="server" type="number" ></asp:TextBox>
            </div>
            &nbsp;&nbsp;&nbsp;
            <div>
                <asp:Label for="ComentarioLibro" ID="Label7" runat="server">Comentario (Opcional)</asp:Label>
                <asp:TextBox ID="txtComentarioLibro" name="ComentarioLibro" runat="server"></asp:TextBox>
            </div>
            &nbsp;&nbsp;&nbsp;
            <div>
                <asp:ListBox ID="lstLibros" runat="server" style="width:100%; height: 33%"></asp:ListBox>
            </div>
            <div style="height: 40px; width: 1510px">
                <asp:Button Text="Alta" OnClick="btnAltaLibro_Click" style="width:100px; height:30px" runat="server"></asp:Button>
                &nbsp;&nbsp;&nbsp;
                <asp:Button Text="Baja" OnClick="btnBajaLibro_Click" style="width:100px; height:30px" runat="server"></asp:Button>
                &nbsp;&nbsp;&nbsp;
                <asp:Button Text="Modificar" OnClick="btnModificarLibro_Click" style="width:100px; height:30px" runat="server"></asp:Button>
                &nbsp;&nbsp;&nbsp;
                <asp:Button Text="Limpiar" OnClick="btnLimpiarLibro_Click" style="width:100px; height:30px" runat="server"></asp:Button>
                &nbsp;&nbsp;&nbsp;
                <asp:Label Text="  " ID="labelMensajeLibros" runat="server"></asp:Label>
            </div> 
        </div>
    </form>
</body>
</html>
