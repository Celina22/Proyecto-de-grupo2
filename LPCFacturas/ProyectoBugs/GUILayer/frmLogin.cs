using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LPCFacturas.BusinessLayer;

namespace LPCFacturas.GUILayer
{
    public partial class frmLogin : Form
    {
        private readonly UsuarioService usuarioService;

        public string UsuarioLogueado { get; internal set; }
        public frmLogin()
        {
            InitializeComponent();
            usuarioService = new UsuarioService();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un usuario.", "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Focus();
                return;
            }
            //if (this.txtClave.Text == "")
            if (string.IsNullOrEmpty(this.txtClave.Text))
            {
                MessageBox.Show("Debe ingresar una clave.", "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtClave.Focus();
                return;
            }

            var usr = usuarioService.ValidarUsuario(txtUsuario.Text, txtClave.Text);
            //Controlamos que las creadenciales sean las correctas. 
            string msj = "";
            if (usr != null)
            {
                UsuarioLogueado = usr.NombreUsuario;
                msj = "Login OK. Bienvenido, " + UsuarioLogueado + ".";
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
    }
}
