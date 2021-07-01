using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programming
{
    class Perfect_Number
    {
        public static void ReadInput()
        {
            //Get input from user
            int perfectNumber;
            Console.WriteLine(" Enter a number");
            perfectNumber = Convert.ToInt32(Console.ReadLine());
            PerfectNumver_Compute(perfectNumber);
        }


        private static void PerfectNumver_Compute(int perfectNum)
        {
            //local variables
            int sum=0,temp;
            for(int i=1;i< perfectNum;i++)
            {
                //Check if i is divisible by number
                if(perfectNum%i==0)
                {
                    sum += i;
                }    
            }
            //check whether sum of divisible values is equal to Number
            if(sum==perfectNum)
            {
                Console.WriteLine("Yes, it is a Perfect Number");
            }
            else
            {
                Console.WriteLine("No, it is not a Perfect Number!");

            }
        }
    }
}
