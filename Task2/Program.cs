using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysTask2
{
    class Program
    {


        static void Main(string[] args)
        {

            MyMatrix mx = new MyMatrix();
            int[][] matrix = mx.CreateMatrix();

            mx.PrintMatrix(matrix);

            int[][] newMatrix = mx.ChangeSize(2, 2);
            mx.PrintMatrix(newMatrix);

            mx.ChangeSize(2, 0);

            int[][] anotherMx = mx.ChangeSize(9, 2);
            mx.PrintMatrix(anotherMx);

            Console.ReadKey();
           
        }
    }
}
