using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Password
    {
            private string _raw;
            private string _hash;

       


        public Password(string raw, string hash)
            {
                _raw = raw;
                _hash = hash;
               

            }
        

        public string Raw
        {
            set => _raw = value;
            get => _raw;
        }

        public string Hash
        {
            set => _hash = value;
            get => _hash;
        }



    }
        }

