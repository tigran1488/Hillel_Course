namespace Time {

    class Program
    {
        static void Main(string[] args)
        {

            int h = 2, m = 13, s = 43;
            int time = (s + (13 * 60) + (2 * 60 * 60));
            Console.WriteLine("Task_2");
            Console.WriteLine($"Загальний час (2год,13хв,43сек) у секундах={time}c");
            Console.ReadKey();
        }
    }

}