using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Task
{
    internal class GreetingPlugin : IPlugin
    {
        public void Execute() 
        {
            Console.WriteLine("Hello my friends");
        }
    }
}
