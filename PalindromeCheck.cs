using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTech
{
    public class PalindromeCheck
    {
        public static void Main()
        {
            Console.WriteLine("Please Enter a String :");
            string? input = Console.ReadLine();

            bool IsPalindrome= CheckPalindrome(input);
            Console.WriteLine($"Is the string Palindrome ? {IsPalindrome} : {input}");

        }

        private static bool CheckPalindrome(string? input)
        {
            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                if (input[left] != input[right])
                    return false;
                left++;
                right--;
            }       
            
            return true;            
        }
    }
}
