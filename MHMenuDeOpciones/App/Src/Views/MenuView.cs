using MHMenuDeOpciones.App.Src.Controllers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHMenuDeOpciones.App.Src.Views
{
    public partial class MenuView : Form
    {
        #region Campos de clase
        private FuncionCuadraticaView _FormFuncionCuadraticaView;
        #endregion

        #region Propiedades
        public FuncionCuadraticaView FormFuncionCuadraticaView
        {
            get => _FormFuncionCuadraticaView;
        }
        #endregion

        #region Métodos
        public MenuView()
        {
            this._FormFuncionCuadraticaView = FuncionCuadraticaController.GetView();

            InitializeComponent();

            Reset();
        }

        private void Reset()
        {
            this.radioButton1.Checked = true;
            this.groupInput.Visible = true;

            MostrarFuncionCuadratica();
        }

        private void MostrarFuncionCuadratica()
        {
            this.groupInput.Controls.Clear();

            this._FormFuncionCuadraticaView.Reset();
            this._FormFuncionCuadraticaView.Parent = this.flowLayoutPanel1;
            this._FormFuncionCuadraticaView.Dock = DockStyle.Fill;

            this.groupInput.Controls.Add(FormFuncionCuadraticaView);

            this._FormFuncionCuadraticaView.Show();
        }
        #endregion

        #region Eventos
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MostrarFuncionCuadratica();
        }
        #endregion
    }
}
