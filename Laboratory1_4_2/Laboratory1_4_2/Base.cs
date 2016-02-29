using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1_4_2
{
    public class Base<T>where T: new()
    {
        static Base()
        {
            System.Console.WriteLine(" Static constructor");
            T some = new T();
        }
    }
}
