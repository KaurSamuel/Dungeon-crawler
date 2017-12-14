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
            SoundPlayer music = new SoundPlayer
            {
                SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\music.wav"
            };
            music.PlayLooping();

            Player_Max_HP = 100;
            Player_current_HP = 100;
            Currently_equipped = "wA001";

            Console.OutputEncoding = Encoding.Unicode;

            Engine engine = new Engine();

            engine.Run();

        }
    }
}
