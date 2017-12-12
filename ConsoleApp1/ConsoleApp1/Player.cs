using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player
    {
        public string CurrentHP { get; set; }
        public string MaxHP { get; set; }
        public string XP { get; set; }
        public string Lvl { get; set; }
    }
    public class playervalues : Monsters
    {
        private Player _player;

        public bool Game()
        {
            _player = new Player
            {
                CurrentHP = "100",
                MaxHP = "100",
                XP = "0",
                Lvl = "1"
            };
            return true;
        }
    }
}
