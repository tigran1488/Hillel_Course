namespace Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Напишіть програму, яка «запитуватиме» правильний пароль, доки він не буде введений. Правильний пароль нехай буде "root".Якщо пароль неправильний, програма повинна сказати "Неправильний пароль!"
            while (true)
            {
                Console.Clear();
                Console.Write("Enter password: ");
                string password = Console.ReadLine();
                if (password == "root")
                {
                    Console.Write("Correct password!");
                }
                else Console.Write("Wrong password! Try Again");
                Console.ReadKey();
            }
        }
    }
}