using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory2_3
{
    class Laboratory2_3
    {
        static void Main(string[] args)
        {
            // 10) declare 2 objects
            Money money1 = new Money(2, CurrencyTypes.UAH);
            Money money2 = new Money(7, CurrencyTypes.UAH);
            // 11) do operations
            // add 2 objects of Money
            Money money = new Money();
            money = money1 + money2;
            Console.WriteLine("Operator overload(money object1+money object2) +: {0}", money.Amount);
            money--;
            Console.WriteLine("Operator overload(decrease money object1) --: {0}",money.Amount);
            money = money1 * money2;
            Console.WriteLine("Operator overload(money object1*money object2*3) *: {0}",money.Amount);
            bool a;
            a = money1 > money2;
            Console.WriteLine("Operator overload(if(money object1>money object2) return true,else return false) >: {0}",a);
            a = money1 < money2;
            Console.WriteLine("Operator overload(if(money object1>money object2) return false,else return true) >: {0}",a);
            Console.WriteLine("Operator overload(return type of money Amount): {0}",money1.Amount.GetType());
            string i = money1;
            Console.WriteLine("Operator overload(return type of money Amount): {0}", i.GetType());
            Console.ReadKey();  
        }
    }
}
