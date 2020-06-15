using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        private List<Letter> myLetters = new List<Letter>(20);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtTrackingNumber.Text)) 
            {
                if (myLetters.Count <= 20)
                {
                    myLetters.Add(new Letter(txtRecipient.Text, Convert.ToDateTime(txtSentDate.Text)));
                }
            }
            else
            {
                if (myLetters.Count <= 20)
                    myLetters.Add(new CertifiedLetter(txtRecipient.Text, Convert.ToDateTime(txtSentDate.Text), txtTrackingNumber.Text));

            }
            string currentLabel = lblOutput.Text;
            lblOutput.Text = myLetters[myLetters.Count - 1].ToString() + $"\n" + currentLabel ;

        }
    }
}
