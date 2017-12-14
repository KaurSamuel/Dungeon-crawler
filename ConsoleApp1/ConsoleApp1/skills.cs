using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace ConsoleApp1
{
    class skills : Player_Values
    {
        public static string Combat_start(string ID)
        {
            Currently_figting_enemy = ID;
            string[] Enemys = ID.Split(' ');
            int enemynb = 1;
            Console.WriteLine("what enemy would you like to fight?");            
            foreach (var enemy in Enemys)
            {
                Console.WriteLine(enemynb + ". " + Convertor.export_mon(enemy, "mob_Name"));
                enemynb++;
            }
            int playerChoise = int.Parse(Console.ReadLine());
            playerChoise--;

            Turn_start(Enemys[playerChoise],int.Parse(Convertor.export_mon(Enemys[playerChoise], "mob_hp")));
            return ("");
        }
        public static string Turn_start(string enemy, int enemyHP)
        {
       
            if (Player_current_HP <= 0)
            {
                Console.WriteLine("you died, you bad,git gud");
                Thread.Sleep(5000);
                Console.WriteLine("Prepare to die!");
                //Directory.SetCurrentDirectory("../../img");
                //System.Diagnostics.Process.Start("script.bat");
            }
            if (enemyHP <= 0)
            {
                Console.WriteLine("good yob you defeated the enemy");
            }
            while (enemyHP >= 0)
            {                                               
                Console.WriteLine("Your turn,choose your action!");
                Console.WriteLine("1. Normal attack");
                int Userinput = int.Parse(Console.ReadLine());
                if (Userinput == 1)
                {
                    Normal_attack(enemyHP, enemy);
                }
            }
            return ("");
        }
        public static string Normal_attack(int HP, string enemy)
        {
            Random rng = new Random();
            Console.WriteLine("You attack with your equiped weapon");
            Thread.Sleep(1000);
            int DMG = rng.Next(int.Parse(Convertor.exporter_wep(Currently_equiped, "wep_min_dmg")), int.Parse(Convertor.exporter_wep(Currently_equiped, "wep_max_dmg")));
            Console.WriteLine("You hit your enemy and deal "+DMG+" damage");
            HP = HP - DMG;
            Console.WriteLine("the enemy now has " + HP + " hitpoints");
            if (HP<=0)
            {
                Turn_start(enemy,HP);
            }
            Enemy_turn(enemy,HP);
            Turn_start(enemy, HP);
            return ("");
        }
        public static string Enemy_turn(string enemy, int enemy_HP)
        {
            Random rng = new Random();
            Console.WriteLine("its the enemys turn now!");
            Thread.Sleep(1000);
            int DMG = rng.Next(int.Parse(Convertor.export_mon(enemy, "mob_min_dmg")), int.Parse(Convertor.export_mon(enemy, "mob_max_dmg")));
            Console.WriteLine("the enemy attacks you and hits! ");
            Console.WriteLine("the enemy deals " + DMG + " damage to you");
            Player_current_HP = Player_current_HP - DMG;
            Console.WriteLine("you now have "+Player_current_HP+ " hitpoints");
            Turn_start(enemy, enemy_HP);
            return ("");
        }
    }
}
