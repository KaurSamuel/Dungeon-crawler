﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class objectvalues
    {
        public string objDesc { get; set; }
    }
    public class objects
    {
        public objectvalues Obj01()
        {
            objectvalues chair = new objectvalues
            {
                objDesc = "There is a wooden chair."
            };
            return (chair);
        }
        public objectvalues Obj02()
        {
            objectvalues table = new objectvalues
            {
                objDesc = "There is a wooden table."
            };
            return (table);
        }
        public objectvalues Obj03()
        {
            objectvalues trash_bin = new objectvalues
            {
                objDesc = "There is an empty trash bin."
            };
            return (trash_bin);
        }
        public objectvalues Obj04()
        {
            objectvalues trash_bin2 = new objectvalues
            {
                objDesc = "There is a trash bin filled with paper."
            };
            return (trash_bin2);
        }
        public objectvalues Obj05()
        {
            objectvalues smell = new objectvalues
            {
                objDesc = "There is a weird smell in this room."
            };
            return (smell);
        }
        public objectvalues Obj06()
        {
            objectvalues gert = new objectvalues
            {
                objDesc = "There is a Gert-Andry Kääramees in the room."
            };
            return (gert);
        }
    }
}
