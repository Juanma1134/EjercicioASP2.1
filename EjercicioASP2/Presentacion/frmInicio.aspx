<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmInicio.aspx.cs" Inherits="EjercicioASP2.Presentacion.frmInicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous"/>
    <style type="text/css">
        #form1 {
            height: 630px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <a href="frmLibros.aspx"> LIBROS </a>
        <br />
       <a href="frmlectores.aspx"> LECTORES </a>
        <br />
       <a href="frmAutores.aspx"> AUTORES </a>
    </form>
</body>
</html>
