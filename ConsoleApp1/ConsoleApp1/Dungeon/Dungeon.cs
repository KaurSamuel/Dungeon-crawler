using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp1
{
    class Dungeon
    {
        List<Room> MapArray = new List<Room>();
        Vector2 CurPos = new Vector2(0.0f, 0.0f);
        Room CurRoom;
        Random rnd = new Random();

        //Every side of a room
        //Used to show which sides are on a room
        const byte SidesUp = 0x1;
        const byte SidesDown = 0x2;
        const byte SidesLeft = 0x4;
        const byte SidesRight = 0x8;
        
        //Used to check which sides are on a room
        const byte AddSidesUp = 0;
        const byte AddSidesDown = 1;
        const byte AddSidesLeft = 2;
        const byte AddSidesRight = 3;

        //Struct to hold each room
        public struct Room
        {
            public string roomData;
            public Vector2 pos;
            public Vector2 size;
            public byte sides;
            
            public Room(Vector2 Pos, Vector2 Size, string RoomData, byte Sides)
            {
                roomData = RoomData;
                pos = Pos;
                size = Size;
                sides = Sides;
            }
        }

        //Generates a random map on creation
        public Dungeon()
        {
            GenerateMap();
        }

        //Checks certain bit from a byte and returns it
        bool CheckSide(byte curSide, int bit)
        {
            return (curSide & (1 << bit)) != 0;
        }

        //Replaces a letter at a certain index
        static string ReplaceAtIndex(int i, char value, string word)
        {
            char[] letters = word.ToCharArray();
            letters[i] = value;
            return string.Join("", letters);
        }

        //Returns true if there are any enemies alive in the room
        public bool EnemiesAlive { get; set; }

        //Generates first room
        public Room GenerateStartRoom(Vector2 MapSize)
        {
            Random rnd = new Random();
            Vector2 posTopLeft = MapSize * 0.25f;
            Vector2 posBotRight = MapSize * 0.75f;
            Room room;

            room = GenerateRoom(CurPos, rnd.Next(0, 15));

            CurPos = room.pos;

            return room;
        }

        public Room SetDoors(Room room, byte side)
        {
            room.sides = side;
            return room;
        }

        //Adds door to a side of a room 
        public Room AddDoors(Room room, byte sides)
        {
            int sideX = (int)room.size.X;
            int sideY = (int)room.size.Y;

            //Checks each bit and if 1 adds a # to roomData
            if (CheckSide(sides, AddSidesUp)) //Up side
                room.roomData = ReplaceAtIndex(sideX / 2, '#', room.roomData);

            if (CheckSide(sides, AddSidesDown)) //Down side
                room.roomData = ReplaceAtIndex((sideX * sideY) - ((sideX + 1) / 2), '#', room.roomData);

            if (CheckSide(sides, AddSidesLeft)) //Left side
                room.roomData = ReplaceAtIndex(((sideX * (sideY / 2))), '#', room.roomData);

            if (CheckSide(sides, AddSidesRight)) //Right side
                room.roomData = ReplaceAtIndex((sideX * (sideY / 2)) + sideX - 2, '#', room.roomData);

            room.sides = sides;
            
            return room;
        }

        //Generates a random room
        public Room GenerateRoom(Vector2 pos = default(Vector2), int sides = 0)
        {
            Room room;
            string roomData = "";
            int roomWidth = rnd.Next(8, 32);
            int roomHeight = rnd.Next(8, 16);

            pos = CurPos;

            for (int cur_height = 0; cur_height < roomHeight; cur_height++)
            {
                for (int cur_width = 0; cur_width < roomWidth; cur_width++)
                {
                    char appendable = ' ';

                    if (cur_width == 0 || cur_width == roomWidth - 1)
                        appendable = '\u2502';

                    if (cur_height == 0 || cur_height == roomHeight - 1)
                        appendable = '\u2500';

                    roomData += appendable;
                }


                roomData += '\n';
            }

            //Adds a corners to a room
            roomData = ReplaceAtIndex(0, '\u250C', roomData);
            roomData = ReplaceAtIndex(roomWidth - 1, '\u2510', roomData);
            roomData = ReplaceAtIndex((++roomWidth * roomHeight) - roomWidth, '\u2514', roomData);
            roomData = ReplaceAtIndex(roomData.Length - 2, '\u2518', roomData);

            room = new Room(pos, new Vector2(roomWidth, roomHeight), roomData, (byte)sides);
           
            room = AddDoors(room, (byte)rnd.Next(1, 15));

            MapArray.Add(room);

            return room;
        }

        //Generates a map
        public bool GenerateMap()
        {
            GenerateStartRoom(new Vector2(25, 25));

            return true;
        }

        //If room exist sets CurRoom to that, otherwise generates new
        private void MoveToRoom(int EnteredSide)
        {
            foreach (Room room in MapArray)
            {
                if (room.pos == CurPos)
                {
                    CurRoom = room;
                    return;
                }
            }

            CurRoom = GenerateRoom(CurPos, EnteredSide);
        }

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

        //Prints Moving options
        private bool DrawMove()
        {
            int count = 0;
            int sideUp = 0;
            int sideDown = 0;
            int sideLeft = 0;
            int sideRight = 0;

            if (CheckSide(CurRoom.sides, AddSidesUp))
            {
                count++;
                sideUp = count;
                Console.WriteLine(count + ". " + '\u25B2');
            }
            
            if (CheckSide(CurRoom.sides, AddSidesDown))
            {
                count++;
                sideDown = count;
                Console.WriteLine(count + ". " + '\u25BA');
            }
            
            if (CheckSide(CurRoom.sides, AddSidesLeft))
            {
                count++;
                sideLeft = count;
                Console.WriteLine(count + ". " + '\u25BC');
            }
            
            if (CheckSide(CurRoom.sides, AddSidesRight))
            {
                count++;
                sideRight = count;
                Console.WriteLine(count + ". " + '\u25C4');
            }

            count++;

            Console.WriteLine(count + ". Back");

            while(true)
            {
                string userInput;

                userInput = Console.ReadLine();

                if (userInput == sideUp.ToString())
                {
                    CurPos.Y++;
                    MoveToRoom(sideUp);
                    break;
                }

                else if (userInput == sideDown.ToString())
                {
                    CurPos.Y--;
                    MoveToRoom(sideDown);
                    break;
                }

                else if (userInput == sideLeft.ToString())
                {
                    CurPos.X--;
                    MoveToRoom(sideLeft);
                    break;
                }

                else if (userInput == sideLeft.ToString())
                {
                    CurPos.X++;
                    MoveToRoom(sideRight);
                    break;
                }

                else if(userInput == count.ToString())
                {
                    return true;
                }
                   

            }

            return true;
        }

        //Calls suicide options
        private bool DrawSuicide()
        {
            string userInput;

            

            Console.WriteLine("Are you sure?(Y/N)");
            userInput = Console.ReadLine();

            while(true)
            {
                if (userInput.ToUpper() == "Y")
                {
                    Console.WriteLine("Suicide is punishable by death.");
                    Thread.Sleep(1000);
                    Console.WriteLine("Prepare to die!");
                    Thread.Sleep(3000);
                    Directory.SetCurrentDirectory("../../img");
                    System.Diagnostics.Process.Start("script.bat");
                }

                else if(userInput.ToUpper() == "N")
                {
                    return false;
                }

                else
                {
                    Console.WriteLine("Unknown option.");
                }
            }
        }

        //Calls user options
        private bool DrawOptions()
        {
            string userInput;

            while(true)
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

        //Prints CurRoom
        public bool DrawMap()
        {
            
            Room curRoom = new Room();

            foreach (Room room in MapArray)
                if (room.pos == CurPos)
                    curRoom = room;

            Console.WriteLine(curRoom.roomData);

            CurRoom = curRoom;

            return true;
        }

        //Main loop
        public void GameLoop()
        {
            while(true)
            {
                Console.Clear();
                DrawMap();
                DrawOptions();
            }

        }
    }
}
