using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    internal class Auto : Transport
    {
       public int numOfDoors;
        public Auto( string name, int maxSpeed, int numOfDoors) : base (name, maxSpeed)
        {
            this.numOfDoors = numOfDoors;       
        }
        public override void Move()
        {
           
            Console.WriteLine("Auto can move only on the road  ");
        }
                public override void PrintDetails()
                {
                    Console.WriteLine($"Car name is {name} , maximum speed is {maxSpeed}km/h, it has {numOfDoors} doors");
                }
    }
}
