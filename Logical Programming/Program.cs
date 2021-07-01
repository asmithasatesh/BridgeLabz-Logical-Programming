using System;

namespace Logical_Programming
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter program number to execute");
            Console.WriteLine("1.CouponbNumbers\n2.Stopwatch Simulate\n3.Fibonacci Series\n4.Perfect Number\n5.Check prime number");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Coupon_Numbers.ReadInput();
                    break;
                case 2:
                    Stopwatch_Simulate.ReadInput();
                    break;
                case 3:
                    Fibonacci_Series.ReadInput();
                    break;
                case 4:
                    Perfect_Number.ReadInput();
                    break;
                case 5:
                    Prime.ReadInput();
                    break;
            }
        }
    }
}
