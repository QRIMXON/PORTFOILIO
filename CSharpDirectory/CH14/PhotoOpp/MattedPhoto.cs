using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public enum Color
    {

        BLACK = 0,
        RED = 1,
        GREEN = 2,
        BLUE = 4,
        WHITE = 7
    }
   public class MattedPhoto:Photo
    {
        protected Color _color;

        public MattedPhoto(float width, float height, Color color) : base(width, height)
        {
            _color = color;
        }
        public Color Color

        {
            set { _color = value; }
            get { return _color; }
        }
        public override string ToString()
        {
            return $"{_width}x{_height}, {Price}, {_color}";
        }
        public override double Price { get => base.Price + 10; }
    }
}
