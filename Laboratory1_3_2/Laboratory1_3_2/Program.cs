using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observation Somebird flight");
            Bird My_Bird = new Bird("Somebird", 70);
            int ii;
            char rdk;
            try
            {
                do
                {
                    try
                    {
                        Console.WriteLine("Monitoring in Try block ");
                        Console.WriteLine(@"Please, type the number
                1. array overflow
                2. throw exception
                3. user exception
                                    ");
                        int i = int.Parse(Console.ReadLine());
                        switch (i)
                        {
                            case 1:
                                int j = My_Bird.arr[4];
                                break;
                            case 2:
                                throw (new System.Exception("Oh! My system exception..."));
                            case 3:
                                for (i = 0; i < My_Bird.arr[3]; i++)
                                {
                                    My_Bird.FlySpeed(i);
                                }
                                break;
                            default:
                                break;
                        }



                    }
                    catch (BirdFlyAwayExeption e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(e.When);
                        Console.WriteLine(e.Why);

                    }
                    catch (System.Exception e)
                    {
                        Console.WriteLine("CLS exception: Message -  " + e.Message + " Source - " + e.Source);

                    }
                    finally
                    {
                        Console.WriteLine("For next step ...");
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                    Console.ForegroundColor = ConsoleColor.White;


                    rdk = Console.ReadKey().KeyChar;
                } while (rdk != ' ');

            }
            catch (Exception ex)
            { throw; }
        }
    }
}
