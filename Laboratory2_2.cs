using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory2_2
{
    class Laboratory2_2
    {
        static void Main(string[] args)
        {
           
           Console.WriteLine("Please enter first position(x):");
           int x = int.Parse(Console.ReadLine());
           Console.WriteLine("Please enter first position(y):");
           int y = int.Parse(Console.ReadLine());
           Console.WriteLine("Please enter width :");
           int width = int.Parse(Console.ReadLine());
           Console.WriteLine("Please enter height:");
           int height = int.Parse(Console.ReadLine());
           Console.WriteLine("Please enter drawing symbol(*,+,.):");
           char symb = char.Parse(Console.ReadLine());
           Console.WriteLine("Please enter message:");
           string mess = Console.ReadLine();
           Box box = new Box(x,y,width,height,symb,ref mess);
           Console.Clear();
           box.Draw();
           Console.ReadKey();
        }
    }
}
