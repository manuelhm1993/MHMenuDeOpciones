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

        public static Resultado GetResultadoFuncionCuadratica(double a, double b, double c)
        {
            Resultado result = new Resultado();

            double delta = (b * b) - (4 * a * c);

            if (delta > 0)
            {
                delta = Math.Sqrt(delta);

                double x1 = (-b + delta) / (2 * a);
                double x2 = (-b - delta) / (2 * a);

                System.Globalization.CultureInfo culturaVenezuela = new System.Globalization.CultureInfo("es-VE");

                //result.Text = $"Raices reales: x1 = { string.Format("{0:N2}", x1) }, x2 = { string.Format("{0:N2}", x2) }";
                result.Text = $"Raices reales: x1 = {x1.ToString("N2", culturaVenezuela)} && x2 = {x2.ToString("N2", culturaVenezuela)}";
                result.Caption = "Éxito";
                result.Buttons = MessageBoxButtons.OK;
                result.Icon = MessageBoxIcon.Information;
            }
            else if (delta == 0)
            {
                result.Text = "Solo Chuck Norris puede dividir por cero";
                result.Caption = "Error";
                result.Buttons = MessageBoxButtons.OK;
                result.Icon = MessageBoxIcon.Error;
            }
            else
            {
                result.Text = "Solo Chuck Norris puede dividir sacar la raíz de un número negativo";
                result.Caption = "Error";
                result.Buttons = MessageBoxButtons.OK;
                result.Icon = MessageBoxIcon.Error;
            }

            return result;
        }
        #endregion
    }
}
