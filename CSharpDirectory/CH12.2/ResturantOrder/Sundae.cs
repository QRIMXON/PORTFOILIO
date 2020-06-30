using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
   public enum SundaeTopping
    {
        NONE, 
        SPRINKLES,
        NUTS,
        CHOCOLATE

    }
    public class Sundae
    {
        //Constants
        public const double BASE_PRICE = 4.53;
        public const double TOPPING_PRICE = .51;

        //instance fields
        private SundaeTopping[] _toppings = new SundaeTopping[2];
        private int _toppingCount;
        private double _price;

        //properties
        public int ToppingCount
        {
            get => _toppingCount;
        }

        public double Price
        {
            get => _price;
        }

        //Default Constructor
        public Sundae()
        {
            _price += BASE_PRICE;
            _toppingCount = 0;
            _toppings[0] = SundaeTopping.NONE;
        }
        public SundaeTopping GetTopping(int index)
        {
            return _toppings[index];
        }
        public void AddTopping(SundaeTopping t)
        {
            if (_toppingCount < 2)
            {
                _toppings[_toppingCount] = t;
                _price += TOPPING_PRICE;
                _toppingCount++;
            }
        }
    }
}


