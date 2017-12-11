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
    public class monsters
    {
        // A - Tier1
        // B - Tier2
        // C - Tier3
        public enemyvalues A001()
        {
            enemyvalues green_slime = new enemyvalues();
            green_slime.mobName = "Green Slime";
            green_slime.mobHP = "15";
            green_slime.mobMaxDMG = "15";
            green_slime.mobMinDMG = "5";
            green_slime.mobEXP = "30";
            return (green_slime);
        }

        public enemyvalues A002()
        {
            enemyvalues blue_slime  = new enemyvalues();
            blue_slime.mobName = "Blue Slime";
            blue_slime.mobHP = "20";
            blue_slime.mobMaxDMG = "20";
            blue_slime.mobMinDMG = "5";
            blue_slime.mobEXP = "35";
            return (blue_slime);
        }

    }
}
