using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Lab3
{
   public class NormalCard:ICard
    {
        private string _name;
        private System.Drawing.Image _image;
        private double _value;

        public NormalCard(string name, System.Drawing.Image image, double value)
        {
            _name = name;
            _image = image;
            _value = value;
        }

        public string Name => _name;

        public Image Image => _image;

        public double Value => _value;

        public int CompareTo(ICard obj)
        {
            return this.Value.CompareTo(obj.Value);
        }

        public void ShowCard(PictureBox picture, Label label)
        {
            picture.Image = _image;
            label.Text = _name;
            picture.BackColor = System.Drawing.Color.Transparent;
            label.ForeColor = System.Drawing.Color.Black;
            label.Font = new Font("Times New Roman", 10);
        }

       
    }
}
