using Registar.Common;
using Registar.DataLayer;
using Registar.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.Repository
{
    internal class BikeRepository
    {
        public IList<DomainModel.Bike> SearchBikes(IDictionary<string, string> paramaters)
        {
            using (var context = DataContextManager.CreateContext<IRegistarContext>())
            {
                //LoggingManager
                return context.Bikes.ToList();
            }
        }
    }
}
