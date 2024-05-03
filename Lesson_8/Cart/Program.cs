namespace Cart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            double totalCost=0.0;
            ProductType  productType;
            do
            {
                Console.WriteLine("Введіть тип товару (1: Їжа, 2: Одяг, 3: Електроніка, 4: Книги):");
                if (Enum.TryParse(Console.ReadLine(), out productType))
                {
                    Console.WriteLine("Введіть ціну товару:");
                    if (double.TryParse(Console.ReadLine(), out double price) && price >= 0)
                    {
                        totalCost += price;
                        Console.WriteLine($"Загальна вартість у кошику: {totalCost:C}");
                    }
                    else if (Enum.TryParse(Console.ReadLine(), out productType))
                    {
                       Console.WriteLine("Некоректний тип товару! Введіть 1, 2, 3 або 4");
                    }
                   
                    
                    else 
                    {  
                        Console.WriteLine("Некоректна ціна! Введіть додатнє число");
                    }
                }
               
                Console.WriteLine("Продовжити введення? (Y/N)");
            } while (Console.ReadLine().Trim().ToUpper() == "Y");
            Console.WriteLine($"Загальна вартість усіх товарів у кошику: {totalCost:C}");
        }

    } 
}