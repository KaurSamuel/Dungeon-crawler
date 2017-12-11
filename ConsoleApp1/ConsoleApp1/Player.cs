using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player
    {
        public string CurrentHitPoints { get; set; }
        public string Gold { get; set; }
        public string ExperiencePoints { get; set; }
        public string Level { get; set; }
        public List<InventoryItem> Inventory { get; set; }

        public Player(string currentHitPoints,
        string gold, string experiencePoints, string level) :
        base(currentHitPoints)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
            Inventory = new List<InventoryItem>();
        }
    }
