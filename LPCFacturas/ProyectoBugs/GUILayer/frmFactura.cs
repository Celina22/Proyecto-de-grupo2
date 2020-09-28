using LPCFacturas.BusinessLayer;
using LPCFacturas.Entities;
using System;
using System.Collections;
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
    public partial class frmFactura : Form
    {
        ClienteService oClienteService = new ClienteService();
        ProductoService oProductoService = new ProductoService();
        ProyectoService oProyectoService = new ProyectoService();
        int ordenDetalle = 0;
        IList<DetalleFactura> listaDetalleFactura;

        IList<DetalleFactura> detalles;
        bool flagProducto = false;
        public frmFactura()
        {
            InitializeComponent();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            rdbProyecto.Checked = true;
        }

        private void rdbProducto_CheckedChanged(object sender, EventArgs e)
        {
            limpiarCampos();
            flagProducto = true;
            lblDetalle.Text = "Producto:";
            lblValor.Text = "Precio:";
            lblProporcion.Text = "Cantidad:";

        }

        private void rdbProyecto_CheckedChanged(object sender, EventArgs e)
        {
            limpiarCampos();
            flagProducto = false;
            lblDetalle.Text = "Proyecto:";
            lblValor.Text = "Costo/Hora:";
            lblProporcion.Text = "Horas:";
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtIdCliente.Text != string.Empty)
            {
                int numero;
                if (Int32.TryParse(txtIdCliente.Text, out numero))
                {
                    Cliente oCliente;
                    oCliente = oClienteService.recuperarCliente(txtIdCliente.Text);
                    if (oCliente != null)
                    {
                        txtNombreCliente.Text = oCliente.Razon_social;
                    }
                    else
                        MessageBox.Show("Cliente no encontrado...");
                }

            }    
        }

        private void txtIdDetalle_Leave(object sender, EventArgs e)
        {
            if(flagProducto)
            {
                int numero;
                if (Int32.TryParse(txtIdDetalle.Text, out numero))
                {
                    Producto oProducto;
                    oProducto = oProductoService.recuperarProducto(txtIdDetalle.Text);
                    if (oProducto != null)
                    {
                        txtDetalle.Text = oProducto.Nombre;
                    }
                    else
                        MessageBox.Show("Producto no encontrado...");
                }
            }
            else
            {
                int numero;
                if (Int32.TryParse(txtIdDetalle.Text, out numero))
                {
                    Proyecto oProyecto;
                    oProyecto = oProyectoService.recuperarProyecto(txtIdDetalle.Text);
                    if (oProyecto != null)
                    {
                        txtDetalle.Text = oProyecto.Descripcion;
                    }
                    else
                        MessageBox.Show("Proyecto no encontrado...");
                }
            }
        }

        private void limpiarCampos()
        {
            txtIdDetalle.Text = txtDetalle.Text = string.Empty;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(validarCampos())
            {
                dgvDetalles.Rows.Add(txtIdDetalle.Text.ToString(),
                                txtDetalle.Text.ToString(),
                                txtProporcion.Text.ToString(),
                                txtValor.Text.ToString(),
                                txtSubtotal.Text.ToString());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool validarCampos()
        {

            if (txtDetalle.Text == string.Empty)
            {
                MessageBox.Show("Datos ingresados no válidos. Debe seleccionar un producto o proyecto.", "Datos de factura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDetalle.Focus();
                return false;
            }
            if (txtValor.Text == string.Empty)
            {
                MessageBox.Show("Datos ingresados no válidos. Debe ingresar un valor del producto o proyecto.", "Datos de factura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
                return false;
            }
            if (txtProporcion.Text == string.Empty)
            {
                MessageBox.Show("Datos ingresados no válidos. Debe ingresar una cantidad a facturar.", "Datos de factura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProporcion.Focus();
                return false;
            }
            return true;
        }
    }
}
