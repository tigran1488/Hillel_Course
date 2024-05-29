namespace Static_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Logger.AddLog("System started.");
            Logger.AddLog("User logged in.");
            Logger.AddLog("Unable to connect to database.");

            var logs = Logger.GetLogs();
            foreach (var log in logs)
            {
                Console.WriteLine(log);
            }
        }
    }
}