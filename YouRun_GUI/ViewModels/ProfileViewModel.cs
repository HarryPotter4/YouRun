using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouRun;
using YouRun.ViewModels;

namespace YouRun_GUI.ViewModels
{
    class ProfileViewModel : Screen
    {
        private IWindowManager _windowManager;

        public ProfileViewModel(IWindowManager _windowManager)
        {
            this._windowManager = _windowManager;
        }

        public void Btn_NewProfile()
        {
            _windowManager.ShowWindow(new Wizard_ViewModel(_windowManager));
        }
        public void Open_Profile()
        {

        }
    }
}
