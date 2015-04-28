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
        ILogger Logger { get; set; }

        public void LogWarning(string msg)
        {
            Logger.LogWarning(msg);
        }
    }
}
