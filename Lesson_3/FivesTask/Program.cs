namespace FivesTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5) Користувач вводить радіус круга. Напишіть програму, яка обчислює площу цього круга і виводить в консоль результат.
            Console.Write("Enter radius of circle: ");
            double r=double.Parse(Console.ReadLine());
            double area=Math.Pow(r,2)*Math.PI;
            Console.WriteLine($"area of the circle={area}");
            Console.ReadKey();
        }
    }
}