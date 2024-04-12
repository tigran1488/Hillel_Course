namespace CompareNumbers
{
    internal class Program
    {
     static void Main(string[] args)
        {
            Console.Write("Input first number:");
            int a=int.Parse(Console.ReadLine());
            Console.Write("Input second number:");
            int b = int.Parse(Console.ReadLine());
            if (a > b) { Console.WriteLine($"{a}>{b}"); }
            else if (a < b) { Console.WriteLine($"{a}<{b}"); }
            else if (a == b) { Console.WriteLine($"{a}={b}"); }
            Console.ReadKey();
    
        }
    }
} 