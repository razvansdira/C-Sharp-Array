using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Array
{
    class Exercise29
    {
        static void Main(string[] args)
        {
            int x, y, z, w, count = 0;
            int[,] arr = new int[10, 10];

            Console.Write("   Input the number of rows : ");
            z = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the number of columns : ");
            w = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input elements in the matrix: ");
            for (x = 0; x < z; x++)
            {
                for (y = 0; y < w; y++)
                {
                    Console.Write("\nElement - [{0}],[{1}] : ", x, y);
                    arr[x, y] = Convert.ToInt32(Console.ReadLine());
                    if (arr[x, y] == 0)
                        ++count;
                }
            }

            if(count>((w*z)/2))
                Console.Write("\n The given matrix is sparse matrix.");
            else
                Console.Write("\n The given matrix is notsparse matrix.");
            Console.Write("\nThere are {0} number of zeros in the matrix.", count);
            Console.ReadLine();
        }
    }
}
