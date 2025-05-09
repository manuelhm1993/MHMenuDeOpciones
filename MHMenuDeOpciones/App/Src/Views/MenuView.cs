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
        #region Métodos
        public MenuView()
        {
            InitializeComponent();

            Reset();
        }

        private void Reset()
        {
            this.radioButton1.Checked = true;

            this.groupInput.Controls.Clear();
            //this.groupInput.Controls.Add();
            this.groupInput.Visible = true;
        }
        #endregion
    }
}
