using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    //public delegate void LogState(string msg);

    public interface ILogger
    {
        void ComputerLogStateChanged(object sender, string args);

    }
}
