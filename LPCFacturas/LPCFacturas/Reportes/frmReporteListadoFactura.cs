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
    public partial class frmReporteListadoFactura : Form
    {
        private FacturaService oFacturaService = new FacturaService();
        private ClienteService oClienteService = new ClienteService();
        public frmReporteListadoFactura()
        {
            InitializeComponent();
        }

        private void frmReporteListadoFactura_Load(object sender, EventArgs e)
        {
            cargarCombo(cboCliente, oClienteService.recuperarTodos(), "razon_social", "id_cliente");
            this.rvwFacturas.RefreshReport();
        }

        private void cargarCombo(ComboBox combo, Object source, string display, string value)
        {
            combo.DataSource = source;
            combo.DisplayMember = display;
            combo.ValueMember = value;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string cliente;
            string monto;
            if (cboCliente.SelectedIndex == -1)
                cliente = "-1";
            else
                cliente = cboCliente.SelectedValue.ToString();
            DataTable tabla = new DataTable();
            if (txtMonto.Text == string.Empty)
                monto = "-1";
            else
                monto = txtMonto.Text;

            tabla = oFacturaService.recuperarFacturas(dtpFechaDesde.Value, dtpFechaHasta.Value, cliente, monto);

            ReportDataSource ds = new ReportDataSource("ListadoFactura", tabla);

            rvwFacturas.LocalReport.DataSources.Clear();
            rvwFacturas.LocalReport.DataSources.Add(ds);
            rvwFacturas.LocalReport.Refresh();
            rvwFacturas.RefreshReport();
        }

        private void frmReporteListadoFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Está seguro que quiere salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
