using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3._0
{
    public partial class Form1 : Form
    {
        private List<Champion> myChampions = new List<Champion>();
      

        public Form1()
        {
            myChampions.Add(new Champion("Rockus", ChampionType.FRONT_LINE, new Ability("Mini Gun"), new Ability("Missile Launcher"),
            new Ability("Emitter"), new Ability("Advance"), new Ability("Hexa Fire")));
        
            myChampions.Add(new Champion("Makoa", ChampionType.FRONT_LINE, new Ability ("Cannon"), new Ability ("Dredge Anchor"),
            new Ability ("Shell Shield"), new Ability ("Shell Spin"), new Ability ("Ancient Rage")));

            myChampions.Add(new Champion("Drogoz", ChampionType.DAMAGE, new Ability ("Rocket Launcher"), new Ability("Fire Spit"),
            new Ability ("Salvo"),new Ability ("Thrust"), new Ability ("Dragon Punch")));

            myChampions.Add(new Champion("Tyra", ChampionType.DAMAGE, new Ability("Auto-Launcher"), new Ability ("Nade Launcher"),
            new Ability ("Fire Bomb"), new Ability ("Hunter's Mark"), new Ability ("Crossfire")));

            myChampions.Add(new Champion("Grover", ChampionType.SUPPORT, new Ability ("Throwing Axe"), new Ability("Crippling Throw"),
            new Ability ("Blossom"), new Ability ("Vine"), new Ability("Whirlwind")));

            myChampions.Add(new Champion("Evie", ChampionType.FLANK, new Ability("Ice Staff"), new Ability("Ice Block"),
            new Ability("Blink"), new Ability ("Soar"), new Ability ("Ice Storm")));



            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool found = false;

            for (int i = 0; i < myChampions.Count; i++)
            {
               
                string champSearch = txtChampion.Text.ToLower();


                if (myChampions[i].Name.ToLower().Contains(champSearch))
                {
                    found = true;

                    lblName.Text = myChampions[i].Name.ToString();
                    lblType.Text = myChampions[i].Type.ToString();
                    lblLeft.Text = myChampions[i].LeftMouse.Name;
                    lblRight.Text = myChampions[i].RightMouse.Name;
                    lblQ.Text = myChampions[i].Q.Name;
                    lblF.Text = myChampions[i].F.Name;
                    lblE.Text = myChampions[i].E.Name;
                }

                if (found == false)
                {
                    lblName.Text = $"Champion not found";
                    lblType.Text = "";
                    lblLeft.Text = "";
                    lblRight.Text = "";
                    lblQ.Text = "";
                    lblF.Text = "";
                    lblE.Text = "";
                }

            }
        }
      
    }
    }

