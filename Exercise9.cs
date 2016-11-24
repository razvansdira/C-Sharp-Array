using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Array
{
    class Exercise9
    {
        static void Main(string[] args)
        {
            int i, x, a, z;
            int[] arr = new int[10];

            Console.Write(" Input number of elements to be stored: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array: ", x);
            for (i = 1; i <= x; i++)
            {
                Console.Write("\n Elementul {0} este: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            z = arr[1];
            a = arr[1];

            for (i = 1; i <= x; i++)
            {
                if (arr[i] > z)
                    z = arr[i];

                if (arr[i] < a)
                    a = arr[i];
            }
                    Console.Write("\n  {0} is maximum element.", z);
                    Console.Write("\n  {0} is minimum element.", a);
            
            Console.ReadLine();
        }
    }
}
