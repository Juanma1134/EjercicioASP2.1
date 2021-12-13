using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP2.Presentacion
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #region METODOS AUXILIARES
        private void Limpiar()
        {
            txtIdVenta.Clear();
            dateFechaVenta.ResetText();
            cmbTituloLibroVenta.ResetText();
            cmbAutorVenta.ResetText();
            cmbLectorVenta.ResetText();
            txtPrecioVenta.Clear();
        }
        private Boolean faltanDatos()
        {
            if (txtIdVenta.Text == "" || txtPrecioVenta.Text == "" || cmbTituloLibroVenta.Text == "" || cmbLectorVenta.Text == "")
            {
                return true;
            }
            return false;
        }
        private void CargarEnTextBox(short pId)
        {
            Limpiar();
            Dominio.ControladoraFeria unaFeria = new Dominio.ControladoraFeria();
            Dominio.Ventas unaVenta = unaFeria.BuscarVenta(pId);
            txtIdVenta.Text = Convert.ToString(unaVenta.IdVenta);
            dateFechaVenta.Value = unaVenta.FechaVenta;
            cmbTituloLibroVenta.SelectedItem = unaVenta.TituloLibro;
            cmbAutorVenta.SelectedItem = unaVenta.Autor;
            //cmbAutordeLibro.SelectedItem = unaVenta.Autores;
            txtPrecioVenta.Text = Convert.ToString(unaVenta.Precio);
            //txtComentarioLibro.Text = unaVenta.Comentario;
        }
        private void Listar()
        {
            Dominio.ControladoraFeria Feria = new Dominio.ControladoraFeria();
            lstVentas.DataSource = null;
            lstVentas.DataSource = Feria.ListaLibros();
        }
        #endregion
        #region COMBOBOX
        private void cmbListarTituloLibro()
        // Llama a los libros en el cmb
        {
            Dominio.ControladoraFeria Feria = new Dominio.ControladoraFeria();
            cmbTituloLibroVenta.DataSource = null;
            cmbTituloLibroVenta.DataSource = Feria.ListaLibros();
        }
        private void cmbListarAutorLibro()
        // Llama a los autores en el cmb
        {
            Dominio.ControladoraFeria Feria = new Dominio.ControladoraFeria();
            cmbAutorVenta.DataSource = null;
            cmbAutorVenta.DataSource = Feria.ListaAutores();
        }
        private void cmbListarLectorLibro()
        // Llama a los lectores en el cmb
        {
            Dominio.ControladoraFeria Feria = new Dominio.ControladoraFeria();
            cmbLectorVenta.DataSource = null;
            cmbLectorVenta.DataSource = Feria.ListaLectores();
        }
        private void cmbTituloLibroVenta_Click(object sender, EventArgs e)
        {
            cmbListarTituloLibro();
        }
        private void cmbAutorVenta_Click(object sender, EventArgs e)
        {
            cmbListarAutorLibro();
        }
        private void cmbLectorVenta_Click(object sender, EventArgs e)
        {
            cmbListarLectorLibro();
        }

        #endregion
        #region BOTONES
        private void btnVender_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}