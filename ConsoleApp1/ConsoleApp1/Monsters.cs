using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class enemyvalues
    {
        public string mobName { get; set; }
        public string mobHP { get; set; }
        public string mobMaxDMG { get; set; }
        public string mobMinDMG { get; set; }
        public string mobEXP { get; set; }
        public string ChestLoot { get; set; }   
    }

    //KÕIK MONSTERID:
    public class Monsters
    {
        // A - Tier1
        // B - Tier2
        // C - Tier3
        // AA - Tier1 boss
        // BB - Tier2 boss
        // CC - Tier3 boss
        // D - FINAL BOSS!!!!
        // G - test

        //Tier1 enemyd algavad
        public static enemyvalues A001()
        {
            enemyvalues green_slime = new enemyvalues
            {
                mobName = "Green Slime",
                mobHP = "15",
                mobMaxDMG = "15",
                mobMinDMG = "5",
                mobEXP = "30"
            };
            return (green_slime);
        }

        public static enemyvalues A002()
        {
            enemyvalues blue_slime = new enemyvalues
            {
                mobName = "Blue Slime",
                mobHP = "20",
                mobMaxDMG = "20",
                mobMinDMG = "5",
                mobEXP = "35"
            };
            return (blue_slime);
        }

        public static enemyvalues A003()
        {
            enemyvalues rat = new enemyvalues
            {
                mobName = "Rat",
                mobHP = "25",
                mobMaxDMG = "25",
                mobMinDMG = "7",
                mobEXP = "40"
            };
            return (rat);
        }
        public static enemyvalues A004()
        {
            enemyvalues chicken = new enemyvalues
            {
                mobName = "Chicken",
                mobHP = "20",
                mobMaxDMG = "15",
                mobMinDMG = "7",
                mobEXP = "26"
            };
            return (chicken);
        }
        public static enemyvalues A005()
        {
            enemyvalues snake = new enemyvalues
            {
                mobName = "Snake",
                mobHP = "40",
                mobMaxDMG = "30",
                mobMinDMG = "10",
                mobEXP = "35"
            };
            return (snake);
        }
        public static enemyvalues A006()
        {
            enemyvalues imp = new enemyvalues
            {
                mobName = "Imp",
                mobHP = "35",
                mobMaxDMG = "26",
                mobMinDMG = "8",
                mobEXP = "32"
            };
            return (imp);
        }

        public static enemyvalues AA01()
        {
            enemyvalues king_slime = new enemyvalues
            {
                mobName = "King Slime",
                mobHP = "150",
                mobMaxDMG = "40",
                mobMinDMG = "10",
                mobEXP = "200"
            };
            return (king_slime);
        }
        public static enemyvalues AA02()
        {
            enemyvalues giant_rat = new enemyvalues
            {
                mobName = "Giant Rat",
                mobHP = "200",
                mobMaxDMG = "32",
                mobMinDMG = "18",
                mobEXP = "200"
            };
            return (giant_rat);
        }
        public static enemyvalues AA03()
        {
            enemyvalues rogue = new enemyvalues
            {
                mobName = "Rogue",
                mobHP = "350",
                mobMaxDMG = "42",
                mobMinDMG = "4",
                mobEXP = "200"
            };
            return (rogue);
        }
        //Tier1 enemyd lõppevad

        //Tier2 enemyd algavad
        public static enemyvalues B001()
        {
            enemyvalues zombie = new enemyvalues()
            {
                mobName = "Zombie",
                mobHP = "235",
                mobMaxDMG = "30",
                mobMinDMG = "15",
                mobEXP = "105"
            };
            return (zombie);
        }
        public static enemyvalues B002()
        {
            enemyvalues poison_spider = new enemyvalues()
            {
                mobName = "Poison Spider",
                mobHP = "285",
                mobMaxDMG = "34",
                mobMinDMG = "14",
                mobEXP = "121"
            };
            return (poison_spider);
        }
        public static enemyvalues B003()
        {
            enemyvalues wolf = new enemyvalues()
            {
                mobName = "Wolf",
                mobHP = "268",
                mobMaxDMG = "32",
                mobMinDMG = "24",
                mobEXP = "110"
            };
            return (wolf);
        }
        public static enemyvalues B004()
        {
            enemyvalues black_bear = new enemyvalues()
            {
                mobName = "Black Bear",
                mobHP = "308",
                mobMaxDMG = "30",
                mobMinDMG = "18",
                mobEXP = "108"
            };
            return (black_bear);
        }
        public static enemyvalues B005()
        {
            enemyvalues scorpion = new enemyvalues()
            {
                mobName = "Scorpion",
                mobHP = "256",
                mobMaxDMG = "42",
                mobMinDMG = "13",
                mobEXP = "97"
            };
            return (scorpion);
        }
        public static enemyvalues B006()
        {
            enemyvalues ghost = new enemyvalues()
            {
                mobName = "Ghost",
                mobHP = "288",
                mobMaxDMG = "32",
                mobMinDMG = "18",
                mobEXP = "101"
            };
            return (ghost);
        }
        
        public static enemyvalues BB01()
        {
            enemyvalues dungeon_rat = new enemyvalues()
            {
                mobName = "Dungeon Rat",
                mobHP = "582",
                mobMaxDMG = "86",
                mobMinDMG = "32",
                mobEXP = "1000",
            };
            return (dungeon_rat);
        }
        public static enemyvalues BB02()
        {
            enemyvalues giant = new enemyvalues()
            {
                mobName = "Giant",
                mobHP = "750",
                mobMaxDMG = "56",
                mobMinDMG = "22",
                mobEXP = "1000"
            };
            return (giant);
        }
        public static enemyvalues BB03()
        {
            enemyvalues black_knight = new enemyvalues()
            {
                mobName = "Black Knight",
                mobHP = "674",
                mobMaxDMG = "48",
                mobMinDMG = "40",
                mobEXP = "1000"
            };
            return (black_knight);
        }
        //Tier2 enemyd lõppevad

        //Tier3 enemyd algavad
        public static enemyvalues C001()
        {
            enemyvalues pirate = new enemyvalues()
            {
                mobName = "Pirate",
                mobHP = "740",
                mobMaxDMG = "64",
                mobMinDMG = "38",
                mobEXP = "400"
            };
            return (pirate);
        }
        public static enemyvalues C002()
        {
            enemyvalues head_thief = new enemyvalues()
            {
                mobName = "Head thief",
                mobHP = "950",
                mobMaxDMG = "86",
                mobMinDMG = "40",
                mobEXP = "452"
            };
            return (head_thief);
        }
        public static enemyvalues C003()
        {
            enemyvalues archer = new enemyvalues()
            {
                mobName = "Archer",
                mobHP = "1050",
                mobMaxDMG = "70",
                mobMinDMG = "30",
                mobEXP = "430"
            };
            return (archer);
        }
        public static enemyvalues C004()
        {
            enemyvalues skeleton = new enemyvalues()
            {
                mobName = "Skeleton",
                mobHP = "820",
                mobMaxDMG = "52",
                mobMinDMG = "45",
                mobEXP = "482"
            };
            return (skeleton);
        }
        public static enemyvalues C005()
        {
            enemyvalues minotaur = new enemyvalues()
            {
                mobName = "Minotaur",
                mobHP = "1082",
                mobMaxDMG = "73",
                mobMinDMG = "52",
                mobEXP = "500"
            };
            return (minotaur);
        }
        public static enemyvalues C006() //peaks olema suht rare
        {
            enemyvalues gnome = new enemyvalues()
            {
                mobName = "Gnome",
                mobHP = "4000",
                mobMaxDMG = "40",
                mobMinDMG = "20",
                mobEXP = "2500"
            };
            return (gnome);
        }

        public static enemyvalues CC01()
        {
            enemyvalues unicow = new enemyvalues()
            {
                mobName = "Unicow",
                mobHP = "2840",
                mobMaxDMG = "102",
                mobMinDMG = "52",
                mobEXP = "2500"
            };
            return (unicow);
        }
        public static enemyvalues CC02()
        {
            enemyvalues wizard = new enemyvalues()
            {
                mobName = "Wizard",
                mobHP = "2520",
                mobMaxDMG = "92",
                mobMinDMG = "58",
                mobEXP = "2500",
            };
            return (wizard);
        }
        public static enemyvalues CC03()
        {
            enemyvalues summoner = new enemyvalues()
            {
                mobName = "Summoner",
                mobHP = "2300",
                mobMaxDMG = "110",
                mobMinDMG = "70",
                mobEXP = "2500"
            };
            return (summoner);
        }
        //Tier3 enemyd lõppevad

        //Final bossid:
        public static enemyvalues D01()
        {
            enemyvalues hindrek = new enemyvalues
            {
                mobName = "Hindrek the genius",
                mobHP = "5000",
                mobMaxDMG = "2000",
                mobMinDMG = "200",
                mobEXP = "10000"
            };
            return (hindrek);
        }

        public static enemyvalues D02()
        {
            enemyvalues kaur = new enemyvalues
            {
                mobName = "Kaur the mastermind",
                mobHP = "5000",
                mobMaxDMG = "2000",
                mobMinDMG = "200",
                mobEXP = "10000"
            };
            return (kaur);
        }
        
        public static enemyvalues D03()
        {
            enemyvalues karl = new enemyvalues
            {
                mobName = "Karl the betrayer",
                mobHP = "5",
                mobMaxDMG = "2000",
                mobMinDMG = "200",
                mobEXP = "10000"
            };
            return (karl);
        }
        public static enemyvalues D04()
        {
            enemyvalues jaan = new enemyvalues
            {
                mobName = "Jaan the nerd",
                mobHP = "5000",
                mobMaxDMG = "2000",
                mobMinDMG = "200",
                mobEXP = "10000"
            };
            return (jaan);
        }
        //final bossid lõppevad

        //test:
        public static enemyvalues G01()
        {
            enemyvalues test = new enemyvalues
            {
                mobName = "Test mob",
                mobHP = "10",
                mobMaxDMG = "8",
                mobMinDMG = "5",
                mobEXP = "200001"
            };
            return (test);
        }
    }
}
