﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLsp.TheBad
{
    public class Plane : Vehicle
    {
        public override void OperateVehicle()
        {
            throw new NotImplementedException("Nicholas Cage can't fly a plane!");
        }

        public override void GetInfoForLater()
        {
            Console.WriteLine("Get info for plane!");
        }
    }
}
