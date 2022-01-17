using System;

namespace IsPalindrome_Easy_
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine(IsPalindrome());
        }

        public static bool IsPalindrome()
        {
            int value = -121;
            int result = 0;
            if (value < 0 || ((value % 10 == 0) && value != 0)) return false;

            while (value > result)
            {
                int curr = value % 10;
                value /= 10;
                result = result * 10 + curr;
                Console.WriteLine(result);
            }
            return value == result || value == result / 10;
        }

    }
}
