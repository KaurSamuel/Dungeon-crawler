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
    }


    class Player_Inventory : Player_Values
    {
        public static string Add_to_inventory(string Whatitem,string ID)
        {
            Weapons_Inventory.Add(ID);
            return ("");
        }
        public static string Drawinventory()
        {
            foreach (var item in Weapons_Inventory)
            {
                Console.WriteLine(item);
            }
            return ("");
        }
    }


 
}
