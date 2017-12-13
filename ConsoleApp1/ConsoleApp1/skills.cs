using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class skills
    {
        public static string Combat_start(string ID)
        {
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
            Console.WriteLine("Your turn,chose your action!");
            Console.WriteLine("1. Normal attack");
            int Userinput = int.Parse(Console.ReadLine());
            if (Userinput==1)
            {
                Normal_attack(enemyHP);
            }

            return ("");
        }
        public static string Normal_attack(int HP)
        {



            return ("");
        }

    }
}
