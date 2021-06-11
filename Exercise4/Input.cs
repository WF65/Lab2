using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Input
    {
        public int[,] inputArray()
        {

            //Console.WriteLine("Please input the no of columns of the 2D array:");
            //int columns = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please input the no of rows of the 2D array:");
            //int rows = Convert.ToInt32(Console.ReadLine());
            int rows = 3;
            int columns = 3;
            Console.WriteLine("Please input array elements:");
            int[,] input = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    input[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("");
            return input;

        }
    }
}
