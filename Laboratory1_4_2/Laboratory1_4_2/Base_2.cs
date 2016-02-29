using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1_4_2
{
    public class Base_2<T> where T : new()
    {
        protected Base_2()
        {
            Console.WriteLine("Hi Base protected construct");
            T some = new T();
        }
    }
}
