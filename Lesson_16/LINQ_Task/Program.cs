namespace LINQ_Task
{

    class ProductTask
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
    internal class Program

    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // 1) Фільтрація: Дано список цілих чисел: { 2, 5, 8, 12, 15, 18, 22}. Відфільтруйте всі числа, які більше 10.

            int[] nums = { 2, 5, 8, 12, 15, 18, 22 };
            var numResult=nums.Where(x => x > 10).ToList();
            Console.WriteLine(string.Join(',',numResult));

            //2) Сортування: Дано список імен фруктів: { "Яблуко", "Апельсин", "Банан", "Ківі"}. Відсортуйте цей список в алфавітному порядку.

            List<string> fruits = new List<string> { "Яблуко", "Апельсин", "Банан", "Ківі" };
            fruits.Sort();
            Console.WriteLine("------------------------------");
            Console.WriteLine(string.Join(',', fruits));

            //3) Видалення дублікатів: Дано список рядків: { "А", "Б", "В", "А", "Г", "В"}. Видаліть всі дублікати і поверніть унікальні рядки.
            
            List<string> letters = new List<string> { "А", "Б", "В", "А", "Г", "В" };
            var newLetters = letters.Distinct();
            Console.WriteLine("------------------------------");
            Console.WriteLine(string.Join(',', newLetters));

            //4) Підрахунок: Дано список оцінок студентів { 85, 92, 78, 95, 88, 90}. Порахуйте, скільки студентів отримали більше 90 балів.
            List<int> students = new List<int> { 85, 92, 78, 95, 88, 90 };
            var newStudents = students.Where(s => s >= 90).Count();
            Console.WriteLine("------------------------------");
            Console.WriteLine(string.Join(',', newStudents));

            //5) Фільтрація та сортування: Дано список об'єктів, які представляють товари і мають поля "Назва" і "Ціна". Відфільтруйте товари, які мають ціну менше 50 гривень і відсортуйте їх за зростанням ціни.
            List<ProductTask> products = new List<ProductTask>
        {
            new ProductTask { Name = "Product1", Price = 45 },
            new ProductTask { Name = "Product2", Price = 65 },
            new ProductTask { Name = "Product3", Price = 78 },
            new ProductTask { Name = "Product4", Price = 123 },
            new ProductTask { Name = "Product5", Price = 20 },
            new ProductTask { Name = "Product6", Price = 13 },
            new ProductTask { Name = "Product7", Price = 7 }
        };
            var filteredAndSortProducts = products.Where(p => p.Price < 50).OrderBy(p => p.Price).ToList();
            Console.WriteLine("------------------------------");
            foreach (var item in filteredAndSortProducts)
            {
                Console.WriteLine($"Name: {item.Name}, Price: {item.Price}");
            }


            //6) Пошук максимального за індексом: Дано список цілих чисел { 10, 25, 8, 45, 15, 30, 55, 5}. Знайдіть максимальне число за індексом(позицією) в списку.
            List<int> nums2 = new List<int> { 10, 25, 8, 45, 15, 30, 55, 5 };
            var maxNum=nums2.Select((value, index)=> new { Value=value, Index=index }).OrderByDescending(x=>x.Value).First();
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Max number: {maxNum.Value}, Index: {maxNum.Index}");
        }
    }
}