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
        private List<WebSubscription> myWebSubs = new List<WebSubscription>();
        private List<ProSubscription> myProSubs = new List<ProSubscription>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) && txtPackage.Text.ToLower() == "basic")
            {
                
                {
                    myWebSubs.Add(new WebSubscription(txtUser.Text, txtPackage.Text));

                    lblPrice.Text = myWebSubs[myWebSubs.Count - 1].ToString();
                }
            }
            else if (txtPassword.Text != "" && txtPackage.Text.ToLower() == "pro")
            {
                myProSubs.Add(new ProSubscription(txtUser.Text, txtPackage.Text, txtPassword.Text));

                lblProPrice.Text = myProSubs[myProSubs.Count - 1].ToString();
               

            }
            
            
             

        }
    }
}
    

