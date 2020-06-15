using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class ProSubscription
    {
        private string _proUser;
        private string _proPackage;
            private string _password;

            public ProSubscription(string proUser, string proPackage, string password) 
            {
            _proUser = proUser;
            _proPackage = proPackage;
        _password = password;
            }
        public string ProUser => _proUser;
        public string Package => _proPackage;
        public string Password => _password;
        public virtual double Price => 15.00;

        public override string ToString()
            {
                return $"{_proUser}, {_proPackage}, {Price}";
        }
        }
    }

