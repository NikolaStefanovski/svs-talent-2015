using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLsp.TheBad
{
    public class Vehicle
    {
        public virtual void OperateVehicle()
        {
            Console.WriteLine("Operate the vehicle!");
        }

        public virtual void ParkVehicle()
        {
            Console.WriteLine("Parking the vehicle!");
        }
    }
}
