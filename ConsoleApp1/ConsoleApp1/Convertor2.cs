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
            string ValueType = "0";
            if (whatvalue == "mob_Name")
            {
                ValueType = "0";
            }

            else if (whatvalue == "mob_hp")
            {
                ValueType = "1";
            }

            else if (whatvalue == "mob_max_dmg")
            {
                ValueType = "2";
            }

            else if (whatvalue == "mob_min_dmg")
            {
                ValueType = "3";
            }

            else if (whatvalue == "mob_exp")
            {
                ValueType = "4";
            }

            string DirectoryPath = "monsters.txt";
            foreach(string line in System.IO.File.ReadAllLines(DirectoryPath))
            {
                string id = line.Substring(0, 5);

                if(id == ID)
                {
                    string[] allWords = line.Split();
                    return (allWords[int.Parse(ValueType)]);
                }
            }

            return "";
        }
    }
}
