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
        public string wepAtkSpd { get; set; }
    }
    public class HPvalues
    {
        public string potName { get; set; }
        public string healingAmount { get; set; }
    }

    public class hppotions
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


    public class Weapons
    {
        public static Func<weaponvalues> new_weapon { get; internal set; }

        //wepAtkSpd - daggers = 7-10
        //            swords = 4-6
        //            battleaxe = 1-3

        // wA - Tier1
        // wB - Tier2
        // wC - Tier3
        // wAA - Tier1 boss weaponid
        // wBB - Tier2 boss weaponid
        // wCC - Tier3 boss weaponid
        // wD - FINAL BOSS LOOT!!!!!
        // wG - test

        //Tier1 weaponid algavad:
        public weaponvalues wA001()
        {
            weaponvalues bronze_dagger = new weaponvalues
            {
                wepName = "Bronze Dagger",
                wepDesc = "Short but pointy.",
                wepMinDMG = "5",
                wepMaxDMG = "15",
                wepAtkSpd = "7"
            };
            return (bronze_dagger);
        }
        public weaponvalues wA002()
        {
            weaponvalues iron_dagger = new weaponvalues
            {
                wepName = "Iron Dagger",
                wepDesc = "Short but pointy.",
                wepMinDMG = "10",
                wepMaxDMG = "25",
                wepAtkSpd = "8"
            };
            return (iron_dagger);
        }
        public weaponvalues wA003()
        {
            weaponvalues steel_dagger = new weaponvalues
            {
                wepName = "Steel Dagger",
                wepDesc = "Short but pointy.",
                wepMinDMG = "7",
                wepMaxDMG = "29",
                wepAtkSpd = "9"
            };
            return (steel_dagger);
        }
        public weaponvalues wA004()
        {
            weaponvalues bronze_sword = new weaponvalues
            {
                wepName = "Bronze Sword",
                wepDesc = "A razor-sharp sword.",
                wepMinDMG = "10",
                wepMaxDMG = "30",
                wepAtkSpd = "4"
            };
            return (bronze_sword);
        }
        public weaponvalues wA005()
        {
            weaponvalues iron_sword = new weaponvalues
            {
                wepName = "Iron Sword",
                wepDesc = "A razor-sharp sword.",
                wepMinDMG = "15",
                wepMaxDMG = "35",
                wepAtkSpd = "5"
            };
            return (iron_sword);
        }
        public weaponvalues wA006()
        {
            weaponvalues steel_sword = new weaponvalues
            {
                wepName = "Steel Sword",
                wepDesc = "A razor-sharp sword.",
                wepMinDMG = "20",
                wepMaxDMG = "40",
                wepAtkSpd = "6"
            };
            return (steel_sword);
        }
        public weaponvalues wA007()
        {
            weaponvalues bronze_battleaxe = new weaponvalues
            {
                wepName = "Bronze battleaxe",
                wepDesc = "A vicious looking axe",
                wepMinDMG = "20",
                wepMaxDMG = "40",
                wepAtkSpd = "1"
            };
            return (bronze_battleaxe);
        }
        public weaponvalues wA008()
        {
            weaponvalues iron_battleaxe = new weaponvalues
            {
                wepName = "Iron battleaxe",
                wepDesc = "A vicious looking axe",
                wepMinDMG = "25",
                wepMaxDMG = "45",
                wepAtkSpd = "2"
            };
            return (iron_battleaxe);
        }
        public weaponvalues wA009()
        {
            weaponvalues steel_battleaxe = new weaponvalues
            {
                wepName = "Steel battleaxe",
                wepDesc = "A vicious looking axe",
                wepMinDMG = "30",
                wepMaxDMG = "50",
                wepAtkSpd = "3"
            };
            return (steel_battleaxe);
        }

        public weaponvalues wAA01()
        {
            weaponvalues white_halberd = new weaponvalues
            {
                wepName = "White Halberd",
                wepDesc = "A white halberd.",
                wepMinDMG = "30",
                wepMaxDMG = "80",
                wepAtkSpd = "5"
            };
            return (white_halberd);
        }
        public weaponvalues wAA02()
        {
            weaponvalues black_halberd = new weaponvalues
            {
                wepName = "Black halberd",
                wepDesc = "A black halberd",
                wepMinDMG = "30",
                wepMaxDMG = "80",
                wepAtkSpd = "5"
            };
            return (black_halberd);
        }
        //Tier1 weaponid lõppevad

        //Tier2 weaponid algavad
        public weaponvalues wB001()
        {
            weaponvalues black_dagger = new weaponvalues
            {
                wepName = "Black Dagger",
                wepDesc = "Short but pointy.",
                wepMinDMG = "35",
                wepMaxDMG = "55",
                wepAtkSpd = "8"
            };
            return (black_dagger);
        }
        public weaponvalues wB002()
        {
            weaponvalues mithril_dagger = new weaponvalues
            {
                wepName = "Mithril Dagger",
                wepDesc = "Short but pointy.",
                wepMinDMG = "45",
                wepMaxDMG = "65",
                wepAtkSpd = "9"
            };
            return (mithril_dagger);
        }
        public weaponvalues wB003()
        {
            weaponvalues adamant_dagger = new weaponvalues
            {
                wepName = "Adamant dagger",
                wepDesc = "Short but pointy.",
                wepMinDMG = "55",
                wepMaxDMG = "85",
                wepAtkSpd = "10"
            };
            return (adamant_dagger);
        }
        public weaponvalues wB004()
        {
            weaponvalues black_sword = new weaponvalues
            {
                wepName = "Black Sword",
                wepDesc = "A razor-sharp sword.",
                wepMinDMG = "55",
                wepMaxDMG = "85",
                wepAtkSpd = "5",
            };
            return (black_sword);
        }
        public weaponvalues wB005()
        {
            weaponvalues mithril_sword = new weaponvalues
            {
                wepName = "Mihtril Sword",
                wepDesc = "A razor-sharp sword.",
                wepMinDMG = "60",
                wepMaxDMG = "90",
                wepAtkSpd = "6"
            };
            return (mithril_sword);
        }
        public weaponvalues wB006()
        {
            weaponvalues adamant_sword = new weaponvalues
            {
                wepName = "Adamantium Sword",
                wepDesc = "A razor-sharp sword.",
                wepMinDMG = "65",
                wepMaxDMG = "100",
                wepAtkSpd = "7"
            };
            return (adamant_sword);
        }
        public weaponvalues wB007()
        {
            weaponvalues black_battleaxe = new weaponvalues
            {
                wepName = "Black battleaxe",
                wepDesc = "A vicious looking axe",
                wepMinDMG = "65",
                wepMaxDMG = "100",
                wepAtkSpd = "1"
            };
            return (black_battleaxe);
        }
        public weaponvalues wB008()
        {
            weaponvalues mithril_battleaxe = new weaponvalues
            {
                wepName = "Mithril battleaxe",
                wepDesc = "A vicious looking axe",
                wepMinDMG = "70",
                wepMaxDMG = "100",
                wepAtkSpd = "2"
            };
            return (mithril_battleaxe);
        }
        public weaponvalues wB009()
        {
            weaponvalues adamant_battleaxe = new weaponvalues
            {
                wepName = "Adamantium battleaxe",
                wepDesc = "A vicious looking axe",
                wepMinDMG = "75",
                wepMaxDMG = "105",
                wepAtkSpd = "3"
            };
            return (adamant_battleaxe);
        }

        public weaponvalues wBB01()
        {
            weaponvalues dwarven_army_axe = new weaponvalues
            {
                wepName = "Dwarven Army Axe",
                wepDesc = "A highly useful modular tool.",
                wepMinDMG = "105",
                wepMaxDMG = "170",
                wepAtkSpd = "5"
            };
            return (dwarven_army_axe);
        }
        public weaponvalues wBB02()
        {
            weaponvalues blessed_hatchet = new weaponvalues
            {
                wepName = "Blessed hatchet",
                wepDesc = "It radiates purity but can still lop off heads",
                wepMinDMG = "99",
                wepMaxDMG = "150",
                wepAtkSpd = "9"
            };
            return (blessed_hatchet);
        }
        //Tier2 weaponid lõppevad

        //Tier3 weaponid algavad
        public weaponvalues wC001()
        {
            weaponvalues rune_dagger = new weaponvalues
            {
                wepName = "Rune Dagger",
                wepDesc = "Short but pointy.",
                wepMinDMG = "100",
                wepMaxDMG = "145",
                wepAtkSpd = "8"
            };
            return (rune_dagger);
        }
        public weaponvalues wC002()
        {
            weaponvalues dragon_dagger = new weaponvalues
            {
                wepName = "Dragon Dagger",
                wepDesc = "Short but pointy.",
                wepMinDMG = "130",
                wepMaxDMG = "200",
                wepAtkSpd = "9"
            };
            return (dragon_dagger);
        }
        public weaponvalues wC003()
        {
            weaponvalues crystal_dagger = new weaponvalues
            {
                wepName = "Crystal Dagger",
                wepDesc = "A dagger fashioned from crystal.",
                wepMinDMG = "160",
                wepMaxDMG = "240",
                wepAtkSpd = "10"
            };
            return (crystal_dagger);
        }
        public weaponvalues wC004()
        {
            weaponvalues rune_sword = new weaponvalues
            {
                wepName = "Rune Sword",
                wepDesc = "A razor-sharp sword.",
                wepMinDMG = "150",
                wepMaxDMG = "225",
                wepAtkSpd = "5"
            };
            return (rune_sword);
        }
        public weaponvalues wC005()
        {
            weaponvalues leaf_bladed_sword = new weaponvalues
            {
                wepName = "Leaf-bladed Sword",
                wepDesc = "A razor-sharp sword.",
                wepMinDMG = "175",
                wepMaxDMG = "260",
                wepAtkSpd = "6"
            };
            return (leaf_bladed_sword);
        }
        public weaponvalues wC006()
        {
            weaponvalues toktz_xil_ak = new weaponvalues
            {
                wepName = "Toktz-xil-ak",
                wepDesc = "A razor-sharp sword of obsidian.",
                wepMinDMG = "225",
                wepMaxDMG = "300",
                wepAtkSpd = "7"
            };
            return (toktz_xil_ak);
        }
        public weaponvalues wC007()
        {
            weaponvalues rune_battleaxe = new weaponvalues
            {
                wepName = "Rune battleaxe",
                wepDesc = "A vicious looking axe",
                wepMinDMG = "180",
                wepMaxDMG = "240",
                wepAtkSpd = "1"
            };
            return (rune_battleaxe);
        }
        public weaponvalues wC008()
        {
            weaponvalues dragon_battleaxe = new weaponvalues
            {
                wepName = "Dragon battleaxe",
                wepDesc = "A vicious looking axe",
                wepMinDMG = "210",
                wepMaxDMG = "280",
                wepAtkSpd = "2"
            };
            return (dragon_battleaxe);
        }
        public weaponvalues wC009()
        {
            weaponvalues primal_battleaxe = new weaponvalues
            {
                wepName = "Primal battleaxe",
                wepDesc = "A vicious looking axe",
                wepMinDMG = "250",
                wepMaxDMG = "330",
                wepAtkSpd = "3"
            };
            return (primal_battleaxe);
        }

        public weaponvalues wCC01()
        {
            weaponvalues chaotic_rapier = new weaponvalues
            {
                wepName = "Chaotic rapier",
                wepDesc = "A razor-sharp rapier.",
                wepMinDMG = "300",
                wepMaxDMG = "500",
                wepAtkSpd = "10"
            };
            return (chaotic_rapier);
        }
        public weaponvalues wCC02()
        {
            weaponvalues tetsu_wakizashi = new weaponvalues
            {
                wepName = "Tetsi wakizashi",
                wepDesc = "A razor-sharp sword designed by the Gu masters of Wushanko.",
                wepMinDMG = "350",
                wepMaxDMG = "550",
                wepAtkSpd = "6"
            };
            return (tetsu_wakizashi);
        }
        public weaponvalues wCC03()
        {
            weaponvalues flameburst_defender = new weaponvalues
            {
                wepName = "Flameburst Defender",
                wepDesc = "A fiery weapon.",
                wepMinDMG = "450",
                wepMaxDMG = "700",
                wepAtkSpd = "3"
            };
            return (flameburst_defender);
        }
        public weaponvalues wCC04()
        {
            weaponvalues ko_cannon = new weaponvalues
            {
                wepName = "Knockout cannon",
                wepDesc = "Better watchout!",
                wepMinDMG = "500",
                wepMaxDMG = "1000",
                wepAtkSpd = "1"
            };
            return (ko_cannon);
        }
        //Tier3 asjad lõppevad

        //Final boss loot
       public weaponvalues wD001()
        {
            weaponvalues you_win = new weaponvalues
            {
                wepName = "You win!",
                wepDesc = "You have won the game, here's a reward!",
                wepMinDMG = "1337",
                wepMaxDMG = "9001",
                wepAtkSpd = "10"
            };
            return (you_win);
        }
        //Final boss loot lõppeb

        //test
        public weaponvalues wG001()
        {
            weaponvalues test = new weaponvalues
            {
                wepName = "test",
                wepDesc = "test",
                wepMinDMG = "100",
                wepMaxDMG = "200",
                wepAtkSpd = "5",
            };
            return (test);
        }
        
    }
}
