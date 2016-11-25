using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Array
{
    class Exercise25
    {
        static void Main(string[] args)
        {
            int x, y, z;
            int[,] arr = new int[20, 20];
            int[] r = new int[10];
            int[] c = new int[10];

            Console.Write("Input the size: ");
            z = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input elements in the matrix: ");
            for (x = 0; x < z; x++)
            {
                for (y = 0; y < z; y++)
                {
                    Console.Write("\nElement - [{0}],[{1}] : ", x, y);
                    arr[x, y] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write(" The matrix is: ");
            for (x = 0; x < z; x++)
            {
                Console.Write("\n");
                for (y = 0; y < z; y++)
                    Console.Write("  {0} ", arr[x, y]);
            }

            for (x = 0; x < z; x++)
            {
                r[x] = 0;
                for (y = 0; y < z; y++)
                    r[x] += arr[x, y];
            }

            for (x = 0; x < z; x++)
            {
                c[x] = 0;
                for (y = 0; y < z; y++)
                    c[y] += arr[x, y];
            }

            Console.Write("\nThe sum is: ");
            for (x = 0; x < z; x++)
            {
                Console.Write("\n");
                for (y = 0; y < z; y++)
                    Console.Write(" {0}  ", arr[x, y]);
                Console.Write(" {0}  ", r[x]);
            }

            Console.Write("\n");
            for (y = 0; y < z; y++)
                Console.Write(" {0}  ", c[y]);
            Console.ReadLine();
        }
    }
}
