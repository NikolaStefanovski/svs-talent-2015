using ExampleLsp.TheBad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLsp.TheBad
{
    public class Car : Vehicle
    {
        public override void OperateVehicle()
        {
            Console.WriteLine("Drive the car!");
        }

        public override void ParkVehicle()
        {
            Console.WriteLine("Parking car in garage!");
        }
    }
}
