﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLsp.TheGood
{
    public class Plane : IInform
    {
        public void GetInfoForLater()
        {
            Console.WriteLine("Get info for plane!");
        }
    }
}
