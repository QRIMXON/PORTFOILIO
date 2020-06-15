using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        private List<Password> myPasswords = new List<Password>();
        public Form1()
        {
            myPasswords.Add(new Password("123456", "e10adc3949ba59abbe56e057f20f883e"));
            myPasswords.Add(new Password("123456789", "25f9e794323b453885f5181f1b624d0b"));
            myPasswords.Add(new Password("qwerty", "d8578edf8458ce06fbc5bb76a58c5ca4"));
            myPasswords.Add(new Password("111111", "96e79218965eb72c92a549dd5a330112"));
            myPasswords.Add(new Password("password", "5f4dcc3b5aa765d61d8327deb882cf99"));
            myPasswords.Add(new Password("qwertyuiop", "6eea9b7ef19179a06954edd0f6c05ceb"));
            myPasswords.Add(new Password("123321", "c8837b23ff8aaa8a2dde915473ce0991"));
            myPasswords.Add(new Password("google", "c822c1b63853ed273b89687ac505f9fa"));
            myPasswords.Add(new Password("P@ssw0rd", "161ebd7d45089b3446ee4e0d86dbcf92"));
            myPasswords.Add(new Password("Tr0ub4dor&3", "4ece57a61323b52ccffdbef021956754"));

            InitializeComponent();
        }

        private void btnCrack_Click(object sender, EventArgs e)
        {
            CrackPassword(txtHash.Text);
        }

        private void CrackPassword(string hash)
        {


            string inputHash = txtHash.Text;

            bool found = false;
            int position = -1;


            for (int i = 0; i < myPasswords.Count; i++)
            {
                if (myPasswords[i].Hash == inputHash)
                {

                    found = true;
                    position = i;
                    lblPassword.Text = myPasswords[position].Raw;
                }
                
            }

            if (found == false)
            {

                lblPassword.Text = "FAIL";
            }
        }
    }
}

