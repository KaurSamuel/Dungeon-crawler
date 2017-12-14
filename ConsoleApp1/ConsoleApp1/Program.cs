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
<<<<<<< HEAD
            Currently_equiped = "wA001";

            Console.OutputEncoding = Encoding.Unicode;

            Engine engine = new Engine();

=======
            SoundPlayer music = new SoundPlayer
            {
                SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\music.wav"
            };
            music.PlayLooping();

            Currently_equiped = "wA001";

            Console.OutputEncoding = Encoding.Unicode;
            Engine engine = new Engine();
            skills.Turn_start();
>>>>>>> 66071278c4b553592315dd645e55d8309b0006a8
            engine.Run();

        }
    }
}
