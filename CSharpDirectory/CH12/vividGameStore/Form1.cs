using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        private List<Game> myGames = new List<Game>();
      



        public Form1()
        {

            myGames.Add(new Game("Player Unknown's Battlegrounds (PUBG)", "Bluehole", 35));
            myGames.Add(new Game("Leauge of Legends", "Riot Games", 0));
            myGames.Add(new Game("Call of Duty: Black Ops III", "Activision", 60));
            myGames.Add(new Game("Battlefield 4", "Electronic Arts(EA)", 20));
            myGames.Add(new Game("Super Mario Odyssey", "Nintendo", 60));

            InitializeComponent();
        }



        private void btnGame_Click(object sender, EventArgs e)
        {
           int foundPosition = SearchForGames(txtGame.Text.ToLower());
            ShowGameInfo(foundPosition);
        }

        private int SearchForGames(string userSearch)
        {
            int index = -1;
           

            for (int i = 0; i < myGames.Count; i++)
            {
                if (myGames[i].GetName().ToLower().Contains(userSearch) || myGames[i].GetPublisher().ToLower().Contains(userSearch))
                {
                  
                    index = i;
                }

            }

         
            return index;
        }

        private void ShowGameInfo(int index)
        {

            if (index < 0)
            {
                lblName.Text = String.Format($"Item not found.");
                lblPublish.Text = String.Format($"Item not found.");
                lblPrice.Text = String.Format($"Item not found.");
                

            }
            else
            {
                lblName.Text = myGames[index].GetName();
                lblPublish.Text = myGames[index].GetPublisher();
                lblPrice.Text = myGames[index].GetPrice().ToString("C");
                

            }
        }
    }
}

    