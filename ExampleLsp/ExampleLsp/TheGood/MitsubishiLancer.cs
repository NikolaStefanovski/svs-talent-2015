using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLsp.TheGood
{
    public class MitsubishiLancer : Car
    {
        public override void OperateVehicle()
        {
            Console.WriteLine("Drive the Lancer!");
        }

        public override void GetInfoForLater()
        {
            Console.WriteLine("Get info for Lancer!");
        }
    }
}
