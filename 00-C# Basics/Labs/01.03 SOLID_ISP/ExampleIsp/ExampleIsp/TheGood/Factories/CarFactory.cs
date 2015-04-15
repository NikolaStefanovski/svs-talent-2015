using ExampleIsp.TheGood.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheGood.Factories
{
    public class CarFactory : Factory, ICarFactory
    {
        public int ProduceTank()
        {
            throw new NotImplementedException();
        }
    }
}
