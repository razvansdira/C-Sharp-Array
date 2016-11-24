using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Array
{
    class Exercise13
    {
        static void Main(string[] args)
        {
            int i, j=0, x, nou;
            int[] arr = new int[10];

            Console.Write("Input the number of elements to be stored in the array: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input {0} elements in the array: ", x);
            for (i = 0; i < x; i++)

            {
                Console.Write("\nElement - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write(" Input the value to be inserted: ");
            nou = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < x; i++)
            {
                if (nou < arr[i])
                {
                    j = i;
                    break;
                }
            }
            for(i=x;i>=j; i--)
            {
                arr[i] = arr[i - 1];
                arr[j] = nou;
            }
                        
            Console.Write("The final list is: ");
            for (i = 0; i <= x; i++)
                Console.Write("{0} ", arr[i]);
            Console.ReadLine();
        }
    }
}
