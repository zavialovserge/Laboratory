using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOperators_stud
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            Console.WriteLine(@"Please,  type the number:
            1. Farmer, wolf, goat and cabbage puzzle
            2. Console calculator
            3. Factorial calculation
            4. Quess number
            ");

            a = long.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Farmer_puzzle();
                    Console.WriteLine("");
                    break;
                case 2:
                    Calculator();
                    Console.WriteLine("");
                    break;
                case 3:
                    Factorial_calculation();
                    Console.WriteLine("");
                    break;
                case 4:
                    QuessNumber();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
        #region farmer
        static void Farmer_puzzle()
        {
            //Key sequence: 3817283 or 3827183
            int a1, a2, a3, a4, a5, a6, a7;
            int b1 = 3, b2 = 8, c3 = 1, d3 = 2, b4 = 7, c5 = 2, d5 = 1, b6 = 8, b7 = 3;
            Console.WriteLine(@"From one bank to another should carry a wolf, goat and cabbage. 
At the same time can neither carry nor leave together on the banks of a wolf and a goat, 
a goat and cabbage. You can only carry a wolf with cabbage or as each passenger separately. 
You can do whatever how many flights. How to transport the wolf, goat and cabbage that all went well?");
            Console.WriteLine("There: farmer and wolf - 1");
            Console.WriteLine("There: farmer and cabbage - 2");
            Console.WriteLine("There: farmer and goat - 3");
            Console.WriteLine("There: farmer  - 4");
            Console.WriteLine("Back: farmer and wolf - 5");
            Console.WriteLine("Back: farmer and cabbage - 6");
            Console.WriteLine("Back: farmer and goat - 7");
            Console.WriteLine("Back: farmer  - 8");
            a1 = int.Parse(Console.ReadLine());
            if (a1 == b1)
            {
                Console.WriteLine("Please,  type next number");
                a2 = int.Parse(Console.ReadLine());
                if (a2 == b2)
                {
                    Console.WriteLine("Please,  type next number");
                    a3 = int.Parse(Console.ReadLine());
                    if (a3 == c3 || a3 == d3)
                    {
                        Console.WriteLine("Please,  type next number");
                        a4 = int.Parse(Console.ReadLine());
                        if (a4 == b4)
                        {
                            Console.WriteLine("Please,  type next number");
                            a5 = int.Parse(Console.ReadLine());
                            if ((a5 == c5 && a3 == c3) || (a5 == d5 && a3 == d3))
                            {
                                Console.WriteLine("Please,  type next number");
                                a6 = int.Parse(Console.ReadLine());
                                if (a6 == b6)
                                {
                                    Console.WriteLine("Please,  type next number");
                                    a7 = int.Parse(Console.ReadLine());
                                    if (a7 == b7)
                                    {
                                        Console.WriteLine("Success :)");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Failure");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Failure");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Failure");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Failure");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Failure");
                    }
                }
                else
                {
                    Console.WriteLine("Failure");
                }
            }
            else
            {
                Console.WriteLine("Failure");
            }

        }
        #endregion

        #region calculator
        static void Calculator()
        {
           
            Console.WriteLine(@"Select the arithmetic operation: 
            1.Multiplication
            2.Divide
            3.Addition
            4.Substraction
            5.Expotentiation
            ");
            int c;
            c=int.Parse(Console.ReadLine());
            double a, b;
            Console.WriteLine("Please enter a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter b:");
            b = double.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    Console.WriteLine(a * b);
                    break;
                case 2:
                    if (b != 0)
                    {
                        Console.WriteLine(a / b);
                        break;
                    }
                    else 
                    { 
                      Console.WriteLine("b=0, Please Reload programm and enter currect value");
                      break;
                    }
                case 3:
                    Console.WriteLine(a + b);
                    break;
                case 4:
                    Console.WriteLine(a - b);
                    break;
                case 5:
                    Console.WriteLine(Math.Pow(a, b));
                    break;
                default:
                    Console.WriteLine("Please reload programm and enter currect number");
                    break;
            }
        }
        #endregion

        #region Factorial
        static void Factorial_calculation()
        {
            int n;
            int result = 1;
            Console.WriteLine("Please enter a:");
            n = int.Parse(Console.ReadLine());

            result = fact(n);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static int fact(int n)
        {
            if (n == 0)
            { return 1; }
            else return n * fact(n - 1);
        }
        #endregion
        #region QuessNumber
        static void QuessNumber()
        {
            const int Max = 200;
            Random rand = new Random();
            int a=0;
            int quantityGuess = 0;
            int Guess=rand.Next(Max)+1;
            while (a != Guess)
            {
                quantityGuess++;

                Console.WriteLine("Please enter your number:");
                a = int.Parse(Console.ReadLine());
                if(a<Guess)
                {
                   Console.WriteLine("{0} Too low",a);
                }
                else if(a>Guess)
                {
                   Console.WriteLine("{0} Too high",a);
                }
                else
                {
                    
                    Console.WriteLine("{0} is right! Congratulations.", a);
                    Console.WriteLine("Number of guesses: {0}", quantityGuess);
                }
            }
        }
        #endregion
    }
}

