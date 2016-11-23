using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Array
{
    class Exercise1
    {
        static void Main(string[] args)
        {
            int i;
            int[] arr = new int[11];

            Console.Write(" Input 10 elements in the array: ");
            for(i=1; i<=10; i++)
            {
                Console.Write("\nElement - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(" Elements in array are: ");
            for(i=1; i<=10; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.ReadLine();
        }
    }
}
