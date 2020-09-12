using LPCFacturas.DataAccessLayer;
using LPCFacturas.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBugs.GUILayer
{
    public partial class frmABMProyecto : Form
    {
        ProyectoDao oProyecto = new ProyectoDao();
        public frmABMProyecto()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmABMProyecto_Load(object sender, EventArgs e)
        {
            habilitarCampos(false);
            cargarCombo(cboProducto, "productos");
            cargarCombo(cboResponsable, "usuarios", 2);
            cargarGrilla(dgvProyecto, oProyecto.GetAll());

        }

        private void habilitarCampos(bool x)
        {
            cboProducto.Enabled = x;
            cboResponsable.Enabled = x;
            btnGuardar.Enabled = x;
            btnCancelar.Enabled = x;
            txtDescripcion.Enabled = x;
            txtAlcance.Enabled = x;
            txtVersion.Enabled = x;
            btnEliminar.Enabled = !x;
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnSalir.Enabled = !x;
            dgvProyecto.Enabled = !x;
        }

        private void cargarCombo(ComboBox combo, string nombreTabla, int n = 1)
        {
            var strSql = "SELECT * FROM " + nombreTabla;

            var tabla = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[n].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }

        private void cargarGrilla(DataGridView grilla, IList<Proyecto> lista)
        {
            grilla.Rows.Clear();
            //for(int i = 0; i<lista.Count; i++)
            foreach (var proyecto in lista)
            {
                grilla.Rows.Add(proyecto.Id_proyecto.ToString(),
                                proyecto.Producto.ToString(),
                                proyecto.Descripcion.ToString(),
                                proyecto.Version.ToString(),
                                proyecto.Responsable.ToString());
            }
        }
    }
}
