using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Combat
    {
        public static string Combat_phase_start(string ID, string How_many_enemys)
        {
            string[] Enemys = ID.Split(' ');
            int enemynb = 1;
            Console.WriteLine("what enemy would you like to fight?");

            foreach (var enemy in Enemys)
            {

                Console.WriteLine(enemynb + ". " + Convertor.export_mon(enemy, "mob_Name"));
                enemynb++;
            }
            string playerChoise = Console.ReadLine();
            return ("");
        }
    }
}
