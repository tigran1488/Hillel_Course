using System;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3) Потрібно додати до масиву елемент на початок.Нехай масив буде на 10 елементів.
            var random = new Random();
            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(0, 100);
            }
            int[] newElement = new int[nums.Length + 1];
            
            for (int i = 0; i < nums.Length; i++)
            {
                newElement[i] = nums[i];
            }
            newElement[0] = random.Next(1000,1400);
            for (int i = 0; i < nums.Length; i++)
            {
                newElement[i + 1] = nums[i];
            }
            foreach (var item in newElement)
            {
                Console.Write(item + "\t");
            }
        }
    }
}