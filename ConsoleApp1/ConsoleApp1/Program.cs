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
            Currently_equiped = "wA001";

            Console.OutputEncoding = Encoding.Unicode;


            Engine engine = new Engine();

            engine.Run();

        }
    }
}
