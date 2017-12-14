using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Player_Values
    {
        public static int Player_current_HP { get; set; }
        public static string Currently_figting_enemy { get; set; }
        public int Player_level { get; set; }
        public int Player_current_exp { get; set;}
        public int Player_block_chance { get; set; }
        public int Player_rooms_cleared { get; set; }
        public int Player_monsters_killed { get; set; }
        public static List<string> Weapons_Inventory = new List<string>();
        public static string Currently_equipped { get; set; }
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
            int mitukorda = 1;
            //Console.WriteLine("--------------------");
            foreach (var item in Weapons_Inventory)
            {
                string Name = Convertor.exporter_wep(item, "wep_name");
                Console.WriteLine(mitukorda +". "+ Name);
                mitukorda++;
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
            Currently_equipped = Weapons_Inventory[What_item];
            Console.WriteLine("You've equipped a/an "+ Convertor.exporter_wep(Currently_equipped,"wep_name" + "."));
            return ("");
        }
    }


 
}
