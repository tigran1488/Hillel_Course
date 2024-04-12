using System;
namespace MathTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int randomNumber1 = GenerateRandomNumber1(11);
            int randomNumber2 = GenerateRandomNumber2(11);
            int randomNumber3 = GenerateRandomNumber3(11);
            double a = randomNumber1;
            double b = randomNumber2;
            double c = randomNumber3;
            Console.WriteLine($"a={a},b={b},c={c}");
            double D = Math.Pow(b,2) -( 4 * a * c);

            if (D < 0)
            {
                Console.WriteLine("Рівняння не має коренів");
            }
            else if (D == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Рівняння має один корінь: x = {x}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"Рівняння має два корені: x1 = {x1}, x2 = {x2}");
            }
            Console.ReadKey();
        }
       

        
        private static int GenerateRandomNumber1(int limit)
        {
            Random random = new Random();
            return random.Next(limit);
        }
        private static int GenerateRandomNumber2(int limit)
        {
            Random random = new Random();
            return random.Next(limit);
        }

        private static int GenerateRandomNumber3(int limit)
        {
            Random random = new Random();
            return random.Next(limit);
        }


    } 
    }
