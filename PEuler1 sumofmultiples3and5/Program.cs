using System;

namespace sumofmultiples3and5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumof3and5s = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) 
                {
                    sumof3and5s += i;
                }
            }

            Console.WriteLine(sumof3and5s);
            Console.ReadKey();
        }
    }
}
