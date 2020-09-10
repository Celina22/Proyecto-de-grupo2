using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiPrimerProyecto.Clases;

namespace MiPrimerProyecto.Formularios
{
    public partial class frmABMUsuarios : Form
    {
        bool nuevo = false;
        Datos oBD = new Datos();
        Usuario oUsuario = new Usuario();
        public frmABMUsuarios()
        {
            InitializeComponent();
        }

        private void frmABMUsuarios_Load(object sender, EventArgs e)
        {
            habilitar(true);
            DataTable tabla = new DataTable();
            tabla = oBD.consultarTabla("Perfiles");
            cboPerfil.DataSource = tabla;
            cboPerfil.DisplayMember = tabla.Columns[1].ColumnName;
            cboPerfil.ValueMember = tabla.Columns[0].ColumnName;
            cboPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPerfil.SelectedIndex = -1;

            cargarGrilla(grdUsuarios, oUsuario.recuperarUsuarios());
        }
        private void cargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(
                    tabla.Rows[i]["id_usuario"],
                    tabla.Rows[i]["usuario"],
                    tabla.Rows[i]["email"]
                    );
            }
        }
        private void habilitar(bool x)
        {
            txtId.Enabled = !x;
            txtNombre.Enabled = !x;
            txtPassword.Enabled = !x;
            txtEmail.Enabled = !x;
            cboPerfil.Enabled = !x;

            btnNuevo.Enabled = x;
            btnEditar.Enabled = x;
            btnBorrar.Enabled = x;
            btnSalir.Enabled = x;

            btnGuardar.Enabled = !x;
            btnCancelar.Enabled = !x;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.nuevo = true;
            habilitar(false);
            limpiarCampos();

            txtId.Focus();
        }

        private void limpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtPassword.Clear();
            txtEmail.Text = string.Empty;
            cboPerfil.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar(false);
            txtId.Focus();
            grdUsuarios.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            grdUsuarios.Enabled = true;
            habilitar(true);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que quiere eliminar al usuario " + txtNombre.Text + "?", "Borrar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                oUsuario.Id_Usuario = Convert.ToInt32(txtId.Text);
                oUsuario.eliminarUsuario();
                this.cargarGrilla(grdUsuarios, oUsuario.recuperarUsuarios());
            }
    
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            grdUsuarios.Enabled = true;

            oUsuario.N_usuario = txtNombre.Text;
            oUsuario.Password = txtPassword.Text;
            oUsuario.Email = txtEmail.Text;
            oUsuario.Id_perfil = (int)cboPerfil.SelectedValue;
            oUsuario.Estado = "S";
            oUsuario.Borrado = 0;

            bool validado = oUsuario.validarDatosUsuario();
            if (validado)
            {
                if (nuevo)
                {
                    if (!oUsuario.existe())
                    {
                        oUsuario.grabarNuevoUsuario();
                        MessageBox.Show("Usuario dado de alta correctamente.", "Nuevo usuario", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Ya existe el usuario.");
                    }
                }
                else
                {
                    oUsuario.Id_Usuario = Convert.ToInt32(txtId.Text);
                    oUsuario.actualizarUsuario();
                    MessageBox.Show("Usuario actualizado correctamente.", "Actualizar usuario", MessageBoxButtons.OK);
                }
            }
            this.cargarGrilla(grdUsuarios, oUsuario.recuperarUsuarios());
            habilitar(true);
            this.nuevo = false;
        }

        private void grdUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            int idUsuarioSelec = (int)grdUsuarios.CurrentRow.Cells[0].Value;
            this.actualizarCampos(idUsuarioSelec);
        }

        private void actualizarCampos(int idUsuarioSelec)
        {
            DataTable tabla = new DataTable();
            tabla = oUsuario.recuperarUsuario(idUsuarioSelec);
            txtId.Text = tabla.Rows[0]["id_usuario"].ToString();
            txtNombre.Text = tabla.Rows[0]["usuario"].ToString();
            txtPassword.Text = tabla.Rows[0]["password"].ToString();
            txtEmail.Text = tabla.Rows[0]["email"].ToString();
            cboPerfil.SelectedValue = tabla.Rows[0]["id_perfil"];
        }
    }
}
