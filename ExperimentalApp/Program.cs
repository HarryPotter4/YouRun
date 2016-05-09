using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExperimentalApp
{
    class Program
    {

        string test = "Blablabla";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello3");
            Console.ReadKey();

            
        }

        public void WriteProfileFile()
        {
            File.WriteAllText(@"D:\Users\David.Preiss\Source\Repos\YouRun\ExperimentalApp\bin\Debug\Test.txt", test);
        }
    }
}
