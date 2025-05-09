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
    public partial class CalcularEdadView : Form
    {
        public CalcularEdadView()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            this.calendario.Value = DateTime.Now;
            this.calendario.Focus();
        }

        private void btnCalcularEdad_Click(object sender, EventArgs e)
        {
            Resultado result = CalcularEdadController.GetEdad(this.calendario.Value);

            MessageBox.Show(result.Text, result.Caption, result.Buttons, result.Icon);

            Reset();
        }
    }
}
