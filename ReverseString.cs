using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTech
{
    public class ReverseString
    {
        public static void Main()
        {
            Console.WriteLine("Enter a String :");
            string input = Console.ReadLine();

            string reversed= StringReverse(input);
            Console.WriteLine($"Reversed String :{reversed}");
        }

        private static string StringReverse(string? input)
        {
            char[] chararray = input.ToCharArray();
            Array.Reverse(chararray);
            return new string(chararray);
        }
    }
}
