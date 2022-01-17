using System;

namespace TwoSum_Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = TwoSum();
            Console.WriteLine("[{0}]", string.Join(", ", nums));
        }
        public static int[] TwoSum()
        {
            int[] nums = { 3, 2, 4 };
            int target = 6;
            int[] arr = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            throw new Exception("Not Found");
        }
    }
}
