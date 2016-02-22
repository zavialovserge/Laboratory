using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_3_1_lab
{
    class MyArray
    {
        int[] arr;

        public void Assign(int []arr, int size)
        {
           // 5) add block try (outside of existing block try)
            try
            {
                //  null reference exception
                //string foo = null;
                //foo.ToUpper();
                try
                {
                    //this.arr = new int[size];
                    //for (int i = 0; i < arr.Length; i++)
                    //    this.arr[i] = arr[i] / arr[i + 1];

                    // 1) assign some value to cell of array int_array, which index is out of range

                    //int[] int_array = new int[5];
                    //int_array[this.arr.Length - 1] = this.arr[this.arr.Length - 1];
                    int a = 1;
                    int b = 0;
                    int c = a / b;
                    // 7) use unchecked to assign result of operation 1000000000 * 100 
                    // to last cell of array


                }
                 //2) catch exception index out of rage
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                    // output message 
                }

                //4) catch devision by 0 exception
                //catch(DivideByZeroException ex)
                //{
                //    Console.WriteLine(ex.Message); 
                //    // output message 
                //}


                // 6) add catch block for null reference exception of outside block try  
                // change the code to execute this block (any method of any class)

            }
           
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message); 
            }
        }
    }
}
