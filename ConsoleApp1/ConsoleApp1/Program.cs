using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Engine;

namespace ConsoleApp1
{
    public DungeonCrawler()
    {
        InitializeComponent();

        _player = new Player();

        _player.CurrentHitPoints = 10;
        _player.Gold = 20;
        _player.ExperiencePoints = 0;
        _player.Level = 1;

        lblHitPoints.Text = _player.CurrentHitPoints.ToString();
        lblGold.Text = _player.Gold.ToString();
        lblExperience.Text = _player.ExperiencePoints.ToString();
        lblLevel.Text = _player.Level.ToString();

        // Update Hit Points in UI
        lblHitPoints.Text = _player.CurrentHitPoints.ToString();
    }
}
