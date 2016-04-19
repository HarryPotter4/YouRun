using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouRun_GUI.ViewModels
{
    class ChartViewModel : Screen
    {
        public ChartViewModel()
        {
            DataGrid_StopWatch = new BindableCollection<ChartViewModel>();
        }

        private IObservableCollection<ChartViewModel> _DataGrid_StopWatch;
        public  IObservableCollection<ChartViewModel> DataGrid_StopWatch
        {
            get
            {
                return _DataGrid_StopWatch;
            }

            set
            {
                _DataGrid_StopWatch = value;
                NotifyOfPropertyChange(() => DataGrid_StopWatch);
            }
        }
    }
}
