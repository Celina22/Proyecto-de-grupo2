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
    public partial class frmEstadisticaGraficoFactura : Form
    {
        private FacturaService oFacturaService = new FacturaService();
        public frmEstadisticaGraficoFactura()
        {
            InitializeComponent();
        }

        private void frmEstadisticaGraficoFactura_Load(object sender, EventArgs e)
        {

            this.rpvGraficoFacturas.RefreshReport();
            DataTable tabla = new DataTable();
            tabla = oFacturaService.recuperarTodas();

            DataTable tabla1 = new DataTable();
            tabla1 = oFacturaService.recuperarTodasPorMes();

            DataTable tabla2 = new DataTable();
            tabla2 = oFacturaService.recuperarTodasTotal();

            ReportDataSource ds = new ReportDataSource("GraficoFacturas", tabla);
            ReportDataSource ds1 = new ReportDataSource("GraficoFacturasPorMes", tabla1);
            ReportDataSource ds2 = new ReportDataSource("GraficoFacturasTotal", tabla2);


            rpvGraficoFacturas.LocalReport.DataSources.Clear();
            rpvGraficoFacturas.LocalReport.DataSources.Add(ds);
            rpvGraficoFacturas.LocalReport.DataSources.Add(ds1);
            rpvGraficoFacturas.LocalReport.DataSources.Add(ds2);
            rpvGraficoFacturas.LocalReport.Refresh();
            rpvGraficoFacturas.RefreshReport();
        }
    }
}
