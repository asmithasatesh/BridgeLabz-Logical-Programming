using System;
using System.Diagnostics;
using System.Threading;

namespace Logical_Programming
{
    class Fibonacci_Series
    {
        public static void ReadInput()
        {
            //Get input from user
            int endRange;
            Console.WriteLine(" Enter the range for Fibonacci series");
            endRange = Convert.ToInt32(Console.ReadLine());
            //Calculate Fibonacci series
            Fibbo_Calculate(endRange);
        }


        private static void Fibbo_Calculate(int timeLapse)
        {
            //Given fibo0->0 fibo1->1
            int f1 = 0, f2 = 1, f3;
            Console.Write(f1+"\t");
            Console.Write(f2+"\t");
            for(int i=2;i<timeLapse;i++)
            {
                //Compute f3 by adding f1+f2
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
                Console.Write(f3+"\t");
            }

        }
    }
}
