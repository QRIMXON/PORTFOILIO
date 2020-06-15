using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public enum ChampionType
    {
        FRONT_LINE,
        DAMAGE,
        REPORT,
        FLANK,
    }
    class Champion
    {
        private string _name;
        private ChampionType _type;
        private Ability _leftMouse;
        private Ability _rightMouse;
        private Ability _q;
        private Ability _f;
        private Ability _e;

        public Champion(string name, ChampionType type, Ability leftMouse, 
         Ability rightMouse, Ability q, Ability f, Ability e)
        {
            _name = name;
            _type = type;
            _leftMouse = leftMouse;
            _rightMouse = rightMouse;
            _q = q;
            _f = f;
            _e = e;

        }

        public string Name => _name;

        public ChampionType Type => _type;

        public Ability LeftMouse => _leftMouse;
        public Ability RightMouse => _rightMouse;
        public Ability Q => _q;
        public Ability F => _f;
        public Ability E => _e;




    }
}



