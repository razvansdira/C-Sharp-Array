using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Array
{
    class Exercise15
    {
        static void Main(string[] args)
        {
            int i, j, x;
            int[] arr = new int[10];

            Console.Write("Input the number of elements to be stored in the array: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input {0} elements in the array: ", x);

            for (i = 0; i < x; i++)
            {
                Console.Write("\nElement - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Input the position to be deleted: ");
            j = Convert.ToInt32(Console.ReadLine());
            i = 0;

            while (i != j - 1)
                i++;
            while (i < x)
            {
                arr[i] = arr[i + 1];
                i++;
            }
            x--;

            Console.Write(" The final list is: ");
            for (i = 0; i < x; i++)
                Console.Write("{0} ", arr[i]);
            Console.ReadLine();
        }
    }
}
