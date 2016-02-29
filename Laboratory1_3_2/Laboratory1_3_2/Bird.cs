using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1_3_2
{
    class Bird
    {
        public int[] arr = { 1, 2, 3, 4 };
        public int speed { get; set; }
        public string name { get; set; }

        private bool BirdFlewAway;
        public Bird() { }
        public Bird(string _name, int _speed)
        {
            name = _name;
            speed=_speed;
        }
        public void FlySpeed(int value)
        {
            if (BirdFlewAway)
                Console.WriteLine("{0} flew away ...", name);
            else
            {
                speed += value;
                if (speed >= arr[3])
                {
                    BirdFlewAway = true;
                    speed = 0;

                   BirdFlyAwayExeption ex =
                        new BirdFlyAwayExeption(string.Format("{0} flew with incredible speed!", name),
                                               "Oh! Startle.", DateTime.Now);
                    ex.HelpLink = "http://en.wikipedia.org/wiki/Tufted_titmouse";

                    throw ex;
                }
                else
                    Console.WriteLine("... flying close with the speed = {0}", speed);
            }
        }
    }
   
}
