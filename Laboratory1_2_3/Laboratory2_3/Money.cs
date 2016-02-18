using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory2_3
{
    // 1) declare enumeration CurrencyTypes, values UAH, USD, EU
    enum CurrencyTypes
    {
        UAH,
        USD,
        EU
    }

    class Money
    {
        // 2) declare 2 properties Amount, CurrencyType
        public int Amount { get; set; }
        public CurrencyTypes CurrencyType { get; set; }
        // 3) declare parameter constructor for properties initialization
        public Money()
            : this(0, 0)
        {

        }
        public Money(int _amount, CurrencyTypes _CurrencyType)
        {
            Amount = _amount;
            CurrencyType = _CurrencyType;
        }
        // 4) declare overloading of operator + to add 2 objects of Money
        public static Money operator +(Money money1, Money money2)
        {
            Money money = new Money();
            money.Amount = money1.Amount + money2.Amount;
            return money;
            
        }
        
        // 5) declare overloading of operator -- to decrease object of Money by 1
        public static Money operator --(Money money1)
        {
            Money money = new Money();
            money.Amount = --money1.Amount;
            return money;
        }
        // 6) declare overloading of operator * to increase object of Money 3 times
        public static Money operator *(Money money1, Money money2)
        {
            Money money = new Money();
            money.Amount = money1.Amount * money2.Amount + money1.Amount * money2.Amount + money1.Amount * money2.Amount;
            return money;
        }
        // 7) declare overloading of operator > and < to compare 2 objects of Money
        public static bool operator >(Money money1, Money money2)
        {
            if (money1.Amount > money2.Amount)
                return true;
            else
                return false;
        }
        public static bool operator <(Money money1, Money money2)
        {
            if (money1.Amount < money2.Amount)
                return true;
            else
                return false;
        }
        // 8) declare overloading of operator true and false to check CurrencyType of object
        public static bool operator true(Money money1)
        {
            if (money1.CurrencyType == CurrencyTypes.UAH || money1.CurrencyType==CurrencyTypes.USD)
                return true;
            else
                return false;
        }
        public static bool operator false(Money money1)
        {
            if (money1.CurrencyType == CurrencyTypes.EU)
                return true;
            else
                return false;
        }
        // 9) declare overloading of implicit/ explicit conversion  to convert Money to double, string and vice versa

        public static implicit operator double(Money money1)
        {
            return money1.Amount;
        }
        public static implicit operator string(Money money1)
        {
            return money1.Amount.ToString();
        }
       
        //print
      
    }
}
