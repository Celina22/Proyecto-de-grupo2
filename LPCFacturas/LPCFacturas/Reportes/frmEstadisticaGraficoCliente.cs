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
    public partial class frmEstadisticaGraficoCliente : Form
    {
        private ClienteService oClienteService = new ClienteService();
        
        public frmEstadisticaGraficoCliente()
        {
            InitializeComponent();
        }

        private void frmEstadisticaGraficoCliente_Load(object sender, EventArgs e)
        {

            this.rvwGraficosClientes.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = oClienteService.recuperarClientes(dtpFechaDesde.Value, dtpFechaHasta.Value);

            ReportDataSource ds = new ReportDataSource("GraficoClientes", tabla);

            rvwGraficosClientes.LocalReport.DataSources.Clear();
            rvwGraficosClientes.LocalReport.DataSources.Add(ds);
            rvwGraficosClientes.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("prmFechaDesde", dtpFechaDesde.Value.ToShortDateString()),
                                                                            new ReportParameter("prmFechaHasta", dtpFechaHasta.Value.ToShortDateString())});
            rvwGraficosClientes.RefreshReport();

            DataTable tabla2 = new DataTable();
            //tabla = 
        }
    }
}
