using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOcp
{
    public class Vehicle
    {
        public VehicleType Type { get; set; }

        public void OperateVehicle()
        {
            switch (Enum.GetName(typeof(VehicleType), Type))
            {
                case "Land": Console.WriteLine("Drive the vehicle!");
                    break;
                case "Flying": Console.WriteLine("FLy the vehicle");
                    break;
                case "Submarine": Console.WriteLine("Submerge the vehicle!");
                    break;
                default: Console.WriteLine("Unknown vehicle!");
                    break;
            }
        }
    }

    enum VehicleType
    {
        None, Land, Flying, Submarine
    }
}
