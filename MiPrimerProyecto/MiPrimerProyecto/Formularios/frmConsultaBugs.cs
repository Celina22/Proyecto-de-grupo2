using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiPrimerProyecto.Clases;

namespace MiPrimerProyecto.Formularios
{
    public partial class frmConsultaBugs : Form
    {
        Datos oBD = new Datos();
        Bug oBug = new Bug();

        public frmConsultaBugs()
        {
            InitializeComponent();
        }

        private void frmConsultaBugs_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;

            this.cargarCombo(cboEstado, "Estados");
            this.cargarCombo(cboPrioridad, "Prioridades");
            this.cargarCombo(cboProducto, "Productos");
            this.cargarCombo(cboAsignadoA, "Usuarios", 2);
            this.cargarCombo(cboCriticidad, "Criticidades");

            this.cargarGrilla(grdBugs, oBug.recuperarBugs());
        }

        private void cargarGrilla(DataGridView grilla, DataTable tabla)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_bug"], tabla.Rows[i]["titulo"], tabla.Rows[i]["Producto"], tabla.Rows[i]["fecha_alta"], tabla.Rows[i]["Estado"], tabla.Rows[i]["Asignado a"], tabla.Rows[i]["Criticidad"], tabla.Rows[i]["Prioridad"]);
            }
        }
        private void cargarCombo(ComboBox combo, string nombreTabla, int n = 1)
        {
            DataTable tabla = new DataTable();
            tabla = oBD.consultarTabla(nombreTabla);
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[n].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.cargarGrilla(grdBugs, oBug.recuperarBugs());
        }
    }
}
