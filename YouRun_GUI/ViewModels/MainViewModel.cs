using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouRun_GUI.ViewModels
{
    class MainViewModel : Screen
    {
        private void InitialWindows()
        {
            int temp = (int) MenuWidth / 3;
            Btn_documentView_Width = temp;
            Btn_chart_Width = temp;
            Btn_traingsPlan_Width = temp;
        }

        private string _WindowTitle;
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

        private BindableCollection<StopWatchViewModel> _listView_Content;
        public BindableCollection<StopWatchViewModel> ListView_Content
        {
            get
            {
                return _listView_Content;
            }

            set
            {
                _listView_Content = value;
                NotifyOfPropertyChange(() => ListView_Content);
            }
        }

        public void Btn_StopWatch()
        {
            Debug.Write("Das ist die Stopwatch");
        }
        public void Btn_ChartDiagram()
        {
            Debug.Write("Das ist das Chartdiagramm");
        }
        public void Btn_PDFDocument()
        {
            Debug.Write("Das ist die PDFDOCUment");
        }
    }

    

}
