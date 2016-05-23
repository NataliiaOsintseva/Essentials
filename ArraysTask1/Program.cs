using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysTask1
{
    class Program
    {
        //static Array myArray = new Array(3);

        public static void Main(string[] args)
        {
            Array myArray = new Array(3);

            myArray.PrintMaxValue();
            myArray.PrintMinValue();
            Console.WriteLine("Sum is {0}", myArray.Sum());
            myArray.Average();
            myArray.OddNum();

            Console.ReadKey();
        }
    }
}
