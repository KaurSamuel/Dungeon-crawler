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
        private List<Room> MapArray;

        public enum Sides { Up = 1, Down = 2, Left = 4, Right = 8};

        public struct Room
        {
            List<string> roomString;
            Vector2 pos;
            
            public Room(Vector2y, List<string> roomString, Sides _sides)
            {
                RoomString = new List<string>();
                X = x;
                Y = y;
                Sides sides = Sides.Down;
            }
        }

        public Dungeon()
        {

        }

        public bool EnemiesAlive { get; set; }

        public Vector2 GenerateStartRoom(Vector2 MapSize)
        {
            Random rnd = new Random();
            Vector2 posTopLeft = MapSize * 0.25f;
            Vector2 posBotRight = MapSize * 0.5f;
            Vector2 newPos;

            newPos.X = (int)posTopLeft.X + (int)posBotRight.X;
            newPos.Y = (int)posTopLeft.Y + (int)posBotRight.Y;

            Room room()

            return;
        }

        public Room[] GenerateRoom(Vector2 MapSize)
        {
            GenerateStartRoom(MapSize);


            return;
        }

        public bool GenerateMap()
        {
            

            return true;
        }

        public bool DrawMap()
        {


            return true;
        }
    }
}
