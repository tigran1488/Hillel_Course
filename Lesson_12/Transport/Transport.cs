using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    internal class Transport
    {
        public int maxSpeed;
        public string name;
        public Transport(string name, int maxSpeed)
        {
            this.name = name;
            this.maxSpeed = maxSpeed;
        }
       
        public virtual void Move()
        { 
           Console.WriteLine("This type of transport can move");
        }
        public virtual void PrintDetails()
        {
            Console.WriteLine($"transport name is {name},  {maxSpeed}km/h");
        }
        
    }
}
