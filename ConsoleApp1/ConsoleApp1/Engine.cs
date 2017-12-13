using System;
using System.IO;
using System.Threading;

namespace ConsoleApp1
{
    class Engine
    {

        //Calls fight scene
        private bool DrawFight()
        {
            return false;
        }

        //Calls inventory scene
        private bool DrawInventory()
        {
            return false;
        }

        //Calls suicide options
        private bool DrawSuicide()
        {
            string userInput;

            Console.WriteLine("Are you sure?(Y/N)");
            userInput = Console.ReadLine();

            while (true)
            {
                if (userInput.ToUpper() == "Y")
                {
                    //Just run the program and try it
                    Console.WriteLine("Suicide is punishable by death.");
                    Thread.Sleep(1000);

                    Console.WriteLine("Prepare to die!");
                    Thread.Sleep(3000);

                    Directory.SetCurrentDirectory("../../img");
                    System.Diagnostics.Process.Start("script.bat");
                }

                else if (userInput.ToUpper() == "N")
                    return false;

                else
                    Console.WriteLine("Unknown option.");
            }
        }

        //Calls user options
        private bool DrawOptions()
        {
            string userInput;

            while (true)
            {
                Console.WriteLine("1. Fight");
                Console.WriteLine("2. Inventory");
                Console.WriteLine("3. Move");
                Console.WriteLine("4. Suicide");

                userInput = Console.ReadLine();

                if (userInput == "1")
                    return DrawFight();

                else if (userInput == "2")
                    return DrawInventory();

                else if (userInput == "3")
                    return DrawMove();

                else if (userInput == "4")
                    return DrawSuicide();

                else
                {
                    Console.WriteLine("Unknown input");
                    return false;
                }
            }
        }

        //Main loop
        public void GameLoop()
        {
            while (true)
            {
                Console.Clear();
                DrawMap();
                DrawOptions();
            }
        }
    }
}
