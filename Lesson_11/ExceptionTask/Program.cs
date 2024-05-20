namespace ExceptionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool inputValid = false;
            while (!inputValid)
            {
                try
                {
                    Console.Write("input your age: ");
                    int age = int.Parse(Console.ReadLine());
                    if (age < 0 || 100 < age)
                    {
                        throw new FormatException("age is not correct");
                    }
                    else Console.WriteLine($"your age is - {age}");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    
                }
              
            }
        }
    }
}