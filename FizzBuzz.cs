using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTech
{
    public class FizzBuzz
    {
        public static void Main()
        {
            fizzbuzz();
        }

        private static void fizzbuzz()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
