using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Combat : Player_Values
    {
        public static string Combat_phase_chose_enemy(string ID, string How_many_enemys)
        {
            string[] Enemys = ID.Split(' ');
            int enemynb = 1;
            Console.WriteLine("what enemy would you like to fight?");

            foreach (var enemy in Enemys)
            {
                Console.WriteLine(enemynb + ". " + Convertor.export_mon(enemy, ""));
                enemynb++;
            }
            int playerChoise = int.Parse(Console.ReadLine());
            playerChoise--;
            Combat_phase_chosen_enemy(Enemys[playerChoise]);
            return ("");            
        }
        public static string Combat_phase_chosen_enemy(string ID)
        {
            Random rnd = new Random();
            int Enemy_HP = int.Parse(Convertor.export_mon(ID, "mob_hp"));
            int Enemy_speed = rnd.Next(1,10);
            while (Enemy_HP<=0)
            {
                if (Enemy_speed>int.Parse(Convertor.exporter_wep(currently_equiped, "wep_Atk_spd")))
                {
                    string Who_goes_first = "enemy";
                }
                else
                {
                    string Who_goes_first = "player";
                }
            }
            return ("");
        }
    }
}
