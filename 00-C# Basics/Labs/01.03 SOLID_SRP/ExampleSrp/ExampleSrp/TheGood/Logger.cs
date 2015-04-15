using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    /// <summary>
    /// Enables dispatching the log record of state change to various systems using methods matching the EventHandler<string> delegate signature.
    /// </summary>
    public class Logger : ILogger
    {
        private static Logger _instance;

        public static Logger Instance {
            get 
            {
                return _instance;
            }
        }

        private Logger()
        {
                
        }

        static Logger()
        {
            _instance = new Logger();
        }

        /// <summary>
        /// dispatch the log record to a computer system.
        /// </summary>
        /// <param name="statechangeinfo"></param>
        public void ComputerLogStateChanged(object sender, string stateChangedInfo)
        {
            Console.WriteLine("==== SYSTEM ==== State changed: {0}", stateChangedInfo);
        }

        public void ComputerLogException(object sender, string exceptionMsg)
        {
            Console.WriteLine(exceptionMsg);
        }
    }
}
