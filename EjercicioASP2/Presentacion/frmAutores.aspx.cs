using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace EjercicioASP2.Presentacion
{
    public partial class frmAutores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                this.Listar();
            }
        }

        #region METODOS AUXILIARES
        private void Limpiar()
        {
            txtIdAutor.Text ="";
            txtNombreAutor.Text="";
            txtApellidoAutor.Text = "";
            txtNacionalidadAutor.Text = "";
            lblMensajeAutor.Text = "";
            txtIdAutor.Focus();
        }
        private Boolean faltanDatos()
        {
            if (txtIdAutor.Text == "" || txtNombreAutor.Text == "" || txtApellidoAutor.Text == "" || txtNacionalidadAutor.Text == "")
            {
                return true;
            }
            return false;
        }

        private void CargarEnTextBox(short pId)
        {
            Limpiar();
            Dominio.ControladoraFeria unaFeria = new Dominio.ControladoraFeria();
            Dominio.Autores unAutor = unaFeria.BuscarAutor(pId);
            txtIdAutor.Text = Convert.ToString(unAutor.Id); //unAutor.Id.ToString();
            txtNombreAutor.Text = unAutor.Nombre;
            txtApellidoAutor.Text = unAutor.Apellido;
            dateFechaNacAutor2.SelectedDate = unAutor.FechaNac;
            dateFechaFallAutor.SelectedDate = unAutor.FechaFall;
            txtNacionalidadAutor.Text = unAutor.Nacionalidad;
        }
        private void Listar()
        //Listamos la informacion de la lista autores a el listBox
        {
            Dominio.ControladoraFeria Feria = new Dominio.ControladoraFeria();
            lstAutores.DataSource = null;
            lstAutores.DataSource = Feria.ListaAutores();
            //Feria.ListaAutores(lstAutores.DataSource);
        }
        #endregion

        private void btnAltaAutor_Click(object sender, EventArgs e)
        {
            if (!faltanDatos())
            //Si es diferente a faltanDatos(), osea que devuelve false
            {
                short IdAutor = short.Parse(txtIdAutor.Text);
                string NombreAutor = txtNombreAutor.Text;
                string ApellidoAutor = txtApellidoAutor.Text;
                DateTime FechaNacAutor = dateFechaNacAutor2.SelectedDate;
                DateTime FechaFallAutor = dateFechaFallAutor.SelectedDate;
                string NacionalidadAutor = txtNacionalidadAutor.Text;
                Dominio.Autores unAutor = new Dominio.Autores(IdAutor, NombreAutor, ApellidoAutor, FechaNacAutor, FechaFallAutor, NacionalidadAutor);
                Dominio.ControladoraFeria Controladora = new Dominio.ControladoraFeria();
                if (Controladora.AltaAutor(unAutor))
                // Si alta autor es true, lo añade a la lista
                {
                    Limpiar();
                    Listar();
                    lblMensajeAutor.Text = "Se añadió Autor con éxito";
                }
                else
                {
                    txtIdAutor.Text = " ";
                    txtIdAutor.Focus();
                    lblMensajeAutor.Text = "El ID ingresado ya existe";
                }
            }
            else
            {
                lblMensajeAutor.Text = "Falta ingresar datos en las cajas de texto";
            }
        }
        private void btnBajaAutor_Click(object sender, EventArgs e)
        {
            Dominio.ControladoraFeria Controladora = new Dominio.ControladoraFeria();
            if (txtIdAutor.Text != "")
            {
                short idAutor = short.Parse(txtIdAutor.Text);
                if (Controladora.BajaAutor(idAutor))
                {
                    Limpiar();
                    Listar();
                    lblMensajeAutor.Text = "Autor elimiando con exito";
                }
                else
                {
                    txtIdAutor.Text="";
                    txtIdAutor.Focus();
                    lblMensajeAutor.Text = "No existe socio con el ID colocado";
                }
            }
            else
            {
                txtIdAutor.Text = "Ingrese el ID del socio que desea eliminar";
            }
        }
        private void btnModificarAutor_Click(object sender, EventArgs e)
        {
            Dominio.ControladoraFeria Controladora = new Dominio.ControladoraFeria();
            if (!faltanDatos())
            {
                short IdAutor = short.Parse(txtIdAutor.Text);
                string NombreAutor = txtNombreAutor.Text;
                string ApellidoAutor = txtApellidoAutor.Text;
                DateTime FechaNacAutor = dateFechaNacAutor2.SelectedDate;
                DateTime FechaFallAutor = dateFechaFallAutor.SelectedDate;
                string NacionalidadAutor = txtNacionalidadAutor.Text;
                if (Controladora.ModificarAutor(IdAutor, NombreAutor, ApellidoAutor, FechaNacAutor, FechaFallAutor, NacionalidadAutor))
                {
                    Limpiar();
                    Listar();
                    lblMensajeAutor.Text = "Se ha modificado con exito";
                }
                else
                {
                    txtIdAutor.Focus();
                    txtIdAutor.Text="";
                    lblMensajeAutor.Text = "No se encontró el ID seleccionado";
                }
            }
            else
            {
                lblMensajeAutor.Text = "Ingrese todo los datos";
            }
        }
        private void btnLimpiarAutor_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void lstAutores_Click(object sender, EventArgs e)
        {
            if (lstAutores.SelectedIndex > -1)
            {
                string linea = lstAutores.SelectedItem.ToString();
                string[] partes = linea.Split(' ');
                short idAutor = short.Parse(partes[1]);
                // ID es la posición 1, ya que antes está el texto colocado por nosotros "ID: ".
                CargarEnTextBox(idAutor);
            }
        }
    }
}