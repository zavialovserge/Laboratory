using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1_4_2
{
    public class Derived: Base<Derived>
    {
        public Derived()
        {
            Console.WriteLine("Hello constr Derived");
        }
    }
}
