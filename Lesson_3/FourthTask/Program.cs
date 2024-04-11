namespace FourthTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4) Написати програму, яка обчислює середнє арифметичне двох чисел.
            Console.Write("Enter number 1:");
            double num1=double.Parse(Console.ReadLine());
            Console.Write("Enter number 2:");
            double num2 = double.Parse(Console.ReadLine());
            double average = (num1 + num2) / 2;
            Console.WriteLine($"average number={average}");
            Console.ReadKey();
        }
    }
}