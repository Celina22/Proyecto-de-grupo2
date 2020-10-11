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
    public partial class frmBug : Form
    {
        public frmBug()
        {
            InitializeComponent();
        }

        private void frmBug_Load(object sender, EventArgs e)
        {
            this.cargarCombo(cboProducto, "Productos");
            this.cargarCombo(cboCriticidad, "Criticidades");
            this.cargarCombo(cboPrioridad, "Prioridades");

        }
        private void cargarCombo(ComboBox combo, string nombreTabla, int n = 1)
        {
            DataTable tabla = new DataTable();
            tabla = DataManager.GetInstance().ConsultaSQL("SELECT * FROM " + nombreTabla);
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[n].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Validar si Existe
            //Validar datos
            Bug oBug = new Bug();
            oBug.Titulo = txtTitulo.Text;
            oBug.Descripcion = txtDescripcion.Text;
            oBug.Id_criticidad = (int)cboCriticidad.SelectedValue;
            oBug.Id_producto = (int)cboProducto.SelectedValue;
            oBug.Id_prioridad = (int)cboPrioridad.SelectedValue;
            oBug.Id_estado = 1;

            BugHistorico oBugHistorico = new BugHistorico();
            oBugHistorico.Fecha_historico = DateTime.Today;
            oBugHistorico.Id_usuario_responsable = 1;
            //oBug.crearBug();
        }
    }
}
