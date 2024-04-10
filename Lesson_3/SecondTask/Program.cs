namespace SecondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2) Написати програму, яка обчислює квадрат будь-якого введеного числа (бажано використати Math).
            Console.Write("Input number: ");
            double num=double.Parse(Console.ReadLine());
            double pow = Math.Pow(num,2);
            Console.WriteLine($"Your number squared={pow}");
            Console.ReadKey();

        }
    }
}