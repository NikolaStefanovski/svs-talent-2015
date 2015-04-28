using Registar.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.Common
{
    public class LoggingManager
    {
        static ILogger Logger { get; set; }

		public static void LogWarning(string msg)
        {
            Logger.LogWarning(msg);
        }

		public static void RegisterLogger(ILogger logger)
		{
			Logger = logger;
		}
    }
}
