using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Photo
    {
        protected float _width;
        protected float _height;

        public Photo(float width, float height)
        {
           _width = width;
           _height = height;

        }

        public float Width
        {
            set { _width = value; }
            get { return _width; }
        }

        public float Height
        {
            set { _height = value; }
            get { return _height;  }
        }

        public virtual double Price
        {
          
            get 
            {
                if (Width == 8.0 && Height == 10.0)
                {
                    return 3.99;
                }
                else if (Width == 10.0 && Height == 12.0)
                {
                   return  5.99;
                }
                else
                {
                   return  9.99;
                }
            }
        }

        public override string ToString()
        {
            return $"{_width}x{_height}, {Price}";
        }
    }
}
