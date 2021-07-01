using System;

namespace Logical_Programming
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the which program to execute");
            Console.WriteLine("1.CouponbNumbers 2.Stopwatch Simulate");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Coupon_Numbers.ReadInput();
                    break;
                case 2:
                    Stopwatch_Simulate.ReadInput();
                    break;
            }
        }
    }
}
