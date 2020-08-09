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
        string user = "admin";
        string pass = "123";
        public frm_login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //if (this.txtUsuario.Text == "")
            if (this.txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un usuario.");
                this.txtUsuario.Focus();
                return;
            }
            //if (this.txtClave.Text == "")
            if (string.IsNullOrEmpty(this.txtClave.Text))
            {
                MessageBox.Show("Debe ingresar una clave.");
                this.txtClave.Focus();
                return;
            }

            //Validar usuario y clave.
            string msj = "";
            if (this.txtUsuario.Text == this.user && this.txtClave.Text == this.pass)
            {
                msj = "Login OK. Bienvenido, " + user + ".";
                MessageBox.Show(msj, "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                msj = "Usuario y/o clave incorrectos.";
                MessageBox.Show(msj, "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtUsuario.Text = string.Empty;
                this.txtClave.Text = string.Empty;
                this.txtUsuario.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
