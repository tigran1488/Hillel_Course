using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_catalog
{
    internal class ContactCat
    {
        private Dictionary<string, string> directContact = new Dictionary<string, string>();

        public void AddContact(string name, string phoneNumber)
        {
           directContact.ContainsKey(name);
           directContact.Add(name, phoneNumber);
           Console.WriteLine($"Контакт {name} успішно додано.");  
        }
        public void RemoveContact(string name)
        {
            directContact.Remove(name);
            Console.WriteLine($"Контакт {name} успішно видалено.");  
        }
        public void SearchContact(string name)
        {
           directContact.ContainsKey(name);
           Console.WriteLine($"Ім'я: {name}, Номер телефону: {directContact[name]}");  
        }
        public void UpdateContact(string name, string newPhoneNumber) {
           directContact.ContainsKey(name);
           directContact[name] = newPhoneNumber;
           Console.WriteLine($"Контакт {name} успішно оновлено.");
        }
        public void ShowAllContacts()
        {
               Console.WriteLine("Список всіх контактів:");
               foreach (var contact in directContact)
               {
                   Console.WriteLine($"Ім'я: {contact.Key}, Номер телефону: {contact.Value}");
               }
            
        }

    }
}
