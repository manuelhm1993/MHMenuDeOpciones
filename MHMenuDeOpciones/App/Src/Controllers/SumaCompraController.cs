using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

using MHMenuDeOpciones.App.Src.Models;
using MHMenuDeOpciones.App.Src.Views;

namespace MHMenuDeOpciones.App.Src.Controllers
{
    public static class SumaCompraController
    {
        #region Campos de clase
        private static SumaCompraView _FormSumaCompraView = new SumaCompraView();
        #endregion

        #region Propiedades
        public static SumaCompraView FormSumaCompraView
        {
            get => _FormSumaCompraView;
            set => _FormSumaCompraView = value;
        }
        #endregion

        #region Métodos
        public static SumaCompraView GetView() => FormSumaCompraView;

        public static Resultado GetResultadoSumaCompra(IEnumerable<NumericUpDown> items)
        {
            Resultado result = new Resultado();

            double suma = 0;

            foreach (NumericUpDown item in items)
            {
                suma += (double)item.Value;
            }

            CultureInfo ves = new CultureInfo("es-VE");

            result.Text = $"El total de la compra es: ${suma.ToString("N2", ves)}";
            result.Caption = "Éxito";
            result.Buttons = MessageBoxButtons.OK;
            result.Icon = MessageBoxIcon.Information;

            return result;
        }
        #endregion
    }
}
