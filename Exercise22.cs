﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Array
{
    class Exercise22
    {
        static void Main(string[] args)
        {
            int x, y, z, w;
            int[,] arr = new int[2, 2];
            int[,] brr = new int[2, 2];

            Console.Write(" Input the number of rows : ");
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
                }
            }

            Console.Write(" The matrix is: ");
            for (x = 0; x < z; x++)
            {
                Console.Write("\n");
                for (y = 0; y < w; y++)
                    Console.Write("  {0} ", arr[x, y]);
            }

            for (x = 0; x < z; x++)
            {
                for (y = 0; y < w; y++)
                {

                    brr[y, x] = arr[x, y];
                }
            }

            Console.Write("\nThe traspose of a matrix is: ");
            for (x = 0; x < w; x++)
            {
                Console.Write("\n");
                for (y = 0; y < z; y++)
                {
                    Console.Write("  {0} ", brr[x, y]);
                }
            }
            Console.ReadLine();
        }
    }
}
