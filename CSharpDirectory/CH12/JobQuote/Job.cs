using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Job
    {
        private string _description;
        private float _hoursToComplete;
        private float _hourlyFee;
        private float _totalFee;
        public const double TRIP_FEE = 35;

        public Job(string description, float hoursToComplete, float hourlyFee)
        {
            _description = description;
            _hoursToComplete = hoursToComplete;
            _hourlyFee = hourlyFee;
            _totalFee = hourlyFee * hoursToComplete + (float)TRIP_FEE;

        }

        public string Description
        {
            set { _description = value; }
            get { return _description; }
        }

        public float HoursToComplete
        {
            set => _hoursToComplete = value;
            get => _hoursToComplete;
        }

        public float HourlyFee
        {
            set => _hourlyFee = value;
            get => _hourlyFee;
        }

        public float TotalFee
        {
            get => _totalFee;
        }
    }
}
