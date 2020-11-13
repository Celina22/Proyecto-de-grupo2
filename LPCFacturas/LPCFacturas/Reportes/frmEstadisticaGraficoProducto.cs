﻿using LPCFacturas.BusinessLayer;
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

            this.rptProductos.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void frmEstadisticaGraficoProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = oProductoService.recuperarProductosEstadisticas(dtpFechaDesde.Value, dtpFechaHasta.Value);

            ReportDataSource ds = new ReportDataSource("DatosEstadisticosProductos", tabla);


            DataTable tabla2 = new DataTable();
            tabla2 = oProductoService.recuperarProcutosEstadisticasImporte(dtpFechaDesde.Value, dtpFechaHasta.Value);

            ReportDataSource ds2 = new ReportDataSource("DatosEstadisticosProductosImporte", tabla2);

            rptProductos.LocalReport.DataSources.Clear();
            rptProductos.LocalReport.DataSources.Add(ds);
            rptProductos.LocalReport.DataSources.Add(ds2);
            rptProductos.LocalReport.Refresh();
            rptProductos.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("prmFechaDesde", dtpFechaDesde.Value.ToShortDateString()),
                                                                            new ReportParameter("prmFechaHasta", dtpFechaHasta.Value.ToShortDateString())});
            rptProductos.RefreshReport();
        }
    }
}
