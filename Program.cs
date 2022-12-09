using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega_Final
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Interfaz_Productos());
            //Application.Run(new Interfaz_Em());
            //Application.Run(new Interfaz_Ventas());
            Application.Run(new Inicio_S());
            //Application.Run(new Interfaz_Admin());
        }
    }
}
