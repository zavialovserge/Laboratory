using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1_4_2
{
    class Base_4<T> where T:new()
    {
        private static T _instance;
        public static T Instance
        {
            get
            {
                Console.WriteLine("Static field");
                _instance = new T();
                return _instance;
            }
        }
        protected Base_4()
        {
            Console.WriteLine("Hello from protected constr Base_4 without new ");
        }
    }
}
