using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Array
{
    class Exercise30
    {
        public static void Main()
        {
            int x, y, r1, c1, r2, c2, comp = 1;
            int[,] arr = new int[10, 10];
            int[,] brr = new int[10, 10];

            Console.Write(" Input the number of rows in the first matrix : ");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the number of columns in  the first matrix : ");
            c1 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input the number of rows in the second matrix : ");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the number of columns in  the second matrix : ");
            c2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("  Input elements in the first matrix :\n");
            for (x = 0; x < r1; x++)
            {
                for (y = 0; y < c1; y++)
                {
                    Console.Write("\n Element - [{0}],[{1}] : ", x, y);
                    arr[x, y] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("Input elements in the second matrix:\n");
            for (x = 0; x < r2; x++)
            {
                for (y = 0; y < c2; y++)
                {
                    Console.Write("\n Element - [{0}],[{1}] : ", x, y);
                    brr[x, y] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("The first matrix is :\n");
            for (x = 0; x < r1; x++)
            {
                for (y = 0; y < c1; y++)
                    Console.Write("  {0} ", arr[x, y]);
                Console.Write("\n");
            }
            Console.Write("The second matrix is :\n");
            for (x = 0; x < r2; x++)
            {
                for (y = 0; y < c2; y++)
                    Console.Write("  {0} ", brr[x, y]);
                Console.Write("\n");
            }

            if (r1 != r2 && c1 != c2)
                Console.Write("The Matrices Cannot be compared:\n");
            else
            {
                Console.Write("The Matrices can be compared:\n");
                for (x = 0; x < r1; x++)
                {
                    for (y = 0; y < c2; y++)
                    {
                        if (arr[x, y] != brr[x, y])
                        {
                            comp = 0;
                            break;
                        }
                    }
                }
                if (comp == 1)
                    Console.Write(" Two matrices are equal.");
                else
                    Console.Write(" Two matrices are not equal.");
            }
            Console.ReadLine();
        }
    }
}
