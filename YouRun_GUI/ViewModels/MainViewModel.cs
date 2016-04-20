using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouRun_GUI.ViewModels
{
    [Export(typeof(MainViewModel))]
    class MainViewModel : Conductor<Screen>
    {
        private StopWatchViewModel stopWatchViewModel;
        private ChartViewModel chartViewModel;

        private readonly IWindowManager _windowManager;


        [ImportingConstructor]
        public MainViewModel(IWindowManager windowManager)
        {
            this._windowManager = windowManager;
            ActivateItem(new ProfileViewModel(_windowManager));
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
                NotifyOfPropertyChange(() => WindowTitle);
            }
        }

       
        public void Btn_StopWatch()
        {
            ActivateItem(new StopWatchViewModel());
            Debug.Write("Das ist die Stopwatch");
        }
        public void Btn_ChartDiagram()
        {
            ActivateItem(new ChartViewModel());                              
            Debug.Write("Das ist das Chartdiagramm");                           
        }
        

        public void Btn_PDFDocument()
        {
            ActivateItem(new DocumentViewModel());
            Debug.Write("Das ist die PDFDOCUment");
        }
        public void Btn_ProfileView()
        {
            ActivateItem(new ProfileViewModel(_windowManager));
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
