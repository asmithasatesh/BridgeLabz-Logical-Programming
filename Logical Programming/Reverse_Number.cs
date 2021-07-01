using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programming
{
    class Reverse_Number
    {
        public static void ReadInput()
        {
            //Get input from user
            int reverse;
            Console.WriteLine(" Enter number to be reversed");
            reverse = Convert.ToInt32(Console.ReadLine());
            //Calling reverse function
            Reverse(reverse);
        }


        private static void Reverse(int reverse)
        {
            //Declare local variables
            int rem, rev=0;
            while(reverse>0)
            {
                //Get remainder
                rem = reverse % 10;
                rev = rev * 10 + rem;
                reverse /= 10;
            }
            //Print the reversed number
            Console.WriteLine("Rversed number is = "+rev);

        }
    }
}
