using MHMenuDeOpciones.App.Src.Models;
using MHMenuDeOpciones.App.Src.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHMenuDeOpciones.App.Src.Controllers
{
    public static class CalcularEdadController
    {
        #region Campos de clase
        private static CalcularEdadView _FormCalcularEdadView = new CalcularEdadView();
        #endregion

        #region Propiedades
        public static CalcularEdadView FormCalcularEdadView
        {
            get => _FormCalcularEdadView;
            set => _FormCalcularEdadView = value;
        }
        #endregion

        #region Métodos
        public static CalcularEdadView GetView() => FormCalcularEdadView;

        public static Resultado GetEdad(DateTime Fecha)
        {
            Resultado result = new Resultado();

            result.Text = $"Usted tiene { DateTime.Now.Year - Fecha.Year } años";
            result.Caption = "Éxito";
            result.Buttons = MessageBoxButtons.OK;
            result.Icon = MessageBoxIcon.Information;

            return result;
        }
        #endregion
    }
}
