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
            int sum=0,temp;
            temp = perfectNum;
            for(int i=1;i< perfectNum;i++)
            {
                if(perfectNum%i==0)
                {
                    sum += i;
                }    
            }
            if(sum==temp)
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
