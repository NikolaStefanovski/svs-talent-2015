using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOcp.TheGood
{
    public class Car : Vehicle
    {
        public override void OperateVehicle()
        {
            Console.WriteLine("Drive the car!");
        }
    }
}
