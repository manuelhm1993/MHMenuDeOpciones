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

        public static Resultado GetResultadoSumaCompra()
        {
            Resultado result = new Resultado();

            return result;
        }
        #endregion
    }
}
