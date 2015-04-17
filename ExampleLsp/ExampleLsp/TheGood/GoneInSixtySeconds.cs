using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLsp.TheGood
{
    public class GoneInSixtySeconds
    {
        /// <summary>
        /// Tuka ima greska bidejki Nicholas Cage ne znae da krade avioni.
        /// </summary>
        //IOperate[] vehicles = { new ShelbyGT(), new MitsubishiLancer(), new Plane() };

        IOperate[] vehicles = { new ShelbyGT(), new MitsubishiLancer() };

        /// <summary>
        /// Gone in 60 seconds...
        /// </summary>
        public void NicholasCage()
        {
            foreach (IOperate vehicle in vehicles)
            {
                vehicle.OperateVehicle();
            }
        }
    }
}
