using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MHMenuDeOpciones.App.Src.Models;
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

        public static Object GetResultadoFuncionCuadratica(double a, double b, double c)
        {
            double delta = (b * b) - (4 * a * c);
            Object result = null;

            if (delta > 0)
            {
                delta = Math.Sqrt(delta);

                double x1 = (-b + delta) / (2 * a);
                double x2 = (-b - delta) / (2 * a);

                result = FuncionCuadratica.Resultado = new Dictionary<string, string> {
                    { "Text", $"Raices reales: x1 = {x1}, x2 = {x2}" },
                    { "Caption", "Éxito" },
                    { "Buttons", "" + MessageBoxButtons.OK },
                    { "Icon", "" + MessageBoxIcon.Information },
                };
            }
            else if (delta == 0)
            {
                result = FuncionCuadratica.Resultado = new Dictionary<string, string> {
                    { "Text", "Solo Chuck Norris puede dividir por cero" },
                    { "Caption", "Error" },
                    { "Buttons", "" + MessageBoxButtons.OK },
                    { "Icon", "" + MessageBoxIcon.Error },
                };
            }
            else
            {
                result = FuncionCuadratica.Resultado = new Dictionary<string, string> {
                    { "Text", "Solo Chuck Norris puede dividir sacar la raíz de un número negativo" },
                    { "Caption", "Error" },
                    { "Buttons", "" + MessageBoxButtons.OK },
                    { "Icon", "" + MessageBoxIcon.Error },
                };
            }

            return result;
        }
        #endregion
    }
}
