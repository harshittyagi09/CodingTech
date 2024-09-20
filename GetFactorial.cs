using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTech
{
    public class GetFactorial
    {
        public static void Main()
        {
            Console.WriteLine("Enter a Number :");
            int num = int.Parse(Console.ReadLine());

            long result = Factorial(num);
            Console.WriteLine($"Factorial of {num} is {result}");
        }


        private static long Factorial(int num)
        {
            if (num == 0 || num==1) 
                return 1;
            else
                return num*Factorial(num-1);

        }
    }
}
