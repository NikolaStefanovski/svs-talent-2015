using ExampleIsp.TheGood.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheGood.Factories
{
    public class MotorcycleFactory : Factory, IMotorcycleFactory
    {
        public int ProduceFrame()
        {
            throw new NotImplementedException();
        }

        public int ProduceHandles()
        {
            throw new NotImplementedException();
        }

        public int ProduceTankMoto()
        {
            throw new NotImplementedException();
        }

        public int ProduceEngineMoto()
        {
            throw new NotImplementedException();
        }

        public int ProduceGearsMoto()
        {
            throw new NotImplementedException();
        }
    }
}
