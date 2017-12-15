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
        public static bool shield_or_nah { get; set; }
        public static int current_enemy_HP { get; set; }
        public static string[] Currently_fighting_enemys { get; set; }
        public static string Currently_fighting_enemy_ID { get; set; }
        public static string Dropped_item { get; set; }

        public static bool Combat_start(string ID)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Currently_fighting_enemys = ID.Split(' ');
            
            int enemynb = 1;
            Console.WriteLine("Which enemy would you like to fight?");
            foreach (var item in Currently_fighting_enemys)
            {
                Console.WriteLine(enemynb + ". " + Convertor.export_mon(Currently_fighting_enemys[enemynb - 1], "mob_Name"));
                enemynb ++;
            }

            string userInput = "";
            while (true)
            {
                userInput = Console.ReadLine();

                if (int.Parse(userInput) > 0)
                    if (int.Parse(userInput) < Currently_fighting_enemys.Count() + 1)
                        break;

                else
                    Console.WriteLine("Incorrect input");
            }

            Currently_fighting_enemy_ID = Currently_fighting_enemys[int.Parse(userInput) - 1];
            current_enemy_HP = int.Parse(Convertor.export_mon(Currently_fighting_enemy_ID, "mob_hp"));
            
            while (true)
            {
                if (!Turn_start())
                    break;
                Console.WriteLine();
                Enemy_turn();
            }

            if (Dropped_item != "")
            {

                Console.Write("The enemy dropped a ");
                if (shield_or_nah==false)
                {
                    Player_Inventory.Add_to_inventory("weapon", Dropped_item);
                    Console.WriteLine(Convertor.exporter_wep(Dropped_item, "wep_name"));
                }
                else if (shield_or_nah==false)
                {
                    Player_Inventory.Add_to_inventory("hppots", Dropped_item);
                    Console.Write("Pot(TODO)");
                }
                else
                {
                    Player_Inventory.Add_to_inventory("shield", Dropped_item);
                    Console.WriteLine(Convertor.exporter_shield(Dropped_item, "shield_name"));
                }

            }

            Dungeon.CurRoom = Dungeon.RemoveMob(Currently_fighting_enemy_ID, Dungeon.CurRoom);

            for(int i = 0; i < Dungeon.MapArray.Count; i++)
            {
                if (Dungeon.MapArray[i].pos == Dungeon.CurRoom.pos)
                    Dungeon.MapArray[i] = Dungeon.CurRoom;
            }

            Console.ReadLine();

            return true;
        }
        public static bool Turn_start()
        {
            if (Player_current_HP <= 0)
            {
                Console.WriteLine("You have died.");
                Console.ReadKey();
                Environment.Exit(0);
                return false;
            }

            if (current_enemy_HP <= 0)
            {
                Console.WriteLine("Good job! You killed your target!");
                Dropped_item = Randon_drop_chance();

                return false;
            }       
            
            Console.WriteLine("Your turn, choose your action!");
            Console.WriteLine("1. Normal attack");
            Console.WriteLine("2. Shield attack");
            while(true)
            {
                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    Normal_attack();
                    break;
                }
                if (userInput=="2")
                {
                    shield_attack();
                    break;
                }

                else
                {
                    Console.WriteLine("Unknown command");
                }
            }

            if (Player_current_HP <= 0)
            {
                Console.WriteLine("You have died.");
                return false;
            }

            if (current_enemy_HP <= 0)
            {
                Console.WriteLine("Good job! You killed your target!");
                Dropped_item = Randon_drop_chance();

                return false;
            }

            return true;
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
          
            return ("");
        }
        public static string shield_attack()
        {
            
            Random rng = new Random();
            int Gonna_miss_or_nah = rng.Next(0, 100);
            if (Gonna_miss_or_nah<60)
            {
                Console.WriteLine("you hit your enemy");
                Console.WriteLine("The enemy is stunned!");
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Your turn, choose your action!");
                    Console.WriteLine("1. Normal attack");

                    while (true)
                    {
                        string userInput = Console.ReadLine();

                        if (userInput == "1")
                        {
                            Normal_attack();
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Unknown command");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("You missed, too bad.");
            }
            
            return ("");
        }
        public static string Enemy_turn()
        {
            Random rng = new Random();
            Console.WriteLine("Enemies turn!");
            //Thread.Sleep(1000);
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
            string weapon = "wA000";
            string shield = "sA000";
            string hppots = "hA00";
            Random rng = new Random();
            int weapon_or_shield = rng.Next(0, 100);
            int IS_gonna_drop = rng.Next(0, 100);

            if (IS_gonna_drop<100)
            {
                if (weapon_or_shield<50)
                {

                    weapon = Dungeon.ReplaceAtIndex(4, (char)rng.Next(49, 58), weapon); //Generates a number between 1 and 9 and assigns it to 4th pos
                    shield_or_nah = false; 
                    return (weapon);
                }                                                                 
                else
                {
                    shield = Dungeon.ReplaceAtIndex(4, (char)rng.Next(49, 58), shield); //Generates a number between 1 and 9 and assigns it to 4th pos
                    shield_or_nah = true;
                    return (shield);
                } 
                
            }

            return ("");
        }

    }
}
