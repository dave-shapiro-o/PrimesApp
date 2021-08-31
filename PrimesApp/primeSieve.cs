using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesApp
{
    class PrimeSieve  
    {
        public static string listOfPrimes;
        public static int Calculate(int size)
        { 
            bool[] isPrime = new bool[size];
            StringBuilder builder = new();
            

            for (int i = 0; i < size; ++i)
            {
                isPrime[i] = true;
            }

            for (int i = 2; i < size; ++i)
            {
                for (int j = i + 1; j < size; ++j)
                {
                    if (isPrime[i] && j % i == 0) { isPrime[j] = false; }
                }
            }
            int count = 0;

            for (int i = 1; i < size; ++i)
            {
                if (isPrime[i]) 
                {
                    ++count;
                    builder.Append($"{i, 10}");
                    if (count > 9 && count % 10 == 0) { builder.AppendLine(); }
                }
            }
            listOfPrimes = builder.ToString();
            return count;
        }
    }
}
