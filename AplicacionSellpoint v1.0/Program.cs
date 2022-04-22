using AplicacionSellpoint_v1._0.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionSellpoint_v1._0
{
    internal static class Program
    {

        public static string nombreDeUsuario = string.Empty;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmIniciarSesion());
            if (Program.nombreDeUsuario.Length > 0)
            {
                Application.Run(new frmMenuPrincipal());
            }
        }
    }
}