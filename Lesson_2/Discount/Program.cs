using System;
namespace DiscountValue
{


    class Program
    {
        static void Main(string[] args)
        {

            /*Task_1*/
            double product = 10000, discount = 20;
            double total = ((discount / 100) * product);
            double amount = product - total;
            Console.WriteLine("Task_1");
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine($"Вартість товару до знижки={product} грн\n Відсоток знижки={discount}% \n Сума знижки={total}грн \n Кінцева вартість={amount}грн ");

            Console.ReadKey();


        }
    }
}

