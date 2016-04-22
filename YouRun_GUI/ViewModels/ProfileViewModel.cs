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
        private string pathFile;       
        private ProfileViewModel profileViewModel;



        public ProfileViewModel(IWindowManager _windowManager)
        {
            this._windowManager = _windowManager;
            this.profileViewModel = this;
            
        }
        

        public void Btn_NewProfile()
        {
            var result = _windowManager.ShowDialog(new Wizard_ViewModel(_windowManager, profileViewModel));
            Console.Write("Path is:" + this.pathFile);     
        }
        public void Open_Profile()
        {

        }

        public void setPath(string filePath)
        {
            this.pathFile = filePath;
        }
    }
}
