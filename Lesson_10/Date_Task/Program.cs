using System.Text;
namespace Date_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Введіть день");
            if (!int.TryParse(Console.ReadLine(),out int day)||day<1||day>31)
            {
                Console.WriteLine("Невірне значення дня");
                return;
            }
           
            Console.Write("Введіть місяць");
            if (!int.TryParse(Console.ReadLine(), out int month) || month < 1 || month > 12)
            {
                Console.WriteLine("Невірне значення місяця");
                return;
            }

            Console.Write("Введіть рік");
            if (!int.TryParse(Console.ReadLine(), out int year) || year < 1)
            {
                Console.WriteLine("Невірне значення року");
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(day.ToString("00"));
            sb.Append('-');
            sb.Append(month.ToString("00"));
            sb.Append('-');
            sb.Append((int)year);

            Console.WriteLine($"Ваша дата: {sb}");
           
           
        }
    }
}