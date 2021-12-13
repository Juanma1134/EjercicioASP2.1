using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP2.Presentacion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #region METODOS AUXILIARES
        private void Limpiar()
        {
            txtIdLector.Clear();
            txtNombreLector.Clear();
            txtApellidoLector.Clear();
            txtIdLector.Focus();
        }
        private Boolean faltanDatos()
        {
            if (txtIdLector.Text == "" || txtNombreLector.Text == "" || txtApellidoLector.Text == "")
            {
                return true;
            }
            return false;
        }

        private void CargarEnTextBox(short pId)
        {
            Limpiar();
            Dominio.ControladoraFeria unaFeria = new Dominio.ControladoraFeria();
            Dominio.Lectores unLector = unaFeria.BuscarLector(pId);
            txtIdLector.Text = Convert.ToString(unLector.Id); //unLector.Id.ToString();
            txtNombreLector.Text = unLector.Nombre;
            txtApellidoLector.Text = unLector.Apellido;
        }
        private void Listar()
        {
            Dominio.ControladoraFeria Feria = new Dominio.ControladoraFeria();
            lstLectores.DataSource = null;
            lstLectores.DataSource = Feria.ListaLectores();
        }
        #endregion
        #region BOTONES 
        private void btnAltaLector_Click_1(object sender, EventArgs e)
        {
            if (!faltanDatos())
            //Si es diferente a faltanDatos(), osea que devuelve false kifmldsfs
            {
                short IdLector = short.Parse(txtIdLector.Text);
                string NombreLector = txtNombreLector.Text;
                string ApellidoLector = txtApellidoLector.Text;
                Dominio.Lectores unLector = new Dominio.Lectores(IdLector, NombreLector, ApellidoLector);
                Dominio.ControladoraFeria Controladora = new Dominio.ControladoraFeria();
                if (Controladora.AltaLector(unLector))
                // Si alta Lector es true, lo añade a la lista
                {
                    Limpiar();
                    Listar();
                    lblMensajeLectores.Text = "Se añadió Lector con éxito";
                }
                else
                {
                    txtIdLector.Clear();
                    txtIdLector.Focus();
                    lblMensajeLectores.Text = "El ID ingresado ya existe";
                }
            }
            else
            {
                lblMensajeLectores.Text = "Falta ingresar datos en las cajas de texto";
            }
        }
        private void btnBajaLector_Click_1(object sender, EventArgs e)
        {
            Dominio.ControladoraFeria Controladora = new Dominio.ControladoraFeria();
            if (txtIdLector.Text != "")
            {
                short idLector = short.Parse(txtIdLector.Text);
                if (Controladora.BajaLector(idLector))
                {
                    Limpiar();
                    Listar();
                    lblMensajeLectores.Text = "Lector elimiando con exito";
                }
                else
                {
                    txtIdLector.Clear();
                    txtIdLector.Focus();
                    lblMensajeLectores.Text = "No existe Lector con el ID colocado";
                }
            }
            else
            {
                lblMensajeLectores.Text = "Ingrese el ID del Lector que desea eliminar";
            }
        }
        private void btnModificarLector_Click_1(object sender, EventArgs e)
        {
            Dominio.ControladoraFeria Controladora = new Dominio.ControladoraFeria();
            if (!faltanDatos())
            {
                short IdLector = short.Parse(txtIdLector.Text);
                string NombreLector = txtNombreLector.Text;
                string ApellidoLector = txtApellidoLector.Text;
                if (Controladora.ModificarLector(IdLector, NombreLector, ApellidoLector))
                {
                    Limpiar();
                    Listar();
                    lblMensajeLectores.Text = "Se ha modificado con exito";
                }
                else
                {
                    txtIdLector.Focus();
                    txtIdLector.Clear();
                    lblMensajeLectores.Text = "No se encontró el ID seleccionado";
                }
            }
            else
            {
                lblMensajeLectores.Text = "Ingrese todo los datos";
            }
        }
        private void btnLimpiarLector_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void frmLectores_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void lstLectores_Click(object sender, EventArgs e)
        {
            if (lstLectores.SelectedIndex > -1)
            {
                string linea = lstLectores.SelectedItem.ToString();
                string[] partes = linea.Split(' ');
                short idLector = short.Parse(partes[1]);
                CargarEnTextBox(idLector);
            }
        }
        #endregion
    }
}