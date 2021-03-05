using System;

namespace ProjectEuler6_SumSquareDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfSquares = 0;
            int squareOfSum = 0;
            int difference = 0;

            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += (i * i);
                squareOfSum += i;

            }

            squareOfSum = squareOfSum * squareOfSum;

            difference = squareOfSum - sumOfSquares;

            Console.WriteLine(difference);
            Console.ReadKey();

        }
    }
}
