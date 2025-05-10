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
using Microsoft.VisualBasic; // Se agregó la referencia en el proyecto

namespace MHMenuDeOpciones.App.Src.Views
{
    public partial class SumaCompraView : Form
    {
        private TableLayoutPanel layout;

        public SumaCompraView()
        {
            InitializeComponent();

            layout = new TableLayoutPanel();
            layout.ColumnCount = 4;
            layout.AutoSize = true;
            layout.Dock = DockStyle.Top;
        }

        public void CargarComponentes()
        {
            layout.Controls.Clear();

            string cantidadArticulosString = Interaction.InputBox("Ingrese el número de artículos de la compra:", "Cantidad de Artículos", "1");

            if (int.TryParse(cantidadArticulosString, out int cantidadArticulos))
            {
                CrearInputs(cantidadArticulos, layout);
            }
            else
            {
                MessageBox.Show("El valor ingresado no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            // Crear un botón dinámicamente
            Button button = new Button();

            button.Name = "btnCalcularSumaCompra";
            button.Text = "Calcular";
            button.Height = 30;
            button.Width = 123;

            // Poner a la escucha del evento click al botón
            button.Click += new System.EventHandler(this.SumarItemsCompra);

            // Agregar el botón al layout
            layout.Controls.Add(button);

            // Agregar el layout al form
            this.Controls.Add(layout);
        }

        public void Reset()
        {
            bool primero = true;

            foreach (NumericUpDown number in this.layout.Controls.OfType<NumericUpDown>())
            {
                if(primero)
                {
                    primero = false;
                    number.Focus();
                }
                
                number.Value = 0;
            }
        }

        private void CrearInputs(int cantidad, TableLayoutPanel layout)
        {
            for (int i = 0; i < cantidad; i++)
            {
                NumericUpDown number = new NumericUpDown();

                number.DecimalPlaces = 2;
                number.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
                number.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0});
                number.Minimum = new decimal(new int[] { 0, 0, 0, 0});
                number.Name = $"number{i}";
                number.TabIndex = i;

                layout.Controls.Add(number);
            }

            Common.PonerEscuchaFocus(this.layout.Controls.OfType<NumericUpDown>());
        }

        #region Eventos
        private void SumarItemsCompra(object sender, EventArgs e)
        {
            Resultado result = SumaCompraController.GetResultadoSumaCompra(this.layout.Controls.OfType<NumericUpDown>());

            MessageBox.Show(result.Text, result.Caption, result.Buttons, result.Icon);

            Reset();
        }
        #endregion
    }
}
