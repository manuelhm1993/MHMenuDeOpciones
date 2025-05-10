using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHMenuDeOpciones.App.Utilities
{
    public static class Common
    {
        public static void PonerEscuchaFocus(IEnumerable<NumericUpDown> numbers)
        {
            foreach (NumericUpDown number in numbers)
            {
                number.GotFocus += new System.EventHandler(numericUpDownGotFocus);
            }
        }

        private static void numericUpDownGotFocus(object sender, EventArgs e)
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
    }
}
