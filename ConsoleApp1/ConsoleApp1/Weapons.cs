using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class weaponvalues
    {
        public string wepName { get; set; }
        public string wepDesc { get; set; }
        public string wepMinDMG { get; set; }
        public string wepMaxDMG { get; set; }
    }
    public class HPvalues
    {
        public string potName { get; set; }
        public string healingAmount { get; set; }
    }

    public class Hppotions
    {
        // hA - Tier1
        // hB - Tier2
        // hC - Tier3
        // hh - Special Tier, healib max eludeni
        public HPvalues hA1()
        {
            HPvalues minor_hp = new HPvalues();
            minor_hp.potName = "Minor Health Potion";
            minor_hp.healingAmount = "25";
            return (minor_hp);
        }
        public HPvalues hA2()
        {
            HPvalues small_hp = new HPvalues();
            small_hp.potName = "Small Health Potion";
            small_hp.healingAmount = "50";
            return (small_hp);
        }
        public HPvalues hB1()
        {
            HPvalues medium_hp = new HPvalues();
            medium_hp.potName = "Medium Health Potion";
            medium_hp.healingAmount = "75";
            return (medium_hp);
        }
        public HPvalues hB2()
        {
            HPvalues great_hp = new HPvalues();
            great_hp.potName = "Greater Health Potion";
            great_hp.healingAmount = "100";
            return (great_hp);
        }
        public HPvalues hC1()
        {
            HPvalues big_hp = new HPvalues();
            big_hp.potName = "Big Health Potion";
            big_hp.healingAmount = "125";
            return (big_hp);
        }
        public HPvalues hC2()
        {
            HPvalues huge_hp = new HPvalues();
            huge_hp.potName = "Huge Health Potion";
            huge_hp.healingAmount = "150";
            return (huge_hp);
        }
        public HPvalues hh1()
        {
            HPvalues max_hp = new HPvalues();
            max_hp.potName = "Coca Cola";
            max_hp.healingAmount = ""; //karl lisab selle funktsiooni et healib kasutaja max eludeni
            return (max_hp);
        }
    }


    public class weapons
    {
        // wA - Tier1
        // wB - Tier2
        // wC - Tier3
        // wAA - Tier1 boss weaponid
        // wBB - Tier2 boss weaponid
        // wCC - Tier3 boss weaponid
        // D - FINAL BOSS LOOT!!!!!
        public weaponvalues wA001()
        {
            weaponvalues bronze_sword = new weaponvalues();
            bronze_sword.wepName = "Bronze Sword";
            bronze_sword.wepDesc = "A razor-sharp sword.";
            bronze_sword.wepMinDMG = "5";
            bronze_sword.wepMaxDMG = "15";
            return (bronze_sword);
        }

    }
}
