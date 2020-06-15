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
        double allOrdersTotal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            
                lblMixError.Text = "";
                lblNameError.Text = "";
                lblToppingError.Text = "";

                bool hasSprinkles = false, hasNuts = false, hasSyrup = false, hasLime = false, hasPeach = false, hasMango = false;
                int numSundaeTopings = 0, numSodaFlavors = 0;

                if (chkSprinkles.Checked) { hasSprinkles = true; numSundaeTopings++; }
                if (chkNuts.Checked) { hasNuts = true; numSundaeTopings++; }
                if (chkChocolate.Checked) { hasSyrup = true; numSundaeTopings++; }

                if (chkLime.Checked) { hasLime = true; numSodaFlavors++; }
                if (chkPeach.Checked) { hasPeach = true; numSodaFlavors++; }
                if (chkMango.Checked) { hasMango = true; numSodaFlavors++; }

                bool validOrder = true;

                //Data Validation
                string orderName = txtName.Text;
                if (String.IsNullOrEmpty(orderName))
                {
                    lblNameError.Text = "Name Required";
                    validOrder = false;
                }
                if (chkSundae.Checked == false && chkSoda.Checked == false)
                {
                    lblNameError.Text += " No Food selected";
                    validOrder = false;
                }
                if (numSundaeTopings > 2)
                {
                    lblToppingError.Text = "Only 2 toppings allowed";
                    validOrder = false;
                }
                if (numSodaFlavors > 1)
                {
                    lblMixError.Text = "Only 1 mixing allowed";
                    validOrder = false;
                }

                if (validOrder)
                {
                    Order anOrder = new Order(txtName.Text, chkSundae.Checked, chkSoda.Checked);

                    //Data output
                    //Output Name
                    lblOutput.Text += anOrder.Name + "\n-----------------\n";

                    //Adding Topings and Output for Sundae
                    if (anOrder.Sundae != null)
                    {
                        //Add Toppings for Sundae
                        if (hasSprinkles) { anOrder.Sundae.AddTopping(SundaeTopping.SPRINKLES); }
                        if (hasNuts) { anOrder.Sundae.AddTopping(SundaeTopping.NUTS); }
                        if (hasSyrup) { anOrder.Sundae.AddTopping(SundaeTopping.CHOCOLATE); }

                        //Output for Sundae
                        lblOutput.Text += "Sundae - ";

                        if (anOrder.Sundae.ToppingCount == 0)
                        {
                            lblOutput.Text += anOrder.Sundae.GetTopping(0) + " ";
                        }

                        for (int i = 0; i < anOrder.Sundae.ToppingCount; i++)
                        {
                            lblOutput.Text += anOrder.Sundae.GetTopping(i) + " ";
                        }
                        lblOutput.Text += $"- ${anOrder.Sundae.Price}\n";
                    }

                    if (anOrder.Soda != null)
                    {
                        //Add Toppings for Soda
                        if (hasMango) { anOrder.Soda.AddFlavor(SodaFlavor.MANGO); }
                        if (hasPeach) { anOrder.Soda.AddFlavor(SodaFlavor.PEACH); }
                        if (hasLime) { anOrder.Soda.AddFlavor(SodaFlavor.LIME); }

                        //Output for Soda
                        lblOutput.Text += $"Soda - {anOrder.Soda.Flavor} - ${anOrder.Soda.Price}\n";
                    }

                    lblOutput.Text += "\n";

                    allOrdersTotal += anOrder.Price;
                    lblTotal.Text = $"Total: {allOrdersTotal.ToString("C")}";

                }

            }
        //mistake
        private void lblOutput_Click(object sender, EventArgs e)
        {

        }
    }
    }

