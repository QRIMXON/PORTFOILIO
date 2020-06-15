using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Computer
    {
            private string _name;
            private string _ipAddress;
            private string _services;
            
            

            public Computer(string name, string ipAddress, string services)
            {
                _name = name;
                _ipAddress = ipAddress;
                _services = services;
        

            }

            public string Name
            {
                set => _name = value;
                get => _name;
            }

            public string IpAddress
            {
            set => _ipAddress = value;
            get => _ipAddress;
            }

            public string Services
            {
                set => _services = value;
                get => _services;
            }

           
         
        }
    }


