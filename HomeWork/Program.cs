using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static String Name;
        static void Main(string[] args)
        {
            int ArraySize;
            Console.WriteLine("Please Enter size of Array:");
            while (!Int32.TryParse(Console.ReadLine(), out ArraySize))
            {
                Console.WriteLine("You Entered not a number!");
                Console.WriteLine("Please try to Enter size of Array again. Make sure to Enter only digits:");
            }
            int[] array = new int[ArraySize];

            Console.WriteLine("Please Enter Array values:");
            for (int i=0; i<ArraySize; i++)
        
            {
                while (!Int32.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("You Entered not a number for the Value{0}. Please Enter number again for the Value {0}", i+1);
                }
            }

            Console.WriteLine("Your array looks like this:");

            Console.Write("[");
            ArrayOut(array);
            Console.Write("]");
            Console.WriteLine();

            int max = 0;
            int min = array[1];

            for (int i=0; i<array.Length; i++)
            {
                
                if (array[i]>max)
                {
                    max = array[i];
                }
               
            }

            for (int i=0; i<array.Length; i++)
            {
                if (array[i]<min)
                {
                    min = array[i];
                }
            }

            Console.WriteLine("Maximum value in your array is: {0}", max);
            Console.WriteLine("Minimum value in your array is: {0}", min);

            Console.ReadLine();
        }


        static void ArrayOut(int[] TempArray)
        {
            for (int i=0; i<TempArray.Length; i++)
            {
                Console.Write(TempArray[i] + " ");
            }

         
        }

    }
}
