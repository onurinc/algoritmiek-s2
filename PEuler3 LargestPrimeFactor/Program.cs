using System;

namespace LargestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxPrime = 0;
            int oddPrime = 3;
            long num;

            num = 600851475143;

            while (num % 2 == 0)
            {
                maxPrime = 2;
                num = num / 2;
            }

            while (num != 1)
            {
                while (num % oddPrime == 0)
                {
                    maxPrime = oddPrime;
                    num = num / oddPrime;
                }
                oddPrime += 2;
            }
            Console.WriteLine(maxPrime);
            Console.ReadKey();
        }
    }
}
