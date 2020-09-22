﻿using LPCFacturas.BusinessLayer;
using LPCFacturas.Entities;
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
    public partial class frmABMUsuario : Form
    {
        PerfilService oPerfilService = new PerfilService();
        UsuarioService oUsuarioService = new UsuarioService();
        bool nuevo = false;

        public frmABMUsuario()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmABMUsuario_Load(object sender, EventArgs e)
        {            
            cargarCombo(cboPerfil, oPerfilService.recuperarTodos(), "Nombre", "Id_perfil");
            cargarGrilla(dgvUsuario, oUsuarioService.recuperarTodos());
            habilitarCampos(false);
        }

        private void habilitarCampos(bool x)
        {
            cboPerfil.Enabled = x;
            txtEstado.Enabled = x;
            btnGuardar.Enabled = x;
            btnCancelar.Enabled = x;
            txtUsuario.Enabled = x;
            txtEmail.Enabled = x;
            txtPassword.Enabled = x;
            btnEliminar.Enabled = !x;
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnSalir.Enabled = !x;
            dgvUsuario.Enabled = !x;
            if (dgvUsuario.Rows.Count == 0)
                btnEditar.Enabled = btnEliminar.Enabled = false;
        }

        private void cargarCombo(ComboBox combo, Object source, string display, string value)
        {
            combo.DataSource = source;
            combo.DisplayMember = display;
            combo.ValueMember = value;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }

        private void cargarGrilla(DataGridView grilla, IList<Usuario> lista)
        {
            grilla.Rows.Clear();
            //for(int i = 0; i<lista.Count; i++)
            foreach (var usuario in lista)
            {
                grilla.Rows.Add(usuario.IdUsuario.ToString(),
                                usuario.Perfil.ToString(),
                                usuario.NombreUsuario.ToString(),
                                usuario.Email.ToString(),
                                usuario.Estado.ToString());
                                
            }
        }
        private void limpiarCampos()
        {
            txtId.Clear();
            txtUsuario.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtEstado.Clear();
            cboPerfil.SelectedIndex = -1;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            this.habilitarCampos(true);
            limpiarCampos();
            dgvUsuario.Enabled = false;
            cboPerfil.Focus();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitarCampos(false);
            nuevo = false;
            this.actualizarCampos(dgvUsuario.CurrentRow.Cells[2].Value.ToString());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarCampos(true);
            dgvUsuario.Enabled = false;
            cboPerfil.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que quiere eliminar el usuario?", "Borrar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Usuario oUsuario = new Usuario();
                
                oUsuario.IdUsuario = Convert.ToInt32(txtId.Text);
                oUsuarioService.eliminarUsuario(oUsuario);
                cargarGrilla(dgvUsuario, oUsuarioService.recuperarTodos());
                
            }
            habilitarCampos(false);
        }

        private void actualizarCampos(string idUsuario)
        {
            Usuario usuarioSeleccionado = oUsuarioService.recuperarUsuario(idUsuario);
            if (usuarioSeleccionado != null)
            {
                txtId.Text = usuarioSeleccionado.IdUsuario.ToString();
                cboPerfil.SelectedValue = usuarioSeleccionado.Perfil.Id_Perfil;
                txtUsuario.Text = usuarioSeleccionado.NombreUsuario;
                txtPassword.Text = usuarioSeleccionado.Password;
                txtEmail.Text = usuarioSeleccionado.Email;
                txtEstado.Text = usuarioSeleccionado.Estado;
            }
            else
                limpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Usuario oUsuario = new Usuario();
                //oProyecto.Id_proyecto = Convert.ToInt32(txtId.Text);
                oUsuario.Perfil = oPerfilService.recuperarPerfil(cboPerfil.SelectedValue.ToString());
                oUsuario.NombreUsuario = txtUsuario.Text;
                oUsuario.Email = txtEmail.Text;
                oUsuario.Password = txtPassword.Text;
                oUsuario.Estado = txtEstado.Text;
                if(nuevo)
                {
                    oUsuarioService.crearUsuario(oUsuario);
                    MessageBox.Show("¡Usuario creado con éxito!", "Crear usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    oUsuario.IdUsuario = Convert.ToInt32(txtId.Text);
                    oUsuarioService.actualizarUsuario(oUsuario);
                    MessageBox.Show("¡Usuario actualizado con éxito!", "Actualizar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cargarGrilla(dgvUsuario, oUsuarioService.recuperarTodos());
                habilitarCampos(false);
                this.nuevo = false;
            }
        }

        public bool validarCampos()
        {

            if (cboPerfil.SelectedIndex == -1)
            {
                MessageBox.Show("Datos ingresados no válidos. Debe seleccionar un perfil.", "Datos de usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPerfil.Focus();
                return false;
            }
            if (txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Datos ingresados no válidos. Debe ingresar un nombre de usuario.", "Datos de usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }
            if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Datos ingresados no válidos. Debe ingresar una contraseña.", "Datos de usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }
            if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Datos ingresados no válidos. Debe ingresar un email.", "Datos de usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            return true;
        }
        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.actualizarCampos(dgvUsuario.CurrentRow.Cells[2].Value.ToString());
        }

        private void dgvUsuario_SelectionChanged_1(object sender, EventArgs e)
        {
            this.actualizarCampos(dgvUsuario.CurrentRow.Cells[2].Value.ToString());
        }
    }
}
