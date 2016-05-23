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

        public int[][] CreateMatrix()
        {
            Random random = new Random();

            int col = random.Next(2, 8);
            int row = random.Next(2, 8);

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

            return matrix;
        }

        public void PrintMatrix(int[][]matrix)
        {
            int row = matrix.Length;
            int col = matrix[0].Length;

            for (int i = 0; i < row; i++)
            {
                
                for (int j = 0; j < col; j++)
                {

                    Console.Write("{0} ", matrix[i][j]);
                }

                Console.WriteLine();

            }

            Console.WriteLine();

        }


        public int[][] ChangeSize(int x, int y)
        {
            if( x <= 0 || y <= 0)
            {
                Console.WriteLine("Trying to use invalid row or column index. ");
                return null;
            }

            int[][] newMatrix = new int[x][];

            
            Console.WriteLine("Creating new {0}x{1} Matrix from the existing one...", x, y);

            for (int i = 0; i < x; i++)
            {
                newMatrix[i] = new int[y];

                if( i < matrix.Length) {

                    for (int j = 0; j < y; j++)
                    {

                        switch (j < matrix[0].Length)
                        {
                            case true:
                                newMatrix[i][j] = matrix[i][j];
                                break;
                            default:
                                newMatrix[i][j] = 0;
                                break;
                        }
                    }

                }

                else
                {
                    for (int j = 0; j < y; j++)
                    {
                        newMatrix[i][j] = 0;                        
                    }
                }

            }

            return newMatrix;

        }

    }
}
