using System;

namespace CanPlaceFlowers_Easy_
{
    class Program
    {
        public static int location = 0;
        public static int n = 1;
        public static int[] flowerbed = { 1, 0, 0, 0, 1 };
        static void Main(string[] args)
        {
            Console.WriteLine(CanPlaceFlowersv1(flowerbed));
            //RunCanPlaceFlowersv2();
        }

        public static void RunCanPlaceFlowersv2()
        {
            while (CanPlaceFlowersv2(flowerbed) == true)
            {
                n--;
                if (n == 0)
                {
                    break;
                }
            }
            if (n != 0)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
        public static bool CanPlaceFlowersv2(int[] flowerbed)
        {
            int previous = 0;
            int after = 0;
            for (int i = location; i < flowerbed.Length; i++)
            {
                if (i + 1 == flowerbed.Length)
                {
                    after = 0;
                }
                else
                {
                    after = flowerbed[i + 1];
                }
                if (flowerbed[i] == 0 && after == 0 && previous == 0)
                {
                    flowerbed[i] = 1;
                    location = i;
                    return true;
                }
                previous = flowerbed[i];
            }
            return false;
        }

        public static string CanPlaceFlowersv1(int[] flowerbed)
        {
            if (flowerbed == null || flowerbed.Length == 0)
                return "false";

            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0)
                {
                    int prev = (i == 0) ? 0 : flowerbed[i - 1];
                    int next = (i == flowerbed.Length - 1) ? 0 : flowerbed[i + 1];
                    if (prev == 0 && next == 0)
                    {
                        flowerbed[i] = 1;
                        n--;
                    }
                }
            }

            return (n <= 0) ? "true" : "false";
        }
    }
}
