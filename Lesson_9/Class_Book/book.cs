using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Book
{
    public class Book
    {
        public string Name => "Анна Каренина";
        public string Author => "Лев Николаевич Толстой";
        public int Year => 1978;
        public int Pages => 864;

        public void DisplayInfo()
        {
            Console.WriteLine($"Название книги - {Name},\n Автором является - {Author},\n  Первый выпуск книги был в {Year} году,\n   Книга имеет {Pages} страниц");
        }
        public void IsThick()
        {
            if (Pages > 500)
            {
                Console.WriteLine("Эта книга толстая!");
            }
        }


    }
}
