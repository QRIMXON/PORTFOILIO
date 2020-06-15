using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Letter
    {
        protected string _recipient;
        protected DateTime _sentDate;


        public Letter(string recipient, DateTime sentDate)
        {
            _recipient = recipient;
            _sentDate = sentDate;
        }

        public string Recipient => _recipient;
        public DateTime SentDate => _sentDate;

        public virtual double Price => .5;
        public override string ToString()
        {
            return $"{_sentDate}, {_recipient}, {Price}";
        }


    }
}
