using MiPrimerProyecto.Clases;
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
    public partial class frm_login : Form
    {
        Usuario usuario = new Usuario();
        internal Usuario Usuario { get => usuario; set => usuario = value; }

        public frm_login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //if (this.txtUsuario.Text == "")
            if (this.txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un usuario.", "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Focus();
                return;
            }
            //if (this.txtClave.Text == "")
            if (string.IsNullOrEmpty(this.txtClave.Text))
            {
                MessageBox.Show("Debe ingresar una clave.","Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtClave.Focus();
                return;
            }

            //Validar usuario y clave.
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
