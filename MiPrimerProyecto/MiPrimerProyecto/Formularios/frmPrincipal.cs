using MiPrimerProyecto.Clases;
using MiPrimerProyecto.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerProyecto
{
    public partial class frm_principal : Form
    {
        Usuario usuarioActual;
        public frm_principal()
        {
            InitializeComponent();
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {

            //Inicialización del formulario de login.
            frmLogin flogin;
            flogin = new frmLogin();

            flogin.ShowDialog();
            this.usuarioActual = flogin.Usuario;

            if (this.usuarioActual.Id_Usuario == 0)
                this.Close();
            else
                this.Text = this.Text + " - Usuario " + this.usuarioActual.N_usuario;
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaBugs fcb = new frmConsultaBugs();
            fcb.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
