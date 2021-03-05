using System;
using System.Security.Cryptography.X509Certificates;

namespace ProjectEuler5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 20;


            while ( i % 4 != 0 ||  i % 9 != 0 || i % 10 != 0 || i % 11 != 0 || 
                    i % 12 != 0 || i % 13 != 0 || i % 14 != 0 || i % 15 != 0 || 
                    i % 16 != 0 || i % 17 != 0 || i % 18 != 0 || i % 19 != 0 || i % 20 != 0)
            {
                i ++;
            }
            Console.WriteLine(i);
            Console.ReadKey();
        }
	}
}
