using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Person_Info
{ 
    
    internal class Person
    {

        private string name;
        private int age;
        private string gender;
       
        public Person(string name,int age,string gender)
        {
            this.name = name;
            this.gender = gender;
            this.age = age; 
        }
        public Person(string name) : this(name, 0, "Не вказано")                       
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
        }
        public Person(string name, int age) : this(name, age, "Не вказано")
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
        }
        public void PrintDetails()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine($"Ім'я: {name}, Вік: {age}, Стать: {gender}");        
        }
        public bool IsAdult()
        {
           return age >= 18;
        }
        public void ChangeName(string newName) 
        {
            this.name = newName;    
        }
    }
    
}
