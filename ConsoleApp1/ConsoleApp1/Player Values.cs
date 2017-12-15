using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Player_Values
    {
        public static int Player_Max_HP { get; set; }
        public static int Player_current_HP { get; set; }
        public int Player_level { get; set; }
        public int Player_current_exp { get; set;}
        public static int Player_block_chance { get; set; }
        public int Player_rooms_cleared { get; set; }
        public int Player_monsters_killed { get; set; }
        public static List<string> Weapons_Inventory = new List<string>();
        public static string Currently_equipped { get; set; }
    }

    class Player_Inventory : Player_Values
    {
        public static bool Inventory_start()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. view inventory");
            Console.WriteLine("2. equip weapon");
            Console.WriteLine("3. Back");
            int PlayerChoice = int.Parse(Console.ReadLine());
            if (PlayerChoice == 1)
            {
                Draw_inventory();
            }
            else if (PlayerChoice== 2)
            {
                Equip_weapon();
            }

            else if(PlayerChoice == 3)
            {
                return false;
            }

            return (true);
        }
        public static string Add_to_inventory(string Whatitem,string ID)
        {
            Weapons_Inventory.Add(ID);
            return ("");            
        }
        public static string Draw_inventory(bool pause = true)
        {
            int mitukorda = 1;
            Console.WriteLine("--------------------");
            if (Weapons_Inventory.Count == 0)
                Console.WriteLine("There are no items");

            foreach (var item in Weapons_Inventory)
            {
                string Name = Convertor.exporter_wep(item, "wep_name");
                Console.WriteLine(mitukorda +". "+ Name);
                mitukorda++;
            }
            Console.WriteLine("--------------------");

            if (pause)
                Console.ReadKey();
            return ("");
        }
        public static string Equip_weapon()
        {
            

            if (Weapons_Inventory.Count() == 0)
            {
                Console.WriteLine("You dont have any weapons to equip");
                Console.ReadKey();
                return "";
            }

            Draw_inventory(false);
            Console.WriteLine((Weapons_Inventory.Count + 1) + ". Back");
            Console.WriteLine("What item would you like to equip?(number)");
            
            while(true)
            {
                string userInput = Console.ReadLine();

                if (int.Parse(userInput) > 0)
                {
                    if (int.Parse(userInput) <= Weapons_Inventory.Count())
                    {
                        Currently_equipped = Weapons_Inventory[int.Parse(userInput) - 1];
                        Console.WriteLine("You've equipped a/an " + Convertor.exporter_wep(Currently_equipped, "wep_name" + "."));
                        Console.ReadKey();
                        return "";
                    }
                }

                if(int.Parse(userInput) == (Weapons_Inventory.Count + 1))
                {
                    return "";
                }

                else
                {
                    Console.WriteLine("Unknown item");
                }
            }

        }
    }


 
}
