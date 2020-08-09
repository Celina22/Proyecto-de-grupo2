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

namespace MiPrimerProyecto
{
    public partial class frm_principal : Form
    {
        Usuario usuarioActual;
        public frm_principal()
        {
            InitializeComponent();
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            frm_login flogin;
            flogin = new frm_login();
            flogin.ShowDialog();
            this.usuarioActual = flogin.Usuario;
        }
    }
}
