using log4net.Appender;
using log4net.Core;
using Registar.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.Common
{
    public class ConsoleLogger : ColoredConsoleAppender, Registar.Common.Interfaces.ILogger
    {
        public void LogError(string msg)
        {
            this.Target = Console.Error.ToString();

            LoggingEventData data = new LoggingEventData();
            data.Level = Level.Warn;
            data.Message = msg;

            LoggingEvent eventToLog = new LoggingEvent(data);

            this.Append(eventToLog);
        }


        public void LogWarning(string msg)
        {
            this.Target = Console.Out.ToString();

            LoggingEventData data = new LoggingEventData();
            data.Level = Level.Warn;
            data.Message = msg;

            LoggingEvent eventToLog = new LoggingEvent(data);

            this.Append(eventToLog);
        }
    }
}
