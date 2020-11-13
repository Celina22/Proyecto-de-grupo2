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
    public partial class frmEstadisticaGraficoProyecto : Form
    {
        ProyectoService oProyectoService = new ProyectoService();
        public frmEstadisticaGraficoProyecto()
        {
            InitializeComponent();
        }

        private void frmEstadisticaProyecto_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = oProyectoService.recuperarProyectosFacturadosEstadistica(dtpFechaDesde.Value, dtpFechaHasta.Value);

            ReportDataSource ds = new ReportDataSource("ProyectosFacturados", tabla);

            DataTable tabla1 = new DataTable();
            tabla1 = oProyectoService.recuperarProyectosPorResponsables(dtpFechaDesde.Value, dtpFechaHasta.Value);

            ReportDataSource ds1 = new ReportDataSource("ResponsablesProyecto", tabla1);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.DataSources.Add(ds1);
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("prmFechaDesde", dtpFechaDesde.Value.ToShortDateString()),
                                                                            new ReportParameter("prmFechaHasta", dtpFechaHasta.Value.ToShortDateString())});
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }

        private void frmEstadisticaGraficoProyecto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
