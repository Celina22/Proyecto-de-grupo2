using LPCFacturas.BusinessLayer;
using LPCFacturas.Entities;
using LPCFacturas.GUILayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPCFacturas.GUILayer
{
    public partial class frmPrincipal : Form
    {
        Usuario usuarioActual;
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
            frmLogin fl = new frmLogin();
            fl.ShowDialog();
            usuarioActual = fl.UsuarioLogueado;
            this.Text = "Menú Principal - Usuario actual: " + usuarioActual.NombreUsuario;
            fl.Dispose();
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
    }
}
