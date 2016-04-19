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
        int distance = 0;
        int currentWeeklyDistance = 0;
        int nOTPW = 1; // numberofTrainingPerWeek
        double powerFactorWoman = 1.5; //Leistungsunterschied Männer/Frauen
        int leistungsfaktorGlobal = 1;

        int zusätlicherSchlaf=0; // zusätzlich benötigter Schlaf in Minuten
         
      

        public void setGenderfactor()
        {
            if (true == male)
            {
                genderfactor = powerFactorWoman;
            }
        }

        public double getWeeklyDistance(double leistungsfaktor)
        {
            return leistungsfaktor * distance;
        }

        public double schaetzeMarathonZeit(double benötigeZeitfuerLauf, bool Lauf10km) //Hierzu sollte noch die GUI angepasst werden.
        {
            if (Lauf10km)
            {
                return benötigeZeitfuerLauf * 4.667;
            }
            else
            {
                return benötigeZeitfuerLauf * 9.798;
            }
        }

        public void schlafempfehlung()
        {
            if (10 < (getWeeklyDistance(leistungsfaktorGlobal)-currentWeeklyDistance) && getWeeklyDistance(leistungsfaktorGlobal) < 20 )
            {
                zusätlicherSchlaf = 15;
            }
            else if (getWeeklyDistance(leistungsfaktorGlobal)>=20 && getWeeklyDistance(leistungsfaktorGlobal)<30)
            {
                zusätlicherSchlaf = 30;
            }
            else if (getWeeklyDistance(leistungsfaktorGlobal)>=30)
            {
                zusätlicherSchlaf = 45; 
            }
        }



    }
}
