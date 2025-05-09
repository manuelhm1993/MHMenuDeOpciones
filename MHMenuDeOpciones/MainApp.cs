using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using MHMenuDeOpciones.App.Src.Controllers;

namespace MHMenuDeOpciones
{
    internal static class MainApp
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MenuController.GetGUIMenuOpciones());
        }
    }
}
