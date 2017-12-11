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
        public string mobTier { get; set; }
        public string ChestLoot { get; set; }


        //public Monster(string mobName, string mobHP, string mobMaxDMG, string mobMinDMG, string mobEXP, string mobTier, string ChestLoot)  
        //{
        //    chestLoot = new List<Items>();

        //}
        
    }
    public class monsters
    {
        public enemyvalues A001()
        {
            enemyvalues blue_slime = new enemyvalues();
            blue_slime.mobName = "Blue Slime";
            blue_slime.mobHP = "10";
            return (blue_slime);
        }

        public enemyvalues
    }
}
