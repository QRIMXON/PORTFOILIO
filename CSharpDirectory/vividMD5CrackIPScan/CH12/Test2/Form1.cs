using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Test2
{
    public partial class Form1 : Form
    {
        private List<Computer> myComputers = new List<Computer>();


        public Form1()

        {
            myComputers.Add(new Computer("My-Desktop", "127.0.0.1", "20, 21, 23, 25, 53, 80, 123, 389, 443"));
            myComputers.Add(new Computer("google-public-dns-a", "8.8.8.8", "53"));
            myComputers.Add(new Computer("ranken.edu", "47.44.246.80", "25, 80, 443"));


            // decimal deposit = Convert.ToInt32(txtDeposit.Text);


            InitializeComponent();
        }
       
        private void btnScan_Click(object sender, EventArgs e)
        {
            int foundPosition = ScanIpAddress(txtAddress.Text.ToLower());
            ShowComputer(foundPosition);
        }
        
        private int ScanIpAddress(string inputAddress)
        {
            
            int index = -1;


            for (int i = 0; i < myComputers.Count; i++)
            {
                if (myComputers[i].IpAddress.Contains(inputAddress))
                {

                    index = i;
                }

            }


            return index;
        }

        private void ShowComputer(int index)
        {

            string inputAddress = txtAddress.Text;
            if (index < 0)
            {

                lblName.Text = "Request Timed Out";
                lblAddress.Text = inputAddress;
                lblServices.Text = "NONE";


            }
            else
            {
                lblName.Text = myComputers[index].Name;
                lblAddress.Text = myComputers[index].IpAddress;
                lblServices.Text = myComputers[index].Services;



            }
        }
    }
}

    
        
    
