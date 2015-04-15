using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    /// <summary>
    /// Enables dispatching the log record of state change to various systems.
    /// </summary>
    public class Logger
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
        /// Dispatch the log record to a cloud system.
        /// </summary>
        /// <param name="stateChangeInfo"></param>
        public static void ComputerLogChangeStateOnCloud(string stateChangeInfo)
        {
            Console.WriteLine("==== CLOUD ==== Car changed state:{0}", stateChangeInfo);
        }

        /// <summary>
        /// Dispatch the log record to a smart phone.
        /// </summary>
        /// <param name="stateChangeInfo"></param>
        public static void ComputerLogChangeStateOnPhone(string stateChangeInfo)
        {
            Console.WriteLine("==== PHONE ==== Car changed state:{0}", stateChangeInfo);
        }
    }
}
