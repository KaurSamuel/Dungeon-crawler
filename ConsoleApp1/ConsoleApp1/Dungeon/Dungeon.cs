using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp1
{
    class Dungeon
    {
        List<Room> MapArray = new List<Room>();
        Vector2 CurPos;
        Room CurRoom;

        //Every side of a room
        int SidesUp = 0;
        int SidesDown = 1;
        int SidesLeft = 2;
        int SidesRight = 4;

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
            Vector2 newPos;
            Room room;

            newPos.X = rnd.Next((int)posTopLeft.X, (int)posBotRight.X);
            newPos.Y = rnd.Next((int)posTopLeft.Y, (int)posBotRight.Y);

            room = GenerateRoom(newPos, (int)rnd.Next(1, 16));

            CurPos = room.pos;

            room = AddDoor(room, SidesUp);

            return room;
        }

        //Adds door to a side of a room 
        public Room AddDoor(Room room, int sides)
        {
            

           /* if (CheckSide((byte)room.sides, SidesUp)) //Up side
               room.roomData = ReplaceAtIndex((int)room.size.X / 2, '#', room.roomData);
          */  if (CheckSide((byte)room.sides, SidesDown)) //Down side
                room.roomData = ReplaceAtIndex((int)((room.size.X * room.size.Y) - (room.size.X/ 2)), '#', room.roomData);
          /*  if (CheckSide((byte)room.sides, SidesLeft)) //Left side
                room.roomData = ReplaceAtIndex((int)((room.size.Y / 2) * room.size.X / 2), '#', room.roomData);
            if (CheckSide((byte)room.sides, SidesRight)) //Right side
                room.roomData = ReplaceAtIndex((int)(((room.size.X) / 2) * room.size.Y), '#', room.roomData);
                */
            return room;
        }

        //Generates a random room
        public Room GenerateRoom(Vector2 pos = default(Vector2), int sides = 0)
        {
            Random rnd = new Random();
            Room room;
            string roomData = "";
            int roomWidth = rnd.Next(8, 32);
            int roomHeight = rnd.Next(8, 16);

            for (int cur_height = 0; cur_height < roomHeight; cur_height++)
            {
                for (int cur_width = 0; cur_width < roomWidth; cur_width++)
                {
                    char appendable = ' ';

                    if (cur_width == 0 || cur_width == roomWidth - 1)
                        appendable = '|';

                    if (cur_height == 0 || cur_height == roomHeight - 1)
                        appendable = '-';

                    roomData += appendable;
                }

                roomData += '\n';
            }

            //Adds a corners to a room
            roomData = ReplaceAtIndex(0, '\u231C', roomData);
            roomData = ReplaceAtIndex(roomWidth - 1, '\u231C', roomData);
            //roomData = ReplaceAtIndex(roomHeight)

            room = new Room(pos, new Vector2(roomWidth, roomHeight), roomData, (byte)sides);

            room = AddDoor(room, rnd.Next(1, 15));

            MapArray.Add(room);

            return room;
        }

        //Generates a map
        public bool GenerateMap()
        {
            GenerateStartRoom(new Vector2(25, 25));

            return true;
        }

        //If room exist sets CurRoom to that, else generates new
        private void MoveToRoom(int EnteredSide)
        {
            foreach (Room room in MapArray)
            {
                if (room.pos == CurPos)
                    CurRoom = room;
                else
                    CurRoom = GenerateRoom(CurPos, EnteredSide);
            }
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

            if (CheckSide(CurRoom.sides, SidesUp))
            {
                count++;
                sideUp = count;
                Console.WriteLine(count + ". " + '\u25B2');
            }
            
            if (CheckSide(CurRoom.sides, SidesDown))
            {
                count++;
                sideDown = count;
                Console.WriteLine(count + ". " + '\u25BA');
            }
            
            if (CheckSide(CurRoom.sides, SidesLeft))
            {
                count++;
                sideLeft = count;
                Console.WriteLine(count + ". " + '\u25BC');
            }
            
            if (CheckSide(CurRoom.sides, SidesRight))
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
                    MoveToRoom(sideUp);
                    break;
                }

                else if (userInput == sideDown.ToString())
                {
                    MoveToRoom(sideDown);
                    break;
                }

                else if (userInput == sideLeft.ToString())
                {
                    MoveToRoom(sideLeft);
                    break;
                }

                else if (userInput == sideLeft.ToString())
                {
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
            return false;
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
