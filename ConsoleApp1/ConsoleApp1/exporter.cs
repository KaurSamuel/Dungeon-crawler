using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class exporter
    {
        public static weaponvalues exporter()
        {
            string Directorypath = "items.txt";
            string[] lines = System.IO.File.ReadAllLines(Directorypath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            return ();
        }
    }
}
