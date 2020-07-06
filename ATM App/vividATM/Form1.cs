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
        private List<Account> myAccounts = new List<Account>();
        int position = -1;

        public Form1()

        { 
            myAccounts.Add(new Account("12345", "1111", "Mr. Orange", 100.00m));
            myAccounts.Add(new Account("22345", "2222", "Mr. White", 200.00m));
            myAccounts.Add(new Account("32345", "3333", "Mr. Pink", 300.00m));
            myAccounts.Add(new Account("42345", "4444", "Mr. Black", 400.00m));
            myAccounts.Add(new Account("52345", "5555", "Mr. Blue", 500.00m));
           // decimal deposit = Convert.ToInt32(txtDeposit.Text);
           // decimal withdraw = Convert.ToInt32(txtWithdraw.Text);

        
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            Login(txtAccount.Text, txtPin.Text);

        }

      

        private void button1_Click(object sender, EventArgs e)
        {

            MakeDeposit(Convert.ToDecimal(txtDeposit.Text));        

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MakeWithdraw(Convert.ToDecimal(txtWithdraw.Text));

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Logout(); 
        }
        private void Login(string accountNumber, string pin)
        {
            lblDeposit.Visible = false;
            btnDeposit.Visible = false;
            txtDeposit.Visible = false;
            lblWithdraw.Visible = false;
            btnWithdraw.Visible = false;
            txtWithdraw.Visible = false;


            string inputAccount = txtAccount.Text;
            string inputPin = txtPin.Text;
            bool found = false;


            for (int i = 0; i < myAccounts.Count; i++)
            {
                if (myAccounts[i].GetAccountNumber() == inputAccount && myAccounts[i].GetPin() == inputPin)
                {
                    lblWelcome.Text = "Welcome " + myAccounts[i].GetName();
                    lblBalance.Text = "Your Balance is " + myAccounts[i].GetBalance().ToString("C");
                    found = true;
                    lblDeposit.Visible = true;
                    btnDeposit.Visible = true;
                    txtDeposit.Visible = true;
                    lblWithdraw.Visible = true;
                    btnWithdraw.Visible = true;
                    txtWithdraw.Visible = true;
                    position = i;
                }
            }

            if (found == false)
            {
                Logout();
                lblWelcome.Text = "Error";
            }

        }
        private void Logout()
        {
            lblWelcome.Text = "Logged Out";
            lblBalance.Text = "...";
            txtAccount.Text = "";
            txtPin.Text = "";
            lblDeposit.Visible = false;
            btnDeposit.Visible = false;
            txtDeposit.Visible = false;
            lblWithdraw.Visible = false;
            btnWithdraw.Visible = false;
            txtWithdraw.Visible = false;
        }

        private void MakeDeposit(decimal deposit)
        {
            myAccounts[position].MakeDeposit(deposit);
            lblBalance.Text = "Your Balance is " + myAccounts[position].GetBalance().ToString("C");
            txtDeposit.Text = "";
            txtWithdraw.Text = "";
        }

        private void MakeWithdraw(decimal withdraw)
        {
            myAccounts[position].MakeWithdraw(withdraw);
            lblBalance.Text = "Your Balance is " + myAccounts[position].GetBalance().ToString("C");
            txtWithdraw.Text = "";
            txtDeposit.Text = "";
        }
      
        //accidental click, ignore Form1_Load*************************************************//
        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
    }
}
