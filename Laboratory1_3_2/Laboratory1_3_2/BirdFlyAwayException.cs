using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1_3_2
{
    class BirdFlyAwayExeption : ApplicationException
    {
        public DateTime When { get; set; }
        public string Why { get; set; }

        public BirdFlyAwayExeption() { }

        public BirdFlyAwayExeption(string message, string cause, DateTime time)
            : base(message)
        {
            Why = cause;
            When = time;
        }
    }
}
