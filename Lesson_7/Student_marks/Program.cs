using System.Linq;
using System.Runtime.InteropServices;

namespace Student_marks
{

    internal class Program
    {

        static int[] marksMath;
        static int[] marksHistory;
        static int[] marksEnglish;
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            initializeData();

            
            while (true)
            {
                int input = MultipleChoice(true, new ShopMenu());
                switch ((ShopMenu)input)
                {
                    case ShopMenu.Marks:
                        Console.WriteLine("Your choice: Marks   ");
                        showGrades();
                        break;
                    case ShopMenu.Average:
                        Console.WriteLine("Your choice: Average");
                        showGrades();
                        double averageGrade=СalculateAverage();
                        Console.WriteLine($"\nСередня оцінка: {averageGrade}");
                        break;
                    case ShopMenu.AddMarks:
                        Console.WriteLine("Your choice: AddMarks");
                        addNewGrades();
                        Console.WriteLine();
                        showGrades();
                        break;
                    case ShopMenu.Exit:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                        
                }
                Console.ReadLine();
                Console.Clear();
            }

        }

        private static void showNewGrades()
        {
            
                Console.WriteLine($"Math: " + String.Join(", ", marksMath));
                Console.WriteLine($"History: " + String.Join(", ", marksHistory));
                Console.WriteLine($"English: " + String.Join(", ", marksEnglish));
        }
        private static double СalculateAverage() //середня оцінка
        {
            double sum = 0;
            int totalGrades = marksEnglish.Length + marksHistory.Length + marksMath.Length;
            foreach (int grade in marksEnglish)
            {
                sum += grade;
            }
            foreach (int grade in marksHistory)
            {
                sum += grade;
            }
            foreach (int grade in marksMath)
            {
                sum += grade;
            }
            return sum / totalGrades;
        }
        private static void addNewGrades()  //додавання нових оцінок
        {
            Console.Write("Введіть нову оцінку з математики: ");
            int newMathGrade = int.Parse(Console.ReadLine());
            Array.Resize(ref marksMath, marksMath.Length + 1);
            marksMath[marksMath.Length - 1] = newMathGrade;

            Console.Write("Введіть нову оцінку з історії: ");
            int newHistoryGrade = int.Parse(Console.ReadLine());
            Array.Resize(ref marksHistory, marksHistory.Length + 1);
            marksHistory[marksHistory.Length - 1] = newHistoryGrade;

            Console.Write("Введіть нову оцінку з історії: ");
            int newEnglishGrade = int.Parse(Console.ReadLine());
            Array.Resize(ref marksEnglish, marksEnglish.Length + 1);
            marksEnglish[marksEnglish.Length - 1] = newEnglishGrade;
        }

        private static void showGrades()   //виведення початкових даних
        {
            Console.WriteLine($"Math: " + String.Join(", ", marksMath));
            Console.WriteLine($"History: " + String.Join(", ", marksHistory));
            Console.WriteLine($"English: " + String.Join(", ", marksEnglish));
        }

        private static void initializeData()  //початкові дані 
        {
            marksMath = new int[] { 85, 100, 80, 90 };
            marksHistory = new int[] { 75, 65, 80, 82 };
            marksEnglish = new int[] { 85, 70, 60, 95 };
        }

        #region menu code 
       enum ShopMenu
        {
            Marks,Average , AddMarks, Exit
        }

        /// <summary>
        /// Menu based enum
        /// </summary>
        /// <param name="canCancel"></param>
        /// <param name="userEnum">Enum enumeration of the user for which we build the menu</param>
        /// <param name="spacingPerLine">Number of indents between columns</param>
        /// <param name="optionsPerLine">Number of values in one column</param>
        /// <param name="startX">Number of indents on the left side of the console</param>
        /// <param name="startY">Number of indents on the upper side of the console</param>
        /// <returns></returns>
        public static int MultipleChoice(bool canCancel, Enum userEnum, int spacingPerLine = 18, int optionsPerLine = 2,
            int startX = 1, int startY = 1)
        {
            int currentSelection = 0;
            ConsoleKey key;
            Console.CursorVisible = false;
            int length = Enum.GetValues(userEnum.GetType()).Length;
            do
            {
                Console.Clear();

                for (int i = 0; i < length; i++)
                {
                    Console.SetCursorPosition(startX + (i % optionsPerLine) * spacingPerLine, startY + i / optionsPerLine);

                    if (i == currentSelection)
                        Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write(Enum.Parse(userEnum.GetType(), i.ToString()));

                    Console.ResetColor();
                }

                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            if (currentSelection % optionsPerLine > 0)
                                currentSelection--;
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            if (currentSelection % optionsPerLine < optionsPerLine - 1)
                                currentSelection++;
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        {
                            if (currentSelection >= optionsPerLine)
                                currentSelection -= optionsPerLine;
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (currentSelection + optionsPerLine < length)
                                currentSelection += optionsPerLine;
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            if (canCancel)
                                return -1;
                            break;
                        }
                }
            } while (key != ConsoleKey.Enter);

            Console.CursorVisible = true;

            return currentSelection;

            #endregion

        }
    }
}