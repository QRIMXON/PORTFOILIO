using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private List<Conference> myConferences = new List<Conference>(20);


        public Form1()
        {
            InitializeComponent();


        }
        int roomCount = 0;//not used
        int attendCount = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int position1 = -1;//not used
            int position2 = -1;//not used
           
            {
                if (myConferences.Count <= 20)
                {
                    myConferences.Add(new Conference(txtGroup.Text, txtStart.Text, Convert.ToInt32(txtAttend.Text), txtRoom.Text)); ;

                    attendCount += Convert.ToInt32(txtAttend.Text);

                    lblRoomCount.Text = $"{myConferences.Count.ToString()} /20";
                    lblAttendCount.Text = $"${attendCount}";

                }
                if (myConferences.Count >= 21)
                {
                    MessageBox.Show("No More Room");
                }
              

            }
            txtGroup.Text = "";
            txtAttend.Text = "";
            txtRoom.Text = "";
            txtStart.Text = "";
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int position3 = -1;
           


            DateTime begin = DateTime.Parse(txtBegin.Text);
            DateTime end = DateTime.Parse(txtEnd.Text);
           


            for (int i = 0; i < myConferences.Count; i++)
            {



                if (DateTime.Parse(myConferences[i].StartDate) >= begin && DateTime.Parse(myConferences[i].StartDate) <= end)
                    position3 = i;

                lblOutput.Text += $"{myConferences[position3].Display()}";


               




            txtBegin.Text = "";
                txtEnd.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            lblNameOutput.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {


            int position4 = -1;
            string nameSearch = txtNameSearch.Text;



            for (int i = 0; i < myConferences.Count; i++)
            {



                if ((myConferences[i].GroupName) == txtNameSearch.Text)
                    position4 = i;

                lblNameOutput.Text += $"{myConferences[position4].Display()}";
            }
            txtNameSearch.Text = "";
        }

        //if (begin <= start && start <= End) Room R1 = (Room)ConvertToInt32(TxtRoom.Text)

    }
}



