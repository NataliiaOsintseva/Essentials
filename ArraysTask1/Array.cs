using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysTask1
{
    public class Array
    {
        int[] myArray;

        public Array(int n)
        {
            myArray = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                myArray[i] = random.Next(-30, 50);
            }
      
        }

        public void PrintMaxValue()
        {
            int max = myArray[0];

            for ( int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Checking number {0}", myArray[i]);

                if (max < myArray[i])
                {
                    max = myArray[i];
                }

            }

            Console.WriteLine("Maximum is {0}", max);

        }

        public void PrintMinValue()
        {
            int min = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Checking number {0}", myArray[i]);

                if (min > myArray[i])
                {
                    min = myArray[i];
                }

            }

            Console.WriteLine("Minimum is {0}", min);

        }

        public int Sum()
        {
            int sum = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];

            }

           return sum;

        }

        public void Average()
        {
            double average = Sum()/myArray.Length ;
            Console.WriteLine("Average is {0}", average);

        }

        public void OddNum()
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if(myArray[i] % 2 == 1)
                {
                    Console.WriteLine("Number {0} is odd", myArray[i]);
                }

            }
        }
    }
}
