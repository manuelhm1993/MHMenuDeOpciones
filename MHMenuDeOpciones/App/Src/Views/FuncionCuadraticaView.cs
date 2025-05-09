using MHMenuDeOpciones.App.Src.Controllers;
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

            Dictionary<string, string> result = (Dictionary<string, string>)FuncionCuadraticaController.GetResultadoFuncionCuadratica(a, b, c);

            MessageBoxButtons buttons;
            if (!Enum.TryParse(result["Buttons"], out buttons)) buttons = MessageBoxButtons.OK;

            MessageBoxIcon icon;
            if (!Enum.TryParse(result["Icon"], out icon)) icon = MessageBoxIcon.Information;

            MessageBox.Show(result["Text"], result["Caption"], buttons, icon);

            Reset();
        }
        #endregion
    }
}
