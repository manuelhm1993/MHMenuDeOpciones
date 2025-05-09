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

            Reset();
        }

        public void Reset()
        {
            this.TopLevel = false;
            this.TopMost = false;

            foreach(NumericUpDown txt in this.Controls.OfType<NumericUpDown>())
            {
                txt.Value = 0;
            }
        }
        #endregion

        #region Eventos
        private void btnCalcularFC_Click(object sender, EventArgs e)
        {
            double a = (double)this.numericUpDown1.Value;
            double b = (double)this.numericUpDown2.Value;
            double c = (double)this.numericUpDown3.Value;

            double delta = (b * b) - (4 * a * c);

            if (delta > 0)
            {
                delta = Math.Sqrt(delta);

                double x1 = (-b + delta) / (2 * a);
                double x2 = (-b - delta) / (2 * a);

                MessageBox.Show(
                    $"Raices reales: x1 = { x1 }, x2 = { x2 }",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else if (delta == 0)
            {
                MessageBox.Show(
                    "Solo Chuck Norris puede dividir por cero", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                );
            }
            else
            {
                MessageBox.Show(
                    "Solo Chuck Norris puede dividir sacar la raíz de un número negativo",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        #endregion
    }
}
