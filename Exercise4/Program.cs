using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Input i = new Input();
            int[,] input = i.inputArray();
            Solution solu = new Solution();
            solu.spiralDisplay(input);
        }
    }
}
