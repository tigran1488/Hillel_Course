namespace FirstTask
{
    internal class Program
    {
        //1) Дано тризначне число. Знайти число, отримане під час прочитання його цифр справа наліво.
        static void Main(string[] args)
        {
            int number1 = 456;
            int hundreads,tens,one;
            hundreads = number1 / 100;
            tens = ((number1/10)%10);
            one = number1 % 10;     
            Console.WriteLine($"число під час прочитання його цифр справа наліво:{one}{tens}{hundreads}");
            Console.ReadKey();  
        }
    }
}