using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        private List<Job> myJobs = new List<Job>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int foundPosition = -1;


            bool exists = false;

            //code below searches Jobs list by description to see if an instance has already been created.
            for (int i = 0; i < myJobs.Count; i++)
            {
                if (myJobs[i].Description.ToLower().Contains(txtDescription.Text.ToLower()))
                {
                    exists = true;
                    foundPosition = i;
                    myJobs[foundPosition].HoursToComplete = Int32.Parse(txtHours.Text);
                    myJobs[foundPosition].HourlyFee = Int32.Parse(txtRate.Text);
                }
               


            }

              
            if(exists == false)
            {
                 
                 myJobs.Add(new Job(txtDescription.Text, Int32.Parse(txtHours.Text), Int32.Parse(txtRate.Text)));

                //code below sets a new found position so it can display the most recently added Job.
                foundPosition = myJobs.Count - 1;
            }


                lblDescription.Text = myJobs[foundPosition].Description.ToString();
                lblComplete.Text = myJobs[foundPosition].HoursToComplete.ToString();
                lblRate.Text = myJobs[foundPosition].HourlyFee.ToString();
                lblTotal.Text = myJobs[foundPosition].TotalFee.ToString();

            }


           
        }
    }

