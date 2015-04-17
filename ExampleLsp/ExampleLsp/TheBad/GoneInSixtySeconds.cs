using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLsp.TheBad
{
    public class GoneInSixtySeconds
    {
        public Vehicle[] vehicles = { new ShelbyGT(), new MitsubishiLancer(), new Plane() };
        
        /// <summary>
        /// Gone in 60 seconds...
        /// </summary>
        public void NicholasCage() {
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.GetInfoForLater();
                vehicle.OperateVehicle();              
            }
        }
    }
}
