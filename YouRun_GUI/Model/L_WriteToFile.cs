using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace YouRun_GUI.Model
{
    public class L_WriteToFile
    {
        string test = "Blablabla";
        public int WriteProfileFile()
        {
            File.WriteAllText(@".\Test.txt", test);
            return 0;
        }

        public void testc()
        {

            int test2 = WriteProfileFile();
        } 
        

     
    }
}
