using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using System.Diagnostics;

namespace YouRun.ViewModels
{
    class Wizard_ViewModel : Screen
    {
        private string _windowTitle;
        private string _tabControl;
        private string _tabItem_SelectGoals;
        private string _grid_Body_Data;
        private string _individual_Time;
        private bool _tabItem_SelectGoals_isSelected;
        private bool _CurrentBodyData_isSelected;
        private bool _Individual_Time_isSelected;
        

        private string _AspiredTime;
        private IWindowManager _windowManager;

        public Wizard_ViewModel()
        {
            TabItem_SelectGoals_isSelected = true;
            CurrentBodyData_isSelected = false;
            Individual_Time_isSelected = false;
        }

        public Wizard_ViewModel(IWindowManager _windowManager)
        {
            this._windowManager = _windowManager;
            TabItem_SelectGoals_isSelected = true;
            CurrentBodyData_isSelected = false;
            Individual_Time_isSelected = false;
        }

        public string WindowTitle
        {
            get
            {
                return _windowTitle;
            }

            set
            {
                _windowTitle = value;
                NotifyOfPropertyChange(() => WindowTitle);
            }
        }
        public string TabControl
        {
            get
            {
                return _tabControl;
            }

            set
            {
                _tabControl = value;
            }
        }
        public string TabItem_SelectGoals
        {
            get
            {
                return _tabItem_SelectGoals;
            }

            set
            {
                _tabItem_SelectGoals = value;
            }
        }
        public string Grid_Body_Data
        {
            get
            {
                return _grid_Body_Data;
            }

            set
            {
                _grid_Body_Data = value;
            }
        }
        public string Individual_Time
        {
            get
            {
                return _individual_Time;
            }

            set
            {
                _individual_Time = value;
            }
        }

        public bool TabItem_SelectGoals_isSelected
        {
            get
            {
                return _tabItem_SelectGoals_isSelected;
            }

            set
            {
                _tabItem_SelectGoals_isSelected = value;
                NotifyOfPropertyChange(() => TabItem_SelectGoals_isSelected);
            }
        }
        public bool CurrentBodyData_isSelected
        {
            get
            {
                return _CurrentBodyData_isSelected;
            }

            set
            {
                _CurrentBodyData_isSelected = value;
                NotifyOfPropertyChange(() => CurrentBodyData_isSelected);
            }
        }
        public bool Individual_Time_isSelected
        {
            get
            {
                return _Individual_Time_isSelected;
            }

            set
            {
                _Individual_Time_isSelected = value;
                NotifyOfPropertyChange(() => Individual_Time_isSelected);
            }
        }

        public string AspiredTime
        {
            get
            {
                return _AspiredTime;
            }

            set
            {
                
                _AspiredTime = value;
                NotifyOfPropertyChange(() => AspiredTime);
            }
        }

        public void btn_To_Current_Body_Data()
        {
            Debug.WriteLine("Button Next clicked!");
            TabItem_SelectGoals_isSelected = false;            
            CurrentBodyData_isSelected = true;   
        }
        public void btn_To_Individual()
        {
            Debug.WriteLine("Button Next clicked!");
            
            CurrentBodyData_isSelected = false;
            Individual_Time_isSelected = true;
        }
        public void btn_Back_To_Goals()
        {
            CurrentBodyData_isSelected = false;
            TabItem_SelectGoals_isSelected = true;
            
        }
        public void btn_back_To_Body_Data()
        {
            Individual_Time_isSelected = false;
            CurrentBodyData_isSelected = true;            
        }
        public void btn_generate_Workout_Plan()
        {
            //TODO: Store Data in file and save it under...
            
        }
    }
}
