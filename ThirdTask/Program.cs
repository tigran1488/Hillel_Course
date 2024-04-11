namespace ThirdTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3) Дано тризначне число.Знайти число, отримане під час перестановки першої та другої цифр заданого числа.
            int number = 148;
            int hundreads, tens, one;
            hundreads = number / 100;
            tens = ((number / 10) % 10);
            one = number % 10;
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            Console.WriteLine($"число, отримане під час перестановки першої та другої цифр= {tens}{hundreads}{one}");
            Console.ReadKey();
        }
    }
}