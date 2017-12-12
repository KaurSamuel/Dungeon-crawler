using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Convertor2
    {
        public static string export_mon(string ID, string whatvalue)
        {
            string ValueType;
            if (whatvalue == "mob_Name")
            {
                ValueType = "1";
            }

            else if (whatvalue == "mob_hp")
            {
                ValueType = "2";
            }

            else if (whatvalue == "mob_max_dmg")
            {
                ValueType = "3";
            }

            else if (whatvalue == "mob_min_dmg")
            {
                ValueType = "4";
            }

            else if (whatvalue == "mob_exp")
            {
                ValueType = "5";
            }

            string DirectoryPath = "monsters.txt";


        }
    }
}
