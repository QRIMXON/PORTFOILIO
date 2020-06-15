using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
   public class Pokemon
    {
        private string _name;
        private System.Drawing.Image _image;
        private IAbility _ability;


        public Pokemon(string name, System.Drawing.Image image, IAbility ability)
        {
            _name = name;
            _image = image;
            _ability= ability;
        }

        public string Name => _name;

        public System.Drawing.Image Image => _image;

        public IAbility Ability => _ability;


    }
}
