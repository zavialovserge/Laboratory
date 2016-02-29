using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1_4_2
{
    class Derived_4:Base_4<Derived_4>
    {
        public Derived_4()
        {
            Console.WriteLine("Hello from derived_4");
        }
    }
}
