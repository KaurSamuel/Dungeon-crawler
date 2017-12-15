using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace ConsoleApp1
{
    class Program : Player_Values
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Swords and Shields(and potions if you pay for the potions DLC(4,99€))");
            Console.WriteLine("Tutorial: you will be healed to max HP if you clear a room from enemys, equiping shields gives you a chance to block an attack");
            Console.WriteLine("Credits:");
            Console.WriteLine("Hindrek Hannus: graphic designer");
            Console.WriteLine("Kaur Samuel Kannel: Game Designer,Boss");
            Console.WriteLine("Jaan Jahilo: Assets");
            Console.ReadLine();
            SoundPlayer music = new SoundPlayer
            {
                SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\music.wav"
            };
            music.PlayLooping();

            Player_Max_HP = 100;
            Player_current_HP = 100;
            Currently_equipped = "wA001";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.OutputEncoding = Encoding.Unicode;

            Engine engine = new Engine();

            engine.Run();

        }
    }
}
