using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_1_4_lab
{
    class Program
    {
        // 1) declare enum ComputerType
        enum ComputerType
        { 
            Desktop,
            Laptop,
            Server
        }

        // 2) declare struct Computer
        struct Computer
        {
            public int CPU;
            public double freguerncy;
            public int memory;
            public int HDD;
            public ComputerType comp;
        }
                // TODO: Complete member initialization
              

        static void Main(string[] args)
        {
             
            // 3) declare jagged array of computers size 4 (4 departments)
            Computer[][] department= new Computer[4] [];

            // 4) set the size of every array in jagged array (number of computers)

            department[0] = new Computer[5];
            department[0][0].comp = ComputerType.Desktop;
            department[0][1].comp = ComputerType.Desktop;
            department[0][2].comp = ComputerType.Laptop;
            department[0][3].comp = ComputerType.Laptop;
            department[0][4].comp = ComputerType.Server;

            department[1] = new Computer[3];
            department[1][0].comp = ComputerType.Laptop;
            department[1][1].comp = ComputerType.Laptop;
            department[1][2].comp = ComputerType.Laptop;

            department[2] = new Computer[5];
            department[2][0].comp = ComputerType.Desktop;
            department[2][1].comp = ComputerType.Desktop;
            department[2][2].comp = ComputerType.Desktop;
            department[2][3].comp = ComputerType.Laptop;
            department[2][4].comp = ComputerType.Laptop;

            department[3] = new Computer[4];
            department[3][0].comp = ComputerType.Desktop;
            department[3][1].comp = ComputerType.Laptop;
            department[3][2].comp = ComputerType.Server;
            department[3][3].comp = ComputerType.Server; 
            // 5) initialize array
            // Note: use loops and if-else statements
            init(department);
            // 6) count total number of every type of computers
            // 7) count total number of all computers
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)
            count(department);


            // 8) find computer with the largest storage (HDD) - 
            // compare HHD of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            maxValueFunc(department);

            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions
            minValueFunc(department);

            // 10) make desktop upgrade: change memory up to 8
            // change value of memory to 8 for every desktop. Don't do it for other computers
            // Note: use loops and if-else statements
            changeMemoryFunc(department);

        }

        private static void changeMemoryFunc(Computer[][] department)
        {

            Console.WriteLine("Memory before change= {0}", department[0][0].memory);
            for (int i = 0; i < department.Length; i++)
            {
                for (int j = 0; j < department[i].Length; j++)
                {
                    if (department[i][j].comp==ComputerType.Desktop)
                    {
                        department[i][j].memory = 8;
                    }

                }
            }
            Console.WriteLine("Changed memory = {0}", department[0][0].memory);
            Console.ReadKey();
        }

        private static void minValueFunc(Computer[][] department)
        {
            int minValue = department[0][0].memory;
            int minValueCPU = department[0][0].CPU;
            for (int i = 0; i < department.Length; i++)
            {
                for (int j = 0; j < department[i].Length; j++)
                {
                    
                    if (department[i][j].memory < minValue && department[i][j].CPU < minValueCPU)
                    {
                        minValue = department[i][j].memory;
                        minValueCPU = department[i][j].CPU;
                    }
                                   
                }
            }
                   
            for (int i = 0; i < department.Length; i++)
            {
                for (int j = 0; j < department[i].Length; j++)
                {
                    if (department[i][j].memory == minValue && department[i][j].CPU == minValueCPU)
                    {
                        Console.WriteLine("indexes:{0},{1},minValue:{2},minValueCPU:{3}", i, j, minValue, minValueCPU);
                    }
                }
            }
            Console.ReadKey();
        }

        private static void maxValueFunc(Computer[][] department)
        {
            int maxValue = department[0][0].HDD;
            for (int i = 0; i < department.Length; i++)
            {
                for (int j = 0; j < department[i].Length; j++)
                {
                    
                    if (department[i][j].HDD > maxValue)
                    {
                        maxValue = department[i][j].HDD;
                    }
                    
                }
            }
             for (int i = 0; i < department.Length; i++)
            {
                for (int j = 0; j < department[i].Length; j++)
                {
                    if (maxValue == department[i][j].HDD)
                    { 
                        Console.WriteLine("indexes:{0},{1} maxValue: {2}",i,j,maxValue); 
                    }
                    
                }
            }
            Console.ReadKey();
        }

        private static void count(Computer[][] department)
        {
            int count = 0;
            int countDesktop=0;
            int countLaptop=0;
            int countServer=0;

            for (int i = 0; i < department.Length; i++)
            {
                for (int j = 0; j < department[i].Length; j++)
                {
                    count++;
                    if (department[i][j].comp == ComputerType.Desktop)
                    {
                        countDesktop++;
                    }
                    else if (department[i][j].comp == ComputerType.Laptop)
                    {
                        countLaptop++;
                    }
                    else if (department[i][j].comp == ComputerType.Server)
                    {
                        countServer++;
                    }
                }
            }
            Console.WriteLine("All count:{0},Descktop:{1},Laptop:{2},Server:{3}",count,countDesktop,countLaptop,countServer);
            Console.ReadKey();
        }

        private static void init(Computer [][] department)
        {
            for(int i=0;i<department.Length;i++)
            {
                for(int j=0;j<department[i].Length;j++)
                {
                    if(department[i][j].comp == ComputerType.Desktop)
                    {
                     department[i][j].CPU = 4;
                     department[i][j].freguerncy = 2.5;
                     department[i][j].memory = 6;
                     department[i][j].HDD = 500;
                    }
                     else if(department[i][j].comp == ComputerType.Laptop)
                    {
                     department[i][j].CPU = 2;
                     department[i][j].freguerncy = 1.7;
                     department[i][j].memory = 4;
                     department[i][j].HDD = 250;
                    }
                     else if(department[i][j].comp == ComputerType.Server)
                    {
                     department[i][j].CPU = 8;
                     department[i][j].freguerncy = 3.0;
                     department[i][j].memory = 16;
                     department[i][j].HDD = 2000;
                    }
          
                    else{Console.WriteLine("Exeption array has invalid value");}
                }
            }
        }
    }
}
