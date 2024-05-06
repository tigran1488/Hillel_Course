using System.ComponentModel.DataAnnotations;

namespace Class_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Book book = new Book();
            book.DisplayInfo();
            book.IsThick();
        }
    }
}