using System;
using System.Net.Http.Headers;

namespace PEuler9_Pythagorean_triplet
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int sumabc = 1000;
            int result = 0;

            for (a = 1; a < (sumabc / 3); a++)
            {
                for (b = 2; b < (sumabc / 2); b++)
                {
                    c = sumabc - b - a;


                    if ((a * a + b * b) == (c * c))
                    {
                        Console.WriteLine("a = " + a);
                        Console.WriteLine("b = " + b);
                        Console.WriteLine("c = " + c);

                        result = a * b * c;

                    }
                }
            }


            Console.WriteLine("result = " + result);
            Console.ReadKey();
        }
    }
}
