using System;

namespace LargestPalindrome3digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var max = 0;
            int numberOne;
            for (numberOne = 100; numberOne < 1000; numberOne++)
            {
                int numberTwo;
                for (numberTwo = 100; numberTwo < 1000; numberTwo++)
                {
                    var product = numberOne * numberTwo;

                    var reverseProduct = product;
                    var reverse = 0;

                    while (reverseProduct > 0)
                    {
                        reverse = reverse * 10 + reverseProduct % 10;
                        reverseProduct = reverseProduct / 10;
                    }

                    if (reverse == product)
                    {
                        if (product > max)
                        {
                            max = product;
                        }
                    }
                }
            }
            Console.WriteLine(max);
            Console.ReadKey();

        }
    }
}
