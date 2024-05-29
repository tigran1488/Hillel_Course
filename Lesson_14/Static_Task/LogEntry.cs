using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Task
{
    internal class LogEntry
    {
        public DateTime Timestamp { get; }
        public string Message { get; }
        public LogEntry(string message)
        {
            Timestamp = DateTime.Now;
            Message = message;
        }
        public override string ToString()
        {
            return $"{Timestamp:yyyy-MM-dd HH:mm:ss} - {Message}";
        }
    }
}
