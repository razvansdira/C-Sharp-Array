using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Array
{
    class Exercise20
    {
        static void Main(string[] args)
        {
            int x, y, z;
            int[,] arr = new int[2, 2];
            int[,] brr = new int[2, 2];
            int[,] crr = new int[2, 2];

            Console.Write("Input the size of the square matrix: ");
            z = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input elements in the first matrix: ");

            for (x = 0; x < z; x++)
            {
                for (y = 0; y < z; y++)
                {
                    Console.Write("\nElement - [{0},{1}] : ", x, y);
                    arr[x, y] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write(" Input elements in the second matrix: ");

            for (x = 0; x < z; x++)
            {
                for (y = 0; y < z; y++)
                {
                    Console.Write("\nElement - [{0},{1}] : ", x, y);
                    brr[x, y] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write(" The first matrix is: ");

            for (x = 0; x < z; x++)
            {
                Console.Write("\n");
                for (y = 0; y < z; y++)
                {
                    Console.Write("  {0} ", arr[x, y]);
                }
            }

            Console.Write("\n The second matrix is: ");

            for (x = 0; x < z; x++)
            {
                Console.Write("\n");
                for (y = 0; y < z; y++)
                {
                    Console.Write("  {0} ", brr[x, y]);
                }
            }

            for (x = 0; x < z; x++)
            {
                for (y = 0; y < z; y++)
                    crr[x, y] = arr[x, y] - brr[x, y];
            }
            Console.Write("\n The substraction of two matrix is: ");
            for (x = 0; x < z; x++)
            {
                Console.Write("\n");
                for (y = 0; y < z; y++)
                {
                    Console.Write("  {0} ", crr[x, y]);
                }
            }
            Console.ReadLine();
        }
    }
}
