using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public class ShinyCard:ICard
    {
       
            private string _name;
            private System.Drawing.Image _image;
            private double _value;
            private System.Drawing.Font _font;
            private System.Drawing.Color _backColor;
            private System.Drawing.Color _foreColor;

            public ShinyCard(string name, System.Drawing.Image image, double value, Font font, System.Drawing.Color backColor, System.Drawing.Color foreColor) 
            {
            _name = name;
            _image = image;
            _value = value;
            _font = font;
            _backColor = backColor;
            _foreColor = foreColor;

            }

            public string Name => _name;

            public Image Image => _image;

            public double Value => _value;



        Image ICard.Image => _image;

        public int CompareTo(ICard obj)
        {
            return this.Value.CompareTo(obj.Value);
        }

        public void ShowCard(PictureBox picture, Label label)
            {
                picture.Image = _image;
                label.Text = _name;
            picture.BackColor = _backColor;
            label.ForeColor = _foreColor;
            label.Font = _font;
            }

       
    }
    }


