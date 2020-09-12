using LPCFacturas.BusinessLayer;
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
    public partial class frmABMProyecto : Form
    {
        ProyectoService oProyectoService = new ProyectoService();
        UsuarioService oUsuarioService = new UsuarioService();
        ProductoService oProductoService = new ProductoService();
        bool nuevo = false;

        public frmABMProyecto()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmABMProyecto_Load(object sender, EventArgs e)
        {
            habilitarCampos(false);
            cargarCombo(cboProducto, oProductoService.recuperarTodos(), "Nombre", "Id_producto");
            cargarCombo(cboResponsable, oUsuarioService.recuperarTodos(), "NombreUsuario", "NombreUsuario");
            cargarGrilla(dgvProyecto, oProyectoService.recuperarTodos());


        }

        private void habilitarCampos(bool x)
        {
            cboProducto.Enabled = x;
            cboResponsable.Enabled = x;
            btnGuardar.Enabled = x;
            btnCancelar.Enabled = x;
            txtDescripcion.Enabled = x;
            txtAlcance.Enabled = x;
            txtVersion.Enabled = x;
            btnEliminar.Enabled = !x;
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnSalir.Enabled = !x;
            dgvProyecto.Enabled = !x;
            if (dgvProyecto.Rows.Count == 0)
                btnEditar.Enabled = btnEliminar.Enabled = false;
        }

        private void cargarCombo(ComboBox combo, Object source , string display, string value)
        {
            combo.DataSource = source;
            combo.DisplayMember = display;
            combo.ValueMember = value;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }

        private void cargarGrilla(DataGridView grilla, IList<Proyecto> lista)
        {
            grilla.Rows.Clear();
            //for(int i = 0; i<lista.Count; i++)
            foreach (var proyecto in lista)
            {
                grilla.Rows.Add(proyecto.Id_proyecto.ToString(),
                                proyecto.Producto.ToString(),
                                proyecto.Descripcion.ToString(),
                                proyecto.Version.ToString(),
                                proyecto.Responsable.ToString());
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            this.habilitarCampos(true);
            limpiarCampos();
            dgvProyecto.Enabled = false;
            cboProducto.Focus();
        }

        private void limpiarCampos()
        {
            txtId.Clear();
            txtDescripcion.Clear();
            txtAlcance.Clear();
            txtVersion.Clear();
            cboProducto.SelectedIndex = -1;
            cboResponsable.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitarCampos(false);
            nuevo = false;
            limpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarCampos(true);
            dgvProyecto.Enabled = false;
            cboProducto.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que quiere eliminar el proyecto?", "Borrar proyecto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Proyecto oProyecto = new Proyecto();
                oProyecto.Id_proyecto = Convert.ToInt32(txtId.Text);
                oProyectoService.eliminarProyecto(oProyecto);
                cargarGrilla(dgvProyecto, oProyectoService.recuperarTodos());
                
            }
            habilitarCampos(false);
        }

        private void actualizarCampos(string idProyecto)
        {
            Proyecto proyectoSeleccionado = oProyectoService.recuperarProyecto(idProyecto);
            if (proyectoSeleccionado != null)
            {
                txtId.Text = proyectoSeleccionado.Id_proyecto.ToString();
                cboProducto.SelectedValue = proyectoSeleccionado.Producto.Id_producto;
                txtDescripcion.Text = proyectoSeleccionado.Descripcion;
                txtVersion.Text = proyectoSeleccionado.Version;
                txtAlcance.Text = proyectoSeleccionado.Alcance;
                cboResponsable.SelectedValue = proyectoSeleccionado.Responsable.NombreUsuario;
            }
            else
                limpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Proyecto oProyecto = new Proyecto();
                //oProyecto.Id_proyecto = Convert.ToInt32(txtId.Text);
                oProyecto.Producto = oProductoService.recuperarProducto(cboProducto.SelectedValue.ToString());
                oProyecto.Descripcion = txtDescripcion.Text;
                oProyecto.Alcance = txtAlcance.Text;
                oProyecto.Version = txtVersion.Text;
                oProyecto.Responsable = oUsuarioService.recuperarUsuario(cboResponsable.SelectedValue.ToString());
                if(nuevo)
                {
                    oProyectoService.crearProyecto(oProyecto);
                    MessageBox.Show("Proyecto creado con exito!");
                }
                else
                {
                    oProyecto.Id_proyecto = Convert.ToInt32(txtId.Text);
                    oProyectoService.actualizarProyecto(oProyecto);
                    MessageBox.Show("Proyecto actualizado con exito!");
                }
                cargarGrilla(dgvProyecto, oProyectoService.recuperarTodos());
                habilitarCampos(false);
                this.nuevo = false;
            }
        }

        public bool validarCampos()
        {

            if (cboProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un producto");
                cboProducto.Focus();
                return false;
            }
            if (txtDescripcion.Text == string.Empty)
            {
                MessageBox.Show("Debe colocar una descripcion");
                txtDescripcion.Focus();
                return false;
            }
            if (txtVersion.Text == string.Empty)
            {
                MessageBox.Show("Debe colocar una Version");
                txtVersion.Focus();
                return false;
            }
            if (txtAlcance.Text == string.Empty)
            {
                MessageBox.Show("Debe colocar un alcance");
                txtAlcance.Focus();
                return false;
            }
 
            if (cboResponsable.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un usuario responsable");
                cboResponsable.Focus();
                return false;
            }

            return true;
        }

        private void dgvProyecto_SelectionChanged(object sender, EventArgs e)
        {
            this.actualizarCampos(dgvProyecto.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
