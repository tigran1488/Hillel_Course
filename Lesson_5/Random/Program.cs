using NPOI.SS.Formula.Functions;

namespace RandomGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2) Програма загадує число від 1 до 146(привіт, Random).Користувач намагається вгадати його.У разі неправильної відповіді програма підказує «більше» або «менше» 
            Random random = new Random();
            int secretNumber = random.Next(1, 147);
            Console.WriteLine("HELLO! TRY TO GUESS NUMBER FROM 1-146! GOOD LUCK");
            
            bool correctGuess = false;
            while (!correctGuess)
            {
                
                Console.Write("Your try: ");
                int guess = int.Parse(Console.ReadLine());

              
                    if (guess == secretNumber)
                    {
                        Console.WriteLine("You guess! Correct Number: " + secretNumber);
                        correctGuess = true;
                    }
                    else if (guess < secretNumber)
                    {
                        Console.WriteLine("More");
                    }
                    else
                    {
                        Console.WriteLine("Less");
                    }
                
               

            }

        }
    }
}

           
                
