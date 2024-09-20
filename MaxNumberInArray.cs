using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTech
{
    public class MaxNumberInArray
    {
        public static void Main()
        {
            Console.WriteLine("Please Enter the Size of the Array :");
            int Size= int.Parse(Console.ReadLine());

            int[] numbers = new int[Size];
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine($" Enter Element {i+1}:");
                numbers[i] = int.Parse(Console.ReadLine());

            }

            int Max = FindMax(numbers);
            Console.WriteLine($"Maximum Number : {Max}");

        }

        private static int FindMax(int[] numbers)
        {
            int max= numbers[0];
            
            foreach(int num in numbers) 
            {
                    if (num > max)
                    {
                        max = num;
                    }
            }
            
            return max;
        }
    }
}
