using LPCFacturas.BusinessLayer;
using LPCFacturas.Entities;
using LPCFacturas.GUILayer;
using LPCFacturas.Reportes;
using LPCFacturas.Sources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPCFacturas.GUILayer
{
    public partial class frmPrincipal : Form
    {
        
        Usuario usuarioActual;

        public Usuario UsuarioActual { get => usuarioActual; set => usuarioActual = value; }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            int ancho = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            int alto = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            Size = new System.Drawing.Size(ancho, alto);

            this.menuPrincipal.Renderer = new ToolStripProfessionalRenderer(new TestColorTable());
            this.Visible = false;
            frmLogin fl = new frmLogin();
            fl.ShowDialog();
            UsuarioActual = fl.UsuarioLogueado;
            this.Text = "Menú Principal - Usuario actual: " + UsuarioActual.NombreUsuario;
            fl.Dispose();
            this.Visible = true;
        } 
        private void proyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMProyecto abmProyecto = new frmABMProyecto();
            abmProyecto.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMProducto abmProducto = new frmABMProducto();
            abmProducto.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMUsuario aBMUsuario = new frmABMUsuario();
            aBMUsuario.ShowDialog();
        }

        private void barriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMBarrios abmBarrios = new frmABMBarrios();
            abmBarrios.ShowDialog();
        }

        private void contactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMContactos abmContactos = new frmABMContactos();
            abmContactos.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMClientes abmClientes = new frmABMClientes();
            abmClientes.ShowDialog();
        }

        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactura nuevaFactura = new frmFactura(usuarioActual);
            nuevaFactura.ShowDialog();
        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteListadoCliente nuevoReporteCliente = new frmReporteListadoCliente();
            nuevoReporteCliente.ShowDialog();
        }

        private void listadoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteListadoProducto nuevoReporteProducto = new frmReporteListadoProducto();
            nuevoReporteProducto.ShowDialog();
        }

        private void listadoDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteListadoFactura nuevoReporteFactura = new frmReporteListadoFactura();
            nuevoReporteFactura.ShowDialog();
        }

        private void listadoDeProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteListadoProyectos nuevoReporteProyecto = new frmReporteListadoProyectos();
            nuevoReporteProyecto.ShowDialog();
        }
    }
}
