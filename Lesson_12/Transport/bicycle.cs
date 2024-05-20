using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    internal class Bicycle : Transport 
    {
        string typeOfBicycle;
        public Bicycle(string typeOfBicycle, string name, int maxSpeed) : base(name, maxSpeed)
        {
            this.typeOfBicycle = typeOfBicycle; 
        }
        public override void Move()
        {
            Console.WriteLine("Bicycle can move everywhere");
        }
        public override void PrintDetails()
        {
            Console.WriteLine($"Bicycle name is {name}, maximum speed is {maxSpeed}km/h, it is the {typeOfBicycle}");
        }
    }
}
