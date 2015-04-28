using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.Common.Interfaces
{
    public interface ILogger
    {
        void LogError(string msg);

        void LogWarning(string msg);
    }
}
