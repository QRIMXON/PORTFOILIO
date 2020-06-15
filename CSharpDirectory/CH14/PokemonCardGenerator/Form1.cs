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
        private List<NormalCard> normalCards = new List<NormalCard>();
        private List<ShinyCard> shinyCards = new List<ShinyCard>();
        private List<ICard> chosenCards = new List<ICard>();
        Random rnd = new Random();


        public Form1()
        {

            //normal cards
            normalCards.Add(new NormalCard("Charizard", Properties.Resources.charizard, 1));
            normalCards.Add(new NormalCard("Decidueye", Properties.Resources.decidueye, 2));
            normalCards.Add(new NormalCard("Dragonair", Properties.Resources.dragonair, 3));
            normalCards.Add(new NormalCard("Dratini", Properties.Resources.dratini, 4));
            normalCards.Add(new NormalCard("Gardevoir", Properties.Resources.gardevoir, 5));
            normalCards.Add(new NormalCard("Kommo-o", Properties.Resources.kommo_o, 6));
            normalCards.Add(new NormalCard("Mawile", Properties.Resources.mawile, 7));
            normalCards.Add(new NormalCard("Pikachu", Properties.Resources.pikachu_f, 8));
            normalCards.Add(new NormalCard("Rockruff", Properties.Resources.rockruff, 9));
            normalCards.Add(new NormalCard("Serperior", Properties.Resources.serperior, 10));
            normalCards.Add(new NormalCard("Zorua", Properties.Resources.zorua, 11));

            //shiny cards
            shinyCards.Add(new ShinyCard("Charizard", Properties.Resources.charizard_shiny, 12, new Font("Cambria", 10), Color.Purple, Color.Red));
            shinyCards.Add(new ShinyCard("Decidueye", Properties.Resources.decidueye_shiny, 13, new Font("Cambria", 10), Color.Purple, Color.Red));
            shinyCards.Add(new ShinyCard("Dragonair", Properties.Resources.dragonair_shiny, 14, new Font("Cambria", 10), Color.Purple, Color.Red));
            shinyCards.Add(new ShinyCard("Dratini", Properties.Resources.dratini_shiny, 15, new Font("Cambria", 10), Color.Purple, Color.Red));
            shinyCards.Add(new ShinyCard("Gardevoir", Properties.Resources.gardevoir_shiny, 16, new Font("Cambria", 10), Color.Purple, Color.Red));
            shinyCards.Add(new ShinyCard("Kommo-o", Properties.Resources.kommo_o_shiny, 17, new Font("Cambria", 10), Color.Purple, Color.Red));
            shinyCards.Add(new ShinyCard("Mawile", Properties.Resources.mawile_shiny, 18, new Font("Cambria", 10), Color.Purple, Color.Red));
            shinyCards.Add(new ShinyCard("Pikachu", Properties.Resources.pikachu_f_shiny, 19, new Font("Cambria", 10), Color.Purple, Color.Red));
            shinyCards.Add(new ShinyCard("Rockruff", Properties.Resources.rockruff_shiny, 20, new Font("Cambria", 10), Color.Purple, Color.Red));
            shinyCards.Add(new ShinyCard("Serperior", Properties.Resources.serperior_shiny, 21, new Font("Cambria", 10), Color.Purple, Color.Red));
            shinyCards.Add(new ShinyCard("Zorua", Properties.Resources.zorua_shiny, 22, new Font("Cambria", 10), Color.Purple, Color.Red));



            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {

            int randNormalCard;
            int randShinyCard;



            ICard[] cardPack = new ICard[10];

            for (int i = 0; i < 10; i++)
            {
               randNormalCard = rnd.Next(0, 11);
                randShinyCard = rnd.Next(0, 5);

                if (randShinyCard == 1)
                {
                    
                    cardPack[i] = shinyCards[randNormalCard];
                }

                else
                {

                    cardPack[i] = normalCards[randNormalCard];

                }


            }

            Array.Sort(cardPack);
            Array.Reverse(cardPack);

            cardPack[0].ShowCard(picBox1, lbl1);
            cardPack[1].ShowCard(picBox2, lbl2);
            cardPack[2].ShowCard(picBox3, lbl3);
            cardPack[3].ShowCard(picBox4, lbl4);
        }
    }
}



