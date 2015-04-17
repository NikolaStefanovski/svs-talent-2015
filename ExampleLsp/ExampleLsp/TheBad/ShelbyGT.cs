using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLsp.TheBad
{
    public class ShelbyGT : Vehicle
    {
        public override void OperateVehicle()
        {
            Console.WriteLine("Drive the car!");
        }

        public override void GetInfoForLater()
        {
            Console.WriteLine("Get info for Shelby GT");
        }
    }
}
