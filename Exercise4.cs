using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Array
{
    class Exercise4
    {
        static void Main(string[] args)
        {
            int i, x, sum = 0;
            int[] arr = new int[10];
            int[] brr = new int[10];

            Console.Write("Input the number of elements to be stored in the array: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input {0} elements in the array: ", x);
            for (i = 1; i <= x; i++)
            {
                Console.Write("\nElement - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 1; i <= x; i++)
                brr[i] = arr[i];

            Console.Write("  The elements stored in the first array are: ");
            for (i = 1; i <= x; i++)
                Console.Write("{0} ", arr[i]);

            Console.Write("\n The elements stored in the second array are: ");
            for (i = 1; i <= x; i++)
                Console.Write("{0} ", brr[i]);
            Console.ReadLine();
        }
    }
}
