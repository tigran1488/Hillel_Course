using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // 1) Задати масив із 10 елементів.Заповнити цей масив рандомними числами від -100 до 100.Знайти кількість додатніх чисел у масиві.Вивести на екран масив і кількість порахованих чисел. 
           var random=new Random();
            int[]nums=new int[10];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(-100, 100);
            }

            int positiveNum = 0;
            foreach (int number in nums) {
                if (number>0)
                {
                    positiveNum++;
                }
            }  
            Console.WriteLine("Масив чисел:");
            foreach (int number in nums)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine($"Positive number: {positiveNum}");

        }

    }
}
            
            
            
            