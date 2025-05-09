using MHMenuDeOpciones.App.Src.Controllers;
using MHMenuDeOpciones.App.Src.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHMenuDeOpciones.App.Src.Views
{
    public partial class FuncionCuadraticaView : Form
    {
        #region Métodos
        public FuncionCuadraticaView()
        {
            InitializeComponent();

            Numbers = this.Controls.OfType<NumericUpDown>();

            PonerEscuchaFocus();
            Reset();
        }

        public void Reset()
        {
            this.TopLevel = false;
            this.TopMost = false;

            ResetNumericUpDown();
        }

        private void ResetNumericUpDown()
        {
            foreach (NumericUpDown number in Numbers)
            {
                number.Value = 0;
            }

            this.numericUpDown1.Focus();
        }

        private void PonerEscuchaFocus()
        {
            foreach (NumericUpDown number in Numbers)
            {
                number.GotFocus += new System.EventHandler(this.numericUpDownGotFocus);
            }
        }
        #endregion

        #region Eventos
        private void btnCalcularFC_Click(object sender, EventArgs e)
        {
            double a = (double)this.numericUpDown1.Value;
            double b = (double)this.numericUpDown2.Value;
            double c = (double)this.numericUpDown3.Value;

            FuncionCuadratica result = FuncionCuadraticaController.GetResultadoFuncionCuadratica(a, b, c);

            MessageBox.Show(result.Text, result.Caption, result.Buttons, result.Icon);

            Reset();
        }

        private void numericUpDownGotFocus(object sender, EventArgs e)
        {
            NumericUpDown number = (NumericUpDown)sender;
            if (number.Controls.Count > 0)
            {
                foreach (Control control in number.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        textBox.SelectAll();
                        break;
                    }
                }
            }
        }

        private void btnCancelarFC_Click(object sender, EventArgs e)
        {
            ResetNumericUpDown();
        }
        #endregion

        #region Campos de clase
        private IEnumerable<NumericUpDown> Numbers;
        #endregion
    }
}
