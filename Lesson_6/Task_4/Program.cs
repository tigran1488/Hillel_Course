namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // 4) Написати програму, яка виводить всі елементи масиву доки не зустрінеться елемент -1.Масив заповнити рандомними числами, діапазон чисел від - 5 до 5.
           var random=new Random();
            int[]nums=new int[20];
            for (int i = 0; i < nums.Length; i++)
            {
               
                nums[i] = random.Next(-5, 6);
            }
            Console.WriteLine("Loop element:");
            foreach (int number in nums)
            {
                if (number==-1)
                {
                    break;
                }
                Console.Write(number + " ");
            }
        }
    }
}