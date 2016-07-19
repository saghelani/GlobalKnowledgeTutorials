using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DM.Logger
{
    public abstract class Logger
    {
        public abstract void Log(string text);
        public abstract void Log(LogLevel logLevel, string text);
        public abstract void Log(Exception e);
        public abstract void Log(LogLevel logLevel, Exception e);
    }
}
