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

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float width = Convert.ToInt32(txtWidth.Text);
            float height = Convert.ToInt32(txtHeight.Text);


            Photo myPhotos = null;
            MattedPhoto myMattedPhotos = null;
            FramedPhoto myFramedPhotos = null;


            if (rdoUnframed.Checked == true)
            {
                myPhotos = new Photo(width, height);

                lblType.Text = myPhotos.ToString();
                lblCost.Text = myPhotos.Price.ToString();

            }
            if (rdoMatted.Checked == true)
            {
                if (rdoBlack.Checked == true)
                {
                    myMattedPhotos = new MattedPhoto(width, height, Color.BLACK);
                }
                if (rdoBlue.Checked == true)
                {
                    myMattedPhotos = new MattedPhoto(width, height, Color.BLUE);
                }
                if (rdoRed.Checked == true)
                {
                    myMattedPhotos = new MattedPhoto(width, height, Color.RED);
                }
                if (rdoGreen.Checked == true)
                {
                    myMattedPhotos = new MattedPhoto(width, height, Color.GREEN);
                }
                if (rdoWhite.Checked == true)
                {
                    myMattedPhotos = new MattedPhoto(width, height, Color.WHITE);
                }
                lblType.Text = myMattedPhotos.ToString();
                lblCost.Text = myMattedPhotos.Price.ToString();

            }

            if (rdoFramed.Checked == true)
            {
                if (rdoPine.Checked == true)
                {
                    if (rdoSimple.Checked == true)
                    {
                        myFramedPhotos = new FramedPhoto(width, height, Material.PINE, Style.SIMPLE);
                    }
                    if (rdoModern.Checked == true)
                    {
                        myFramedPhotos = new FramedPhoto(width, height, Material.PINE, Style.MODERN);
                    }
                    if (rdoVintage.Checked == true)
                    {
                        myFramedPhotos = new FramedPhoto(width, height, Material.PINE, Style.VINTAGE);
                    }
                    if (rdoAntique.Checked == true)
                    {
                        myFramedPhotos = new FramedPhoto(width, height, Material.PINE, Style.ANTIQUE);
                    }
                    if (rdoEclectic.Checked == true)
                    {
                        myFramedPhotos = new FramedPhoto(width, height, Material.PINE, Style.ECLECTIC);
                    }
                    lblType.Text = myFramedPhotos.ToString();
                    lblCost.Text = myFramedPhotos.Price.ToString();
                }
                if (rdoOak.Checked == true)
                {
                    if (rdoSimple.Checked == true)
                    {
                        myFramedPhotos = new FramedPhoto(width, height, Material.OAK, Style.SIMPLE);
                    }
                    if (rdoModern.Checked == true)
                    {
                        myFramedPhotos = new FramedPhoto(width, height, Material.OAK, Style.MODERN);
                    }
                    if (rdoVintage.Checked == true)
                    {
                        myFramedPhotos = new FramedPhoto(width, height, Material.OAK, Style.VINTAGE);
                    }
                    if (rdoAntique.Checked == true)
                    {
                        myFramedPhotos = new FramedPhoto(width, height, Material.OAK, Style.ANTIQUE);
                    }
                    if (rdoEclectic.Checked == true)
                    {
                        myFramedPhotos = new FramedPhoto(width, height, Material.OAK, Style.ECLECTIC);
                    }
                    lblType.Text = myFramedPhotos.ToString();
                    lblCost.Text = myFramedPhotos.Price.ToString();
                }
                if (rdoSteel.Checked == true)
                {
                    if (rdoSimple.Checked == true)
                    {
                        myFramedPhotos = new FramedPhoto(width, height, Material.STEEL, Style.SIMPLE);
                    }
                    if (rdoModern.Checked == true)
                    {
                        myFramedPhotos = new FramedPhoto(width, height, Material.STEEL, Style.MODERN);
                    }
                    if (rdoVintage.Checked == true)
                    {
                        myFramedPhotos = new FramedPhoto(width, height, Material.STEEL, Style.VINTAGE);
                    }
                    if (rdoAntique.Checked == true)
                    {
                        myFramedPhotos = new FramedPhoto(width, height, Material.STEEL, Style.ANTIQUE);
                    }
                    if (rdoEclectic.Checked == true)
                    {
                        myFramedPhotos = new FramedPhoto(width, height, Material.STEEL, Style.ECLECTIC);
                    }
                    lblType.Text = myFramedPhotos.ToString();
                    lblCost.Text = myFramedPhotos.Price.ToString();
                }
                if (rdoSilver.Checked == true)
                {
                    if (rdoSimple.Checked == true)
                    {
                        myFramedPhotos = new FramedPhoto(width, height, Material.SILVER, Style.SIMPLE);
                    }
                    if (rdoModern.Checked == true)
                    {
                        myFramedPhotos = new FramedPhoto(width, height, Material.SILVER, Style.MODERN);
                    }
                    if (rdoVintage.Checked == true)
                    {
                        myFramedPhotos = new FramedPhoto(width, height, Material.SILVER, Style.VINTAGE);
                    }
                    if (rdoAntique.Checked == true)
                    {
                        myFramedPhotos = new FramedPhoto(width, height, Material.SILVER, Style.ANTIQUE);
                    }
                    if (rdoEclectic.Checked == true)
                    {
                        myFramedPhotos = new FramedPhoto(width, height, Material.SILVER, Style.ECLECTIC);
                    }
                    lblType.Text = myFramedPhotos.ToString();
                    lblCost.Text = myFramedPhotos.Price.ToString();
                }
                if (rdoGold.Checked == true)
                {
                    if (rdoSimple.Checked == true)
                    {
                        myFramedPhotos = new FramedPhoto(width, height, Material.GOLD, Style.SIMPLE);
                    }
                    if (rdoModern.Checked == true)
                    {
                        myFramedPhotos = new FramedPhoto(width, height, Material.GOLD, Style.MODERN);
                    }
                    if (rdoVintage.Checked == true)
                    {
                        myFramedPhotos = new FramedPhoto(width, height, Material.GOLD, Style.VINTAGE);
                    }
                    if (rdoAntique.Checked == true)
                    {
                        myFramedPhotos = new FramedPhoto(width, height, Material.GOLD, Style.ANTIQUE);
                    }
                    if (rdoEclectic.Checked == true)
                    {
                        myFramedPhotos = new FramedPhoto(width, height, Material.GOLD, Style.ECLECTIC);
                    }
                    lblType.Text = myFramedPhotos.ToString();
                    lblCost.Text = myFramedPhotos.Price.ToString();
                }
            }
        }
    }
}
