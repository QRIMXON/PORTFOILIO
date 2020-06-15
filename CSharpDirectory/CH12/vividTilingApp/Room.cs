using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Room
    {
        private string _name;
        private int _width;
        private int _length;
        private int _area;
        private int _boxes;

        public Room(string name, int width, int length)
        {
            _name = name;
            _width = width;
            _length = length;
            _area = length * width;
            _boxes = _area / 12;
            if (_area - (12 * _boxes) != 0)
            {
                _boxes += 2;
            }
            else
            {
                _boxes += 1;
            }

        }

        public string Display() => $"{_name}({_width}x{_length}) needs {_boxes} boxes\n";


        public string Name
        {
            get => _name;
        }

        public int Length
        {
            get => _length;
        }

        public int Width
        {
            get => _width;
        }

        public int Area
        {
            get => _area;
        }
            
        public int Boxes
        {
            get => _boxes;
        }
    }
}
