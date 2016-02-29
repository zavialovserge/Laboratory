using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1_4_2
{
    class Base_3<T> where T: new() 
    {
        private T _instance;
        public T Instance
        {
            get
            {
                Console.WriteLine("Public field");
                _instance = new T();
                return _instance;
            }
        }
        static Base_3()
        {
            Console.WriteLine("Hello from static construktor");
            T some = new T();
        }
    }
}
