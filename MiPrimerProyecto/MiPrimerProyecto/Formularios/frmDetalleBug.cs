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
    public partial class frmDetalleBug : Form
    {
        private int idBug;

        public frmDetalleBug()
        {
            InitializeComponent();
        }
        public frmDetalleBug(int idBug)
        {
            InitializeComponent();
            this.idBug = idBug;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDetalleBug_Load(object sender, EventArgs e)
        {
            actualizarBugs();
            
        }

        private void actualizarBugs()
        {
            DataTable tabla = new DataTable();
            Bug oBugSelecccionado = new Bug();
            tabla = oBugSelecccionado.recuperarBug(idBug);
            txtNumBug.Text = tabla.Rows[0]["id_bug"].ToString();
            txtTitulo.Text = tabla.Rows[0]["titulo"].ToString();
            txtProducto.Text = tabla.Rows[0]["Producto"].ToString();
            txtPrioridad.Text = tabla.Rows[0]["Prioridad"].ToString();
            txtCriticidad.Text = tabla.Rows[0]["Criticidad"].ToString();
            txtFechaCreacion.Text = tabla.Rows[0]["fecha_alta"].ToString();
            txtDescripcion.Text = tabla.Rows[0]["descripcion"].ToString();

            tabla.Clear();
            BugHistorico oBugHistorico = new BugHistorico();
            tabla = oBugHistorico.recuperarHistorico(idBug);
            cargarGrilla(grdHistorial, tabla);

        }
        private void cargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(
                    tabla.Rows[i]["fecha_historico"],
                    tabla.Rows[i]["Responsable"],
                    tabla.Rows[i]["Estado"],
                    tabla.Rows[i]["Asignado a"]
                    );
            }
        }
    }
}
