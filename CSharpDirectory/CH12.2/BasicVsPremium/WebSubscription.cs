using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class WebSubscription
    {
        private string _user;
        private string _package;


        public WebSubscription(string user, string package)
        {
            _user = user;
            _package = package;
        }

        public string User => _user;
        public string Package => _package;

        public virtual double Price => 5.00;
        public override string ToString()
        {
            return $"{_user}, {_package}, {Price}";
        }


    }
}

