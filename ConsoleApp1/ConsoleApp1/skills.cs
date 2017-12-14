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
            string[] Enemies = ID.Split(' ');
            int enemynb = 1;
            Console.WriteLine("Which enemy would you like to fight?");            
            foreach (var enemy in Enemies)
            {
                Console.WriteLine(enemynb + ". " + Convertor.export_mon(enemy, "mob_Name"));
                enemynb++;
            }
            int playerChoice = int.Parse(Console.ReadLine());
            playerChoice--;

            Turn_start(Enemies[playerChoice],int.Parse(Convertor.export_mon(Enemies[playerChoice], "mob_hp")));
            return ("");
        }
        public static string Turn_start(string enemy, int enemyHP)
        {
       
            if (Player_current_HP <= 0)
            {
                Console.WriteLine("You have died.");
                Thread.Sleep(5000);
                Console.WriteLine("Prepare to die!");
                //Directory.SetCurrentDirectory("../../img");
                //System.Diagnostics.Process.Start("script.bat");
            }
            if (enemyHP <= 0)
            {
                Console.WriteLine("Good job! You killed an enemy!");
            }
            while (enemyHP >= 0)
            {                                               
                Console.WriteLine("Your turn, choose your action!");
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
            Console.WriteLine("You attack with your equipped weapon:");
            Thread.Sleep(1000);
            int DMG = rng.Next(int.Parse(Convertor.exporter_wep(Currently_equipped, "wep_min_dmg")), int.Parse(Convertor.exporter_wep(Currently_equipped, "wep_max_dmg")));
            Console.WriteLine("You hit your enemy and dealt "+ DMG +" damage.");
            HP = HP - DMG;
            Console.WriteLine("Enemy now has " + HP + " hitpoints.");
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
            Console.WriteLine("Enemies turn!");
            Thread.Sleep(1000);
            int DMG = rng.Next(int.Parse(Convertor.export_mon(enemy, "mob_min_dmg")), int.Parse(Convertor.export_mon(enemy, "mob_max_dmg")));
            Console.WriteLine("Enemy attacked and dealt " + DMG + " to you.");
            Player_current_HP = Player_current_HP - DMG;
            Console.WriteLine("You now have "+Player_current_HP+ " hitpoints.");
            Turn_start(enemy, enemy_HP);
            return ("");
        }
    }
}
