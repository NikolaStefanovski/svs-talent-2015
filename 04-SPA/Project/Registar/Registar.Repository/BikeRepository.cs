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
        public IList<DomainModel.Bike> SearchBikes()
        {
            using (var context = DataContextManager.CreateContext<IRegistarContext>())
            {
                return context.Bikes.ToList();
            }
        }
    }
}
