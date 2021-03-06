﻿using Registar.Common;
using Registar.DataLayer;
using Registar.DataLayer.Interfaces;
using Registar.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.Repository
{
    internal class BikeRepository : IBikeRepository
    {
        public IList<DomainModel.Bike> SearchBikes(IDictionary<string, string> paramaters)
        {
            using (var context = DataContextManager.CreateContext<IRegistarContext>())
            {
				//LoggingManager


				//var query = from f in context.Bikes select f;
				//return query.ToList();

				var result = context.Bikes;

				if (paramaters["colour"] != null)
                {
                    result.Where(x => x.Colour == paramaters["colour"]);
                }
                if (paramaters["producer"] != null)
                {
                    result.Where(x => x.Producer == paramaters["produce"]);
                }

                return result.ToList();
            }
        }
    }
}
