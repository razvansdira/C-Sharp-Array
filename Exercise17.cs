using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Array
{
    class Exercise17
    {
        static void Main(string[] args)
        {
            int i, j=0, x, aa, a;
            int[] arr = new int[10];

            Console.Write("Input the number of elements to be stored in the array: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input {0} elements in the array: ", x);

            for (i = 0; i < x; i++)
            {
                Console.Write("\nElement - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
             aa = 0;

            for(i=0; i < x; i++)
            {
                if (aa > arr[i])
                {
                    aa = arr[i];
                    j = i;
                }
            }
            a = 99;

            for (i = 0; i < x; i++)
            {
                if (i == j)
                {
                    i++; i--;
                }
                else
                {
                    if (a > arr[i])
                        a = arr[i];
                }
            }
            Console.Write(" The second largest element in the array is: {0}",a);

            Console.ReadLine();
        }
    }
}
