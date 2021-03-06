﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Convertor
    {
        public static enemyvalues ImportMonster(string ID)
        {
            enemyvalues enemy = new enemyvalues();

            enemy.MobName = export_mon(ID, "mob_Name");
            enemy.MobHP = export_mon(ID, "mob_hp");
            enemy.MobMaxDMG = export_mon(ID, "mob_max_dmg");
            enemy.MobMinDMG = export_mon(ID, "mob_min_dmg");
            enemy.MobEXP = export_mon(ID, "mob_min_dmg");

            return enemy;
        }

        public static string export_mon(string ID, string whatvalue)
        {
            string ValueType = "0";
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

            string DirectoryPath = "../../monsters.txt";
            foreach (string line in System.IO.File.ReadAllLines(DirectoryPath))
            {
                string id = line.Substring(0, 4);
                
                if (id == ID)  
                {
                    string[] allWords = line.Split();
                    return (allWords[int.Parse(ValueType)]);
                }
            }

            return "Feature working as intended";
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


            string Directorypath = "../../weapons.txt";
            foreach (string line in System.IO.File.ReadAllLines(Directorypath))
            {


                string id = line.Substring(0, 5);
                if (id == ID)
                {
                    string[] allWords = line.Split();
                    return (allWords[int.Parse(ValueType)]);

                }
            }            return "error";
        }
        public static string exporter_shield(string ID, string whatvalue)
        {
            string ValueType = "0";
            if (whatvalue == "shield_name")
            {
                ValueType = "1";
            }
            if (whatvalue== "shield_block_chance")
            {
                ValueType = "3";
            }
            string Directorypath = "../../armor.txt";
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
