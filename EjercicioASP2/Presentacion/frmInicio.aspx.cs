using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP2.Presentacion
{
    namespace Obligatorio1.Diseño
    {
        public partial class frmInicio : Form
        {
            public frmInicio()
            {
                InitializeComponent();
            }

            private void toolStripMenuAutores_Click(object sender, EventArgs e)
            {
                //frmAutores frmAutores = new frmAutores(); Como lo hicimos antes (sin singleton)
                Form frmAutores = Diseño.frmAutores.Instancia();
                frmAutores.MdiParent = this;
                frmAutores.Show();
                frmAutores.Activate();
                labelBienvenida.Hide();
            }

            private void toolStripMenuLectores_Click(object sender, EventArgs e)
            {
                //frmLectores frmLectores = new frmLectores(); Como lo hicimos antes (sin singleton)
                Form frmLectores = Diseño.frmLectores.Instancia();
                frmLectores.MdiParent = this;
                frmLectores.Show();
                frmLectores.Activate();
                labelBienvenida.Hide();
            }

            private void toolStripMenuLibros_Click(object sender, EventArgs e)
            {
                //frmLibros frmLibros = new frmLibros();
                Form frmLibros = Diseño.frmLibros.Instancia();
                frmLibros.MdiParent = this;
                frmLibros.Show();
                frmLibros.Activate();
                labelBienvenida.Hide();
            }

            private void toolStripMenuVentas_Click(object sender, EventArgs e)
            {
                //frmVentas frmVentas = new frmVentas();
                Form frmVentas = Diseño.frmVentas.Instancia();
                frmVentas.MdiParent = this;
                frmVentas.Show();
                frmVentas.Activate();
                labelBienvenida.Hide();
            }

            private void toolStripMenuEstadisticas_Click(object sender, EventArgs e)
            {
                //frmEstadisticas frmEstadisticas = new frmEstadisticas();
                Form frmEstadisticas = Diseño.frmEstadisticas.Instancia();
                frmEstadisticas.MdiParent = this;
                frmEstadisticas.Show();
                frmEstadisticas.Activate();
                labelBienvenida.Hide();
            }
        }
    }