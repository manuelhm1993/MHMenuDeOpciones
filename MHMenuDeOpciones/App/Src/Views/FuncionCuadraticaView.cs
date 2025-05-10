using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MHMenuDeOpciones.App.Src.Controllers;
using MHMenuDeOpciones.App.Src.Models;
using MHMenuDeOpciones.App.Utilities;

namespace MHMenuDeOpciones.App.Src.Views
{
    public partial class FuncionCuadraticaView : Form
    {
        #region Métodos
        public FuncionCuadraticaView()
        {
            InitializeComponent();

            Numbers = this.Controls.OfType<NumericUpDown>();

            Common.PonerEscuchaFocus(Numbers);
            Reset();
        }

        public void Reset()
        {
            foreach (NumericUpDown number in Numbers)
            {
                number.Value = 0;
            }

            this.numericUpDown1.Focus();
        }
        #endregion

        #region Eventos
        private void btnCalcularFC_Click(object sender, EventArgs e)
        {
            double a = (double)this.numericUpDown1.Value;
            double b = (double)this.numericUpDown2.Value;
            double c = (double)this.numericUpDown3.Value;

            Resultado result = FuncionCuadraticaController.GetResultadoFuncionCuadratica(a, b, c);

            MessageBox.Show(result.Text, result.Caption, result.Buttons, result.Icon);

            Reset();
        }

        private void btnCancelarFC_Click(object sender, EventArgs e)
        {
            Reset();
        }
        #endregion

        #region Campos de clase
        private IEnumerable<NumericUpDown> Numbers;
        #endregion
    }
}
