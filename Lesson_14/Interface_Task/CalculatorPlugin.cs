using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Task
{
    internal class CalculatorPlugin : IPlugin
    {
        public void Execute() 
        {
        int a=3,b=4;
         int c = a + b;
        Console.WriteLine($"{a}+{b}={c}");
        }
    }
}
