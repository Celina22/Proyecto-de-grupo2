using LPCFacturas.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPCFacturas.GUILayer
{
    public partial class frmProductos : Form
    {
        ProductoService oProductoService = new ProductoService();
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            habilitarCampos(false);
        }
        private void habilitarCampos(bool x)
        {
            txtNombre.Enabled = x;
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnEliminar.Enabled = !x;
            btnSalir.Enabled = !x;
            dgvProductos.Enabled = !x;
            if (dgvProductos.Rows.Count == 0)
                btnEditar.Enabled = btnEliminar.Enabled = false;
        }

        private void habilitarFiltros(bool x)
        {
            txtNombre.Enabled = x;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMProductos aBMProducto = new frmABMProductos();
            aBMProducto.ShowDialog();
        }

        private void chbNoFiltrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNoFiltrar.Checked)
            {
                habilitarFiltros(false);
            }
            else
            {
                habilitarFiltros(true);
            }
        }
    }
}
