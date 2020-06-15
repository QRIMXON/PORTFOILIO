using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
   public class CertifiedLetter:Letter
    {
        protected string _trackingNumber;

        public CertifiedLetter(string recipient, DateTime sentDate, string trackingNumber) : base(recipient, sentDate)
        {
            _trackingNumber = trackingNumber;
        }
        public string TrackingNumber => _trackingNumber;
        public override double Price => .65;

        public override string ToString()
        {
            return base.ToString() + $",{_trackingNumber}";
        }
    }
}
