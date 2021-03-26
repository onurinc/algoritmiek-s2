using System;
using System.Collections.Generic;
using System.Net;

namespace PEuler8_100001st_prime
{
    class Program
    {
        static bool isPrime(int primeControl)
        {
            for (int i = 2; i <= Math.Sqrt(primeControl); i++)
            {
                if (primeControl % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int number = 10001;
            int primeControl = 2;
            List<int> primeList = new List<int>();

            while (primeList.Count != 10001)
            {
                if (isPrime(primeControl) == true)
                {
                    primeList.Add(primeControl);
                }
                primeControl++;
            }
            // primeList.ForEach(i => Console.Write("{0}\t", i));
            Console.WriteLine(primeList[number-1]);
            Console.ReadKey();
        }
    }
}
