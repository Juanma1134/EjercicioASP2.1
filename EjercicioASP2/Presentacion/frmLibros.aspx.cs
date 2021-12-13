using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP2.Presentacion
{
    public partial class frmLibros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #region METODOS AUXILIARES
        private void Limpiar()
        {
            txtIdLibro.Clear();
            txtTituloLibro.Clear();
            txtGeneroLibro.Clear();
            dateAñoLibro.ResetText();
            cmbAutordeLibro.ResetText();
            txtPrecioLibro.Clear();
            txtComentarioLibro.Clear();
        }
        private Boolean faltanDatos()
        {
            if (txtIdLibro.Text == "" || txtTituloLibro.Text == "" || txtGeneroLibro.Text == "" || txtPrecioLibro.Text == "")
            {
                return true;
            }
            return false;
        }
        private void CargarEnTextBox(short pId)
        {
            Limpiar();
            Dominio.ControladoraFeria unaFeria = new Dominio.ControladoraFeria();
            Dominio.Libros unLibro = unaFeria.BuscarLibro(pId);
            txtIdLibro.Text = Convert.ToString(unLibro.Id); //unAutor.Id.ToString();
            txtTituloLibro.Text = unLibro.Titulo;
            txtGeneroLibro.Text = unLibro.Genero;
            dateAñoLibro.Value = unLibro.Año;
            cmbAutordeLibro.SelectedItem = unLibro.Autores; //VER
            txtPrecioLibro.Text = Convert.ToString(unLibro.Precio);
            txtComentarioLibro.Text = unLibro.Comentario;
        }
        private void Listar()
        //Listamos la informacion de la lista autores a el listBox
        {
            Dominio.ControladoraFeria Feria = new Dominio.ControladoraFeria();
            lstLibros.DataSource = null;
            lstLibros.DataSource = Feria.ListaLibros();
            //Feria.ListaAutores(lstAutores.DataSource);
        }
        private void ListarCmbAutores()
        {
            Dominio.ControladoraFeria Feria = new Dominio.ControladoraFeria();
            cmbAutordeLibro.DataSource = null;
            cmbAutordeLibro.DataSource = Feria.ListaAutores();
        }
        private void cmbAutordeLibro_Click(object sender, EventArgs e)
        {
            ListarCmbAutores();
        }
        private Dominio.Autores AutorSeleccionado()
        {
            if (cmbAutordeLibro.Text != null)
            {
                Dominio.ControladoraFeria Controladora = new Dominio.ControladoraFeria();
                string Autor = cmbAutordeLibro.SelectedItem.ToString();
                string[] AutorArray = Autor.Split(' ');
                short AutorId = short.Parse(AutorArray[1]);
                Dominio.Autores AutorObjeto = Controladora.BuscarAutor(AutorId);
                if (AutorObjeto != null)
                {
                    return AutorObjeto;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        #endregion
        #region BOTONES
        private void btnAltaLibro_Click(object sender, EventArgs e)
        {
            if (!faltanDatos())
            //Si es diferente a faltanDatos(), osea que devuelve false
            {
                Dominio.Autores Autor = AutorSeleccionado();
                if (Autor != null)
                {
                    short IdLibro = short.Parse(txtIdLibro.Text);
                    string Titulo = txtTituloLibro.Text;
                    string Genero = txtGeneroLibro.Text;
                    DateTime AñoLibro = dateAñoLibro.Value;
                    int Precio = int.Parse(txtPrecioLibro.Text);
                    string Comentario = txtComentarioLibro.Text;
                    Dominio.Libros unLibro = new Dominio.Libros(IdLibro, Titulo, Genero, AñoLibro, Autor, Precio, Comentario);
                    Dominio.ControladoraFeria Controladora = new Dominio.ControladoraFeria();
                    if (Controladora.AltaLibro(unLibro))
                    {
                        Listar();
                        Limpiar();
                        labelMensajeLibros.Text = "Libro ingresado";
                    }
                    else
                    {
                        txtIdLibro.Clear();
                        txtIdLibro.Focus();
                        labelMensajeLibros.Text = "El ID ingresado ya existe";
                    }
                }
                else
                {
                    labelMensajeLibros.Text = "No hay autor ingresado";
                }
            }
            else
            {
                labelMensajeLibros.Text = "Falta ingresar datos en las cajas de texto";
            }
        }
        private void btnBajaLibro_Click(object sender, EventArgs e)
        {
            Dominio.ControladoraFeria Controladora = new Dominio.ControladoraFeria();
            if (txtIdLibro.Text != "")
            {
                short idLibro = short.Parse(txtIdLibro.Text);
                if (Controladora.BajaLibro(idLibro))
                {
                    Limpiar();
                    Listar();
                    labelMensajeLibros.Text = "Autor elimiando con exito";
                }
                else
                {
                    txtIdLibro.Clear();
                    txtIdLibro.Focus();
                    labelMensajeLibros.Text = "No existe socio con el ID colocado";
                }
            }
            else
            {
                txtIdLibro.Text = "Ingrese el ID del socio que desea eliminar";
            }
        }
        private void btnModificarLibro_Click(object sender, EventArgs e)
        {
            Dominio.ControladoraFeria Controladora = new Dominio.ControladoraFeria();
            Dominio.Autores Autor = AutorSeleccionado();
            if (!faltanDatos())
            {
                short IdLibro = short.Parse(txtIdLibro.Text);
                string Titulo = txtTituloLibro.Text;
                string Genero = txtGeneroLibro.Text;
                DateTime Año = dateAñoLibro.Value;
                int Precio = int.Parse(txtPrecioLibro.Text);
                string Comentario = txtComentarioLibro.Text;
                if (Controladora.ModificarLibro(IdLibro, Titulo, Genero, Año, Autor, Precio, Comentario))
                {
                    Limpiar();
                    Listar();
                    labelMensajeLibros.Text = "Se ha modificado con exito";
                }
                else
                {
                    txtIdLibro.Focus();
                    txtIdLibro.Clear();
                    labelMensajeLibros.Text = "No se encontró el ID seleccionado";
                }
            }
            else
            {
                labelMensajeLibros.Text = "Ingrese todo los datos";
            }
        }
        private void btnLimpiarLibro_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        #endregion
        private void lstLibros_Click(object sender, EventArgs e)
        {
            if (lstLibros.SelectedIndex > -1)
            {
                string linea = lstLibros.SelectedItem.ToString();
                string[] partes = linea.Split(' ');
                short idLibro = short.Parse(partes[1]);
                // ID es la posición 1, ya que antes está el texto colocado por nosotros "ID: ".
                CargarEnTextBox(idLibro);
            }
        }
}