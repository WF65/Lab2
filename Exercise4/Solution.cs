using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Solution
    {
        public void spiralDisplay(int[,] input)
        {
            int row = input.GetLength(0);
            //Console.WriteLine($"{row}");
            int column = input.GetLength(1);
            //Console.WriteLine($"{column}");
            Console.WriteLine("Array in spiral form is:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{input[i, j]} ");
                }
            }
        }
    }
}
