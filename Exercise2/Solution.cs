using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Solution
    {
        public int findMostOften(int[] A)
        {
            //count frequency using hashing
            Dictionary<int, int> frequencyCount = new Dictionary<int, int>();

            for (int i = 0; i < A.Length; i++)
            {
                int key = A[i];
                if (frequencyCount.ContainsKey(key))
                {
                    int freq = frequencyCount[key];
                    freq++;
                    frequencyCount[key] = freq;
                }
                else
                {
                    frequencyCount.Add(key, 1);
                }
            }

            //find max frequency
            int minCount = 0;
            int res = -1;
            foreach (KeyValuePair<int, int> pair in frequencyCount)
            {
                if (minCount < pair.Value)
                {
                    minCount = pair.Value;
                    res = pair.Key;
                }
            }
            return res;
        }
    }
}
