using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouRun_GUI.ViewModels
{
    class MainViewModel : Screen
    {
        public MainViewModel()
        {
           // InitialWindows();
        }

        private void InitialWindows()
        {
            int temp = (int) MenuWidth / 3;
            Btn_documentView_Width = temp;
            Btn_chart_Width = temp;
            Btn_traingsPlan_Width = temp;
        }

        private int _MenuWidth;
        private int _Btn_traingsPlan_Width;
        private int _Btn_chart_Width;
        private int _Btn_documentView_Width;
        private string _WindowTitle;

        public int MenuWidth
        {
            get
            {
                return _MenuWidth;
            }

            set
            {
                _MenuWidth = value;
                NotifyOfPropertyChange(() => MenuWidth);
            }
        }
        public int Btn_traingsPlan_Width
        {
            get
            {
                return _Btn_traingsPlan_Width;
            }

            set
            {
                _Btn_traingsPlan_Width = value;
                NotifyOfPropertyChange(() => Btn_traingsPlan_Width);
            }
        }
        public int Btn_chart_Width
        {
            get
            {
                return _Btn_chart_Width;
            }

            set
            {
                _Btn_chart_Width = value;
                NotifyOfPropertyChange(() => Btn_chart_Width);
            }
        }
        public int Btn_documentView_Width
        {
            get
            {
                return _Btn_documentView_Width;
            }

            set
            {
                _Btn_documentView_Width = value;
                NotifyOfPropertyChange(() => Btn_documentView_Width);
            }
        }

        public string WindowTitle
        {
            get
            {
                return _WindowTitle;
            }

            set
            {
                _WindowTitle = value;
                InitialWindows();
                NotifyOfPropertyChange(() => WindowTitle);
            }
        }

        public void btn_trainingsPlan()
        {
            InitialWindows();
        }
        public void btn_chart()
        {
            
        }
        public void btn_documentView()
        {

        }
    }
}
