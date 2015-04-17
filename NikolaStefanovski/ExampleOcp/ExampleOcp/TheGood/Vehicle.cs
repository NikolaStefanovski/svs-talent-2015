using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOcp.TheGood
{
    public class Vehicle
    {
        public virtual void OperateVehicle()
        {
            Console.WriteLine("Unknow vehicle!");
        }
    }
}
