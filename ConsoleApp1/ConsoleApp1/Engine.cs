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
            if(Dungeon.CurRoom.Enemies.Count == 0)
            {
                Console.WriteLine("There are no enemies in this room");
                Console.ReadKey();
                return false;
            }

            string fullEnemies = "";
            foreach (string enemy in Dungeon.CurRoom.Enemies)
                fullEnemies += enemy + " ";

            fullEnemies = fullEnemies.Remove(fullEnemies.Length - 1);
            skills.Combat_start(fullEnemies);

            if(Dungeon.CurRoom.Enemies.Count == 0)
            {
                Player_Values.Player_current_HP += 50;
            }

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

            while (true)
            { 
                userInput = Console.ReadLine();

                if (userInput.ToUpper() == "Y")
                {
                    //Just run the program and try it
                    //Prepare to close the game more like.
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
            string userInput;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1. Fight");
                Console.WriteLine("2. Inventory");
                Console.WriteLine("3. Move");
                Console.WriteLine("4. Inspect room");
                Console.WriteLine("5. Suicide");



                userInput = Console.ReadLine();

                if (userInput == "")
                    return false;

                if (userInput == "1")
                    return Fight();

                else if (userInput == "2")
                    return(Player_Inventory.Inventory_start());

                else if (userInput =="3")
                    return dungeon.DrawMove();

                else if (userInput == "4")
                    return dungeon.InspectRoom();

                else if (userInput == "5")
                    return Suicide();

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
