using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.BusinessLayer.Contracts;
using Registar.DataLayer;
using Registar.DomainModel;

namespace Registar.BusinessLayer.Handlers
{
    internal class BikeSearchCommandHandler : CommandHandlerBase<BikeSearchCommand,BikeSearchResult>
    {
        

        protected override BikeSearchResult ExecuteCommand(BikeSearchCommand command)
        {
            RegistarDbContext context = new RegistarDbContext();

            List<Bike> bikes = new List<Bike>();
            bikes = context.Bikes.OrderBy(p => p.BikeId).Take(10).ToList<Bike>();

            var query = from b in context.Bikes select b;
            if (!string.IsNullOrEmpty(command.Colour))
            {
                query = query.Where(x => x.Model == command.Colour);
            }

            BikeSearchResult result = new BikeSearchResult();

            return null;
            //throw new NotImplementedException();
        }
    }
}
