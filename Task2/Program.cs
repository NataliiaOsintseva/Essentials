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

            MyMatrix matrix = new MyMatrix();
            matrix.PrintMatrix();

            matrix.ChangeSize(10, 3);
            matrix.ChangeSize(2, 0);

            Console.ReadKey();
           
        }
    }
}
