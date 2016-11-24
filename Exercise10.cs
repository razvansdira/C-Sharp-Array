using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Array
{
    class Exercise10
    {
        static void Main(string[] args)
        {
            int i, x, j=0, k=0;
            int[] arr = new int[10];
            int[] brr = new int[10];
            int[] crr = new int[10];

            Console.Write("Input the number of elements to be stored in the first array: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input {0} elements in the first array: ", x);
            for (i = 0; i < x; i++)
            {
                Console.Write("\nElement - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < x; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    brr[j] = arr[i];
                    j++;
                }
                else
                {
                    crr[k] = arr[i];
                    k++;
                }
            }
            Console.Write("\n The even elements are: ");

            for (i = 0; i < j; i++)
                Console.Write("{0} ", brr[i]);

            Console.Write("\n  The odd elements are: ");

            for (i = 0; i < k; i++)
                Console.Write("{0} ", crr[i]);
            Console.ReadLine();
        }
    }
}
