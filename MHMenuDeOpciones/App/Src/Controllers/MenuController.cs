using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MHMenuDeOpciones.App.Src.Views;

namespace MHMenuDeOpciones.App.Src.Controllers
{
    public static class MenuController
    {
        #region Campos de clase
        private static MenuView _FormMenu = new MenuView();
        #endregion

        #region Propiedades
        public static MenuView FormMenu
        {
            get => _FormMenu;
            set => _FormMenu = value;
        }
        #endregion

        #region Métodos
        public static MenuView GetView() => FormMenu;
        #endregion
    }
}
