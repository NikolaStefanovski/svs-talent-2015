using Registar.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.DataLayer
{
    public class DataContextFactory : IContextFactory
    {

        public TContext CreateContext<TContext>() where TContext : IContext
        {
            return null;
        }
    }
}
