using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouRun.ModelView.Logic
{
    class logic_currentBody
    {
        //Variablen für current body-Reiter
        bool male = true;
        double genderfactor = 1;
        double height = 0;
        double weight = 0;
        double pace = 0;
        double level = 1;
        int nOTPW = 1; // numberofTrainingPerWeek
        double powerFactorWoman = 1.5; //Leistungsunterschied Männer/Frauen
        double weeklsDistance;


        public void setGenderfactor()
        {
            if (true == male)
            {
                genderfactor = powerFactorWoman;
            }
        }


    }
}
