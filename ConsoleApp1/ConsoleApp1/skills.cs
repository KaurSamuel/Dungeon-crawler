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
        public static int current_enemy_HP { get; set; }
        public static string[] Currently_figting_enemys { get; set; }
        public static string Currently_fighting_enemy_ID { get; set; }
        public static string Combat_start(string ID)
         
        {
            Currently_figting_enemys = ID.Split(' ');
            
            int enemynb = 1;
            Console.WriteLine("Which enemy would you like to fight?");
            foreach (var item in Currently_figting_enemys)
            {

                Console.WriteLine(enemynb+". "+item);
                enemynb ++;
            }
            int playerchoise = int.Parse(Console.ReadLine());
            Currently_fighting_enemy_ID = Currently_figting_enemys[playerchoise];
            Turn_start();          
            return ("");
        }
        public static string Turn_start()
        {
            while (current_enemy_HP >= 0)
            { 
                if (Player_current_HP <= 0)
            {
                Console.WriteLine("You have died.");
                Thread.Sleep(5000);
                Console.WriteLine("Prepare to die!");
                //Directory.SetCurrentDirectory("../../img");
                //System.Diagnostics.Process.Start("script.bat");
            }
            if (current_enemy_HP <= 0)
            {
                Console.WriteLine("Good job! You killed your target!");
                    return ("");
            }                                                           
                Console.WriteLine("Your turn, choose your action!");
                Console.WriteLine("1. Normal attack");
                int Userinput = int.Parse(Console.ReadLine());
                if (Userinput == 1)
                {
                    Normal_attack();
                }
                Enemy_turn();
            }
            return ("");
        }
        public static string Normal_attack()
        {
            Random rng = new Random();
            Console.WriteLine("You attack with your equipped weapon:");
            Thread.Sleep(1000);
            int DMG = rng.Next(int.Parse(Convertor.exporter_wep(Currently_equipped, "wep_min_dmg")), int.Parse(Convertor.exporter_wep(Currently_equipped, "wep_max_dmg")));
            Console.WriteLine("You hit your enemy and dealt "+ DMG +" damage.");
            current_enemy_HP = current_enemy_HP - DMG;
            Console.WriteLine("Enemy now has " + current_enemy_HP + " hitpoints.");
            if (current_enemy_HP <= 0)
            {
                Turn_start();
            }            
            return ("");
        }
        public static string Enemy_turn()
        {
            Random rng = new Random();
            Console.WriteLine("Enemies turn!");
            Thread.Sleep(1000);
            int Is_gona_block = rng.Next(0,100);
            if (Is_gona_block < Player_block_chance)
            {
                Console.WriteLine("You blocked the enemy attack");
                return("");
            }
            else
            {
                int DMG = rng.Next(int.Parse(Convertor.export_mon(Currently_fighting_enemy_ID, "mob_min_dmg")), int.Parse(Convertor.export_mon(Currently_fighting_enemy_ID, "mob_max_dmg")));
                Console.WriteLine("Enemy attacked and dealt " + DMG + " to you.");
                Player_current_HP = Player_current_HP - DMG;
                Console.WriteLine("You now have " + Player_current_HP + " hitpoints.");
            }
            return ("");
        }
        public static string Randon_drop_chance()
        {
            Random rng = new Random();


            return ("");
        }

    }
}
