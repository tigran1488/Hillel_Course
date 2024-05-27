using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Animal_Task
{
    internal class Bird : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Bird flies");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Bird is chirping");
        }
       
    }
}
