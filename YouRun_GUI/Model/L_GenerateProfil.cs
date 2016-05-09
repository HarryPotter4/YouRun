using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouRun.ViewModels;

namespace YouRun_GUI.Model
{
    public class L_GenerateProfil
    {
        public bool Male = true;
        public double genderFactor = 0;
        int AdditionalWeeklyDistance = 0;
        public int AdditionalDailySleep = 0;
        public double size = 0;

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

        public void setGender(bool male)
        {
            if (male==true)
            {
                this.Male = true;
                this.genderFactor = Constants.genderFactorMale;
            }
            else
            {
                this.Male = false;
                this.genderFactor = Constants.genderFactorFemale;
            }
        }

        //range is up to 40 km per week
        //Test implemented
        public void calcTimeForSleep(int additionalWeeklyDistance) 
        {
            if (additionalWeeklyDistance>=10&&additionalWeeklyDistance<20)
            {
                this.AdditionalDailySleep = 30;
            }
            else if (additionalWeeklyDistance >= 20 && additionalWeeklyDistance < 30)
            {
                this.AdditionalDailySleep = 60;
            }
            else if (additionalWeeklyDistance >= 30 && additionalWeeklyDistance < 40)
            {
                this.AdditionalDailySleep = 90;
            }
            else if (additionalWeeklyDistance >= 40)
            {
                this.AdditionalDailySleep = 120;
            }

        }
        //Test implemented
        public double calcTimeForMarathonBasedOn5Km(double time)
        {
            return time*9.798;
        }
        //Test implemented
        public double calcTimeForMarathonBasedOn10Km(double time)
        {
            return time * 4.667;
        }

        
            
        

      



    }
}
