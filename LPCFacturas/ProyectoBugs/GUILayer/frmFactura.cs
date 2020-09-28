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
    public partial class frmFactura : Form
    {
        bool flagProducto = true;
        public frmFactura()
        {
            InitializeComponent();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {

        }

        private void rdbProducto_CheckedChanged(object sender, EventArgs e)
        {
            lblDetalle.Text = "Producto:";
            lblValor.Text = "Precio:";
            lblProporcion.Text = "Cantidad:";
        }

        private void rdbProyecto_CheckedChanged(object sender, EventArgs e)
        {
            lblDetalle.Text = "Proyecto:";
            lblValor.Text = "Costo/Hora:";
            lblProporcion.Text = "Horas:";
        }

        private void lblSubtotal_Click(object sender, EventArgs e)
        {

        }
    }
}
