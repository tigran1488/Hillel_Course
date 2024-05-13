namespace Person_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Person person1 = new Person("Іван", 29, "чоловік");     
            Person person2 = new Person("Марія");
            Person person3 = new Person("Дмитро", 42);

            Console.WriteLine("Дані про першу особу:");
            person1.PrintDetails();

            Console.WriteLine("Дані про другу особу:");
            person2.PrintDetails();

            Console.WriteLine("Дані про третю особу:");
            person3.PrintDetails();

            Console.WriteLine($"Чи є перша особа дорослою? {person1.IsAdult()}");
            Console.WriteLine($"Чи є друга особа дорослою? {person2.IsAdult()}");
            Console.WriteLine($"Чи є третя особа дорослою? {person3.IsAdult()}");
           
            person1.ChangeName("Петро");

            Console.WriteLine("\nПісля зміни імені першої особи:");
            person1.PrintDetails();
        }
    }
    
}