using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Array
{
    class Exercise7
    {
        static void Main(string[] args)
        {
            int i, j, k, x, y, z;
            int[] arr = new int[10];
            int[] brr = new int[10];
            int[] crr = new int[20];

            Console.Write("Input the number of elements to be stored in the first array: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input {0} elements in the first array: ", x);
            for (i = 0; i < x; i++)
            {
                Console.Write("\nElement - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write(" Input the number of elements to be stored in the second array: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the second array: ", y);
            for (i = 0; i < y; i++)
            {
                Console.Write("\n Element - {0} : ", i);
                brr[i] = Convert.ToInt32(Console.ReadLine());
            }
            z = x + y;

            for (i = 0; i < x; i++)
                crr[i] = arr[i];

            for (j = 0; j < y; j++)
            {
                crr[i] = brr[j];
                i++;
            }

            for (i = 0; i < z; i++)
            {
                for (k = 0; k < z - 1; k++)
                {

                    if (crr[k] >= crr[k + 1])
                    {
                        j = crr[k + 1];
                        crr[k + 1] = crr[k];
                        crr[k] = j;
                    }
                }
            }
            Console.Write("The merged array in ascending order is: ");
            for (i = 0; i < z; i++)
            {
                Console.Write("{0} ", crr[i]);
            }
            Console.ReadLine();
        }
    }
}
