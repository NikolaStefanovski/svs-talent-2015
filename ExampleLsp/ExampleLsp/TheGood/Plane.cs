using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLsp.TheGood
{
    public class Plane : Vehicle
    {
        public override void OperateVehicle()
        {
            Console.WriteLine("Fly the plane!");
        }
    }
}
