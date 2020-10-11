using MiPrimerProyecto.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerProyecto.Formularios
{
    public partial class frmReporteBugs : Form
    {
        public frmReporteBugs()
        {
            InitializeComponent();
        }

        private void frmReporteBugs_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bugstrackerDataSet.Bugs' Puede moverla o quitarla según sea necesario.
            this.bugsTableAdapter.Fill(this.bugstrackerDataSet.Bugs);

            this.reportViewer1.RefreshReport();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Datos oDatos = new Datos();
            string SQL = "SELECT * FROM Bugs WHERE titulo LIKE '%" +
                        txtFiltro.Text + "%'";
            //Toma los datos;
            this.bugsBindingSource.DataSource = oDatos.consultar(SQL);

            //Refresca los datos a mostrar y por consecuente los muestra.
            this.reportViewer1.RefreshReport();
        }
    }
}
