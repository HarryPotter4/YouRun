using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace YouRun_GUI.ViewModels
{
    class ChartViewModel : Screen
    {
        private IWindowManager _windowManager;

        public ChartViewModel(IWindowManager _windowManager)
        {
            this._windowManager = _windowManager;
        }
    }
}
