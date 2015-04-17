using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLsp.TheGood
{
    public class Vehicle : IOperate
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
