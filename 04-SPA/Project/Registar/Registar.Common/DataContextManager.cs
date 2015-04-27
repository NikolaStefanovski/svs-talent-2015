using Registar.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.Common
{
    public class DataContextManager
    {
        private static IContextFactory theFactory;

        public static TContext CreateContext<TContext>() where TContext : IContext 
        {
            TContext result = theFactory.CreateContext<TContext>();
            return result;
        }

        public static void RegisterFactory(IContextFactory factory)
        {
            theFactory = factory;
        }
    }
}
