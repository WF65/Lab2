using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class ArrayGenerate
    {
        public int[] GenerateArray()
        {
            Console.WriteLine("Please enter array size: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine($"Please enter the {i+1}th element:");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("-------------------");
            Console.Write("\n");
            Console.WriteLine("The input array is:");
            Console.Write("[ ");
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"{A[i]} ");
            }
            Console.Write("]");
            Console.Write("\n");
            Console.WriteLine("");
            return A;
        }
    }
}
