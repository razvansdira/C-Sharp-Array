using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Array
{
    class Exercise31
    {
        static void Main(string[] args)
        {
            int x, y, z;
            int[,] arr = new int[10, 10];

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
                Console.Write("\n");
                for (y = 0; y < z; y++)
                    if (x == y && arr[x, y] != 1 || (x != y && arr[x, y] != 0))
                        goto label;
            }
            Console.Write("\nThe matrix is an identity matrix.");
            return;
        label:
            Console.Write("The matrix is not an identity matrix.");

            Console.ReadLine();
        }
    }
}