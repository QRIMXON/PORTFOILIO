using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        private List<Room> myRooms = new List<Room>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //myRooms.Add(new Room(txtRoom.Text, Int32.Parse(txtWidth.Text), Int32.Parse(txtLength.Text)));
            lblDisplay2.Text = "";
            if (myRooms.Count != 20)
            {
                myRooms.Add(new Room(txtRoom.Text, Int32.Parse(txtWidth.Text), Int32.Parse(txtLength.Text)));
                
                
                txtRoom.Text = "";
                txtWidth.Text = "";
                txtLength.Text = "";

                
            }
            else
            {
                MessageBox.Show("No More Room");
            }

            int totalBoxes = 0;
            
            for (int i = 0; i < myRooms.Count; i++)
            {
                //take totals out of loop as to not reset them
               
               // lblRoomTotal.Text = myRooms.Count.ToString();
               // lblBoxesTotal.Text = myRooms[i].Boxes.ToString();
                lblDisplay2.Text += $"{myRooms[i].Display()}";
             //appending
                totalBoxes += myRooms[i].Boxes;

                //append to label +=
            }
            lblRoomTotal.Text = myRooms.Count + "/20";
            lblBoxesTotal.Text = totalBoxes.ToString();
        }
    }
}
