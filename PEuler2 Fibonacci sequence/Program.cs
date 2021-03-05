using System;

namespace Fibonacci_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibOne = 0;
            int fibTwo = 1;
            int result = 0;
            int sumOfEven = 0;

           while (result < 4000000)
            {
                if ((result % 2) == 0)
                {
                    sumOfEven += result;
                }
                    
                result = fibOne + fibTwo;
                fibOne = fibTwo;
                fibTwo = result;
            }
            
            Console.WriteLine(sumOfEven);


            Console.ReadKey();

        }
    }
}
