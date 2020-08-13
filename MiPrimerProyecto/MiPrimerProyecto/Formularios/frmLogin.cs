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
    public partial class frmLogin : Form
    {
        Usuario usuario = new Usuario();
        internal Usuario Usuario { get => usuario; set => usuario = value; }

        public frmLogin()
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
            Usuario.N_usuario = this.txtUsuario.Text;
            Usuario.Password = this.txtClave.Text;
            Usuario.Id_Usuario = Usuario.validarUsuario(Usuario.N_usuario, Usuario.Password);

            string msj = "";
            if (Usuario.validarUsuario(Usuario.N_usuario, Usuario.Password) != 0)
            {
                msj = "Login OK. Bienvenido, " + Usuario.N_usuario + ".";
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
