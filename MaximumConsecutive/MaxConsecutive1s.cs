using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumConsecutive
{
    class MaxConsecutive1s
    {
        public static int Maximum(int[] arr)
        {
            int counter = 0;
            if (arr == null)
            {
                return 0;
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == 1)
                {
                    if (arr[i] == arr[i + 1])
                    {
                        counter++;
                    }
                }

            }
            return counter;
        }

        public static void Main(string[] args)
        {
            int[] arr = { 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 1, 1, 1, 0 };

            Console.WriteLine(Maximum(arr));
            Console.ReadLine();

        }
    }
}
