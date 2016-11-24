using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Array
{
    class Exercise6
    {
        static void Main (string[] args)
        {
            int i, j, x, y, count = 0;
            int[] arr = new int[10];

            Console.Write(" Input the number stored in the array: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements: ",x);

            for (i = 1; i <= x; i++)
            {
                Console.Write("\n Element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("The unique elements of this array are: ", count);

            for (i=1; i<=x; i++)
            {
                count = 0;
                for(j=0; j<=i-1; j++)
                {
                    if(arr[i]==arr[j])
                    {
                        count++;
                    }
                }
                for(y=i+1; y<=x; y++)
                {
                    if (arr[i] == arr[y])
                        count++;
                }
                if (count == 0)
                    Console.Write("{0} ", arr[i]);
            }
            Console.ReadLine();
        }
    }
}
