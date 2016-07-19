using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DM.Logger
{
    public class FileLoggerFactory : LoggerFactory
    {
        public override Logger CreateLogger()
        {
            return new FileLogger();
        }

        public override Logger CreateLogger(string logFileName)
        {
            return new FileLogger(logFileName);
        }

        public override Logger CreateLogger(LogLevel logLevel)
        {
            return new FileLogger(logLevel);
        }

        public override Logger CreateLogger(string logFileName, LogLevel level)
        {
            return new FileLogger(logFileName, level);
        }
    }
}
