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
        private StopWatchViewModel stopWatchViewModel;
        private ChartViewModel chartViewModel;
        
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
                NotifyOfPropertyChange(() => WindowTitle);
            }
        }

       
        public void Btn_StopWatch()
        {
            stopWatchViewModel = new StopWatchViewModel();
            ListView_Content = new BindableCollection<object>(){ stopWatchViewModel  };
            Debug.Write("Das ist die Stopwatch");


        }
        public void Btn_ChartDiagram()
        {
            chartViewModel = new ChartViewModel();
            ListView_Content = new BindableCollection<object>() { chartViewModel };      
                  
            Debug.Write("Das ist das Chartdiagramm");
        }
        public void Btn_PDFDocument()
        {
            Debug.Write("Das ist die PDFDOCUment");
        }

        private BindableCollection<object> _listView_Content;
        public BindableCollection<object> ListView_Content
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


    }

}
