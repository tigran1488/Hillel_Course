using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Task
{
    internal static class Logger
    {
        private static List<LogEntry> logs = new List<LogEntry>();

        public static void AddLog(string message)
        {
            logs.Add(new LogEntry(message));
        }

        public static List<LogEntry> GetLogs()
        {
            return new List<LogEntry>(logs);
        }
    }
}

