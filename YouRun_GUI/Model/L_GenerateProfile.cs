using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouRun.ViewModels;

namespace YouRun_GUI.Model
{
    class L_GenerateProfile
    {
        private Wizard_ViewModel data;
        private string filePath;

        internal string getfilePath()
        {
            return filePath;
        }        

        internal void Generate(Wizard_ViewModel wizard_ViewModel, string filePath)
        {
            this.data = wizard_ViewModel;
            this.filePath = filePath;

            
        }
    }
}
