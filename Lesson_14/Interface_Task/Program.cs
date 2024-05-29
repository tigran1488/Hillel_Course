namespace Interface_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
           PluginManager user = new PluginManager();
           CalculatorPlugin plugin1 = new CalculatorPlugin();
           plugin1.Execute();
           GreetingPlugin plugin2 = new GreetingPlugin();
           plugin2.Execute();
        }
    }
}