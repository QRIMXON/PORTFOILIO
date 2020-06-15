using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private List<Champion> myChampions = new List<Champion>();
        Ability[] abilityList = { new Ability("Mini Gun"), new Ability("Missile Launcher"), new Ability("Emitter"),
        new Ability("Advance"),new Ability("Hexa Fire") };
    };
        public Form1()
        {
            myChampions.Add(new Champion("Rockus", ChampionType.Front_Line, abilityList[0] , "Missile Launcher", "Emitter", "Advance",
                "Hexa Fire"));
            myChampions.Add(new Champion("Makoa", "Front Line", "Cannon",
                "Dredge Anchor", "Shell Shield", "Shell Spin", "Ancient Rage"));
            myChampions.Add(new Champion("Drogoz", "Damage", "Rocket Launcher",
                "Fire Spit", "Salvo", "Thrust", "Dragon Punch"));
            myChampions.Add(new Champion("Tyra", "Damage", "Auto-Launcher",
                "Nade Launcher", "Fire Bomb", "Hunter's Mark", "Crossfire"));
            myChampions.Add(new Champion("Grover", "Support", "Throwing Axe",
                "Crippling Throw", "Blossom", "Vine", "Whirlwind"));
            myChampions.Add(new Champion("Evie", "Flank", "Ice Staff", "Ice Block",
                "Blink", "Soar", "Ice Storm"));

            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int index = -1;
            for (int i = 0; i < myChampions.Count; i++)
            {
                if(
                    )
            }
        }
        enum ChampionType
        {
            Front_Line = 0;

        }
    }
}
