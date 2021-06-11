using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayGenerate a = new ArrayGenerate();
            int[] A = a.GenerateArray();
            Solution s = new Solution();
            Console.WriteLine($"The value that occurs most often in array is {s.findMostOften(A)}");
        }
    }
}
