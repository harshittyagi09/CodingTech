using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTech
{
    public class TwoSum
    {
        public static void Main()
        {
            Console.WriteLine("Enter the Size of the Array :");
            int size = int.Parse(Console.ReadLine());

            int[] nums = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($" Enter Element : {i + 1}");
                nums[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the Desired Sum :");
            int target = int.Parse(Console.ReadLine());

            int[] result = GetTwoSums(nums, target);
            if (result != null)
            {
                Console.WriteLine($" Indices : {result[0]},{result[1]}");
            }

            else
            {
                Console.WriteLine("No Solution Found");
            }
        }

        private static int[]? GetTwoSums(int[] nums, int target)
        {
           Dictionary<int , int> map= new Dictionary<int , int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                map[nums[i]] = i;
            }
            return null;
        }
    }
}

        