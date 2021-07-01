using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programming
{
    class Prime
    {
        public static void ReadInput()
        {
            //Get input from user
            int primeNum;
            Console.WriteLine(" Enter a prime number");
            primeNum = Convert.ToInt32(Console.ReadLine());
            SimulateStopwatch(primeNum);
        }


        private static void SimulateStopwatch(int primeNum)
        {
            //flag-> Prime number. flag->1 Not a prime 
            int flag = 0;
            //Check if any number less than primeNum is divisible
            for(int i=2;i<Math.Sqrt(primeNum);i++)
            {
                if(primeNum!=2 && primeNum%i==0)
                {
                    flag = 1;
                    break;
                }
            }
            //If primeNum is 2 or flag=0 its prime
            if(primeNum==2 || flag==0)
            {
            Console.WriteLine(primeNum+" is a prime number");
            }
            else
            {
                Console.WriteLine(primeNum + " is not a prime number");

            }

        }
    }
}
