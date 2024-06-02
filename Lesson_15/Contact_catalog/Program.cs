namespace Contact_catalog
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            ContactCat contactBook = new ContactCat();
            string command;
           
            do
            {
                Console.WriteLine("\nВиберіть операцію:");
                Console.WriteLine("1. Додати контакт");
                Console.WriteLine("2. Видалити контакт");
                Console.WriteLine("3. Оновити номер телефону");
                Console.WriteLine("4. Шукати контакт");
                Console.WriteLine("5. Вивести всі контакти");
                Console.WriteLine("6. Вийти");
                Console.Write("Введіть номер операції: ");
                command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                        Console.Write("Введіть ім'я: ");
                        string nameToAdd = Console.ReadLine();
                        Console.Write("Введіть номер телефону: ");
                        string phoneNumberToAdd = Console.ReadLine();
                        contactBook.AddContact(nameToAdd, phoneNumberToAdd);
                        break;
                    case "2":
                        Console.Write("Введіть ім'я для видалення: ");
                        string nameToRemove = Console.ReadLine();
                        contactBook.RemoveContact(nameToRemove);
                        break;
                    case "3":
                        Console.Write("Введіть ім'я для оновлення: ");
                        string nameToUpdate = Console.ReadLine();
                        Console.Write("Введіть новий номер телефону: ");
                        string newPhoneNumber = Console.ReadLine();
                        contactBook.UpdateContact(nameToUpdate, newPhoneNumber);
                        break;
                    case "4":
                        Console.Write("Введіть ім'я для пошуку: ");
                        string nameToSearch = Console.ReadLine();
                        contactBook.SearchContact(nameToSearch);
                        break;
                    case "5":
                        contactBook.ShowAllContacts();
                        break;
                    case "6":
                        Console.WriteLine("Вихід з програми.");
                        break;
                   
                }
            } while (command != "6");

        }
    }
}