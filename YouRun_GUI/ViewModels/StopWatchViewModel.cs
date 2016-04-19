using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouRun_GUI.ViewModels
{
    class StopWatchViewModel : Screen
    {
        public StopWatchViewModel()
        {
            _DataGrid_Chart = new BindableCollection<StopWatchViewModel>();
        }

        private IObservableCollection<StopWatchViewModel> _DataGrid_Chart;
        public IObservableCollection<StopWatchViewModel> DataGrid_Chart
        {
            get
            {
                return _DataGrid_Chart;
            }

            set
            {
                _DataGrid_Chart = value;
                NotifyOfPropertyChange(() => DataGrid_Chart);     
            }
        }
    }
}
