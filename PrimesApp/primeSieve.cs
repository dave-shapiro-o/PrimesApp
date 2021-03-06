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
            int count = 0;
            //only set odd numbers and 2 to true initially;
            isPrime[2] = true;
            for (int i = 1; i < size; i += 2)
            {
                isPrime[i] = true;
            }
            // Eliminates all multiples of primes
            for (int i = 2; i * i < size; ++i)
            {
                if (isPrime[i])
                {
                    for (int j = i * 2; j < size; j += i)
                    {
                        { isPrime[j] = false; }
                    }
                }              
            }

            for (int i = 1; i < size; ++i)
            {
                if (isPrime[i]) 
                {
                    ++count;
                    builder.Append($"{i, 10}");
                    if (count > 7 && count % 8 == 0) { builder.AppendLine(); }
                }
            }
            listOfPrimes = builder.ToString();
            return count;
        }
    }
}
