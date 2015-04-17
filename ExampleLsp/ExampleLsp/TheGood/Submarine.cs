using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLsp.TheGood
{
    public class Submarine : Vehicle
    {
        public override void OperateVehicle()
        {
            Console.WriteLine("Go underwater!");
        }

        public override void ParkVehicle()
        {
            throw new NotImplementedException("Cant park submarines!");
        }
    }
}
