using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Task
{
    internal class Dog : Animal
    {

        public override void Move()
        {
            Console.WriteLine("Dog runs on 4 paws");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Dog is barking");
        }
    
      
    }
}