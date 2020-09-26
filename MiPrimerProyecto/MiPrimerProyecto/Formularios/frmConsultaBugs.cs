using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
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

            this.cargarGrilla(grdBugs, oBug.recuperarTodos());
        }

        private void cargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(
                    tabla.Rows[i]["id_bug"], 
                    tabla.Rows[i]["titulo"], 
                    tabla.Rows[i]["Producto"], 
                    tabla.Rows[i]["fecha_alta"], 
                    tabla.Rows[i]["Estado"], 
                    tabla.Rows[i]["Asignado a"], 
                    tabla.Rows[i]["Criticidad"], 
                    tabla.Rows[i]["Prioridad"]
                    );
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
            DataTable tabla = new DataTable();
            string _estado, _prioridad, _producto, _asignadoA, _criticidad;
            _estado = _prioridad = _producto = _asignadoA = _criticidad = "";
            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("Los datos ingresados para las fechas no son válidos.");
                return;
            }

            if (cboEstado.SelectedIndex != -1)
                _estado = cboEstado.SelectedValue.ToString();
            if (cboPrioridad.SelectedIndex != -1)
                _estado = cboPrioridad.SelectedValue.ToString();
            if (cboProducto.SelectedIndex != -1)
                _estado = cboProducto.SelectedValue.ToString();
            if (cboAsignadoA.SelectedIndex != -1)
                _estado = cboAsignadoA.SelectedValue.ToString();
            if (cboCriticidad.SelectedIndex != -1)
                _estado = cboCriticidad.SelectedValue.ToString();

            tabla = oBug.filtrarBugs(dtpFechaDesde.Value.ToShortDateString(),
                                                        dtpFechaHasta.Value.ToShortDateString(),
                                                        _estado,
                                                        _prioridad,
                                                        _producto,
                                                        _asignadoA,
                                                        _criticidad);
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No existen Bugs con esas condiciones...");
                dtpFechaDesde.Value = DateTime.Today;
                dtpFechaHasta.Value = DateTime.Today;
                cboProducto.SelectedIndex = -1;
                cboPrioridad.SelectedIndex = -1;
                cboEstado.SelectedIndex = -1;
                cboAsignadoA.SelectedIndex = -1;
                cboCriticidad.SelectedIndex = -1;
            }
            
            this.cargarGrilla(grdBugs, tabla);
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (grdBugs.SelectedRows.Count == 1)
            {
                frmDetalleBug fdb = new frmDetalleBug((int)grdBugs.CurrentRow.Cells[0].Value);
                fdb.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar algún elemento de la grilla.");
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmBug frmBug = new frmBug();
            frmBug.ShowDialog();
        }
    }
}
