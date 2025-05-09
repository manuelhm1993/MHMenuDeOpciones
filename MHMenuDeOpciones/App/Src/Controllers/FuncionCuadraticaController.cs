using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MHMenuDeOpciones.App.Src.Views;

namespace MHMenuDeOpciones.App.Src.Controllers
{
    public static class FuncionCuadraticaController
    {
        #region Campos de clase
        private static FuncionCuadraticaView _FormFuncionCuadratica = new FuncionCuadraticaView();
        #endregion

        #region Propiedades
        public static FuncionCuadraticaView FormFuncionCuadratica
        {
            get => _FormFuncionCuadratica;
            set => _FormFuncionCuadratica = value;
        }
        #endregion

        #region Métodos
        public static FuncionCuadraticaView GetView() => FormFuncionCuadratica;
        #endregion
    }
}
