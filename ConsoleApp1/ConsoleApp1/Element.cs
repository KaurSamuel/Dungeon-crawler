using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp1
{
    class Element
    {
        public struct ElementStruct
        {
            public string description;
            public string id;
            public char sprite;
            public Vector2 pos;

            public ElementStruct(string desc, string _id, char _sprite, Vector2 _pos)
            {
                description = desc;
                id = _id;
                sprite = _sprite;
                pos = _pos;
            }
        }

        public static ElementStruct LoadElementFromFile(string id)
        {
            ElementStruct elementStruct = new ElementStruct();
            string[] allLines = System.IO.File.ReadAllLines("../../objects.txt");

            foreach(string line in allLines)
            {
                string[] splitLine = line.Split();

                if(splitLine[0] == id)
                {
                    elementStruct.description = splitLine[1];
                    elementStruct.sprite = splitLine[1][0];
                    elementStruct.id = id;
                }
            }

            return elementStruct;
        }

    }
}
