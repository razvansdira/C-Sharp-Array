using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Array
{
    class Exercise8
    {
        static void Main (string[] args)
        {
            int i, j, x, count;
            int[] arr = new int[10];
            int[] brr = new int[10];

            Console.Write(" Input number of elements to be stored: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array: ", x);
            for(i=1; i<=x; i++)
            {
                Console.Write("\n Elementul {0} este: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
                brr[i] = -1;
            }
            for (i = 1; i <= x; i++)
            {
                count = 1;
                for(j=i+1; j <= x; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        brr[j] = 0;
                    }
                }
                if (brr[i] != 0)
                    brr[i] = count;
            }
            Console.Write("Frequency of all elements of array: ");
            for (i = 1; i <= x; i++)
            {
                if (brr[i] != 0)
                    Console.Write("\n {0} occurs {1} times;", arr[i], brr[i]);
            }
            Console.ReadLine();
        }
    }
}
