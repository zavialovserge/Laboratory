using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_3_1_lab
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //CatchExceptionClass cec = new CatchExceptionClass();
            //cec.CatchExceptionMethod();
            //Console.ReadKey();
            // 11) Make some unhandled exception and study Visual Studio debugger report – 
            // read description and find the reason of exception            
            // stackoverflow exception Meth();
            Console.ReadKey();

        }
        static public string Meth()
        {
 	        return Meth();
        } 
        

    }

}
