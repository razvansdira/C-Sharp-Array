using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Array
{
    class Exercise11
    {
        static void Main(string[] args)
        {
            int i, j, x, ord;
            int[] arr = new int[10];

            Console.Write("Input the number of elements to be stored in the array: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input {0} elements in the array: ", x);
            for (i = 1; i <= x; i++)

            {
                Console.Write("\nElement - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 1; i <= x; i++)
            {
                for (j = i + 1; j <= x; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        ord = arr[i];
                        arr[i] = arr[j];
                        arr[j] = ord;
                    }
                }
            }
            Console.Write(" The ascending elements are: ");
            for (i = 1; i <= x; i++)
                Console.Write("{0} ", arr[i]);
            Console.ReadLine();
        }
    }
}
