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
            public int sides;
            
            public Room(Vector2 Pos, Vector2 Size, string RoomData, int Sides)
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

            room = GenerateRoom(newPos, (int)rnd.Next(0, 16));

            CurPos = room.pos;

            room = AddDoor(room, SidesUp);

            return room;
        }
        
        public Room AddDoor(Room room, int sides)
        {
            room.roomData = ReplaceAtIndex((int)room.size.X / 2, ' ', room.roomData);

            room.sides = sides;

            return room;
        }

        public Room GenerateRoom(Vector2 pos = default(Vector2), int sides = 0)
        {
            string roomData = "";
            int roomWidth = 16;
            int roomHeight = 8;

            // Bug: Currently roomWidth and roomHeight are reversed
            
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

            return new Room(new Vector2(25, 25), new Vector2(roomWidth, roomHeight), roomData, SidesNone);
        }

        public bool GenerateMap()
        {
            MapArray.Add(GenerateStartRoom(new Vector2(25, 25)));

            return true;
        }

        public bool DrawMap()
        {
            string buffer = "";
            int sides;
            Room curRoom = new Room();
            Vector2[] sideRooms;

            Console.Clear();

            foreach (Room room in MapArray)
                if (room.pos == CurPos)
                    curRoom = room;
                else
                    throw new System.ArgumentException("CurRoom not found");

            //sideRooms = new Vector2[Vector2];

            //foreach (Room room in MapArray)

            Console.WriteLine(curRoom.roomData);
            Console.WriteLine(buffer);

            return true;
        }
    }
}
