using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouRun_GUI.Model
{
    public class L_Convert
    {
        public int hour = 0;
        public int min = 0;

        public void convertMinToHourAndMin(double min)
        {
            this.min = (int)min % 60;
        }
    }
}
