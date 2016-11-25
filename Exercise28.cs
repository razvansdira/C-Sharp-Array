using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Array
{
    class Exercise28
    {
        static void Main(string[] args)
        {
            int x, y, d=0;
            int[,] arr = new int[10, 10];

            Console.Write(" Input elements in the matrix: ");
            for (x = 0; x < 3; x++)
            {
                for (y = 0; y < 3; y++)
                {
                    Console.Write("\nElement - [{0}],[{1}] : ", x, y);
                    arr[x, y] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write(" The matrix is: ");
            for (x = 0; x < 3; x++)
            {
                Console.Write("\n");
                for (y = 0; y < 3; y++)
                    Console.Write("  {0} ", arr[x, y]);
            }

            for (x = 0; x < 3; x++)
                d = d + (arr[0, x] * (arr[1, (x + 1) % 3] * arr[2, (x + 2) % 3] - arr[1, (x + 2) % 3] * arr[2, (x + 1) % 3]));
            Console.Write("\nThe determinant of the matrix is: {0}.", d);
            Console.ReadLine();
        }
    }
}
