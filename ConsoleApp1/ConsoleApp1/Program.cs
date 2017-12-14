using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program : Player_Values
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
=======
            /* Hiya Human, you have succesfully entered the Gaming Realm.
             * Your Mission is to defeat four evil Program Developers,
             * because they have diabolical plan to take over internet and spread pornographic viruses.
             * Your our last hope :(
             */
            //string relv = Convertor.exporter_wep("wA001","wep_desc");
            //Console.WriteLine(relv);
            //Console.ReadLine();

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Dungeon dungeon = new Dungeon();

            //dungeon.GameLoop();

            while(true)
            {
                Console.Clear();
                dungeon.DrawMap();
            }
>>>>>>> rooms

            
        }
    }
}
