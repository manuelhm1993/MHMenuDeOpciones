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

using MHMenuDeOpciones.App.Src.Controllers;

namespace MHMenuDeOpciones.App.Src.Views
{
    public partial class MenuView : Form
    {
        #region Campos de clase
        private FuncionCuadraticaView _FormFuncionCuadraticaView;
        private CalcularEdadView _FormCalcularEdadView;
        private SumaCompraView _FormSumaCompraView;
        #endregion

        #region Propiedades
        public FuncionCuadraticaView FormFuncionCuadraticaView
        {
            get => _FormFuncionCuadraticaView;
        }

        public CalcularEdadView FormCalcularEdadView
        {
            get => _FormCalcularEdadView;
        }

        public SumaCompraView FormSumaCompraView
        {
            get => _FormSumaCompraView;
        }
        #endregion

        #region Métodos
        public MenuView()
        {
            this._FormFuncionCuadraticaView = FuncionCuadraticaController.GetView();
            this._FormCalcularEdadView = CalcularEdadController.GetView();
            this._FormSumaCompraView = SumaCompraController.GetView();

            InitializeComponent();

            Reset();
        }

        private void Reset()
        {
            this.radioButton1.Checked = true;
            this.groupInput.Visible = true;

            MostrarVista(this._FormFuncionCuadraticaView);
        }

        private void MostrarVista(Form FormView)
        {
            this.groupInput.Controls.Clear();

            if(FormView is FuncionCuadraticaView FuncionCuadratica)
            {
                FuncionCuadratica.Reset();
            }
            else if (FormView is CalcularEdadView CalcularEdad)
            {
                CalcularEdad.Reset();
            }
            else if (FormView is SumaCompraView SumaCompra)
            {
                SumaCompra.Reset();
            }

            FormView.TopLevel = false;
            FormView.TopMost = false;
            FormView.Parent = this.flowLayoutPanel1;
            FormView.Dock = DockStyle.Fill;

            this.groupInput.Controls.Add(FormView);

            FormView.Show();
        }
        #endregion

        #region Eventos
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MostrarVista(this._FormFuncionCuadraticaView);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MostrarVista(this._FormCalcularEdadView);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(this.radioButton3.Checked)
            {
                this._FormSumaCompraView.CargarComponentes();

                MostrarVista(this._FormSumaCompraView);
            }
        }
        #endregion
    }
}
