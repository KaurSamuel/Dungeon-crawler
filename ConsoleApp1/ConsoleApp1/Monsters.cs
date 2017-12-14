using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class enemyvalues
    {
        public string MobName { get; set; }
        public string MobHP { get; set; }
        public string MobMaxDMG { get; set; }
        public string MobMinDMG { get; set; }
        public string MobEXP { get; set; }
    }

    //KÕIK MONSTERID:
    public static class Monsters
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
                MobName = "Green Slime",
                MobHP = "15",
                MobMaxDMG = "15",
                MobMinDMG = "5",
                MobEXP = "30"
            };
            return (green_slime);
        }

        public static enemyvalues A002()
        {
            enemyvalues blue_slime = new enemyvalues
            {
                MobName = "Blue Slime",
                MobHP = "20",
                MobMaxDMG = "20",
                MobMinDMG = "5",
                MobEXP = "35"
            };
            return (blue_slime);
        }

        public static enemyvalues A003()
        {
            enemyvalues rat = new enemyvalues
            {
                MobName = "Rat",
                MobHP = "25",
                MobMaxDMG = "25",
                MobMinDMG = "7",
                MobEXP = "40"
            };
            return (rat);
        }
        public static enemyvalues A004()
        {
            enemyvalues chicken = new enemyvalues
            {
                MobName = "Chicken",
                MobHP = "20",
                MobMaxDMG = "15",
                MobMinDMG = "7",
                MobEXP = "26"
            };
            return (chicken);
        }
        public static enemyvalues A005()
        {
            enemyvalues snake = new enemyvalues
            {
                MobName = "Snake",
                MobHP = "40",
                MobMaxDMG = "30",
                MobMinDMG = "10",
                MobEXP = "35"
            };
            return (snake);
        }
        public static enemyvalues A006()
        {
            enemyvalues imp = new enemyvalues
            {
                MobName = "Imp",
                MobHP = "35",
                MobMaxDMG = "26",
                MobMinDMG = "8",
                MobEXP = "32"
            };
            return (imp);
        }

        public static enemyvalues AA01()
        {
            enemyvalues king_slime = new enemyvalues
            {
                MobName = "King Slime",
                MobHP = "150",
                MobMaxDMG = "40",
                MobMinDMG = "10",
                MobEXP = "200"
            };
            return (king_slime);
        }
        public static enemyvalues AA02()
        {
            enemyvalues giant_rat = new enemyvalues
            {
                MobName = "Giant Rat",
                MobHP = "200",
                MobMaxDMG = "32",
                MobMinDMG = "18",
                MobEXP = "200"
            };
            return (giant_rat);
        }
        public static enemyvalues AA03()
        {
            enemyvalues rogue = new enemyvalues
            {
                MobName = "Rogue",
                MobHP = "350",
                MobMaxDMG = "42",
                MobMinDMG = "4",
                MobEXP = "200"
            };
            return (rogue);
        }
        //Tier1 enemyd lõppevad

        //Tier2 enemyd algavad
        public static enemyvalues B001()
        {
            enemyvalues zombie = new enemyvalues()
            {
                MobName = "Zombie",
                MobHP = "235",
                MobMaxDMG = "30",
                MobMinDMG = "15",
                MobEXP = "105"
            };
            return (zombie);
        }
        public static enemyvalues B002()
        {
            enemyvalues poison_spider = new enemyvalues()
            {
                MobName = "Poison Spider",
                MobHP = "285",
                MobMaxDMG = "34",
                MobMinDMG = "14",
                MobEXP = "121"
            };
            return (poison_spider);
        }
        public static enemyvalues B003()
        {
            enemyvalues wolf = new enemyvalues()
            {
                MobName = "Wolf",
                MobHP = "268",
                MobMaxDMG = "32",
                MobMinDMG = "24",
                MobEXP = "110"
            };
            return (wolf);
        }
        public static enemyvalues B004()
        {
            enemyvalues black_bear = new enemyvalues()
            {
                MobName = "Black Bear",
                MobHP = "308",
                MobMaxDMG = "30",
                MobMinDMG = "18",
                MobEXP = "108"
            };
            return (black_bear);
        }
        public static enemyvalues B005()
        {
            enemyvalues scorpion = new enemyvalues()
            {
                MobName = "Scorpion",
                MobHP = "256",
                MobMaxDMG = "42",
                MobMinDMG = "13",
                MobEXP = "97"
            };
            return (scorpion);
        }
        public static enemyvalues B006()
        {
            enemyvalues ghost = new enemyvalues()
            {
                MobName = "Ghost",
                MobHP = "288",
                MobMaxDMG = "32",
                MobMinDMG = "18",
                MobEXP = "101"
            };
            return (ghost);
        }
        
        public static enemyvalues BB01()
        {
            enemyvalues dungeon_rat = new enemyvalues()
            {
                MobName = "Dungeon Rat",
                MobHP = "582",
                MobMaxDMG = "86",
                MobMinDMG = "32",
                MobEXP = "1000",
            };
            return (dungeon_rat);
        }
        public static enemyvalues BB02()
        {
            enemyvalues giant = new enemyvalues()
            {
                MobName = "Giant",
                MobHP = "750",
                MobMaxDMG = "56",
                MobMinDMG = "22",
                MobEXP = "1000"
            };
            return (giant);
        }
        public static enemyvalues BB03()
        {
            enemyvalues black_knight = new enemyvalues()
            {
                MobName = "Black Knight",
                MobHP = "674",
                MobMaxDMG = "48",
                MobMinDMG = "40",
                MobEXP = "1000"
            };
            return (black_knight);
        }
        //Tier2 enemyd lõppevad

        //Tier3 enemyd algavad
        public static enemyvalues C001()
        {
            enemyvalues pirate = new enemyvalues()
            {
                MobName = "Pirate",
                MobHP = "740",
                MobMaxDMG = "64",
                MobMinDMG = "38",
                MobEXP = "400"
            };
            return (pirate);
        }
        public static enemyvalues C002()
        {
            enemyvalues head_thief = new enemyvalues()
            {
                MobName = "Head thief",
                MobHP = "950",
                MobMaxDMG = "86",
                MobMinDMG = "40",
                MobEXP = "452"
            };
            return (head_thief);
        }
        public static enemyvalues C003()
        {
            enemyvalues archer = new enemyvalues()
            {
                MobName = "Archer",
                MobHP = "1050",
                MobMaxDMG = "70",
                MobMinDMG = "30",
                MobEXP = "430"
            };
            return (archer);
        }
        public static enemyvalues C004()
        {
            enemyvalues skeleton = new enemyvalues()
            {
                MobName = "Skeleton",
                MobHP = "820",
                MobMaxDMG = "52",
                MobMinDMG = "45",
                MobEXP = "482"
            };
            return (skeleton);
        }
        public static enemyvalues C005()
        {
            enemyvalues minotaur = new enemyvalues()
            {
                MobName = "Minotaur",
                MobHP = "1082",
                MobMaxDMG = "73",
                MobMinDMG = "52",
                MobEXP = "500"
            };
            return (minotaur);
        }
        public static enemyvalues C006() //peaks olema suht rare
        {
            enemyvalues gnome = new enemyvalues()
            {
                MobName = "Gnome",
                MobHP = "4000",
                MobMaxDMG = "40",
                MobMinDMG = "20",
                MobEXP = "2500"
            };
            return (gnome);
        }

        public static enemyvalues CC01()
        {
            enemyvalues unicow = new enemyvalues()
            {
                MobName = "Unicow",
                MobHP = "2840",
                MobMaxDMG = "102",
                MobMinDMG = "52",
                MobEXP = "2500"
            };
            return (unicow);
        }
        public static enemyvalues CC02()
        {
            enemyvalues wizard = new enemyvalues()
            {
                MobName = "Wizard",
                MobHP = "2520",
                MobMaxDMG = "92",
                MobMinDMG = "58",
                MobEXP = "2500",
            };
            return (wizard);
        }
        public static enemyvalues CC03()
        {
            enemyvalues summoner = new enemyvalues()
            {
                MobName = "Summoner",
                MobHP = "2300",
                MobMaxDMG = "110",
                MobMinDMG = "70",
                MobEXP = "2500"
            };
            return (summoner);
        }
        //Tier3 enemyd lõppevad

        //Final bossid:
        public static enemyvalues D01()
        {
            enemyvalues hindrek = new enemyvalues
            {
                MobName = "Hindrek the genius",
                MobHP = "5000",
                MobMaxDMG = "2000",
                MobMinDMG = "200",
                MobEXP = "10000"
            };
            return (hindrek);
        }

        public static enemyvalues D02()
        {
            enemyvalues kaur = new enemyvalues
            {
                MobName = "Kaur the mastermind",
                MobHP = "5000",
                MobMaxDMG = "2000",
                MobMinDMG = "200",
                MobEXP = "10000"
            };
            return (kaur);
        }
        
        public static enemyvalues D03()
        {
            enemyvalues karl = new enemyvalues
            {
                MobName = "Karl the betrayer",
                MobHP = "5",
                MobMaxDMG = "2000",
                MobMinDMG = "200",
                MobEXP = "10000"
            };
            return (karl);
        }
        public static enemyvalues D04()
        {
            enemyvalues jaan = new enemyvalues
            {
                MobName = "Jaan the nerd",
                MobHP = "5000",
                MobMaxDMG = "2000",
                MobMinDMG = "200",
                MobEXP = "10000"
            };
            return (jaan);
        }
        //final bossid lõppevad

        //test:
        public static enemyvalues G01()
        {
            enemyvalues test = new enemyvalues
            {
                MobName = "Test mob",
                MobHP = "10",
                MobMaxDMG = "8",
                MobMinDMG = "5",
                MobEXP = "200001"
            };
            return (test);
        }
    }
}
