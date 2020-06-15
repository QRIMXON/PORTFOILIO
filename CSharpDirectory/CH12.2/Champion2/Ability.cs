using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._0
{
    class Ability
    {
        private string _name;

        public Ability(string name)
        {
            _name = name;
        }
        public string Name
        {
            set => _name = value;
            get => _name;
        }


    }
}

