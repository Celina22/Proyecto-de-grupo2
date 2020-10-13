using LPCFacturas.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LPCFacturas.BusinessLayer;
using Microsoft.Reporting.WinForms;

namespace LPCFacturas.Reportes
{
    public partial class frmReporteListadoProducto : Form
    {
        private ProductoService oProductoService = new ProductoService();
        public frmReporteListadoProducto()
        {
            InitializeComponent();
        }

        private void frmReporteListadoProducto_Load(object sender, EventArgs e)
        {

            this.rvwProductos.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void cargarCombo(ComboBox combo, Object source, string display, string value)
        {
            combo.DataSource = source;
            combo.DisplayMember = display;
            combo.ValueMember = value;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string nombre;
            if (txtNombre.Text == string.Empty)
                nombre = "-1";
            else
                nombre = txtNombre.Text;
            DataTable tabla = new DataTable();
            tabla = oProductoService.recuperarProductos(dtpFechaDesde.Value, dtpFechaHasta.Value, nombre);

            ReportDataSource ds = new ReportDataSource("ListadoProductos", tabla);

            rvwProductos.LocalReport.DataSources.Clear();
            rvwProductos.LocalReport.DataSources.Add(ds);
            rvwProductos.LocalReport.Refresh();
            rvwProductos.RefreshReport();
        }
    }
}
