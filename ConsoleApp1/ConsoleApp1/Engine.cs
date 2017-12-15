﻿using System;
using System.IO;
using System.Threading;

namespace ConsoleApp1
{
    class Engine
    {
        Dungeon dungeon;

        public Engine()
        {
            dungeon = new Dungeon();
        }

        //Calls fight scene
        private bool Fight()
        {
            if(dungeon.CurRoom.Enemies.Count == 0)
            {
                Console.WriteLine("There are no enemies in this room");
                Console.ReadKey();
                return false;
            }

            string fullEnemies = "";
            foreach (string enemy in dungeon.CurRoom.Enemies)
                fullEnemies += enemy + " ";

            fullEnemies = fullEnemies.Remove(fullEnemies.Length - 1);
            skills.Combat_start(fullEnemies);

            return true;
        }

        //Calls inventory scene
        private bool Inventory()
        {
            Player_Inventory.Equip_weapon();
            return false;
        }

        //Calls suicide options
        private bool Suicide()
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
        private bool Options()
        {
            int userInput;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1. Fight");
                Console.WriteLine("2. Inventory");
                Console.WriteLine("3. Move");
                Console.WriteLine("4. Suicide");
                Console.WriteLine("5. Inspect room");

                userInput = int.Parse(Console.ReadLine());

                if (userInput == 1)
                    return Fight();

                else if (userInput == 2)
                    return(Player_Inventory.Inventory_start());

                else if (userInput == 3)
                    return dungeon.DrawMove();

                else if (userInput == 4)
                    return Suicide();

                else if (userInput == 5)
                    return dungeon.InspectRoom();

                else
                {
                    Console.WriteLine("Unknown input");
                    return false;
                }
            }
        }

        //Main loop
        public void Run()
        {

            while (true)
            {
                Console.Clear();
                dungeon.DrawMap();
                Options();
            }
        }

    }
}
