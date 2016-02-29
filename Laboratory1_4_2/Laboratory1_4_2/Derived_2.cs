using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1_4_2
{
    class Derived_2: Base_2<Derived_2>
    {
        public Derived_2()
        {
            Console.WriteLine("Hello derived construct");
        }
    }
}
