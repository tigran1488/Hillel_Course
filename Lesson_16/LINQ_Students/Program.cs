using LINQ_Students;
using System.Linq;
using System.Collections.Generic;
namespace LINQ_Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // Фільтрація: Знайдіть усіх студентів, які мають оцінку більше або рівну 90.
        //Сортування: Відсортуйте студентів за оцінкою в спадаючому порядку.
        //Групування: Згрупуйте студентів за курсами і виведіть список студентів на кожному курсі.
        //Підрахунок: Порахуйте кількість студентів на кожному курсі.
        //Проекція: Створіть список рядків, які містять ім'я та оцінку кожного студента, наприклад: "Ім'я: Олена, Оцінка: 95".
            List<Student> students = new List<Student>
            {
                new Student { Name = "Alex", Grade = 80, Course = 1 },
                new Student { Name = "John", Grade = 90, Course = 2 },
                new Student { Name = "Jason", Grade = 65, Course = 1 },
                new Student { Name = "Max", Grade = 94, Course = 3 },
                new Student { Name = "Misha", Grade = 75, Course = 3 },
                new Student { Name = "Artur", Grade = 84, Course = 1 },
                new Student { Name = "Ivan", Grade = 88, Course = 2},
                new Student { Name = "Dima", Grade = 95, Course = 4 },
                new Student { Name = "Ben", Grade = 100, Course = 4 }
          
            };
            var filtByGrade = students.Where(s => s.Grade >= 90).ToList();
            var sortStudents= students.OrderByDescending(s=>s.Grade).ToList();
            var groupStudents= students.GroupBy(s=>s.Course).ToList();
            var studentsCountByCourse = students.GroupBy(s => s.Course).Select(x => new { Course = x.Key, Count = x.Count() }).ToList();
            var studentsInfo = students.Select(s => $"Name:{s.Name}, Grade: {s.Grade}, Course: {s.Course}").ToList();
            
            Console.WriteLine("Students with grade >=90:");
            foreach (var student in filtByGrade)
            {
                Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}, Course: {student.Course}");
            }

            Console.WriteLine("\nStudents sorted by grades reverse");
            foreach (var student in sortStudents)
            {
                Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}, Course: {student.Course}");
            }

            Console.WriteLine("\nStudents group by course:");
            foreach (var group in groupStudents)
            {
                Console.WriteLine($"\nCourse: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}");
                }
            }

            Console.WriteLine("\nQuantity of students on each course");
            foreach (var count in studentsCountByCourse)
            {
                Console.WriteLine($"Course: {count.Course}, Quantity of students: {count.Count}");
            }

            Console.WriteLine("\nList with students name and grade");
            foreach (var info in studentsInfo)
            {
                Console.WriteLine(info);
            }
        }
    }  
}