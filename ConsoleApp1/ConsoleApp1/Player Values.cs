using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Player_Values
    {
        public static int how_many_weapons_dropped { get; set; }
        public static int Player_Max_HP { get; set; }
        public static int Player_current_HP { get; set; }
        public int Player_level { get; set; }
        public int Player_current_exp { get; set; }
        public static int Player_block_chance { get; set; }
        public int Player_rooms_cleared { get; set; }
        public int Player_monsters_killed { get; set; }
        public static List<string> Weapons_Inventory = new List<string>();
        public static List<string> Shields_Inventory = new List<string>();
        public static string Currently_equipped { get; set; }
        public static string Currently_equipped_shield { get; set; }
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
            else if (PlayerChoice == 2)
            {
                Equip_weapon();
            }

            else if (PlayerChoice == 3)
            {
                return false;
            }

            return (true);
        }
        public static string Add_to_inventory(string Whatitem, string ID)
        {
            if (Whatitem == "weapon")
            {
                Weapons_Inventory.Add(ID);
            }
            if (Whatitem == "shield")
            {
                Shields_Inventory.Add(ID);
            }
            return ("");
        }
        public static string Draw_inventory(bool pause = true)
        {
            int mitukorda = 1;
<<<<<<< HEAD
            Console.WriteLine("Do you wish to see your weapons or shields inventory");
            string valik = Console.ReadLine();
            Console.WriteLine("--------------------");
            if (valik == "weapons")
=======
            Console.WriteLine("--------------------");
            if (Weapons_Inventory.Count == 0)
                Console.WriteLine("There are no items");

            foreach (var item in Weapons_Inventory)
>>>>>>> e7a43872f2707e897fdf3a27dc10677dd1c86b4c
            {
                foreach (var item in Weapons_Inventory)
                {
                    string Name = Convertor.exporter_wep(item, "wep_name");
                    Console.WriteLine(mitukorda + ". " + Name);
                    mitukorda++;
                }
                Console.WriteLine("-------------------");
            }
            if (valik == "shields")
            {
                Console.WriteLine("--------------------");
                foreach (var item in Shields_Inventory)
                {
                    string Name = Convertor.exporter_shield(item, "shield_name");
                    Console.WriteLine(mitukorda + ". " + Name);
                    mitukorda++;
                }
                Console.WriteLine("--------------------");
            }
<<<<<<< HEAD
=======
            Console.WriteLine("--------------------");

<<<<<<< HEAD
            if (pause)
                Console.ReadKey();
=======
            Console.ReadKey();
>>>>>>> e7a43872f2707e897fdf3a27dc10677dd1c86b4c
>>>>>>> f7c9901691e1772857b2c4cc26fb7954550ea000
            return ("");
        }
        public static string Equip_weapon()
        {
            Console.WriteLine("do you want to equip a weapon or a shield");
            string valik = Console.ReadLine();
            if (valik == "weapon")
            {
                if (Weapons_Inventory.Count() == 0)
                {
                    Console.WriteLine("You dont have any weapons to equip");
                    Console.ReadKey();
                    return "";
                }

<<<<<<< HEAD
            Draw_inventory(false);
            Console.WriteLine((Weapons_Inventory.Count + 1) + ". Back");
            Console.WriteLine("What item would you like to equip?(number)");
            
            while(true)
            {
                string userInput = Console.ReadLine();
=======
                Draw_inventory();
                Console.WriteLine("What item would you like to equip?(number)");
>>>>>>> f7c9901691e1772857b2c4cc26fb7954550ea000

                while (true)
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

                    else
                    {
                        Console.WriteLine("Unknown item");
                    }
                }
            }
            if (valik == "shield")
            {
                if (Shields_Inventory.Count() == 0)
                {
                    Console.WriteLine("You dont have any shields to equip");
                    Console.ReadKey();
                    return "";
                }

<<<<<<< HEAD
                if(int.Parse(userInput) == (Weapons_Inventory.Count + 1))
                {
                    return "";
                }

                else
=======
                Draw_inventory();
                Console.WriteLine("What item would you like to equip?(number)");

                while (true)
>>>>>>> f7c9901691e1772857b2c4cc26fb7954550ea000
                {
                    string userInput = Console.ReadLine();

                    if (int.Parse(userInput) > 0)
                    {
                        if (int.Parse(userInput) <= Shields_Inventory.Count())
                        {
                            Currently_equipped_shield = Shields_Inventory[int.Parse(userInput) - 1];
                            Console.WriteLine("You've equipped a/an " + Convertor.exporter_shield(Currently_equipped, "shield_name" + "."));
                            Player_block_chance = int.Parse(Convertor.exporter_shield(Currently_equipped_shield, "shield_block_chance"));
                            Console.ReadKey();
                            return "";
                        }
                    }

                    else
                    {
                        Console.WriteLine("Unknown item");
                        
                    }
                }
                

<<<<<<< HEAD
=======
            }
            return ("");
>>>>>>> f7c9901691e1772857b2c4cc26fb7954550ea000
        }
    }
}


 

