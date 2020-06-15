using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = input1.Text.ToLower();
            string[,] info = { { "Markel", "Luiza", "Bryony", "Giraldo", "Lowri" } ,
                     {"Diggory",  "Gunnar", "Hester", "Addy", "Hari"} ,
                     { "555-8390", "555-4618", "555-3103", "555-5815", "555-6660"} };

            
            bool validEntry = false;


            for (int i = 0; i < info.GetLength(1); i++)
            {
                if (info[0, i].ToLower().Contains(userInput) || info[1, i].ToLower().Contains(userInput))

                {
                    validEntry = true;
                    output1.Text = String.Format($"{info[0, i]}");
                    output2.Text = String.Format($"{info[1, i]}");
                    output3.Text = String.Format($"{info[2, i]}");
                    outputVoid.Text = String.Format($"");
                    
                }
                else if (validEntry == false)
                {
                    output1.Text = String.Format($"invalid");
                    output2.Text = String.Format($"invalid");
                    output3.Text = String.Format($"invalid");

                    outputVoid.Text = String.Format($"invalid");
                }
            }
        }
    }
}
