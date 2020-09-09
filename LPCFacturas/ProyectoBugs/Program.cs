using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LPCFacturas.GUILayer;
<<<<<<< HEAD
=======
using ProyectoBugs.GUILayer;
>>>>>>> 2d6edb7a6d04db306345006bac23d76f6f1540b0

namespace LPCFacturas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        }
    }
}
