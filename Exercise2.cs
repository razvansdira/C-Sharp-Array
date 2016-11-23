using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Array
{
    class Exercise2
    {
        static void Main(string[] args)
        {
            int i, x;
            int[] arr = new int[50];

            Console.Write("Input the number of elementsto store in the array: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input {0} elements in the array: ",x);
            for (i = 1; i <= x; i++)
            {
                Console.Write("\nElement - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write(" Elements in array but in reverse order are: ");
            for (i = x; i >= 1; i--)
                Console.Write("{0} ", arr[i]);
            Console.ReadLine();
        }
    }
}
