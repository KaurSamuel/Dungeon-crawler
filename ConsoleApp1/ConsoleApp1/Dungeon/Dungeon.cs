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

        public enum Sides {None = 0, Up = 1, Down = 2, Left = 4, Right = 8};

        public struct Room
        {
            public string roomData;
            public Vector2 pos;
            public Vector2 size;
            public Sides sides;
            
            public Room(Vector2 Pos, Vector2 Size, string RoomData, Sides Sides)
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

            room = GenerateRoom(newPos, (Sides)rnd.Next(0, 16));

            CurPos = room.pos;

            room = AddDoor(room, Sides.Up);

            return room;
        }

        public Room AddDoor(Room room, Sides sides)
        {
            if (sides == Sides.Up)
                room.roomData = ReplaceAtIndex((int)room.size.X / 2, ' ', room.roomData);

            room.sides = sides;

            return room;
        }

        public Room GenerateRoom(Vector2 pos = default(Vector2), Sides sides = 0)
        {
            string roomData = "";
            int roomWidth = 8;
            int roomHeight = 16;

            // Bug: Currently roomWidth and roomHeight are reversed
            
            for (int cur_width = 0; cur_width < roomWidth; cur_width++)
            {
                for (int cur_height = 0; cur_height < roomHeight; cur_height++)
                {
                    char appendable = ' ';

                    if (cur_width == 0 || cur_width == roomWidth - 1)
                        appendable = '-';

                    if (cur_height == 0 || cur_height == roomHeight - 1)
                        appendable = '|';

                    roomData += appendable;
                }

                roomData += '\n';
            }

            return new Room(new Vector2(25, 25), new Vector2(roomWidth, roomHeight), roomData, Sides.None);
        }

        public bool GenerateMap()
        {
            MapArray.Add(GenerateStartRoom(new Vector2(25, 25)));

            return true;
        }

        public bool DrawMap()
        {
            string buffer = "";
            Sides sides;
            Room curRoom;
            Vector2[] sideRooms;

            foreach (Room room in MapArray)
                if (room.pos == CurPos)
                    curRoom = room;

            sideRooms = new Vector2[];

            foreach (Room room in MapArray)
                

            return true;
        }
    }
}
