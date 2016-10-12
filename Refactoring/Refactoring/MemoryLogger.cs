using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    class MemoryLogger : ILogger
    {
        private List<Log> Logs { get; set; } = new List<Log>();
        private LogLevel DisplayLevel = LogLevel.Debug;

        public void AddLog(Log log)
        {
            if (log == null)
            {
                throw new ArgumentNullException("Log", "Log can not be null");
            }
            this.Logs.Add(log);
        }

        public void AddLog(string message, LogLevel level)
        {
            var log = new Log { Message = message, Level = level };
            this.AddLog(log);
        }

        public void setDefaultLogLevel(LogLevel level)
        {
            this.DisplayLevel = level;
        }

        public IList<Log> RetrieveCurrentLogs(LogLevel upToLevel = LogLevel.Error)
        {
            var logsToReturn = this.Logs.Where(w => w.Level <= upToLevel).ToList();
            return logsToReturn;
        }


    }
}
