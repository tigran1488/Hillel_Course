namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 *) Напишіть програму, яка приймає від користувача число від 1 до 100. При цьому якщо число кратне трьом, програма
            //повинна виводити слово Fizz, а якщо кратно п'яти - слово Buzz. Якщо число кратно п'ятнадцяти,
            //програма повинна виводити слово FizzBuzz. Завдання може здатися очевидним,
            //але потрібно отримати найбільш просте та красиве рішення.
            Console.WriteLine("Enter number 1 to 100:");
            int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 100)
            {
                Console.WriteLine("Your number didnt match 1-100");
            }
            else
            {
                if (number % 3 == 0) { Console.WriteLine("Fizz"); }

                if (number % 5 == 0) { Console.WriteLine("Buzz"); }

                if (number % 15 == 0) { Console.WriteLine("FizzBuzz"); }

                else Console.WriteLine($"Number: {number}");
            }
        }
    }
}          
        
            
            
            
