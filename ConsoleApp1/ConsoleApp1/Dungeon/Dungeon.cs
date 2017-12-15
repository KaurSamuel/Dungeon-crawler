using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Collections;

namespace ConsoleApp1
{
    class Dungeon
    {
        public static List<Room> MapArray = new List<Room>();
        Vector2 CurPos = new Vector2(0.0f, 0.0f);
        Vector2 PrevPos = new Vector2(0.0f, 0.0f);
        public static Room CurRoom;
        Random rnd = new Random();
        char doorSign = '\u0126';

        //Every side of a room
        //Used to show which sides are on a room
        const byte SidesUp = 0x1;
        const byte SidesDown = 0x2;
        const byte SidesLeft = 0x4;
        const byte SidesRight = 0x8;

        //Used to check which sides are on a room (Pass to CheckSide function)
        const byte AddSidesUp = 0;
        const byte AddSidesDown = 1;
        const byte AddSidesLeft = 2;
        const byte AddSidesRight = 3;

        //Returns true if there are any enemies alive in the room
        public static bool EnemiesAlive(Room room) //Pass CurRoom on default
        {
            if (room.Enemies.Count > 0)
                return true;
            else
                return false;
        }


        //Holds data of each room
        public struct Room
        {
            public string roomData;
            public Vector2 pos;
            public Vector2 size;
            public byte sides;
            public List<string> Enemies;
            public List<Object> objects;

            public Room(Vector2 Pos, Vector2 Size, string RoomData, byte Sides = 0)
            {
                roomData = RoomData;
                pos = Pos;
                size = Size;
                sides = Sides;
                Enemies = new List<string>();
                objects = new List<Object>();
            }
        }

        //Generates a random map on creation
        public Dungeon()
        {
            GenerateMap();
        }

        Room AddDoorToPrevRoom(Room newRoom)
        {
            Vector2 pos = PrevPos - CurPos;
            Room lRoom = new Room();

            foreach (Room cRoom in MapArray)
                if (cRoom.pos == PrevPos)
                    lRoom = cRoom;

            if (pos.X == 0 && pos.Y == 1) //UP
                if (CheckSide(lRoom.sides, AddSidesDown))
                    return AddDoors(newRoom, SidesUp);

            if (pos.X == 0 && pos.Y == -1) //DOWN
                if (CheckSide(lRoom.sides, AddSidesUp))
                    return AddDoors(newRoom, SidesDown);

            if (pos.X == -1 && pos.Y == 0) //LEFT
                if (CheckSide(lRoom.sides, AddSidesRight))
                    return AddDoors(newRoom, SidesUp);

            if (pos.X == 1 && pos.Y == 0) //RIGHT
                if (CheckSide(lRoom.sides, AddSidesLeft))
                    return AddDoors(newRoom, SidesRight);

            return newRoom;
        }

        //Checks certain bit from a byte and returns it
        bool CheckSide(byte curSide, int bit)
        {
            return (curSide & (1 << bit)) != 0;
        }

        //Replaces a letter at a certain index
        public static string ReplaceAtIndex(int i, char value, string word)
        {
            char[] letters = word.ToCharArray();
            letters[i] = value;
            return string.Join("", letters);
        }

        private Room AddMobs(Room room)
        {
            string id = "A000";
            int mobCount = rnd.Next(0, 4);
            

            for (int i = 0; i < mobCount; i++)
            {
                id = ReplaceAtIndex(3, (char)rnd.Next(49, 54), id); // Generates a number between 1 and 6 and assigns it to 4th pos
                
                while(true)
                {
                    int position = rnd.Next(5, (int)(room.size.X * room.size.Y) - rnd.Next(0, 5));
                    if (room.roomData[position] != ' ')
                        continue;

                    room.roomData = ReplaceAtIndex(position, '?', room.roomData);
                    room.Enemies.Add(id);

                    break;
                }
            }

            return room;
        }

        public static Room RemoveMob(string id, Room room)
        {
            if(room.Enemies.Remove(id))
            {
                int count;

                count = room.roomData.IndexOf('?');

                if (count != -1)
                    room.roomData = ReplaceAtIndex(count, ' ', room.roomData);

                count++;
                
            }

            return room;
        }

        private Room AddObjects(Room room)
        {
            int numObjects = rnd.Next(0, 4);

            for (int i = 0; i < numObjects; i++)
            {
                Element.ElementStruct element;

                element = Element.LoadElementFromFile(rnd.Next(0, 11).ToString());

                while (true)
                {
                    int position = rnd.Next(5, (int)(room.size.X * room.size.Y) - 5);
                    if (room.roomData[position] != ' ')
                        continue;

                    room.roomData = ReplaceAtIndex(position, element.sprite, room.roomData);
                    room.objects.Add(element);
                    break;
                }
            }

            return room;
        }

        //Generates random events to a room(mobs, chests, weapons)
        private Room AddEvents(Room room)
        {
            room = AddMobs(room);
            room = AddObjects(room);


            return room;
        }

        //Generates first room
        public Room GenerateStartRoom(Vector2 MapSize)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Random rnd = new Random();
            Vector2 posTopLeft = MapSize * 0.25f;
            Vector2 posBotRight = MapSize * 0.75f;
            Room room;

            room = GenerateRoom(CurPos, (byte)rnd.Next(0, 15), false);

            CurPos = room.pos;

            return room;
        }

        //Adds door to a side of a room 
        public Room AddDoors(Room room, byte sides)
        {
            int sideX = (int)room.size.X;
            int sideY = (int)room.size.Y;
            byte finalSides = 0;

            //Checks each bit and if 1 adds a # to roomData
            if (CheckSide(sides, AddSidesUp)) //Up side
            {
                room.roomData = ReplaceAtIndex(sideX / 2, doorSign, room.roomData);
            }

            if (CheckSide(sides, AddSidesDown)) //Down side
            {
                room.roomData = ReplaceAtIndex((sideX * sideY) - ((sideX + 1) / 2), doorSign, room.roomData);
            }

            if (CheckSide(sides, AddSidesLeft)) //Left side
            {
                room.roomData = ReplaceAtIndex(((sideX * (sideY / 2))), doorSign, room.roomData);
            }

            if (CheckSide(sides, AddSidesRight)) //Right side
            {
                room.roomData = ReplaceAtIndex((sideX * (sideY / 2)) + sideX - 2, doorSign, room.roomData);
            }

            //Checks each doorsign and adds to finalsides if true
            if (room.roomData[sideX / 2] == doorSign)
                finalSides += SidesUp;
            if (room.roomData[(sideX * sideY) - ((sideX + 1) / 2)] == doorSign)
                finalSides += SidesDown;
            if (room.roomData[(sideX * (sideY / 2))] == doorSign)
                finalSides += SidesLeft;
            if (room.roomData[(sideX * (sideY / 2)) + sideX - 2] == doorSign)
                finalSides += SidesRight;


            room.sides = finalSides;

            return room;
        }

        //Generates a random room
        public Room GenerateRoom(Vector2 pos = default(Vector2), byte sides = 0, bool events = true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
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

            room = new Room(pos, new Vector2(roomWidth, roomHeight), roomData);

            room = AddDoors(room, (byte)rnd.Next(1, 15));

            room = AddDoorToPrevRoom(room);


            if (events)
                room = AddEvents(room);

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

            CurRoom = GenerateRoom(CurPos, (byte)EnteredSide);

        }

        //Inspects room
        public bool InspectRoom()
        {
            Console.WriteLine("There is: ");
            foreach (Element.ElementStruct ele in CurRoom.objects)
                Console.WriteLine(ele.description);
            foreach (string enemy in CurRoom.Enemies)
                Console.WriteLine(Convertor.export_mon(enemy, "mob_Name"));

            Console.ReadKey();

            return true;
        }

        //Prints Moving options
        public bool DrawMove()
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
                Console.WriteLine(count + ". " + '\u2191');//\u25B2
            }

            if (CheckSide(CurRoom.sides, AddSidesDown))
            {
                count++;
                sideDown = count;
                Console.WriteLine(count + ". " + '\u2193');//\u25BA
            }

            if (CheckSide(CurRoom.sides, AddSidesLeft))
            {
                count++;
                sideLeft = count;
                Console.WriteLine(count + ". " + '\u2190');//\u25BC
            }

            if (CheckSide(CurRoom.sides, AddSidesRight))
            {
                count++;
                sideRight = count;
                Console.WriteLine(count + ". " + '\u2192');//\u25C4'
            }

            count++;

            Console.WriteLine(count + ". Back");

            while (true)
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

                else if (userInput == sideRight.ToString())
                {
                    CurPos.X++;
                    MoveToRoom(sideRight);
                    break;
                }

                else if (userInput == count.ToString())
                {
                    return true;
                }

                else
                {
                    Console.WriteLine("Unknown option");
                }
            }

            return true;
        }

        //Prints CurRoom
        public bool DrawMap()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Room curRoom = new Room();

            foreach (Room room in MapArray)
                if (room.pos == CurPos)
                    curRoom = room;

            Console.WriteLine(curRoom.roomData);

            CurRoom = curRoom;
            
            return true;
        }

        public bool Frame()
        {
            return DrawMap();
        }
    }
}
