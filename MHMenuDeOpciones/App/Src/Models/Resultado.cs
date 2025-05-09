using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace MHMenuDeOpciones.App.Src.Models
{
    public class Resultado
    {
        public string Text { get; set; }
        public string Caption { get; set; }
        public MessageBoxButtons Buttons { get; set; }
        public MessageBoxIcon Icon { get; set; }
    }
}
