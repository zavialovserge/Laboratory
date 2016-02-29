using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_4_1_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9) declare object of OnlineShop 
            OnlineShop shop = new OnlineShop();
            // 10) declare several objects of Customer
            Customer first = new Customer("Chocolate");
            Customer second = new Customer("Milk");
            // 11) subscribe method GotNewGoods() of every Customer instance 
            // to event NewGoodsInfo of object of OnlineShop
            shop.someEvent += new EventHandler<GoodsInfoEventArgs>(first.GotNewGoods);
            shop.someEvent += new EventHandler<GoodsInfoEventArgs>(second.GotNewGoods);
            // 12) invoke method NewGoods() of object of OnlineShop
            // discuss results
            shop.NewGoods();
            Console.ReadKey();
        }
    }
}
