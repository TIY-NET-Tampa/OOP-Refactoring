using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    interface ILogger
    {
        IList<Log> RetrieveCurrentLogs(LogLevel upToLevel = LogLevel.Error);
        void AddLog(string message, LogLevel level);
        void AddLog(Log log);
        void setDefaultLogLevel(LogLevel level);
    }
}
