namespace SecondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number: ");
            double num=double.Parse(Console.ReadLine());
            double pow = Math.Pow(num,2);
            Console.WriteLine($"Your number squared={pow}");
            Console.ReadKey();

        }
    }
}