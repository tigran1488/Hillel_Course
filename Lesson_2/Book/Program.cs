using System;
namespace DiscountValue
{


    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding=System.Text.Encoding.UTF8; 
            string book = "Кобзарь", author = "Тарас Шевченко";
            int price = 300, year = 1840;
            Console.WriteLine("Task_3");
            Console.WriteLine($"Параметри книги - назва:{book}, автор:{author}, рік:{year}, ціна:{price}");
            Console.ReadKey();


        }
    }
}
