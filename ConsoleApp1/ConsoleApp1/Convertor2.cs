using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Convertor
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
            foreach (string line in System.IO.File.ReadAllLines(DirectoryPath))
            {
                string id = line.Substring(0, 5);

                if (id == ID)
                {
                    string[] allWords = line.Split();
                    return (allWords[int.Parse(ValueType)]);
                }
            }

            return "error";
        }
        /*weapon name =          wep_name
         *weapon description =   wep_desc
         *weapon minium damage = wep_min_dmg
         *weapon maximum damage= wep_max_dmg
         *weapon attack speed =  wep_Atk_spd
         */
        public static string exporter_wep(string ID, string whatvalue)//esimesena peab andma relva ID ja teisena mida sa tahad kätte saada
        {
            string ValueType = "0";
            if (whatvalue == "wep_name")
            {
                ValueType = "1";
            }
            if (whatvalue == "wep_desc")
            {
                ValueType = "2";
            }
            if (whatvalue == "wep_min_dmg")
            {
                ValueType = "3";
            }
            if (whatvalue == "wep_max_dmg")
            {
                ValueType = "4";
            }
            if (whatvalue == "wep_Atk_spd")
            {
                ValueType = "5";
            }


            string Directorypath = "weapons.txt";
            foreach (string line in System.IO.File.ReadAllLines(Directorypath))
            {


                string id = line.Substring(0, 5);
                if (id == ID)
                {
                    string[] allWords = line.Split();
                    return (allWords[int.Parse(ValueType)]);



                }             
            }
            return "error";
        }
    }
}
