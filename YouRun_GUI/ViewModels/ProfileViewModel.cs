using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouRun;

namespace YouRun_GUI.ViewModels
{
    class ProfileViewModel : Screen
    {
        public void Btn_NewProfile()
        {
            YouRun.App obj;
            obj = new YouRun.App();
        }
        public void Open_Profile()
        {

        }
    }
}
