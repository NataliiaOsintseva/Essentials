using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysTask2
{
    public class MyMatrix
    {
        int[][] matrix;

        public MyMatrix()
        {
            Random random = new Random();

            int col = random.Next(1, 5);
            int row = random.Next(1, 5);

            Console.WriteLine("Creating {0}x{1} Matrix...", col, row);

            matrix = new int[row][];
                              
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[col];

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = random.Next(0, 15);
                }


            }
        }

        public void PrintMatrix()
        {
            int col = matrix.Length;
            int row = matrix[0].Length;
            var isNext = 0;

            for (int i = 0; i < col; i++)
            {
                
                for (int j = 0; j < row; j++)
                {
                    if (isNext != i)
                    {
                        Console.WriteLine();
                        isNext = i;
                    }

                    Console.Write("{0} ", matrix[i][j]);
                }

            }

            Console.WriteLine();

        }

        public void ChangeSize(int x, int y)
        {
            if( x <= 0 || y <= 0)
            {
                Console.WriteLine("Trying to use invalid row or column index. ");
                return;
            }

            Random random = new Random();

            Console.WriteLine("Creating {0}x{1} Matrix...", x, y);

            matrix = new int[x][];

            for (int i = 0; i < x; i++)
            {
                matrix[i] = new int[y];

                for (int j = 0; j < y; j++)
                {
                    matrix[i][j] = random.Next(0, 15);
                }

            }

            PrintMatrix();          

        }

    }
}
