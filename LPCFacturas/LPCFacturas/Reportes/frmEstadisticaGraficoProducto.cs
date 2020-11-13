using LPCFacturas.BusinessLayer;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPCFacturas.Reportes
{
    public partial class frmEstadisticaGraficoProducto : Form
    {
        ProductoService oProductoService = new ProductoService();
        public frmEstadisticaGraficoProducto()
        {
            InitializeComponent();
        }

        private void frmEstadisticaGraficoProducto_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = oProductoService.recuperarProductosEstadisticas();

            ReportDataSource ds = new ReportDataSource("DatosEstadisticosProductos", tabla);

            

            DataTable tabla2 = new DataTable();
            tabla2 = oProductoService.recuperarProcutosEstadisticasImporte();

            ReportDataSource ds2 = new ReportDataSource("DatosEstadisticosProductosImporte", tabla2);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.DataSources.Add(ds2);
            reportViewer1.LocalReport.Refresh();
        }

        private void frmEstadisticaGraficoProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
