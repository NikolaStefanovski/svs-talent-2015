using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLsp.TheGood
{
    public class ShelbyGT : Car
    {
        public override void OperateVehicle()
        {
            Console.WriteLine("Drive the Shelby GT!");
        }

        public override void GetInfoForLater()
        {
            Console.WriteLine("Get info for Shelby GT!");
        }
    }
}
