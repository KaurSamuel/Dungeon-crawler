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
        Room curRoom;

        int SidesNone = 0;
        int SidesUp = 1;
        int SidesDown = 2;
        int SidesLeft = 4;
        int SidesRight = 8;

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

        public Dungeon()
        {
            GenerateMap();
        }

        bool CheckSide(byte curSide, int bit)
        {
            return (curSide & (1 << bit)) != 0;
        }

        static string ReplaceAtIndex(int i, char value, string word)
        {
            char[] letters = word.ToCharArray();
            letters[i] = value;
            return string.Join("", letters);
        }

        public bool EnemiesAlive { get; set; }

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
        
        public Room AddDoor(Room room, int sides)
        {
            if (CheckSide((byte)room.sides, SidesUp))
                room.roomData = ReplaceAtIndex((int)room.size.X / 2, '#', room.roomData);
            if (CheckSide((byte)room.sides, SidesDown))
                room.roomData = ReplaceAtIndex((int)((room.size.X * room.size.Y) - (room.size.X / 2)), '#', room.roomData);
            if (CheckSide((byte)room.sides, SidesLeft))
                room.roomData = ReplaceAtIndex((int)((room.size.Y / 2) * room.size.X / 2), '#', room.roomData);
            //if (CheckSide((byte)room.sides, SidesRight))
               // room.roomData = ReplaceAtIndex((int)((room.size)))

            // room.sides = sides;

            return room;
        }

        public Room GenerateRoom(Vector2 pos = default(Vector2), int sides = 0)
        {
            Random rnd = new Random();
            Room room;
            string roomData = "";
            int roomWidth = rnd.Next(8, 32);
            int roomHeight = rnd.Next(6, 16);

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

            //roomData = ReplaceAtIndex(0, '\u231C', roomData);
            //roomData = ReplaceAtIndex(roomWidth, '\u231C', roomData);
            //roomData = ReplaceAtIndex(roomHeight)

            room = new Room(pos, new Vector2(roomWidth, roomHeight), roomData, (byte)sides);

            room = AddDoor(room, rnd.Next(0, 15));

            MapArray.Add(room);

            return room;
        }

        public bool GenerateMap()
        {
            GenerateStartRoom(new Vector2(25, 25));

            return true;
        }

        public void DrawFight()
        {

        }

        public void DrawInventory()
        {

        }

        public void DrawMove()
        {
            int count = 0;
            int sideUp = 0;
            int sideDown = 0;
            int sideLeft = 0;
            int sideRight = 0;

            if (CheckSide(curRoom.sides, SidesUp))
            {
                count++;
                sideUp = count;
                Console.WriteLine(count + ". " + '\u25B2');
            }
            
            if (CheckSide(curRoom.sides, SidesUp))
            {
                count++;
                sideDown = count;
                Console.WriteLine(count + ". " + '\u25BA');
            }
            
            if (CheckSide(curRoom.sides, SidesUp))
            {
                count++;
                sideLeft = count;
                Console.WriteLine(count + ". " + '\u25BC');
            }
            
            if (CheckSide(curRoom.sides, SidesUp))
            {
                count++;
                sideRight = count;
                Console.WriteLine(count + ". " + '\u25C4');
            }

            Console.WriteLine(count + ". Back");

            while(true)
            {
                string userInput;

                userInput = Console.ReadLine();

                if (userInput == "1")
                    break;

            }

            
        }

        public void DrawSuicide()
        {

        }

        public void DrawOptions()
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
                {
                    DrawFight();
                    break;
                }

                else if (userInput == "2")
                {
                    DrawInventory();
                    break;
                }

                else if (userInput == "3")
                {
                    DrawMove();
                    break;
                }
                   
                else if (userInput == "4")
                {
                    DrawSuicide();
                    break; 
                }
                   
                else
                {
                    Console.WriteLine("Unknown input");
                }    
               
            }

            
        }

        public bool DrawMap()
        {
            Console.Clear();
            Room curRoom = new Room();

            foreach (Room room in MapArray)
                if (room.pos == CurPos)
                    curRoom = room;

            Console.WriteLine(curRoom.roomData);

            DrawOptions();

            return true;
        }
    }
}
