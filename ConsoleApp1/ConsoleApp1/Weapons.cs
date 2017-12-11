using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Weapons : Items
    {
        public int wepID { get; set; }
        public string wepName { get; set; }
        public int wepMinDMG { get; set; }
        public int wepMaxDMG { get; set; }
        public int wepTier { get; set; }
    }
}
