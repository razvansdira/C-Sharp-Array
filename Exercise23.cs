using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Array
{
    class Exercise23
    {
        static void Main(string[] args)
        {
            int x, y, z, sum=0;
            int[,] arr = new int[2, 2];

            Console.Write("Input the size: ");
            z = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input elements in the matrix: ");
            for (x = 0; x < z; x++)
            {
                for (y = 0; y < z; y++)
                {
                    Console.Write("\nElement - [{0}],[{1}] : ", x, y);
                    arr[x, y] = Convert.ToInt32(Console.ReadLine());
                    if (x == y)
                        sum += arr[x, y];
                }
            }

            Console.Write(" The matrix is: ");
            for (x = 0; x < z; x++)
            {
                Console.Write("\n");
                for (y = 0; y < z; y++)
                    Console.Write("  {0} ", arr[x, y]);
            }

            Console.Write("\nAddition of the right diagonal elements is: {0}", sum);
            Console.ReadLine();
        }
    }
}
