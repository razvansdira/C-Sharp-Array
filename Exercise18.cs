using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Array
{
    class Exercise18
    {
        static void Main(string[] args)
        {
            int x, y;
            int[,] arr = new int[2,2];

            Console.Write(" Input elements in the matrix: ");

            for (x = 0; x < 2; x++)
            {
                for(y=0; y<2; y++)
                {
                    Console.Write("\nElement - [{0},{1}] : ", x, y);
                    arr[x, y] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write(" The matrix is: ");

            for (x = 0; x < 2; x++)
            {
                Console.Write("\n");
                for (y=0; y<2; y++)
                {
                    Console.Write("  {0} ", arr[x, y]);
                }
            }
            Console.ReadLine();
        }
    }
}
