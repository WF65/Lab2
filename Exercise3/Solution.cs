using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Solution
    {
        public void findPerfectSquares()
        {
            Console.WriteLine("Please input begining number between -10000 and 10000:");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input ending number between -10000 and 10000:");
            int end = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = start; i <= end; i++)
            {
                double root = Math.Sqrt(i);
                if (root%1 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"The no. of perfect squares in between {start} and {end} is {count}");

        }
    }
}
