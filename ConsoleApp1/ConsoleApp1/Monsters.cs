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
        // AA - Tier1 boss
        // BB - Tier2 boss
        // CC - Tier3 boss
        // D - FINAL BOSS!!!!
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



        public enemyvalues AA01()
        {
            enemyvalues king_slime = new enemyvalues();
            king_slime.mobName = "King Slime";
            king_slime.mobHP = "150";
            king_slime.mobMaxDMG = "40";
            king_slime.mobMinDMG = "10";
            king_slime.mobEXP = "200";
            return (king_slime);
        }

        public enemyvalues D01()
        {
            enemyvalues hindrek = new enemyvalues();
            hindrek.mobName = "Hindrek the genius";
            hindrek.mobHP = "5000";
            hindrek.mobMaxDMG = "2000";
            hindrek.mobMinDMG = "200";
            hindrek.mobEXP = "10000";
            return (hindrek);
        }

        public enemyvalues D02()
        {
            enemyvalues kaur = new enemyvalues();
            kaur.mobName = "Kaur the mastermind";
            kaur.mobHP = "5000";
            kaur.mobMaxDMG = "2000";
            kaur.mobMinDMG = "200";
            kaur.mobEXP = "10000";
            return (kaur);
        }
        
        public enemyvalues D03()
        {
            enemyvalues karl = new enemyvalues();
            karl.mobName = "Karl the beast";
            karl.mobHP = "5000";
            karl.mobMaxDMG = "2000";
            karl.mobMinDMG = "200";
            karl.mobEXP = "10000";
            return (karl);
        }
        public enemyvalues D04()
        {
            enemyvalues jaan = new enemyvalues();
            jaan.mobName = "Jaan the nerd";
            jaan.mobHP = "5000";
            jaan.mobMaxDMG = "2000";
            jaan.mobMinDMG = "200";
            jaan.mobEXP = "10000";
            return (jaan);
        }


    }
}
