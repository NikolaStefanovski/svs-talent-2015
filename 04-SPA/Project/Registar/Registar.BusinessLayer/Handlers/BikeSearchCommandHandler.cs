using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.BusinessLayer.Contracts;
using Registar.DataLayer;
using Registar.DomainModel;
using System.Data.Entity;
using Registar.Repository.Interfaces;
using Registar.Common;

namespace Registar.BusinessLayer.Handlers
{
    internal class BikeSearchCommandHandler : CommandHandlerBase<BikeSearchCommand, BikeSearchResult>
    {
        protected override BikeSearchResult ExecuteCommand(BikeSearchCommand command)
        {
            IBikeRepository bikeRepo = RepositoryManager.CreateRepository<IBikeRepository>();

            BikeSearchResult result = new BikeSearchResult();
            result.Result = bikeRepo.SearchBikes() as List<Bike>;
     
            return result;

        }
    }
}
