using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Player_Values
    {
        public string Player_level { get; set; }
        public string Player_current_exp { get; set;}
        public string Player_block_chance { get; set; }
        public string Player_rooms_cleared { get; set; }
        public string Player_monsters_killed { get; set; }
        public static List<string> Weapons_Inventory = new List<string>();
        public static string currently_equiped { get; set; }
    }

    class Player_Inventory : Player_Values
    {
        public static string Add_to_inventory(string Whatitem,string ID)
        {
            Weapons_Inventory.Add(ID);
            return ("");            
        }
        public static string Draw_inventory()
        {
            int mittukorda = 1;
            //Console.WriteLine("--------------------");
            foreach (var item in Weapons_Inventory)
            {
                string Name = Convertor.exporter_wep(item, "wep_name");
                Console.WriteLine(mittukorda +". "+ Name);
                mittukorda++;
            }
            //Console.WriteLine("-------------------");
            return ("");
        }
        public static string Equip_weapon()
        {
            Draw_inventory();
            Console.WriteLine("What item would you like to equip?(write the number)");
            int What_item = 0;
            What_item = int.Parse(Console.ReadLine());
            What_item--;
            currently_equiped = Weapons_Inventory[What_item];
            Console.WriteLine("you have equipped the "+ Convertor.exporter_wep(currently_equiped,"wep_name"));
            return ("");
        }
    }


 
}
