namespace SixthTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6 *) Дослідити інші способи поміняти місцями значення двох змінних без використання тимчасової змінної та використання суми / множення.
            Console.Write("enter num1:");
            int num1=int.Parse(Console.ReadLine());
            Console.Write("enter num2:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"num1-{num2}");
            (num1, num2) = (num2, num1);
            Console.WriteLine($"num2-{num2}");
            Console.ReadKey();
        }
    }
}