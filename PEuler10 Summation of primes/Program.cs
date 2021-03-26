using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace PEuler10_Summation_of_primes
{
    class Program
    {
        static bool isPrime(int value)
        {
            for (int i = 2; i <= Math.Sqrt(value); i++)
            {
                if (value%i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            List<int> primeList = new List<int>();
            for (int i = 2; i < 2000000; i++)
            {
                if (isPrime(i))
                {
                    primeList.Add(i);
                }
            }

            long summation = 0;
            for (int i = 0; i < primeList.Count; i++)
            {
                summation += primeList[i];
            }

            Console.WriteLine(summation);
            Console.ReadKey();
        }
    }
}
