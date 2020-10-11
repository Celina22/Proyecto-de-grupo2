using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LPCFacturas.Entities;
using LPCFacturas.BusinessLayer;

namespace LPCFacturas.Reportes
{
    public partial class frmReporteCliente : Form
    {
        ClienteService oClienteService = new ClienteService();
        public frmReporteCliente()
        {
            InitializeComponent();
        }

        private void frmReporteCliente_Load(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Fill(this.reporteClienteDataSet.Clientes); ;
            this.reportViewer1.RefreshReport();
        }
    }
}
