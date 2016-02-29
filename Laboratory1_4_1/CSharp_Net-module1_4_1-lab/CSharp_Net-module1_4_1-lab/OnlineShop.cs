using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_4_1_lab
{
    class OnlineShop
    {
        // 4) declare event of type EventHandler<GoodsInfoEventArgs>
        public event EventHandler<GoodsInfoEventArgs> someEvent;

        // 5) declare method NewGoods for event initiation
        // use parameter string to get GoodsName
        // don't forget to check if event is not null
        // in true case intiate the event
        // use next line
        public void NewGoods()
        {
            if(someEvent!=null)
                someEvent(this, new GoodsInfoEventArgs("Chocolate")); 
        }
        // your_event_name(this, new GoodsInfoEventArgs(GoodsName));
       
    }
}
