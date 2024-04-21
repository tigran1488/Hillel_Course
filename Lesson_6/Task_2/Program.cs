using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2) Написати програму для інверсії масиву, тобто перевороту його у зворотному порядку. В цьому завданні недостатньо просто вивести елементи масиву у зворотному порядку.
            int [] nums = { 17, 13, 15, 63, 72, 2, 9 };
            int[] reversedNums = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                reversedNums[i] = nums[nums.Length - 1 - i];
            }
            Console.WriteLine("Reversed num:");
            foreach (int number in reversedNums)
            {
                Console.Write(number + " ");
            }
        }
    }
}

            