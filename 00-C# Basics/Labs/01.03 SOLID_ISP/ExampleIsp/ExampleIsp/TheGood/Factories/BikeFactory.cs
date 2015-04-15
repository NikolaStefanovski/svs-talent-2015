using ExampleIsp.TheGood.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheGood.Factories
{
    public class BikeFactory : Factory, IBikeFactory
    {
        public int ProduceFrameBike()
        {
            throw new NotImplementedException();
        }

        public int ProduceHandlesBike()
        {
            throw new NotImplementedException();
        }

        public int ProduceGearsBike()
        {
            throw new NotImplementedException();
        }
    }
}
