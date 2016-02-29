using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1_4_2
{
    class Derived_3:Base_3<Derived_3>
    {
        public Derived_3()
        { Console.WriteLine("Hello from derived_3"); }
    }
}
