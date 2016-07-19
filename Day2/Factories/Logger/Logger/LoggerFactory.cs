using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DM.Logger
{
    public abstract class LoggerFactory
    {
        public abstract Logger CreateLogger();
        public abstract Logger CreateLogger(LogLevel logLevel);
        public abstract Logger CreateLogger(string logFileName);
        public abstract Logger CreateLogger(string logFileName, LogLevel level);
    }
}
